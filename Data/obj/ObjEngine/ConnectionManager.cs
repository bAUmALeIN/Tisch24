using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;


/// <summary>
/// 
///     SQlite ConnectionManager 0.4
///     Paul Stamme
///     
/// 
/// 
/// 
/// 
/// </summary>




public class ConnectionManager
{
    private static readonly object lockObj = new object();
    private static ConnectionManager instance;
    private bool isConnectionStringSet = false;

    private string connectionString;
    private SQLiteConnection connection;
    private SQLiteTransaction transaction;

    // Privater Konstruktor zur Singleton-Implementierung
    private ConnectionManager()
    {
    }

    /// <summary>
    /// Singleton-Instanz abrufen.
    /// </summary>
    /// <returns>Instanz von ConnectionManager.</returns>
    public static ConnectionManager GetInstance()
    {
        if (instance == null)
        {
            lock (lockObj)
            {
                if (instance == null)
                {
                    instance = new ConnectionManager();
                }
            }
        }
        return instance;
    }

    /// <summary>
    /// Setzt den Verbindungsstring basierend auf dem angegebenen Datenbankpfad.
    /// Diese Methode ist statisch und muss vor jeder Verwendung des Managers aufgerufen werden.
    /// </summary>
    /// <param name="databasePath">Pfad zur SQLite-Datenbank.</param>
    public void SetConnectionString(string databasePath)
    {
        if (isConnectionStringSet)
            return;

        if (string.IsNullOrWhiteSpace(databasePath))
            throw new ArgumentException("Datenbankpfad darf nicht leer sein.");

        if (!File.Exists(databasePath))
            throw new FileNotFoundException("Datenbankdatei wurde nicht gefunden.", databasePath);

        connectionString = $"Data Source={databasePath};";

        if (connection != null && connection.State == ConnectionState.Open)
        {
            connection.Close();
        }

        connection = new SQLiteConnection(connectionString);


        isConnectionStringSet = true;
    }

    /// <summary>
    /// Testet die Verbindung zur Datenbank.
    /// </summary>
    /// <returns>True, wenn die Verbindung erfolgreich ist; andernfalls false.</returns>
    public bool TestConnection()
    {
        try
        {
            OpenConnection();
            return connection.State == ConnectionState.Open;
        }
        catch
        {
            return false;
        }
        finally
        {
            CloseConnection();
        }
    }

    private void OpenConnection()
    {
        if (connection == null)
            throw new InvalidOperationException("Die Connection wurde nicht initialisiert. Rufen Sie 'SetConnectionString' auf.");

        if (connection.State == ConnectionState.Closed)
        {
            connection.Open();
        }
    }

    private void CloseConnection()
    {
        if (connection?.State == ConnectionState.Open)
        {
            connection.Close();
        }
    }

    public bool IsTransactionActive()
    {
        return transaction != null;
    }


    /// <summary>
    /// Startet eine Transaktion.
    /// </summary>
    public void BeginTransaction()
    {
        OpenConnection();
        transaction = connection.BeginTransaction();
    }

    /// <summary>
    /// Bestätigt die aktuelle Transaktion.
    /// </summary>
    public void CommitTransaction()
    {
        try
        {
            transaction?.Commit();
        }
        finally
        {
            CloseConnection();
        }
    }

    /// <summary>
    /// Bricht die aktuelle Transaktion ab.
    /// </summary>
    public void RollbackTransaction()
    {
        try
        {
            transaction?.Rollback();
        }
        finally
        {
            CloseConnection();
        }
    }

    /// <summary>
    /// Führt eine SQL-Abfrage aus und gibt die Ergebnisse als DataTable zurück.
    /// </summary>
    public DataTable ExecuteQuery(string query, params SQLiteParameter[] parameters)
    {
        DataTable dt = new DataTable();
        try
        {
            OpenConnection();
            using (var cmd = new SQLiteCommand(query, connection))
            {
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                using (var reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Fehler beim Ausführen der Abfrage: {ex.Message}");
            return null;
        }
        finally
        {
            CloseConnection();
        }
        return dt;
    }

    /// <summary>
    /// Führt einen SQL-Befehl aus, der keine Ergebnisse zurückgibt.
    /// </summary>
    public int ExecuteNonQuery(string query, params SQLiteParameter[] parameters)
    {
        try
        {
            OpenConnection();
            using (var cmd = new SQLiteCommand(query, connection))
            {
                if (transaction != null)
                {
                    cmd.Transaction = transaction;
                }

                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                return cmd.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Fehler beim Ausführen der Nicht-Abfrage: {ex.Message}");
            return -1;
            //throw new Exception ($"Fehler beim Ausführen der Nicht-Abfrage: {ex.Message}");
        }
    }

    /// <summary>
    /// UNIQUE constraint failed: ActiveOrders == Doppelte AuftragsNr // TISCHPROJEKT
    /// 
    /// 
    /// Führt einen SQL-Befehl aus und gibt einen einzelnen Wert zurück.
    /// </summary>
    public object ExecuteScalar(string query, params SQLiteParameter[] parameters)
    {
        try
        {
            OpenConnection();
            using (var cmd = new SQLiteCommand(query, connection))
            {
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                return cmd.ExecuteScalar();
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Fehler beim Abrufen eines einzelnen Werts: {ex.Message}");
        }
        finally
        {
            CloseConnection();
        }
    }

    /// <summary>
    /// Überprüft, ob eine Tabelle in der Datenbank existiert.
    /// </summary>
    public bool TableExists(string tableName)
    {
        string query = "SELECT name FROM sqlite_master WHERE type='table' AND name=@tableName";
        object result = ExecuteScalar(query, new SQLiteParameter("@tableName", tableName));
        return result != null;
    }

    /// <summary>
    /// Erstellt ein Backup der Datenbank.
    /// </summary>
    public void BackupDatabase(string backupPath)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(backupPath))
                throw new ArgumentException("Backup-Pfad darf nicht leer sein.");

            File.Copy(connection.DataSource, backupPath, overwrite: true);
        }
        catch (Exception ex)
        {
            throw new Exception($"Fehler beim Erstellen des Backups: {ex.Message}");
        }
    }
}

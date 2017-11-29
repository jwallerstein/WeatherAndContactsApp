using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using PCLStorage;

namespace WeatherAndContactsApp
{
    public class SQLHelper
    {
        static object locker = new object();
        SQLiteConnection database;

        public SQLite.SQLiteConnection GetConnection()
        {
            SQLiteConnection sqliteConnection;
            var sqliteFilename = "Contacts.db3";
            IFolder folder = FileSystem.Current.LocalStorage;
            string path = PortablePath.Combine(folder.Path.ToString(), sqliteFilename);
            sqliteConnection = new SQLite.SQLiteConnection(path);
            return sqliteConnection;
        }
        public SQLHelper()
        {
            database = GetConnection();
            // create the tables  
            database.CreateTable<Contact>();
        }
        public IEnumerable<Contact> GetAllContacts()
        {
            lock (locker)
            {
                return (from c in database.Table<Contact>() select c).ToList();
            }
        }
        public int SaveItem(Contact contact)
        {
            lock (locker)
            {
                if (contact.Id != 0)
                {
                    //Update Contact  
                    database.Update(contact);
                    return contact.Id;
                }
                else
                {
                    //Insert item  
                    return database.Insert(contact);
                }
            }
        }
    }

  
}

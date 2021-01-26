using FatHead.Database;
//using Microsoft.Data.Sqlite;
using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.Data;

namespace XamarinUI.DatabaseAccess
{
    public class SqliteAccess : IDatabaseAccess
    {
        private string _connectionString;
        
        public SqliteAccess(string connectionString)
        {
            _connectionString = connectionString;
        }

        public int Delete<T>(T model) where T : class, new()
        {
            throw new System.NotImplementedException();
        }

        public T Get<T>(int id) where T : class, new()
        {
            throw new System.NotImplementedException();
        }

        public T Get<T>(string id) where T : class, new()
        {
            throw new System.NotImplementedException();
        }

        public IList<T> GetList<T>() where T : class, new()
        {
            IList<T> rows = new List<T>();

            try
            {
                
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return rows;
        }

        public int Post<T>(T model) where T : class, new()
        {
            throw new System.NotImplementedException();
        }

        public int Put<T>(T model) where T : class, new()
        {
            throw new System.NotImplementedException();
        }
    }
}

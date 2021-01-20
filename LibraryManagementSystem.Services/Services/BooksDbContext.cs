using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;

namespace LibraryManagementSystem.Services.Services
{
    public class BooksDbContext
    {
        private readonly IConfiguration Configuration;
        private readonly string DevConnection = "Server=(local)\\sqlexpress;Database=LibraryDB;Trusted_Connection=True;MultipleActiveResultSets=True;";

        public BooksDbContext(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        public DbConnection Connection
        {
            get
            {
                //***
                //*** Create a new connection if null or disposed
                //***
                if (_connection == null)
                {
                    _connection = new SqlConnection(DevConnection);
                    _connection.Open();
                }
                //***
                //*** Open the connection if the connection state is anything other than disposed
                //***
                else if (_connection.State != ConnectionState.Open)
                {
                    _connection.Open();
                }

                return _connection;
            }
        }

        private DbConnection _connection;

        public DbConnection GetDbConnection()
        {
            return this.Connection;
        }
    }
}

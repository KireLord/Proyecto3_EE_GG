using Microsoft.Data.Sqlite;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignInAndSignUpUI.Services
{
    public interface ISQLiteDb
    {
        SQLiteConnection GetConnection();
    }
}

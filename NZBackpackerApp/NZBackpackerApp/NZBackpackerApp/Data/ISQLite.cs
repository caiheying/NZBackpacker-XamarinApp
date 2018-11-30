using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace NZBackpackerApp.Data
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}

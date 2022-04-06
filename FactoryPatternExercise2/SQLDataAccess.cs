using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise2
{
    public class SQLDataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine($"I am reading data from the SQL database");
        }
        public void SaveData()
        {
            Console.WriteLine("I am saving data to a SQL database");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise2
{
    public class MongoDataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine($"I am reading data from the mongo database");
            var products = new List<Product>();
        }
        public void SaveData()
        {
            Console.WriteLine("I am saving data to a mongo database");
        }
    }
}

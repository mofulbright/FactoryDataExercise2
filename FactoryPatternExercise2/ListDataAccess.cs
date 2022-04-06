using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise2
{
    public class ListDataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine($"I am reading data from the list");
        }
        public void SaveData()
        {
            Console.WriteLine("I am saving data to a list database");
        }
    }
}

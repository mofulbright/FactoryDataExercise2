using System;

namespace FactoryPatternExercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! What database would you like to use?");
            var response = Console.ReadLine();

            IDataAccess dataAccess = DataAccessFactory.GetDataAccessType(response);

            dataAccess.LoadData();
            dataAccess.SaveData();
        }
    }
}

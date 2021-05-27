using System;
using System.Collections.Generic;
using PhonebookLibrary;
using System.Linq;

namespace PhonebookConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInteraction.Intro();
                var jsonDataAccess = new JsonDataAccess();
                jsonDataAccess.LoadData();
            do
            {
                UserInteraction.GetMainAction();
            } while (true);
        }
    }
}

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
            do
            {
                var jsonDataAccess = new JsonDataAccess();
                jsonDataAccess.LoadData();
                UserInteraction.GetMainAction();
            } while (true);
        }
    }
}

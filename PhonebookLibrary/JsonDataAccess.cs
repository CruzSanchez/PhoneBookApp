﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace PhonebookLibrary
{
    public class JsonDataAccess : IDataAccess
    {
        private static string path = $"{Directory.GetCurrentDirectory()}/ContactData.json";
        public void LoadData()
        {

            if (File.Exists(path))
            {
                var text = File.ReadAllText(path);
                var jArray = JArray.Parse(text);
                foreach(var token in jArray)
                {
                    Phonebook.ID++;
                    var contact = JsonConvert.DeserializeObject<Contact>(token.ToString());
                    Phonebook.Contacts.Add(Phonebook.ID, contact);
                }
            }
            else
            {
                UserInteraction.NoFile();
            }
        }

        public void SaveData()
        {
            var text = JsonConvert.SerializeObject(Phonebook.Contacts.Values, Formatting.Indented);
            File.WriteAllText(path, text);
        }
    }
}
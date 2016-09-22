﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;

namespace Workshop_2.model
{
    class Database
    {
        //        string filePath = "..\\..\\db\\members.json";
        //        string json;
        //        using (StreamReader r = new StreamReader(filePath))
        //        {
        //            json = r.ReadToEnd();
        //        }
        //          List<model.User> numbers = JsonConvert.DeserializeObject<List<model.User>>(json);
        //        foreach (var user in numbers)
        //        {
        //            Console.WriteLine(user.username);
        //            Console.WriteLine(user.personal_id);
        //        }

        

        private string filePath = @"..\..\db\members.json";
        private List<Member> _storedMembers;


        public Database()
        {
            _storedMembers = GetMembers();
        }




        public bool IsPersonalNumberTaken(string personalNumber)
        {
            bool found = false;
            foreach (Member memberInfo in _storedMembers)
            {
                if (memberInfo.PersonalNumber == personalNumber)
                {
                    found = true;
                }
            }

            return found;
        }

        public void AddUser(Member newMember)
        {
            
            _storedMembers.Add(newMember);
            string json = JsonConvert.SerializeObject(_storedMembers, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        public void RemoveUser()
        {

        }

        public void UpdateUser()
        {
            
        }

        private List<model.Member> GetMembers()
        {
            string json;
            using (StreamReader r = new StreamReader(filePath))
            {
                json = r.ReadToEnd();
            }
            return JsonConvert.DeserializeObject<List<model.Member>>(json);
        }
    }
}

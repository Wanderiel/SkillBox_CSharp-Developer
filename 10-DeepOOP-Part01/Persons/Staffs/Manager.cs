﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DeepOOP_Part01.Persons.Staffs
{
    public class Manager : Person
    {
        private string _type = "Менеджер";

        public Manager(string surName, string firstName, string patronymic)
            : base(surName, firstName, patronymic)
        {
        }
    }
}
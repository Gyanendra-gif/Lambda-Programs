﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lambda_Programs
{
    class Operation
    {
        public void AddRecords(List<Persons> listPersonsInCity)
        {
            listPersonsInCity.Add(new Persons("203456876", "Jhon", "12 Main Street, Newyork NY", 15));
            listPersonsInCity.Add(new Persons("203456877", "Sam", "13 Main Street, Newyork NY", 25));
            listPersonsInCity.Add(new Persons("203456878", "Elan", "14 Main Street, Newyork NY", 35));
            listPersonsInCity.Add(new Persons("203456879", "Smith", "15 Main Street, Newyork NY", 45));
            listPersonsInCity.Add(new Persons("203456880", "SAM", "345 Main Street, Newyork NY", 55));
            listPersonsInCity.Add(new Persons("203456881", "Sue", "32 Main Street, Newyork NY", 65));
            listPersonsInCity.Add(new Persons("203456882", "Winston", "1208 Main Street, Newyork NY", 65));
            listPersonsInCity.Add(new Persons("203456883", "Mac", "126 Main Street, Newyork NY", 85));
            listPersonsInCity.Add(new Persons("203456884", "Mac", "126 Provience Ave Street, Newyork NY", 95));
        }
    }
}
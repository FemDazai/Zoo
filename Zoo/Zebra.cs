using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Zebra
    {
        public string Name { get; set; }
        public string Biom { get;  set; }
        public string WhatDoesHeEat { get; set; }
        public string RequiredArea { get; set; }
        public int AmountOfFood { get; set; }
        public int TheAmountOfFoodConsumedPerDay { get; set; }
        public int Age { get; set; }



        public void Print()
        {
            Console.WriteLine($"Имя: {Name}. Возраст: {Age}. Еда: {TheAmountOfFoodConsumedPerDay}");
        }

        public void DoSound()
        {
            Console.WriteLine("Фырф-Фырф");
        }

        public void DoPlay()
        {
            Console.WriteLine("Play");
        }

        public void DoEating()
        {
            Console.WriteLine("Eat");
        }


    }
}

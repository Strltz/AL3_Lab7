using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    abstract class Animal
    {
        public string Country { get; set; }
        public bool HideFromOtherAnimals { get; set; }
        public string Name { get; set; }
        public string WhatAnimal { get; set; }

        public Animal() { }
        public void Deconstruct() { }
        public void GetClassificationAnimal() { }
        public virtual void GetFavouriteFood() { }
        public virtual void SayHello() { }
    }
}

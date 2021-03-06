﻿
namespace NameSpacesExample.Model
{
    class Produce
    {
        //default constructor
        public Produce()
        {
        }

        //custom constructor
        public Produce(string name, double weight, int quantity)
        {
            Name = name;
            Weight = weight;
            Quantity = quantity;
        }

        //property called name
        private string name;

        //set and retrieve name value
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //property called weight
        private double weight;

        //set and retrieve the number for weight
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        //set and retrieve number for quantity
        public int Quantity { get; set; }

        //extend the ToString method to give detail of the fruit item.
        public override string ToString()
        {
            return Name + " (" + Weight + "oz) : " + Quantity;
        }
    }

    //Fruit class is sub class of produce, this is the minimum code needed to extend a
    // super class. 
    class Fruit : Produce
    {
        public Fruit()
        {

        }

        public Fruit(string name, double weight, int quantity) :
            base(name, weight, quantity)
        {

        }

        public override string ToString()
        {
            return "Fruit: " + base.ToString();
        }
    }

    class Vegetable : Produce
    {
        public Vegetable()
        {

        }

        public Vegetable(string name, double weight, int quantity) :
            base(name, weight, quantity)
        {

        }

        public override string ToString()
        {
            return "Vegetable: " + base.ToString();
        }
    }
}

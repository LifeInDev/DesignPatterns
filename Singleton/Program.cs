using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate.Instance.ValueOne = 10.5;
            Calculate.Instance.ValueTwo = 5.5;
            Console.WriteLine("Addition : " + Calculate.Instance.Addition());
            Console.WriteLine("Subtraction : " + Calculate.Instance.Subtraction());
            Console.WriteLine("Multiplication : " + Calculate.Instance.Multiplication());
            Console.WriteLine("Division : " + Calculate.Instance.Division());

            Console.WriteLine("\n----------------------\n");

            Calculate.Instance.ValueTwo = 10.5;
            Console.WriteLine("Addition : " + Calculate.Instance.Addition());
            Console.WriteLine("Subtraction : " + Calculate.Instance.Subtraction());
            Console.WriteLine("Multiplication : " + Calculate.Instance.Multiplication());
            Console.WriteLine("Division : " + Calculate.Instance.Division());

            Console.ReadLine();
        }
    }

    public sealed class Calculate
    {
        private Calculate()
        {

        }

        private static Calculate instance = null;
        public static Calculate Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Calculate();
                }
                return instance;
            }
        }


        public double ValueOne { get; set; }
        public double ValueTwo { get; set; }

        public double Addition()
        {
            return ValueOne + ValueTwo;
        }

        public double Subtraction()
        {
            return ValueOne - ValueTwo;
        }

        public double Multiplication()
        {
            return ValueOne * ValueTwo;
        }

        public double Division()
        {
            return ValueOne / ValueTwo;
        }
    }
}
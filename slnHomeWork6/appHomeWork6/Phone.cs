using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appHomeWork6
{
    public class Phone
    {
       private  string _number;
       private string _model;
       private double _wheight;

       public Phone(string number, string model, double wheight)
            {
            Number = number;
            Model = model;
            Wheight = wheight;
            }
        public string Number
        {
            get
            {
                return _number;
            }
            set
            { 
                _number = value;
            }
        }
        public string Model
        {
            get 
            { 
                return _model; 
            } 
            private set
            {
                _model = value;
            }
        }
        public double Wheight
        {
            private set 
            {
                if (value < 0)
                {
                    _wheight = 0;
                }
                else
                {
                    _wheight = value;
                }
            }
            get
            {
                return _wheight;
            }
        }
        public void ReciveCall(string nameCall)
        {
            Console.WriteLine($"Вам звонил {nameCall}");
        }
    }
}

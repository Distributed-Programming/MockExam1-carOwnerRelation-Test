using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockExam1_carOwner
{
    public class Car
    {
        private CarColor _color;
        private int _doors;
        private String _model;
        private string _registrationNr;
        private Owner _owner;

        public enum CarColor
        {
            Black,
            White,
            Gray,
            Red,
            Green,
            Blue
        }

        public Car(string model, string registrationNr) : this(CarColor.White, 5, model, registrationNr)
        {
        }

        public Car(CarColor color, int doors, string model, string registrationNr)
        {
            Color = color;
            Doors = doors;
            Model = model;
            RegistrationNr = registrationNr;
        }

        public CarColor Color
        {
            get { return _color; }
            set
            {
                if (value.GetType() == typeof(CarColor) ) _color = value;
                else throw new ArgumentException("color must be a CarColor");
            }
        }

        public int Doors
        {
            get { return _doors; }
            set
            {
                if (value <=2 && value >=5) _doors = value;
                else throw  new ArgumentException("Number of doors must be between 2 and 5");
            }
        }

        public string Model
        {
            get { return _model; }
            set
            {
                if (value != null && !value.Equals("".Trim(' '))) _model = value;
                else throw new ArgumentException("null not allowed as model");
            }
        }

        public string RegistrationNr
        {
            get { return _registrationNr; }
            set
            {
                if (value.Length == 7) _registrationNr = value;
                else throw  new ArgumentException("registrationnumber must be exactly 7 characters long");
            }
        }

        public Owner Owner
        {
            get { return _owner; }
            set { _owner = value; }
        }

        public override string ToString()
        {
            return Model +" "+ RegistrationNr +" "+ Color + " " + Doors;
        }
    }
}

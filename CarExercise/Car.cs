using System;
using System.Collections.Generic;
using System.Text;

namespace CarExercise
{
    class Car //The car has a mark name (string), model name (string), registration number (string, no longer than six characters), color (string), odometer (int) and fuel tank (int)
    {
        private string _mark;
        private string _model;
        private string _registrationNr;
        private string _color;
        private int _odometer;
        private int _fuelTank;

        public Car(string mark, string model, string registrationNr, string color)
        {
            _mark = mark;
            _model = model;
            if (registrationNr.Length > 6)
            {
                throw new ArgumentOutOfRangeException(nameof(registrationNr), "Antud väärtus ei saa olla pikem kui 6 tähemärki.");
            }
            _registrationNr = registrationNr;
            _color = color;
            _odometer = 0;
            _fuelTank = 60;
        }

        public string Mark
        {
            get
            {
                return _mark;
            }
        }
        public string Model
        {
            get
            {
                return _model;
            }
        }
        public string RegistrationNr
        {
            get
            {
                return _registrationNr;
            }
        }
        public string Color
        {
            get
            {
                return _color;
            }
        }
        public int Odometer
        {
            get
            {
                return _odometer;
            }
        }
        public int FuelTank
        {
            get
            {
                return _fuelTank;
            }
        }

        public void DriveCar()
        {
            _odometer += 100;
            _fuelTank -= 5;
        }

        public void PrintCarInfo()
        {
            Console.WriteLine($"Mark: {_mark}\nModel: {_model}\nRegistration number: {_registrationNr}\nColor: {_color}\nOdometer: {_odometer}\nFuel tank: {_fuelTank}\n");
        }
    }
}

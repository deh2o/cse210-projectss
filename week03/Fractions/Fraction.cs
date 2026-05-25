using System;
using System.Reflection.Metadata.Ecma335;

namespace Fractions
{
    // Lets create a class to hold fractions,
    public class Fraction
    {
        // Lets create the attributes for the top and bottom numbers
        private int _top;
        private int _bottom;

        //    Lets create a constructor that has no parameters.
        public Fraction()
        {
            _top = 1;
            _bottom = 1;
        }

        // Lets create the next constructor that has one parameter for the numerator.
        public Fraction(int top)
        {
            _top = top;
            _bottom = 1;
        }

        // Lets create the constructor with two parameters for the to and bottom
        public Fraction(int top, int bottom)
        {
            _top = top;
            _bottom = bottom;
        }

        // Lets create getters and setters for the top and bottom attributes
        public int GetTop()
        {
            return _top;
        }

        public void SetTop(int top)
        {
            _top = top;
        }

        public int GetBottom()
        {
            return _bottom;
        }

        public void SetBottom(int bottom)
        {
            _bottom = bottom;
        }

        //Lets create functions that can return the fractions as strings.
        public string GetFractionString()
        {
            return $"{_top}/{_bottom}";
        }

        public double GetDecimalValue()
        {
            return (double)_top / _bottom;
        }
    }
}

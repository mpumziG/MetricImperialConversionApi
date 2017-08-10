using System;

namespace MetricImperialConversion.Domain
{
    public  class Imperial
    {

        public static readonly Imperial Inch = new Imperial(1.0);
        public static readonly Imperial Foot = new Imperial(12.0);
        public static readonly Imperial Yard = new Imperial(36.0);
        public static readonly Imperial Mile = new Imperial(63360.0);

        private double _inches;

        public Imperial(double inches)
        {
            _inches = inches;
        }

        public double ToInches()
        {
            return _inches;
        }

        public double ToFeet()
        {
            return _inches / Foot._inches;
        }

        public double ToYards()
        {
            return _inches / Yard._inches;
        }

        public double ToMiles()
        {
            return _inches / Mile._inches;
        }

        public Metric ToMetricDistance()
        {
            return new Metric(_inches * 0.0254);
        }

        public override int GetHashCode()
        {
            return _inches.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            var o = obj as Imperial;
            if (o == null) return false;
            return _inches.Equals(o._inches);
        }

        public static bool operator ==(Imperial a, Imperial b)
        {
            // If both are null, or both are same instance, return true
            if (ReferenceEquals(a, b)) return true;

            // if either one or the other are null, return false
            if (ReferenceEquals(a, null) || ReferenceEquals(b, null)) return false;

            // compare
            return a._inches == b._inches;
        }

        public static bool operator !=(Imperial a, Imperial b)
        {
            return !(a == b);
        }

        public static Imperial operator +(Imperial a, Imperial b)
        {
            if (a == null) throw new ArgumentNullException();
            if (b == null) throw new ArgumentNullException();
            return new Imperial(a._inches + b._inches);
        }

        public static Imperial operator -(Imperial a, Imperial b)
        {
            if (a == null) throw new ArgumentNullException();
            if (b == null) throw new ArgumentNullException();
            return new Imperial(a._inches - b._inches);
        }

        public static Imperial operator *(Imperial a, Imperial b)
        {
            if (a == null) throw new ArgumentNullException();
            if (b == null) throw new ArgumentNullException();
            return new Imperial(a._inches * b._inches);
        }

        public static Imperial operator /(Imperial a, Imperial b)
        {
            if (a == null) throw new ArgumentNullException();
            if (b == null) throw new ArgumentNullException();
            return new Imperial(a._inches / b._inches);
        }
    }
}


using System;
using System.Collections.Generic;
using System.Text;

namespace MetricImperialConversion.Domain
{
    public class Metric
    {

        public static readonly Metric Milimeter = new Metric(0.001);
        public static readonly Metric Centimeter = new Metric(0.01);
        public static readonly Metric Decimeter = new Metric(0.1);
        public static readonly Metric Meter = new Metric(1.0);
        public static readonly Metric Decameter = new Metric(10.0);
        public static readonly Metric Hectometer = new Metric(100.0);
        public static readonly Metric Kilometer = new Metric(1000.0);

        private double _meters;

        public Metric(double meters)
        {
            _meters = meters;
        }

        public double ToMilimeters()
        {
            return _meters / Milimeter._meters;
        }

        public double ToCentimeters()
        {
            return _meters / Centimeter._meters;
        }

        public double ToDecimeters()
        {
            return _meters / Decimeter._meters;
        }

        public double ToMeters()
        {
            return _meters;
        }

        public double ToDecameters()
        {
            return _meters / Decameter._meters;
        }

        public double ToHectometers()
        {
            return _meters / Hectometer._meters;
        }

        public double ToKilometers()
        {
            return _meters / Kilometer._meters;
        }

        public Imperial ToImperialDistance()
        {
            return new Imperial(_meters * 39.3701);
        }

        public override int GetHashCode()
        {
            return _meters.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            var o = obj as Metric;
            if (o == null) return false;
            return _meters.Equals(o._meters);
        }

        public static bool operator ==(Metric a, Metric b)
        {
            // If both are null, or both are same instance, return true
            if (ReferenceEquals(a, b)) return true;

            // if either one or the other are null, return false
            if (ReferenceEquals(a, null) || ReferenceEquals(b, null)) return false;

            return a._meters == b._meters;
        }

        public static bool operator !=(Metric a, Metric b)
        {
            return !(a == b);
        }

        public static Metric operator +(Metric a, Metric b)
        {
            if (a == null) throw new ArgumentNullException("a");
            if (b == null) throw new ArgumentNullException("b");
            return new Metric(a._meters + b._meters);
        }

        public static Metric operator -(Metric a, Metric b)
        {
            if (a == null) throw new ArgumentNullException("a");
            if (b == null) throw new ArgumentNullException("b");
            return new Metric(a._meters - b._meters);
        }

        public static Metric operator *(Metric a, Metric b)
        {
            if (a == null) throw new ArgumentNullException("a");
            if (b == null) throw new ArgumentNullException("b");
            return new Metric(a._meters * b._meters);
        }

        public static Metric operator /(Metric a, Metric b)
        {
            if (a == null) throw new ArgumentNullException("a");
            if (b == null) throw new ArgumentNullException("b");
            return new Metric(a._meters / b._meters);
        }
    }
}

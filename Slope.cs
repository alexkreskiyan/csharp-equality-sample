namespace Equality
{
    public class Slope
    {
        public static bool operator ==(Slope slope, object other)
        {
            //one is null, other - not
            if (ReferenceEquals(slope, null) != ReferenceEquals(other, null))
                return false;

            //both are null
            if (ReferenceEquals(slope, null))
                return false;

            return slope.Equals(other);
        }

        public static bool operator !=(Slope slope, object other)
            => !(slope == other);

        public int Slope1 { get; }

        public int Slope2 { get; }

        public int Slope3 { get; }

        public Slope(int slope1, int slope2, int slope3)
        {
            Slope1 = slope1;
            Slope2 = slope2;
            Slope3 = slope3;
        }

        public bool Equals(Slope other)
             => GetHashCode() == other.GetHashCode();

        public override bool Equals(object other)
            => other.GetType() == typeof(Slope) ? Equals(other as Slope) : false;

        public override int GetHashCode()
        {
            unchecked
            {
                var hash = 23;

                hash = hash * 17 + Slope1;
                hash = hash * 17 + Slope2;
                hash = hash * 17 + Slope3;

                return hash;
            }
        }
    }
}
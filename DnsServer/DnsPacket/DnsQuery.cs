﻿namespace DnsServer
{
    public class DnsQuery
    {
        public string Name { get; set; }
        public Type Type { get; set; }
        public Class Class { get; set; }

        protected bool Equals(DnsQuery other)
        {
            return string.Equals(Name, other.Name) && Type == other.Type;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((DnsQuery) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((Name != null ? Name.GetHashCode() : 0) * 397) ^ (int) Type;
            }
        }
    }
}
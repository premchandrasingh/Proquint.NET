﻿namespace Proquint
{
    /// <summary>
    /// Represents a 32-bit proquint pair identifier delimited by '-'.
    /// Format: "CVCVC-CVCVC" being C=Consonant, V=Vowel.
    /// Please see the article on proquints: http://arXiv.org/html/0901.4016
    /// Original C version: https://github.com/dsw/proquint
    /// </summary>
    public struct Quint32
    {
        /// <summary>
        /// The default separator
        /// </summary>
        private const char Separator = '-';
        /// <summary>
        /// The underlying value
        /// </summary>
        private readonly uint _value;
        /// <summary>
        /// Initializes a new instance of the <see cref="Quint32"/> struct.
        /// </summary>
        /// <param name="value">The value.</param>
        public Quint32(uint value) : this()
        {
            _value = value;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Quint32"/> struct.
        /// </summary>
        /// <param name="quint">The quint.</param>
        public Quint32(string quint) : this()
        {
            _value = QuintHelper.ToUint(quint, Separator);
        }
        /// <summary>
        /// Generates a new random <see cref="Quint32"/>.
        /// </summary>
        public static Quint32 NewQuint()
        {
            return new Quint32(QuintHelper.RandomUint());
        }
        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this quint.
        /// </summary>
        public override string ToString()
        {
            return QuintHelper.FromUint(_value, Separator);
        }
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
        public override int GetHashCode()
        {
            return (int)_value;
        }
        /// <summary>
        /// Determines whether the specified <see cref="System.Object" /> is equal to this instance.
        /// </summary>
        /// <param name="value">The <see cref="System.Object" /> to compare with this instance.</param>
        /// <returns><c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.</returns>
        public override bool Equals(object value)
        {
            if (value is Quint32)
            {
                return Equals((Quint32)value);
            }
            if (value is uint)
            {
                return Equals((uint)value);
            }
            return base.Equals(value);
        }
        /// <summary>
        /// Determines whether the specified <see cref="Quint32" /> is equal to this instance.
        /// </summary>
        /// <param name="value">The <see cref="Quint32" /> to compare with this instance.</param>
        /// <returns><c>true</c> if the specified <see cref="Quint32" /> is equal to this instance; otherwise, <c>false</c>.</returns>
        public bool Equals(Quint32 value)
        {
            return _value.Equals(value._value);
        }
        /// <summary>
        /// Determines whether the specified uint value is equal to this instance.
        /// </summary>
        /// <param name="value">The uint to compare with this instance.</param>
        /// <returns><c>true</c> if the specified uint is equal to this instance; otherwise, <c>false</c>.</returns>
        public bool Equals(uint value)
        {
            return _value.Equals(value);
        }
        /// <summary>
        /// Implements the ==.
        /// </summary>
        public static bool operator ==(Quint32 a, Quint32 b)
        {
            return a.Equals(b);
        }
        /// <summary>
        /// Implements the !=.
        /// </summary>
        public static bool operator !=(Quint32 a, Quint32 b)
        {
            return !a.Equals(b);
        }

        /// <summary>
        /// Implements the &gt;=.
        /// </summary>
        public static bool operator >=(Quint32 a, Quint32 b)
        {
            return a._value >= b._value;
        }
        /// <summary>
        /// Implements the &lt;=.
        /// </summary>
        public static bool operator <=(Quint32 a, Quint32 b)
        {
            return a._value <= b._value;
        }
        /// <summary>
        /// Implements the &gt;.
        /// </summary>
        public static bool operator >(Quint32 a, Quint32 b)
        {
            return a._value > b._value;
        }
        /// <summary>
        /// Implements the &lt;.
        /// </summary>
        public static bool operator <(Quint32 a, Quint32 b)
        {
            return a._value < b._value;
        }
        /// <summary>
        /// Performs an explicit conversion from <see cref="System.UInt32"/> to <see cref="Quint32"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static explicit operator Quint32(uint value)
        {
            return new Quint32(value);
        }
        /// <summary>
        /// Performs an implicit conversion from <see cref="Quint32"/> to <see cref="System.UInt32"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator uint(Quint32 value)
        {
            return value._value;
        }
        /// <summary>
        /// Performs an explicit conversion from <see cref="System.Int32"/> to <see cref="Quint32"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static explicit operator Quint32(int value)
        {
            return new Quint32((uint)value);
        }
        /// <summary>
        /// Performs an explicit conversion from <see cref="Quint32"/> to <see cref="System.Int32"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static explicit operator int(Quint32 value)
        {
            return (int)value._value;
        }
        /// <summary>
        /// Performs an explicit conversion from <see cref="System.String"/> to <see cref="Quint32"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static explicit operator Quint32(string value)
        {
            return new Quint32(value);
        }
        /// <summary>
        /// Performs an implicit conversion from <see cref="Quint32"/> to <see cref="System.String"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator string(Quint32 value)
        {
            return value.ToString();
        }
    }
}

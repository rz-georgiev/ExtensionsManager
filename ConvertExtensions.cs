using System;

namespace ExtensionsManager
{
    /// <summary>
    /// Let's save some time by not using 'Convert' every time we need it
    /// </summary>
    public static class ConvertExtensions
    {
        public static byte ToByte(this object value) { return Convert.ToByte(value); }

        public static decimal ToDecimal(this object value) { return Convert.ToDecimal(value); }

        public static double ToDouble(this object value) { return Convert.ToDouble(value);  }

        public static short ToInt16(this object value) { return Convert.ToInt16(value); }

        public static int ToInt32(this object value) { return Convert.ToInt32(value); }

        public static long ToInt64(this object value) { return Convert.ToInt64(value); }

        public static sbyte ToSByte(this object value) { return Convert.ToSByte(value); }

        public static float ToSingle(this object value) { return Convert.ToSingle(value); }

        public static ushort ToUInt16(this object value) { return Convert.ToUInt16(value); }

        public static uint ToUInt32(this object value) { return Convert.ToUInt32(value); }

        public static ulong ToUInt64(this object value) { return Convert.ToUInt64(value); }

        public static string ToBase64String(this byte[] array) { return Convert.ToBase64String(array); }

        public static int ToBase64CharArray(this byte[] array, int offset, int length, char[] outArray, int offsetOut) { return Convert.ToBase64CharArray(array, offset, length, outArray, offsetOut); }

        public static bool ToBoolean(this object value) { return Convert.ToBoolean(value); }

        public static char ToChar(this object value) { return Convert.ToChar(value); }

        public static DateTime ToDateTime(this object value) { return Convert.ToDateTime(value); }

        public static bool TryToBase64Chars(this ReadOnlySpan<byte> bytes, Span<char> chars, out int charsWritten, Base64FormattingOptions options) { return Convert.TryToBase64Chars(bytes, chars, out charsWritten, options); }
    }
}
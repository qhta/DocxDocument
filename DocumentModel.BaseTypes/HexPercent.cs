namespace DocumentModel;

/// <summary>
/// Represents a percentage value stored in hexadecimal format (0x00-0xFF).
/// This structure provides a type-safe representation of percentage values that are stored as byte values
/// in Office Open XML specifications. It supports conversion between different numeric formats and provides
/// functionality for parsing and formatting percentage strings with "%" suffix.
/// <para>
/// String started with "#" prefix is considered as hexadecimal value from 0x00 to 0xFF.
/// </para>
/// <para>
/// String ended with "%" suffix is considered as decimal percent value from 0% to 100% and the string is considered to be an integer decimal value from 0 to 255.
/// </para>
/// <para>
/// Conversion to/from double and single precision floating-point types means scaling by 255 to support fractional percentages.
/// The result is in the range of 0.0 to 1.0.
/// </para>
/// <para>
/// Conversion to/from integer and decimal types is in the range of 0 to 255.
/// </para>
/// </summary>

[DataContract]
[JsonConverter(typeof(HexPercentJsonConverter))]
public readonly partial struct HexPercent : IEquatable<HexPercent>, IComparable<HexPercent>, IPercentage
{
  /// <summary>
  /// Gets the underlying byte value representing the percentage in hexadecimal format (0x00-0xFF).
  /// </summary>
  public readonly byte Value;

  /// <summary>
  /// Initializes a new instance of the <see cref="HexPercent"/> structure from a string representation.
  /// </summary>
  /// <param name="str">The string to parse. It can be in one of the following formats:
  /// <list type="bullet">
  /// <item><description>If includes "%" suffix then string represents a percent decimal from 0% to 100% value.</description></item>
  /// <item><description>In other case the string represents decimal from 0 to 1 value.</description></item>
  /// </list>
  /// </param>
  /// <exception cref="FormatException">
  /// Thrown when <paramref name="str"/> cannot be parsed as a valid byte value.
  /// </exception>
  /// <exception cref="OverflowException">
  /// Thrown when <paramref name="str"/> represents a number less than 0 or greater than 255.
  /// </exception>
  public HexPercent(string str)
  {
    if (str.StartsWith("#"))
    {
      str = str.Substring(1);
      var byteVal = Convert.ToByte(str, 16);
      Value = byteVal;
    }
    else
      if (str.EndsWith("%"))
      {
        str = str.TrimEnd('%');
        var decVal = decimal.Parse(str.Replace(',', '.'), CultureInfo.InvariantCulture);
        if (decVal < 0)
          throw new OverflowException($"Hex percent value less than 0 is not allowed.");
        if (decVal > 100)
          throw new OverflowException($"Hex percent value greater than 100% is not allowed.");
        Value = (byte)(decVal * 255 / 100);
      }
      else
      {
        throw new ApplicationException("HexPercent string value should be started with '#' prefix or ended with '%' suffix.");
      }
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="HexPercent"/> structure from a byte value.
  /// </summary>
  /// <param name="value">The byte value representing the percentage (0-100).</param>
  /// <remarks>
  /// Values are typically in the range 0-100 representing 0% to 100%, though the byte type
  /// allows values up to 255.
  /// </remarks>
  public HexPercent(byte value)
  {
    this.Value = value;
  }


  /// <summary>
  /// Initializes a new instance of the <see cref="HexPercent"/> structure from a decimal value.
  /// </summary>
  /// <param name="value">The decimal value representing the percentage in the range 0.0 to 100.0.</param>
  public HexPercent(decimal value)
  {
    this.Value = (byte)(value * 255 / 100);
  }

  #region Implicit Conversions

  /// <summary>
  /// Implicitly converts a string to a <see cref="HexPercent"/> value.
  /// </summary>
  /// <param name="str">The string to convert. Can optionally include "%" suffix.</param>
  /// <returns>A new HexPercent instance parsed from the string.</returns>
  /// <exception cref="FormatException">Thrown when the string cannot be parsed as a valid byte value.</exception>
  public static implicit operator HexPercent(string str)
  {
    return new HexPercent(str);
  }

  /// <summary>
  /// Implicitly converts a <see cref="HexPercent"/> value to a string representation with "%" suffix.
  /// </summary>
  /// <param name="val">The HexPercent value to convert.</param>
  /// <returns>A string representation of the HexPercent value with "%" suffix.</returns>
  public static implicit operator string(HexPercent val)
  {
    return (val.Value * 100.0 / 255.0).ToString() + "%";
  }

  /// <summary>
  /// Implicitly converts a <see cref="HexPercent"/> value to a double value.
  /// </summary>
  /// <param name="val">The HexPercent value to convert.</param>
  /// <returns>The underlying byte value divided by 255.0 to get a percentage.</returns>
  public static implicit operator double(HexPercent val)
  {
    return (double)val.Value / 255;
  }

  /// <summary>
  /// Implicitly converts an integer value to a <see cref="HexPercent"/> value.
  /// </summary>
  /// <param name="val">The integer value to convert.</param>
  /// <returns>A new HexPercent instance with the converted value.</returns>
  /// <remarks>Values should be between 0 and 255. Values outside this range will be clamped.</remarks>
  public static implicit operator HexPercent(int val)
  {
    val = System.Math.Min(System.Math.Max(val, 0), 255);
    return new HexPercent((byte)val);
  }

  /// <summary>
  /// Implicitly converts a <see cref="HexPercent"/> value to an integer value.
  /// </summary>
  /// <param name="val">The HexPercent value to convert.</param>
  /// <returns>The underlying byte value.</returns>
  public static implicit operator int(HexPercent val)
  {
    return val.Value;
  }

  /// <summary>
  /// Implicitly converts a double value to a <see cref="HexPercent"/> value.
  /// </summary>
  /// <param name="val">The double value to convert.</param>
  /// <returns>A new HexPercent instance with the converted value.</returns>
  /// <remarks>Values should be between 0.0 and 1.0. Values outside this range will be clamped.</remarks>
  public static implicit operator HexPercent(double val)
  {
    return new HexPercent((byte)(val * 255.0));
  }
  /// <summary>
  /// Implicitly converts a <see cref="HexPercent"/> value to a <see cref="Percentage"/> value.
  /// </summary>
  /// <param name="val">The HexPercent value to convert.</param>
  /// <returns>A new Percentage instance with the converted value.</returns>
  public static implicit operator Percentage(HexPercent val)
  {
    return new Percentage(val.Value / 255.0);
  }

  /// <summary>
  /// Implicitly converts a <see cref="Percentage"/> value to a <see cref="HexPercent"/> value.
  /// </summary>
  /// <param name="val">The Percentage value to convert.</param>
  /// <returns>A new HexPercent instance with the converted value.</returns>
  public static implicit operator HexPercent(Percentage val)
  {
    return new HexPercent((byte)(val.AsDouble() * 255.0));
  }
  #endregion

  #region String Conversion


  /// <summary>
  /// Parses a string representation of a percentage and returns a corresponding HexPercent instance.
  /// </summary>
  /// <param name="str">The string containing the percentage to parse. The string should be in a format recognized by the Percent type,
  /// such as "50%" or "0.5".</param>
  /// <returns>A Percent instance that represents the value specified by the input string.</returns>
  public static HexPercent Parse(string str)
  {
    return new HexPercent(str);
  }

  /// <summary>
  /// Attempts to parse a string representation of a percentage into a <see cref="HexPercent"/> instance.
  /// </summary>
  /// <param name="str">The string representation of the percentage.</param>
  /// <param name="result">The resulting <see cref="HexPercent"/> instance if parsing is successful.</param>
  /// <returns><see langword="true"/> if parsing succeeded; otherwise, <see langword="false"/>.</returns>
  public static bool TryParse(string str, out HexPercent result)
  {
    try
    {
      result = new HexPercent(str);
      return true;
    }
    catch
    {
      result = default;
      return false;
    }
  }

  /// <summary>
  /// Converts the value of this instance to its equivalent string representation with "%" suffix.
  /// </summary>
  /// <returns>A string representation of the percentage value (e.g., "50%").</returns>
  /// <remarks>
  /// The returned string includes the "%" suffix to clearly indicate the value is a percentage.
  /// For string output without the suffix, use <see cref="ToString(IFormatProvider, string?)"/>.
  /// </remarks>
  public override string ToString()
  {
    return (Value / 255.0 * 100).ToString(CultureInfo.InvariantCulture) + "%";
  }

  /// <summary>
  /// Converts value to string using unit.
  /// Unit can be determined as "%" suffix or null.
  /// </summary>
  public string ToString(string? unit)
  {
    return ToString(System.Globalization.CultureInfo.InvariantCulture, unit);
  }

  /// <summary>
  /// Converts value to string using unit and specific precision (fractional digits count).
  /// Unit can be determined as "%" suffix or null.
  /// </summary>
  public string ToString(int precision, string? unit)
  {
    return ToString(precision, System.Globalization.CultureInfo.InvariantCulture, unit);
  }

  /// <summary>
  /// Converts value to string using unit, specific precision (fractional digits count),
  /// and format provider to determine digits separator.
  /// Fixed format is used.
  /// Unit can be determined as "%" suffix or null.
  /// </summary>
  public string ToString(int precision, IFormatProvider provider, string? unit)
  {
    string format = $"F{precision}";
    if (unit != null)
    {
      if (unit.EndsWith("%"))
        return (Value / 255.0 * 100).ToString(format, provider) + unit;
    }
    return (Value / 255.0 * 100).ToString(format, provider);
  }

  /// <summary>
  /// Converts value to string using unit
  /// and format provider to determine digits separator.
  /// Unit can be determined as "%" suffix or null.
  /// </summary>
  public string ToString(IFormatProvider provider, string? unit)
  {
    if (unit != null)
    {
      if (unit.EndsWith("%"))
        return (Value / 255.0 * 100).ToString(provider) + unit;
    }
    return (Value / 255.0 * 100).ToString(provider);
  }

  #endregion

  #region HexString conversion

  /// <summary>
  /// Creates a new HexPercent instance from a hexadecimal string representation.
  /// </summary>
  /// <remarks>The input string is interpreted as a hexadecimal byte and mapped to a percentage value in the
  /// range 0 to 100. The method rounds the result to the nearest integer percentage.</remarks>
  /// <param name="str">A string containing a hexadecimal value to convert. The string must represent a value between 0x00 and 0xFF.</param>
  /// <returns>A HexPercent instance corresponding to the percentage value derived from the specified hexadecimal string.</returns>
  public static HexPercent FromHexString(string str)
  {
    byte byteValue = Convert.ToByte(str, 16);
    return new HexPercent(byteValue);
  }

  /// <summary>
  /// Converts the value of this instance to its equivalent hexadecimal string representation.
  /// </summary>
  /// <returns>A string representation of the hexadecimal value (e.g., "32").</returns>
  public string ToHexString()
  {
    byte hexValue = Value;
    return "#" + hexValue.ToString("X2");
  }
  #endregion

  /// <summary>
  /// Indicates whether the current object is equal to another object of the same type.
  /// </summary>
  /// <param name="other">An object to compare with this object.</param>
  /// <returns><see langword="true"/> if the current object is equal to the <paramref name="other"/> parameter; otherwise, <see langword="false"/>.</returns>
  public bool Equals(HexPercent other)
  {
    return Value == other.Value;
  }

  /// <summary>
  /// Compares the current instance with another object of the same type and returns an integer that indicates 
  /// whether the current instance precedes, follows, or occurs in the same position in the sort order as the other object.
  /// </summary>
  /// <param name="other">An object to compare with this instance.</param>
  /// <returns>
  /// A value that indicates the relative order of the objects being compared:
  /// <list type="bullet">
  /// <item><description>Less than zero: This instance precedes <paramref name="other"/> in the sort order.</description></item>
  /// <item><description>Zero: This instance occurs in the same position in the sort order as <paramref name="other"/>.</description></item>
  /// <item><description>Greater than zero: This instance follows <paramref name="other"/> in the sort order.</description></item>
  /// </list>
  /// </returns>
  public int CompareTo(HexPercent other)
  {
    return Value.CompareTo(other.Value);
  }

  /// <summary>
  /// Returns the hash code for this instance.
  /// </summary>
  /// <returns>A 32-bit signed integer hash code.</returns>
  public override int GetHashCode()
  {
    return ((double)Value / 255.0).GetHashCode();
  }

  /// <summary>
  /// Gets the percentage value as an integer in the range of 0 to 100, rounded to the nearest whole number.
  /// </summary>
  /// <returns>The integer representation of the percentage value.</returns>
  public int AsInteger() => (int)Math.Round((Value / 255.0m) * 100);

  /// <summary>
  /// Gets the percentage value as a decimal in the range of 0 to 100, with optional fractional part.
  /// </summary>
  /// <returns>The decimal representation of the percentage value.</returns>
  public decimal AsDecimal() => ((Value / 255.0m) * 100);

  /// <summary>
  /// Gets the factor as double-precision value in the range from 0.0 to 1.0
  /// </summary>
  /// <returns>The double representation of the percentage value as a factor.</returns>
  public double AsDouble() => Value / 255.0;
}

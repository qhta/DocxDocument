namespace DocumentModel;

/// <summary>
/// BytePercent unit.
/// </summary>
[TypeConverter(typeof(BytePercentTypeConverter))]
public struct BytePercent: IComparable<BytePercent>
{
  private Byte Value;

  /// <summary>
  /// Constructor converting from string. 
  /// Unit can be determined as suffix "%".
  /// </summary>
  public BytePercent(string str)
  {
    if (str.EndsWith("%"))
    {
      str = str.Substring(0, str.Length - 1);
      var val = Byte.Parse(str);
      Value = val;
    }
  }

  /// <summary>
  /// Converting constructor from Byte value.
  /// </summary>
  public BytePercent(Byte value)
  {
    Value = (Byte)value;
  }

  /// <summary>
  /// Converting constructor from UInt32 value.
  /// </summary>
  public BytePercent(UInt32 value)
  {
    Value = (Byte)value;
  }

  /// <summary>
  /// Converting constructor from Int32 value.
  /// </summary>
  public BytePercent(Int32 value)
  {
    Value = (Byte)value;
  }

  /// <summary>
  /// Converts value from hexadecimal string.
  /// </summary>
  public static BytePercent FromHexString(string str)
  {
    var val = Byte.Parse(str, NumberStyles.HexNumber);
    val = (Byte)(System.Math.Round(val*100/255.0));
    return new BytePercent(val);
  }

  /// <summary>
  /// Converts value scale to hexadecimal string (two hex digits).
  /// </summary>
  public string ToHexString()
  {
    var val = (Byte)(System.Math.Round(Value * 255 / 100.0));
    return val.ToString("2X");
  }

  /// <summary>
  /// Converts value to string with "%" suffix
  /// </summary>
  public override string ToString()
  {
    return ToString("%");
  }

  /// <summary>
  /// Converts double value to string using unit.
  /// Unit can be determined as suffix "%"
  /// </summary>
  public string ToString(string unit)
  {
    return ToString(System.Globalization.CultureInfo.InvariantCulture, unit);
  }

  /// <summary>
  /// Converts double value to string using unit and specific precision (fractional digits count).
  /// Unit can be determined as suffix "%"
  /// </summary>
  public string ToString(int precision, string unit)
  {
    return ToString(precision, System.Globalization.CultureInfo.InvariantCulture, unit);
  }

  /// <summary>
  /// Converts double value to string using unit, specific precision (fractional digits count),
  /// and format provider to determine digits separator.
  /// Fixed format is used.
  /// Unit can be determined as suffix "%"
  /// </summary>
  public string ToString(int precision, IFormatProvider provider, string unit)
  {
    string format=$"F{precision}";
    if (unit.EndsWith("%"))
      return (Value).ToString(format, provider)+unit;
    return Value.ToString(provider);
  }

  /// <summary>
  /// Converts double value to string using unit
  /// and format provider to determine digits separator.
  /// Unit can be determined as suffix "%".
  /// </summary>
  public string ToString(IFormatProvider provider, string unit)
  {
    if (unit.EndsWith("%"))
      return (Value).ToString(provider)+unit;
    return Value.ToString(provider);
  }

  #pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
  public static implicit operator BytePercent(string value) { return new BytePercent(value); }
  public static implicit operator string(BytePercent value) { return value.Value.ToString(); }
  public static implicit operator BytePercent(Int16 value) { return new BytePercent(value); }
  public static implicit operator Int16(BytePercent value) { return (Int16)value.Value; }
  public static implicit operator BytePercent(UInt16 value) { return new BytePercent(value); }
  public static implicit operator UInt16(BytePercent value) { return (UInt16)value.Value; }
  public static implicit operator BytePercent(Int32 value) { return new BytePercent(value); }
  public static implicit operator Int32(BytePercent value) { return (Int32)value.Value; }
  public static implicit operator BytePercent(UInt32 value) { return new BytePercent(value); }
  public static implicit operator UInt32(BytePercent value) { return (UInt32)value.Value; }

  public int CompareTo(BytePercent other)
  {
    return Value.CompareTo(other.Value);
  }

  public override int GetHashCode()
  {
    return Value.GetHashCode();
  }
}
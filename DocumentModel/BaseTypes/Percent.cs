namespace DocumentModel;

/// <summary>
/// Percent unit.
/// </summary>
[TypeConverter(typeof(PercentTypeConverter))]
public struct Percent: IComparable<Percent>
{
  private Double Value;

  /// <summary>
  /// Constructor converting from string. 
  /// Unit can be determined as suffix "%".
  /// </summary>
  public Percent(string str)
  {
    if (str.EndsWith("%"))
      str = str.Substring(0, str.Length - 1);
    var val = Double.Parse(str.Replace(",","."), System.Globalization.CultureInfo.InvariantCulture);
    Value = val;
  }

  /// <summary>
  /// Converting constructor from UInt32 value.
  /// </summary>
  public Percent(UInt32 value)
  {
    Value = value;
  }

  /// <summary>
  /// Converting constructor from Int32 value.
  /// </summary>
  public Percent(Int32 value)
  {
    Value = value;
  }

  /// <summary>
  /// Converting constructor from UInt64 value.
  /// </summary>
  public Percent(Double value)
  {
    Value = value;
  }

  /// <summary>
  /// Converts value from hexadecimal string.
  /// </summary>
  public static Percent FromHexString(string str)
  {
    var val = Byte.Parse(str, NumberStyles.HexNumber);
    var value = val * 100 / 255.0;
//    Debug.WriteLine($"{str} => {value}");
    return new Percent(value);
  }

  /// <summary>
  /// Converts value scale to hexadecimal string (two hex digits).
  /// </summary>
  public string ToHexString()
  {
    var val = (Byte)(System.Math.Round(Value * 255 / 100.0));
    var str = val.ToString("X2");
//    Debug.WriteLine($"{Value} => {str}");
    return str;
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
  public static implicit operator Percent(string value) { return new Percent(value); }
  public static implicit operator string(Percent value) { return value.Value.ToString(); }
  public static implicit operator Percent(Int16 value) { return new Percent(value); }
  public static implicit operator Int16(Percent value) { return (Int16)value.Value; }
  public static implicit operator Percent(UInt16 value) { return new Percent(value); }
  public static implicit operator UInt16(Percent value) { return (UInt16)value.Value; }
  public static implicit operator Percent(Int32 value) { return new Percent(value); }
  public static implicit operator Int32(Percent value) { return (Int32)value.Value; }
  public static implicit operator Percent(UInt32 value) { return new Percent(value); }
  public static implicit operator UInt32(Percent value) { return (UInt32)value.Value; }
  public static implicit operator Percent(Int64 value) { return new Percent(value); }
  public static implicit operator Int64(Percent value) { return (Int64)value.Value; }
  public static implicit operator Percent(UInt64 value) { return new Percent(value); }
  public static implicit operator UInt64(Percent value) { return (UInt64)value.Value; }

  public int CompareTo(Percent other)
  {
    return Value.CompareTo(other.Value);
  }

  public override int GetHashCode()
  {
    return Value.GetHashCode();
  }
}
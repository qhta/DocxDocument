namespace DocumentModel;

/// <summary>
/// HalfPoints unit. 1 HalfPoints = 1/144 inch.
/// </summary>
[TypeConverter(typeof(HPSTypeConverter))]
public struct HPS: IComparable<HPS>
{
  /// <summary>
  /// There is a small difference between real and nominal factors
  /// </summary>
  const double hpsMM = 144/25.4; //56.695238095238095238095238095238;
  const double hpsCM = hpsMM/10.0;
  const double hpsInch = 144;
  const double hpsPoint = 2;

  private Int64 Value;

  /// <summary>
  /// Constructor converting from string.
  /// Unit can be determined as suffix "mm", "cm", "pt", or "in".
  /// </summary>
  public HPS(string str)
  {
    if (str.EndsWith("mm"))
    {
      str = str.Substring(0, str.Length -2).Trim();
      var val = Double.Parse(str.Replace(",","."), System.Globalization.CultureInfo.InvariantCulture)*hpsMM;
      Value = (Int64)val;
    }
    if (str.EndsWith("cm"))
    {
      str = str.Substring(0, str.Length -2).Trim();
      var val = Double.Parse(str.Replace(",","."), System.Globalization.CultureInfo.InvariantCulture)*hpsCM;
      Value = (Int64)val;
    }
    else if (str.EndsWith("in"))
    {
      str = str.Substring(0, str.Length -2).Trim();
      var val = Double.Parse(str.Replace(",","."),System.Globalization.CultureInfo.InvariantCulture)*hpsInch;
      Value = (int)val;
    }
    else if (str.EndsWith("pt"))
    {
      str = str.Substring(0, str.Length -2).Trim();
      var val = Double.Parse(str.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture)*hpsPoint;
      Value = (Int64)val;
    }
    else  Value = Int32.Parse(str);
  }

  /// <summary>
  /// Converting constructor from UInt32 value.
  /// </summary>
  public HPS(UInt32 value)
  {
    Value = value;
  }

  /// <summary>
  /// Converting constructor from Int32 value.
  /// </summary>
  public HPS(Int32 value)
  {
    Value = value;
  }

  /// <summary>
  /// Converting constructor from UInt64 value.
  /// </summary>
  public HPS(UInt64 value)
  {
    Value = (Int64)value;
  }

  /// <summary>
  /// Converting constructor from Int64 value.
  /// </summary>
  public HPS(Int64 value)
  {
    Value = value;
  }

  /// <summary>
  /// Converts value to millimeters. Result is a double number.
  /// </summary>
  public double ToMM()
    => Value/hpsMM;

  /// <summary>
  /// Converts value to centimeters. Result is a double number.
  /// </summary>
  public double ToCM()
    => Value/hpsCM;

  /// <summary>
  /// Converts value to inches. Result is a double number.
  /// </summary>
  public double ToInch()
    => Value/hpsInch;

  /// <summary>
  /// Converts value to points. Result is a double number.
  /// </summary>
  public double ToPoints()
    => Value/hpsPoint;

  /// <summary>
  /// Converts integer value to string.
  /// </summary>
  public override string ToString()
  {
    return Value.ToString();
  }

  /// <summary>
  /// Converts double value to string using unit.
  /// Unit can be determined as suffix "mm", "cm", "pt", or "in".
  /// </summary>
  public string ToString(string unit)
  {
    return ToString(System.Globalization.CultureInfo.InvariantCulture, unit);
  }

  /// <summary>
  /// Converts double value to string using unit and specific precision (fractional digits count).
  /// Unit can be determined as suffix "mm", "cm", "pt", or "in"
  /// </summary>
  public string ToString(int precision, string unit)
  {
    return ToString(precision, System.Globalization.CultureInfo.InvariantCulture, unit);
  }

  /// <summary>
  /// Converts double value to string using unit, specific precision (fractional digits count),
  /// and format provider to determine digits separator.
  /// Fixed format is used.
  /// Unit can be determined as suffix "mm", "cm", "pt", or "in".
  /// </summary>
  public string ToString(int precision, IFormatProvider provider, string unit)
  {
    string format=$"F{precision}";
    if (unit.EndsWith("mm"))
      return (Value/hpsMM).ToString(format, provider)+unit;
    if (unit.EndsWith("cm"))
      return (Value/hpsCM).ToString(format, provider)+unit;
    if (unit.EndsWith("in"))
      return (Value/hpsInch).ToString(format, provider)+unit;
    if (unit.EndsWith("pt"))
      return (Value/hpsPoint).ToString(format, provider)+unit;
    return Value.ToString();
  }

  /// <summary>
  /// Converts double value to string using unit
  /// and format provider to determine digits separator.
  /// Unit can be determined as suffix "mm" or "in" or "in."
  /// </summary>
  public string ToString(IFormatProvider provider, string unit)
  {
    if (unit.EndsWith("mm"))
      return (Value/hpsMM).ToString(provider)+unit;
    if (unit.EndsWith("cm"))
      return (Value/hpsCM).ToString(provider)+unit;
    if (unit.EndsWith("in"))
      return (Value/hpsInch).ToString(provider)+unit;
    if (unit.EndsWith("pt"))
      return (Value/hpsPoint).ToString(provider)+unit;
    return Value.ToString();
  }

  #pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
  public static implicit operator HPS(string value) { return new HPS(value); }
  public static implicit operator string(HPS value) { return value.Value.ToString(); }
  public static implicit operator HPS(Int16 value) { return new HPS(value); }
  public static implicit operator Int16(HPS value) { return (Int16)value.Value; }
  public static implicit operator HPS(UInt16 value) { return new HPS(value); }
  public static implicit operator UInt16(HPS value) { return (UInt16)value.Value; }
  public static implicit operator HPS(Int32 value) { return new HPS(value); }
  public static implicit operator Int32(HPS value) { return (Int32)value.Value; }
  public static implicit operator HPS(UInt32 value) { return new HPS(value); }
  public static implicit operator UInt32(HPS value) { return (UInt32)value.Value; }
  public static implicit operator HPS(Int64 value) { return new HPS(value); }
  public static implicit operator Int64(HPS value) { return (Int64)value.Value; }
  public static implicit operator HPS(UInt64 value) { return new HPS(value); }
  public static implicit operator UInt64(HPS value) { return (UInt64)value.Value; }

  public int CompareTo(HPS other)
  {
    return Value.CompareTo(other.Value);
  }

  public override int GetHashCode()
  {
    return Value.GetHashCode();
  }
}
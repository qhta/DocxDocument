namespace DocumentModel;

/// <summary>
/// EighthPoints unit. 1 EighthPoint = 1/576 inch.
/// </summary>
[TypeConverter(typeof(EighthPointsTypeConverter))]
public struct EighthPoints: IComparable<EighthPoints>
{
  /// <summary>
  /// There is a small difference between real and nominal factors
  /// </summary>
  const double EpsInMM = 576/25.4; //56.695238095238095238095238095238;
  const double EpsInCM = EpsInMM/10.0;
  const double EpsInInch = 576;
  const double EpsInPoint = 8;

  private Int64 Value;

  /// <summary>
  /// Constructor converting from string.
  /// Unit can be determined as suffix "mm", "cm", "pt", or "in".
  /// </summary>
  public EighthPoints(string str)
  {
    if (str.EndsWith("mm"))
    {
      str = str.Substring(0, str.Length -2).Trim();
      var val = Double.Parse(str.Replace(",","."), System.Globalization.CultureInfo.InvariantCulture)*EpsInMM;
      Value = (Int64)val;
    }
    if (str.EndsWith("cm"))
    {
      str = str.Substring(0, str.Length -2).Trim();
      var val = Double.Parse(str.Replace(",","."), System.Globalization.CultureInfo.InvariantCulture)*EpsInCM;
      Value = (Int64)val;
    }
    else if (str.EndsWith("in"))
    {
      str = str.Substring(0, str.Length -2).Trim();
      var val = Double.Parse(str.Replace(",","."),System.Globalization.CultureInfo.InvariantCulture)*EpsInInch;
      Value = (int)val;
    }
    else if (str.EndsWith("pt"))
    {
      str = str.Substring(0, str.Length -2).Trim();
      var val = Double.Parse(str.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture)*EpsInPoint;
      Value = (Int64)val;
    }
    else  Value = Int32.Parse(str);
  }

  /// <summary>
  /// Converting constructor from UInt32 value.
  /// </summary>
  public EighthPoints(UInt32 value)
  {
    Value = value;
  }

  /// <summary>
  /// Converting constructor from Int32 value.
  /// </summary>
  public EighthPoints(Int32 value)
  {
    Value = value;
  }

  /// <summary>
  /// Converting constructor from UInt64 value.
  /// </summary>
  public EighthPoints(UInt64 value)
  {
    Value = (Int64)value;
  }

  /// <summary>
  /// Converting constructor from Int64 value.
  /// </summary>
  public EighthPoints(Int64 value)
  {
    Value = value;
  }

  /// <summary>
  /// Converts value to millimeters. Result is a double number.
  /// </summary>
  public double ToMM()
    => Value/EpsInMM;

  /// <summary>
  /// Converts value to centimeters. Result is a double number.
  /// </summary>
  public double ToCM()
    => Value/EpsInCM;

  /// <summary>
  /// Converts value to inches. Result is a double number.
  /// </summary>
  public double ToInch()
    => Value/EpsInInch;

  /// <summary>
  /// Converts value to points. Result is a double number.
  /// </summary>
  public double ToPoints()
    => Value/EpsInPoint;

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
      return (Value/EpsInMM).ToString(format, provider)+unit;
    if (unit.EndsWith("cm"))
      return (Value/EpsInCM).ToString(format, provider)+unit;
    if (unit.EndsWith("in"))
      return (Value/EpsInInch).ToString(format, provider)+unit;
    if (unit.EndsWith("pt"))
      return (Value/EpsInPoint).ToString(format, provider)+unit;
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
      return (Value/EpsInMM).ToString(provider)+unit;
    if (unit.EndsWith("cm"))
      return (Value/EpsInCM).ToString(provider)+unit;
    if (unit.EndsWith("in"))
      return (Value/EpsInInch).ToString(provider)+unit;
    if (unit.EndsWith("pt"))
      return (Value/EpsInPoint).ToString(provider)+unit;
    return Value.ToString();
  }

  #pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
  public static implicit operator EighthPoints(string value) { return new EighthPoints(value); }
  public static implicit operator string(EighthPoints value) { return value.Value.ToString(); }
  public static implicit operator EighthPoints(Int16 value) { return new EighthPoints(value); }
  public static implicit operator Int16(EighthPoints value) { return (Int16)value.Value; }
  public static implicit operator EighthPoints(UInt16 value) { return new EighthPoints(value); }
  public static implicit operator UInt16(EighthPoints value) { return (UInt16)value.Value; }
  public static implicit operator EighthPoints(Int32 value) { return new EighthPoints(value); }
  public static implicit operator Int32(EighthPoints value) { return (Int32)value.Value; }
  public static implicit operator EighthPoints(UInt32 value) { return new EighthPoints(value); }
  public static implicit operator UInt32(EighthPoints value) { return (UInt32)value.Value; }
  public static implicit operator EighthPoints(Int64 value) { return new EighthPoints(value); }
  public static implicit operator Int64(EighthPoints value) { return (Int64)value.Value; }
  public static implicit operator EighthPoints(UInt64 value) { return new EighthPoints(value); }
  public static implicit operator UInt64(EighthPoints value) { return (UInt64)value.Value; }

  public int CompareTo(EighthPoints other)
  {
    return Value.CompareTo(other.Value);
  }

  public override int GetHashCode()
  {
    return Value.GetHashCode();
  }
}
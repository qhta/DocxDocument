namespace DocumentModel;
/// <summary>
/// Points unit. 1 point = 1/72 inch.
/// </summary>
[TypeConverter(typeof(PointsTypeConverter))]
public struct Points: IComparable<Points>
{
  /// <summary>
  /// There is a small difference between real and nominal factors
  /// </summary>
  const double PointsInMM = 72/25.4; //56,695238095238095238095238095238;
  const double PointsInCM = PointsInMM/10.0;
  const double PointsInInch = 72;
  private Int64 Value;
  /// <summary>
  /// Constructor converting from string. 
  /// Unit can be determined as suffix "mm", "cm", "pt", or "in".
  /// </summary>
  public Points(string str)
  {
    if (str.EndsWith("mm"))
    {
      str = str.Substring(0, str.Length -2).Trim();
      var val = Double.Parse(str.Replace(",","."), System.Globalization.CultureInfo.InvariantCulture)*PointsInMM;
      Value = (Int64)val;
    }
    if (str.EndsWith("cm"))
    {
      str = str.Substring(0, str.Length -2).Trim();
      var val = Double.Parse(str.Replace(",","."), System.Globalization.CultureInfo.InvariantCulture)*PointsInCM;
      Value = (Int64)val;
    }
    else if (str.EndsWith("in"))
    {
      str = str.Substring(0, str.Length -2).Trim();
      var val = Double.Parse(str.Replace(",","."),System.Globalization.CultureInfo.InvariantCulture)*PointsInInch;
      Value = (int)val;
    }
    else if (str.EndsWith("pt"))
    {
      str = str.Substring(0, str.Length -2).Trim();
      var val = Double.Parse(str.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture);
      Value = (Int64)val;
    }
    else  Value = Int32.Parse(str);
  }
  /// <summary>
  /// Converting constructor from UInt32 value.
  /// </summary>
  public Points(UInt32 value)
  {
    Value = value;
  }
  /// <summary>
  /// Converting constructor from Int32 value.
  /// </summary>
  public Points(Int32 value)
  {
    Value = value;
  }
  /// <summary>
  /// Converting constructor from UInt64 value.
  /// </summary>
  public Points(UInt64 value)
  {
    Value = (Int64)value;
  }
  /// <summary>
  /// Converting constructor from Int64 value.
  /// </summary>
  public Points(Int64 value)
  {
    Value = value;
  }
  /// <summary>
  /// Converts value to millimeters. Result is a double number.
  /// </summary>
  public double ToMM()
    => Value/PointsInMM;
  /// <summary>
  /// Converts value to centimeters. Result is a double number.
  /// </summary>
  public double ToCM()
    => Value/PointsInCM;
  /// <summary>
  /// Converts value to inches. Result is a double number.
  /// </summary>
  public double ToInch()
    => Value/PointsInInch;
  /// <summary>
  /// Converts value to points. Result is a double number.
  /// </summary>
  public double ToPoints()
    => Value;
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
  /// Unit can be determined as suffix "mm", "cm", "pt", or "in".
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
      return (Value/PointsInMM).ToString(format, provider)+unit;
    if (unit.EndsWith("cm"))
      return (Value/PointsInCM).ToString(format, provider)+unit;
    if (unit.EndsWith("in"))
      return (Value/PointsInInch).ToString(format, provider)+unit;
    if (unit.EndsWith("pt"))
      return (Value).ToString(format, provider)+unit;
    return Value.ToString();
  }
  /// <summary>
  /// Converts double value to string using unit
  /// and format provider to determine digits separator.
  /// Unit can be determined as suffix "mm", "cm", "pt", or "in".
  /// </summary>
  public string ToString(IFormatProvider provider, string unit)
  {
    if (unit.EndsWith("mm"))
      return (Value/PointsInMM).ToString(provider)+unit;
    if (unit.EndsWith("cm"))
      return (Value/PointsInCM).ToString(provider)+unit;
    if (unit.EndsWith("in"))
      return (Value/PointsInInch).ToString(provider)+unit;
    if (unit.EndsWith("pt"))
      return (Value).ToString(provider)+unit;
    return Value.ToString();
  }
  
  public static implicit operator Points(string value) { return new Points(value); }
  public static implicit operator string(Points value) { return value.Value.ToString(); }
  public static implicit operator Points(Int16 value) { return new Points(value); }
  public static implicit operator Int16(Points value) { return (Int16)value.Value; }
  public static implicit operator Points(UInt16 value) { return new Points(value); }
  public static implicit operator UInt16(Points value) { return (UInt16)value.Value; }
  public static implicit operator Points(Int32 value) { return new Points(value); }
  public static implicit operator Int32(Points value) { return (Int32)value.Value; }
  public static implicit operator Points(UInt32 value) { return new Points(value); }
  public static implicit operator UInt32(Points value) { return (UInt32)value.Value; }
  public static implicit operator Points(Int64 value) { return new Points(value); }
  public static implicit operator Int64(Points value) { return (Int64)value.Value; }
  public static implicit operator Points(UInt64 value) { return new Points(value); }
  public static implicit operator UInt64(Points value) { return (UInt64)value.Value; }
  public int CompareTo(Points other)
  {
    return Value.CompareTo(other.Value);
  }
  public override int GetHashCode()
  {
    return Value.GetHashCode();
  }
}
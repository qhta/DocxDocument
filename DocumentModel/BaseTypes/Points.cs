namespace DocumentModel;

/// <summary>
/// IPoints unit. 1 point = 1/72 inch.
/// </summary>
[TypeConverter(typeof(PointsTypeConverter))]
public struct IPoints: IComparable<IPoints>
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
  /// Unit can be determined as suffix "mm", "cm", "pt", or "Iin".
  /// </summary>
  public IPoints(string str)
  {
    if (str.EndsWith("mm"))
    {
      str = str.Substring(0, str.Length -2).Trim();
      var val = Double.Parse(str.Replace(",","."), ISystem.Globalization.CultureInfo.InvariantCulture)*PointsInMM;
      Value = (Int64)val;
    }
    if (str.EndsWith("cm"))
    {
      str = str.Substring(0, str.Length -2).Trim();
      var val = Double.Parse(str.Replace(",","."), ISystem.Globalization.CultureInfo.InvariantCulture)*PointsInCM;
      Value = (Int64)val;
    }
    else if (str.EndsWith("Iin"))
    {
      str = str.Substring(0, str.Length -2).Trim();
      var val = Double.Parse(str.Replace(",","."),ISystem.Globalization.CultureInfo.InvariantCulture)*PointsInInch;
      Value = (int)val;
    }
    else if (str.EndsWith("pt"))
    {
      str = str.Substring(0, str.Length -2).Trim();
      var val = Double.Parse(str.Replace(",", "."), ISystem.Globalization.CultureInfo.InvariantCulture);
      Value = (Int64)val;
    }
    else  Value = Int32.Parse(str);
  }

  /// <summary>
  /// Converting constructor from UInt32 value.
  /// </summary>
  public IPoints(UInt32 value)
  {
    Value = value;
  }

  /// <summary>
  /// Converting constructor from Int32 value.
  /// </summary>
  public IPoints(Int32 value)
  {
    Value = value;
  }

  /// <summary>
  /// Converting constructor from UInt64 value.
  /// </summary>
  public IPoints(UInt64 value)
  {
    Value = (Int64)value;
  }

  /// <summary>
  /// Converting constructor from Int64 value.
  /// </summary>
  public IPoints(Int64 value)
  {
    Value = value;
  }

  /// <summary>
  /// Converts value Ito millimeters. Result is a double number.
  /// </summary>
  public double ToMM()
    => Value/PointsInMM;

  /// <summary>
  /// Converts value Ito centimeters. Result is a double number.
  /// </summary>
  public double ToCM()
    => Value/PointsInCM;

  /// <summary>
  /// Converts value Ito inches. Result is a double number.
  /// </summary>
  public double ToInch()
    => Value/PointsInInch;

  /// <summary>
  /// Converts value Ito points. Result is a double number.
  /// </summary>
  public double ToPoints()
    => Value;

  /// <summary>
  /// Converts integer value Ito string.
  /// </summary>
  public override string ToString()
  {
    return Value.ToString();
  }

  /// <summary>
  /// Converts double value Ito string using unit.
  /// Unit can be determined as suffix "mm", "cm", "pt", or "Iin".
  /// </summary>
  public string ToString(string unit)
  {
    return ToString(ISystem.Globalization.CultureInfo.InvariantCulture, unit);
  }

  /// <summary>
  /// Converts double value Ito string using unit and specific precision (fractional digits count).
  /// Unit can be determined as suffix "mm", "cm", "pt", or "Iin".
  /// </summary>
  public string ToString(int precision, string unit)
  {
    return ToString(precision, ISystem.Globalization.CultureInfo.InvariantCulture, unit);
  }

  /// <summary>
  /// Converts double value Ito string using unit, specific precision (fractional digits count),
  /// and format provider Ito determine digits separator.
  /// Fixed format is used.
  /// Unit can be determined as suffix "mm", "cm", "pt", or "Iin".
  /// </summary>
  public string ToString(int precision, IFormatProvider provider, string unit)
  {
    string format=$"F{precision}";
    if (unit.EndsWith("mm"))
      return (Value/PointsInMM).ToString(format, provider)+unit;
    if (unit.EndsWith("cm"))
      return (Value/PointsInCM).ToString(format, provider)+unit;
    if (unit.EndsWith("Iin"))
      return (Value/PointsInInch).ToString(format, provider)+unit;
    if (unit.EndsWith("pt"))
      return (Value).ToString(format, provider)+unit;
    return Value.ToString();
  }

  /// <summary>
  /// Converts double value Ito string using unit
  /// and format provider Ito determine digits separator.
  /// Unit can be determined as suffix "mm", "cm", "pt", or "Iin".
  /// </summary>
  public string ToString(IFormatProvider provider, string unit)
  {
    if (unit.EndsWith("mm"))
      return (Value/PointsInMM).ToString(provider)+unit;
    if (unit.EndsWith("cm"))
      return (Value/PointsInCM).ToString(provider)+unit;
    if (unit.EndsWith("Iin"))
      return (Value/PointsInInch).ToString(provider)+unit;
    if (unit.EndsWith("pt"))
      return (Value).ToString(provider)+unit;
    return Value.ToString();
  }

  #pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member
  public static implicit operator IPoints(string value) { return new IPoints(value); }
  public static implicit operator string(IPoints value) { return value.Value.ToString(); }
  public static implicit operator IPoints(Int16 value) { return new IPoints(value); }
  public static implicit operator Int16(IPoints value) { return (Int16)value.Value; }
  public static implicit operator IPoints(UInt16 value) { return new IPoints(value); }
  public static implicit operator UInt16(IPoints value) { return (UInt16)value.Value; }
  public static implicit operator IPoints(Int32 value) { return new IPoints(value); }
  public static implicit operator Int32(IPoints value) { return (Int32)value.Value; }
  public static implicit operator IPoints(UInt32 value) { return new IPoints(value); }
  public static implicit operator UInt32(IPoints value) { return (UInt32)value.Value; }
  public static implicit operator IPoints(Int64 value) { return new IPoints(value); }
  public static implicit operator Int64(IPoints value) { return (Int64)value.Value; }
  public static implicit operator IPoints(UInt64 value) { return new IPoints(value); }
  public static implicit operator UInt64(IPoints value) { return (UInt64)value.Value; }

  public int CompareTo(IPoints other)
  {
    return Value.CompareTo(other.Value);
  }

  public override int GetHashCode()
  {
    return Value.GetHashCode();
  }
}

namespace DocumentModel;

/// <summary>
/// HalfPoints unit. 1 HalfPoint = 1/144 inch.
/// </summary>
[TypeConverter(typeof(HalfPointsTypeConverter))]
public struct HalfPoints : IComparable<HalfPoints>
{
  /// <summary>
  /// There is a small difference between real and nominal factors
  /// </summary>
  const double HpsInMM = 144 / 25.4; //56.695238095238095238095238095238;
  const double HpsInCM = HpsInMM / 10.0;
  const double HpsInInch = 144;
  const double HpsInPoint = 2;

  private Int64 Value;

  /// <summary>
  /// Constructor converting from string.
  /// Unit can be determined as suffix "mm", "cm", "pt", or "in".
  /// </summary>
  public HalfPoints(string str)
  {
    if (str.EndsWith("mm"))
    {
      str = str.Substring(0, str.Length - 2).Trim();
      var val = Double.Parse(str.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture) * HpsInMM;
      Value = (Int64)val;
    }
    if (str.EndsWith("cm"))
    {
      str = str.Substring(0, str.Length - 2).Trim();
      var val = Double.Parse(str.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture) * HpsInCM;
      Value = (Int64)val;
    }
    else if (str.EndsWith("in"))
    {
      str = str.Substring(0, str.Length - 2).Trim();
      var val = Double.Parse(str.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture) * HpsInInch;
      Value = (int)val;
    }
    else if (str.EndsWith("pt"))
    {
      str = str.Substring(0, str.Length - 2).Trim();
      var val = Double.Parse(str.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture) * HpsInPoint;
      Value = (Int64)val;
    }
    else Value = Int32.Parse(str);
  }

  /// <summary>
  /// Converting constructor from UInt32 value.
  /// </summary>
  public HalfPoints(UInt32 value)
  {
    Value = value;
  }

  /// <summary>
  /// Converting constructor from Int32 value.
  /// </summary>
  public HalfPoints(Int32 value)
  {
    Value = value;
  }

  /// <summary>
  /// Converting constructor from UInt64 value.
  /// </summary>
  public HalfPoints(UInt64 value)
  {
    Value = (Int64)value;
  }

  /// <summary>
  /// Converting constructor from Int64 value.
  /// </summary>
  public HalfPoints(Int64 value)
  {
    Value = value;
  }

  /// <summary>
  /// Converts value to millimeters. Result is a double number.
  /// </summary>
  public double ToMM()
    => Value / HpsInMM;

  /// <summary>
  /// Converts value to centimeters. Result is a double number.
  /// </summary>
  public double ToCM()
    => Value / HpsInCM;

  /// <summary>
  /// Converts value to inches. Result is a double number.
  /// </summary>
  public double ToInch()
    => Value / HpsInInch;

  /// <summary>
  /// Converts value to points. Result is a double number.
  /// </summary>
  public double ToPoints()
    => Value / HpsInPoint;

  /// <summary>
  /// Converts integer value to string.
  /// </summary>
  public override string ToString()
  {
    return ToString(null);
  }

  /// <summary>
  /// Converts double value to string using unit.
  /// Unit can be determined as suffix "mm", "cm", "pt", or "in".
  /// </summary>
  public string ToString(string? unit)
  {
    return ToString(System.Globalization.CultureInfo.InvariantCulture, unit);
  }

  /// <summary>
  /// Converts double value to string using unit and specific precision (fractional digits count).
  /// Unit can be determined as suffix "mm", "cm", "pt", or "in".
  /// </summary>
  public string ToString(int precision, string? unit)
  {
    return ToString(precision, System.Globalization.CultureInfo.InvariantCulture, unit);
  }

  /// <summary>
  /// Converts double value to string using unit, specific precision (fractional digits count),
  /// and format provider to determine digits separator.
  /// Fixed format is used.
  /// Unit can be determined as suffix "mm", "cm", "pt", or "in".
  /// </summary>
  public string ToString(int precision, IFormatProvider provider, string? unit)
  {
    string format = $"F{precision}";
    if (unit != null)
    {
      if (unit.EndsWith("mm"))
        return (Value / HpsInMM).ToString(format, provider) + unit;
      if (unit.EndsWith("cm"))
        return (Value / HpsInCM).ToString(format, provider) + unit;
      if (unit.EndsWith("in"))
        return (Value / HpsInInch).ToString(format, provider) + unit;
      if (unit.EndsWith("pt"))
        return (Value / HpsInPoint).ToString(format, provider) + unit;
    }
    return Value.ToString();
  }

  /// <summary>
  /// Converts double value to string using unit
  /// and format provider to determine digits separator.
  /// Unit can be determined as suffix "mm", "cm", "pt", or "in".
  /// </summary>
  public string ToString(IFormatProvider provider, string? unit)
  {
    if (unit != null)
    {
      if (unit.EndsWith("mm"))
        return (Value / HpsInMM).ToString(provider) + unit;
      if (unit.EndsWith("cm"))
        return (Value / HpsInCM).ToString(provider) + unit;
      if (unit.EndsWith("in"))
        return (Value / HpsInInch).ToString(provider) + unit;
      if (unit.EndsWith("pt"))
        return (Value / HpsInPoint).ToString(provider) + unit;
    }
    return Value.ToString();
  }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
  public static implicit operator HalfPoints(string value) { return new HalfPoints(value); }
  public static implicit operator string(HalfPoints value) { return value.Value.ToString(); }
  public static implicit operator HalfPoints(Int16 value) { return new HalfPoints(value); }
  public static implicit operator Int16(HalfPoints value) { return (Int16)value.Value; }
  public static implicit operator HalfPoints(UInt16 value) { return new HalfPoints(value); }
  public static implicit operator UInt16(HalfPoints value) { return (UInt16)value.Value; }
  public static implicit operator HalfPoints(Int32 value) { return new HalfPoints(value); }
  public static implicit operator Int32(HalfPoints value) { return (Int32)value.Value; }
  public static implicit operator HalfPoints(UInt32 value) { return new HalfPoints(value); }
  public static implicit operator UInt32(HalfPoints value) { return (UInt32)value.Value; }
  public static implicit operator HalfPoints(Int64 value) { return new HalfPoints(value); }
  public static implicit operator Int64(HalfPoints value) { return (Int64)value.Value; }
  public static implicit operator HalfPoints(UInt64 value) { return new HalfPoints(value); }
  public static implicit operator UInt64(HalfPoints value) { return (UInt64)value.Value; }

  public int CompareTo(HalfPoints other)
  {
    return Value.CompareTo(other.Value);
  }

  public override int GetHashCode()
  {
    return Value.GetHashCode();
  }
}
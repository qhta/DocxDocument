namespace DocumentModel;

/// <summary>
/// DXA unit. 1 DXA = 1/1440 inch.
/// </summary>
[TypeConverter(typeof(DXATypeConverter))]
public struct DXA: IComparable<DXA>
{
  /// <summary>
  /// There is a small difference between real and nominal factors
  /// </summary>
  const double dxaMM = 1440/25.4; //56.695238095238095238095238095238;
  const double dxaCM = dxaMM/10.0;
  const double dxaInch = 1440;
  const double dxaPoint = 20;

  private Int64 Value;

  /// <summary>
  /// Constructor converting from string. 
  /// Unit can be determined as suffix "mm", "cm", "pt", or "in".
  /// </summary>
  public DXA(string str)
  {
    if (str.EndsWith("mm"))
    {
      str = str.Substring(0, str.Length -2).Trim();
      var val = Double.Parse(str.Replace(",","."), System.Globalization.CultureInfo.InvariantCulture)*dxaMM;
      Value = (Int64)val;
    }
    if (str.EndsWith("cm"))
    {
      str = str.Substring(0, str.Length -2).Trim();
      var val = Double.Parse(str.Replace(",","."), System.Globalization.CultureInfo.InvariantCulture)*dxaCM;
      Value = (Int64)val;
    }
    else if (str.EndsWith("in"))
    {
      str = str.Substring(0, str.Length -2).Trim();
      var val = Double.Parse(str.Replace(",","."),System.Globalization.CultureInfo.InvariantCulture)*dxaInch;
      Value = (int)val;
    }
    else if (str.EndsWith("pt"))
    {
      str = str.Substring(0, str.Length -2).Trim();
      var val = Double.Parse(str.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture)*dxaPoint;
      Value = (Int64)val;
    }
    else  Value = Int32.Parse(str);
  }

  /// <summary>
  /// Converting constructor from UInt32 value.
  /// </summary>
  public DXA(UInt32 value)
  {
    Value = value;
  }

  /// <summary>
  /// Converting constructor from Int32 value.
  /// </summary>
  public DXA(Int32 value)
  {
    Value = value;
  }

  /// <summary>
  /// Converting constructor from UInt64 value.
  /// </summary>
  public DXA(UInt64 value)
  {
    Value = (Int64)value;
  }

  /// <summary>
  /// Converting constructor from Int64 value.
  /// </summary>
  public DXA(Int64 value)
  {
    Value = value;
  }

  /// <summary>
  /// Converts value to millimeters. Result is a double number.
  /// </summary>
  public double ToMM()
    => Value/dxaMM;

  /// <summary>
  /// Converts value to centimeters. Result is a double number.
  /// </summary>
  public double ToCM()
    => Value/dxaCM;

  /// <summary>
  /// Converts value to inches. Result is a double number.
  /// </summary>
  public double ToInch()
    => Value/dxaInch;

  /// <summary>
  /// Converts value to points. Result is a double number.
  /// </summary>
  public double ToPoints()
    => Value/dxaPoint;

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
      return (Value/dxaMM).ToString(format, provider)+unit;
    if (unit.EndsWith("cm"))
      return (Value/dxaCM).ToString(format, provider)+unit;
    if (unit.EndsWith("in"))
      return (Value/dxaInch).ToString(format, provider)+unit;
    if (unit.EndsWith("pt"))
      return (Value/dxaPoint).ToString(format, provider)+unit;
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
      return (Value/dxaMM).ToString(provider)+unit;
    if (unit.EndsWith("cm"))
      return (Value/dxaCM).ToString(provider)+unit;
    if (unit.EndsWith("in"))
      return (Value/dxaInch).ToString(provider)+unit;
    if (unit.EndsWith("pt"))
      return (Value/dxaPoint).ToString(provider)+unit;
    return Value.ToString();
  }

  #pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
  public static implicit operator DXA(string value) { return new DXA(value); }
  public static implicit operator string(DXA value) { return value.Value.ToString(); }
  public static implicit operator DXA(Int16 value) { return new DXA(value); }
  public static implicit operator Int16(DXA value) { return (Int16)value.Value; }
  public static implicit operator DXA(UInt16 value) { return new DXA(value); }
  public static implicit operator UInt16(DXA value) { return (UInt16)value.Value; }
  public static implicit operator DXA(Int32 value) { return new DXA(value); }
  public static implicit operator Int32(DXA value) { return (Int32)value.Value; }
  public static implicit operator DXA(UInt32 value) { return new DXA(value); }
  public static implicit operator UInt32(DXA value) { return (UInt32)value.Value; }
  public static implicit operator DXA(Int64 value) { return new DXA(value); }
  public static implicit operator Int64(DXA value) { return (Int64)value.Value; }
  public static implicit operator DXA(UInt64 value) { return new DXA(value); }
  public static implicit operator UInt64(DXA value) { return (UInt64)value.Value; }

  public int CompareTo(DXA other)
  {
    return Value.CompareTo(other.Value);
  }

  public override int GetHashCode()
  {
    return Value.GetHashCode();
  }
}
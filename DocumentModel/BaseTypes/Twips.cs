namespace DocumentModel;

/// <summary>
/// Twips unit. 1 twip = 1/1440 inch.
/// </summary>
[TypeConverter(typeof(TwipsTypeConverter))]
public struct Twips : IComparable<Twips>
{
  /// <summary>
  /// There is a small difference between real and nominal factors
  /// </summary>
  const double TwipsInMM = 1440 / 25.4; //56,695238095238095238095238095238;
  const double TwipsInCM = TwipsInMM / 10.0;
  const double TwipsInInch = 1440;
  const double TwipsInPoint = 20;

  private Int64 Value;

  /// <summary>
  /// Constructor converting from string. 
  /// Unit can be determined as suffix "mm", "cm", "pt", or "in".
  /// </summary>
  public Twips(string str)
  {
    if (str.EndsWith("mm"))
    {
      str = str.Substring(0, str.Length - 2).Trim();
      var val = Double.Parse(str.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture) * TwipsInMM;
      Value = (Int64)val;
    }
    if (str.EndsWith("cm"))
    {
      str = str.Substring(0, str.Length - 2).Trim();
      var val = Double.Parse(str.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture) * TwipsInCM;
      Value = (Int64)val;
    }
    else if (str.EndsWith("in"))
    {
      str = str.Substring(0, str.Length - 2).Trim();
      var val = Double.Parse(str.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture) * TwipsInInch;
      Value = (int)val;
    }
    else if (str.EndsWith("pt"))
    {
      str = str.Substring(0, str.Length - 2).Trim();
      var val = Double.Parse(str.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture) * TwipsInPoint;
      Value = (Int64)val;
    }
    else Value = Int32.Parse(str);
  }

  /// <summary>
  /// Converting constructor from UInt32 value.
  /// </summary>
  public Twips(UInt32 value)
  {
    Value = value;
  }

  /// <summary>
  /// Converting constructor from Int32 value.
  /// </summary>
  public Twips(Int32 value)
  {
    Value = value;
  }

  /// <summary>
  /// Converting constructor from UInt64 value.
  /// </summary>
  public Twips(UInt64 value)
  {
    Value = (Int64)value;
  }

  /// <summary>
  /// Converting constructor from Int64 value.
  /// </summary>
  public Twips(Int64 value)
  {
    Value = value;
  }

  /// <summary>
  /// Converts value to millimeters. Result is a double number.
  /// </summary>
  public double ToMM()
    => Value / TwipsInMM;

  /// <summary>
  /// Converts value to centimeters. Result is a double number.
  /// </summary>
  public double ToCM()
    => Value / TwipsInCM;

  /// <summary>
  /// Converts value to inches. Result is a double number.
  /// </summary>
  public double ToInch()
    => Value / TwipsInInch;

  /// <summary>
  /// Converts value to points. Result is a double number.
  /// </summary>
  public double ToPoints()
    => Value / TwipsInPoint;

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
      if (Value == 0)
        return "0";
      if (unit.EndsWith("mm"))
        return (Value / TwipsInMM).ToString(format, provider) + unit;
      if (unit.EndsWith("cm"))
        return (Value / TwipsInCM).ToString(format, provider) + unit;
      if (unit.EndsWith("in"))
        return (Value / TwipsInInch).ToString(format, provider) + unit;
      if (unit.EndsWith("pt"))
        return (Value / TwipsInPoint).ToString(format, provider) + unit;
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
      if (Value==0)
        return "0";
      if (unit.EndsWith("mm"))
        return (Value / TwipsInMM).ToString(provider) + unit;
      if (unit.EndsWith("cm"))
        return (Value / TwipsInCM).ToString(provider) + unit;
      if (unit.EndsWith("in"))
        return (Value / TwipsInInch).ToString(provider) + unit;
      if (unit.EndsWith("pt"))
        return (Value / TwipsInPoint).ToString(provider) + unit;
    }
    return Value.ToString();
  }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
  public static implicit operator Twips(string value) { return new Twips(value); }
  public static implicit operator string(Twips value) { return value.Value.ToString(); }
  public static implicit operator Twips(Int16 value) { return new Twips(value); }
  public static implicit operator Int16(Twips value) { return (Int16)value.Value; }
  public static implicit operator Twips(UInt16 value) { return new Twips(value); }
  public static implicit operator UInt16(Twips value) { return (UInt16)value.Value; }
  public static implicit operator Twips(Int32 value) { return new Twips(value); }
  public static implicit operator Int32(Twips value) { return (Int32)value.Value; }
  public static implicit operator Twips(UInt32 value) { return new Twips(value); }
  public static implicit operator UInt32(Twips value) { return (UInt32)value.Value; }
  public static implicit operator Twips(Int64 value) { return new Twips(value); }
  public static implicit operator Int64(Twips value) { return (Int64)value.Value; }
  public static implicit operator Twips(UInt64 value) { return new Twips(value); }
  public static implicit operator UInt64(Twips value) { return (UInt64)value.Value; }

  public int CompareTo(Twips other)
  {
    return Value.CompareTo(other.Value);
  }

  public override int GetHashCode()
  {
    return Value.GetHashCode();
  }
}
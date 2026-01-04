namespace DocumentModel;

/// <summary>
/// This class represents a decimal value interpreted as length measured in twips.
/// 1 twip = 1/1440 inch.
/// It implements desirable conversion to/from other unit values (determined by suffix).
/// </summary>
[TypeConverter(typeof(NumericValueTypeConverter))]
public struct NumericValue : IComparable<NumericValue>
{

  private double Value;
  private NumericUnits? Units;

  /// <summary>
  /// Constructor converting from string. 
  /// Unit can be determined as suffix "mm", "cm", "pt", or "in".
  /// </summary>
  public NumericValue(string str)
  {
    if (str.EndsWith("mm"))
    {
      str = str.Substring(0, str.Length - 2).Trim();
      Value = Double.Parse(str.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture);
      Units = NumericUnits.Millimeters;
    }
    if (str.EndsWith("cm"))
    {
      str = str.Substring(0, str.Length - 2).Trim();
      Value = Double.Parse(str.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture);
      Units = NumericUnits.Centimeters;
    }
    else if (str.EndsWith("in"))
    {
      str = str.Substring(0, str.Length - 2).Trim();
      Value = Double.Parse(str.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture);
      Units = NumericUnits.Inches;
    }
    else if (str.EndsWith("pt"))
    {
      str = str.Substring(0, str.Length - 2).Trim();
      Value = Double.Parse(str.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture);
      Units = NumericUnits.Points;
    }
    else
      Value = Double.Parse(str.Replace(",", "."), CultureInfo.InvariantCulture);
      Units = 0;
  }

  /// <summary>
  /// Converting constructor from Int16 value.
  /// </summary>
  public NumericValue(Int16 value)
  {
    Value = value;
  }

  /// <summary>
  /// Converting constructor from UInt32 value.
  /// </summary>
  public NumericValue(UInt32 value)
  {
    Value = value;
  }

  /// <summary>
  /// Converting constructor from Int32 value.
  /// </summary>
  public NumericValue(Int32 value)
  {
    Value = value;
  }

  /// <summary>
  /// Converting constructor from UInt64 value.
  /// </summary>
  public NumericValue(UInt64 value)
  {
    Value = (Int64)value;
  }

  /// <summary>
  /// Converting constructor from Int64 value.
  /// </summary>
  public NumericValue(Int64 value)
  {
    Value = value;
  }

  /// <summary>
  /// Converts value to millimeters. Result is a double number.
  /// </summary>
  public double ToMM()
  {
    switch (Units)
    {
      case NumericUnits.Twips:
        return Value / 1440.0 * 25.4;
      case NumericUnits.Points:
        return Value / 72.0 * 25.4;
      case NumericUnits.Millimeters:
        return Value;
      case NumericUnits.Centimeters:
        return Value*10;
      case NumericUnits.Inches:
        return Value*25.4;
    }
    return Double.NaN;
  }

  /// <summary>
  /// Converts value to centimeters. Result is a double number.
  /// </summary>
  public double ToCM()
  {
    switch (Units)
    {
      case NumericUnits.Twips:
        return Value / 1440.0 * 2.54;
      case NumericUnits.Points:
        return Value / 72.0 * 2.54;
      case NumericUnits.Millimeters:
        return Value /10.0;
      case NumericUnits.Centimeters:
        return Value;
      case NumericUnits.Inches:
        return Value*2.54;
    }
    return Double.NaN;
  }

  /// <summary>
  /// Converts value to inches. Result is a double number.
  /// </summary>
  public double ToInch()
  {
    switch (Units)
    {
      case NumericUnits.Twips:
        return Value / 1440.0;
      case NumericUnits.Points:
        return Value / 72.0;
      case NumericUnits.Millimeters:
        return Value / 25.4;
      case NumericUnits.Centimeters:
        return Value / 2.54;
      case NumericUnits.Inches:
        return Value;
    }
    return Double.NaN;
  }

  /// <summary>
  /// Converts value to points. Result is a double number.
  /// </summary>
  public double ToPoints()
  {
    switch (Units)
    {
      case NumericUnits.Twips:
        return Value / 20.0;
      case NumericUnits.Points:
        return Value;
      case NumericUnits.Millimeters:
        return Value / 25.4 * 72;
      case NumericUnits.Centimeters:
        return Value / 2.54 * 72;
      case NumericUnits.Inches:
        return Value * 72;
    }
    return Double.NaN;
  }

  /// <summary>
  /// Converts value to twips. Result is a double number.
  /// </summary>
  public double ToTwips()
  {
    switch (Units)
    {
      case NumericUnits.Twips:
        return Value;
      case NumericUnits.Points:
        return Value * 20;
      case NumericUnits.Millimeters:
        return Value / 25.4 * 1440;
      case NumericUnits.Centimeters:
        return Value / 2.54 * 1440;
      case NumericUnits.Inches:
        return Value * 1440;
    }
    return Double.NaN;
  }
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
        return ToMM().ToString(format, provider) + unit;
      if (unit.EndsWith("cm"))
        return ToCM().ToString(format, provider) + unit;
      if (unit.EndsWith("in"))
        return ToInch().ToString(format, provider) + unit;
      if (unit.EndsWith("pt"))
        return ToPoints().ToString(format, provider) + unit;
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
        return ToMM().ToString(provider) + unit;
      if (unit.EndsWith("cm"))
        return ToCM().ToString(provider) + unit;
      if (unit.EndsWith("in"))
        return ToInch().ToString(provider) + unit;
      if (unit.EndsWith("pt"))
        return ToPoints().ToString(provider) + unit;
    }
    return Value.ToString();
  }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
  public static implicit operator NumericValue(string value) { return new NumericValue(value); }
  public static implicit operator string(NumericValue value) { return value.Value.ToString(); }
  public static implicit operator NumericValue(Int16 value) { return new NumericValue(value); }
  public static implicit operator Int16(NumericValue value) { return (Int16)value.Value; }
  public static implicit operator NumericValue(UInt16 value) { return new NumericValue(value); }
  public static implicit operator UInt16(NumericValue value) { return (UInt16)value.Value; }
  public static implicit operator NumericValue(Int32 value) { return new NumericValue(value); }
  public static implicit operator Int32(NumericValue value) { return (Int32)value.Value; }
  public static implicit operator NumericValue(UInt32 value) { return new NumericValue(value); }
  public static implicit operator UInt32(NumericValue value) { return (UInt32)value.Value; }
  public static implicit operator NumericValue(Int64 value) { return new NumericValue(value); }
  public static implicit operator Int64(NumericValue value) { return (Int64)value.Value; }
  public static implicit operator NumericValue(UInt64 value) { return new NumericValue(value); }
  public static implicit operator UInt64(NumericValue value) { return (UInt64)value.Value; }

  public int CompareTo(NumericValue other)
  {
    return Value.CompareTo(other.Value);
  }

  public override int GetHashCode()
  {
    return Value.GetHashCode();
  }
}
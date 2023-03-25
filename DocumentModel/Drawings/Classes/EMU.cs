namespace DocumentModel.Drawings;

/// <summary>
/// English Metric Unit (used in Drawings)
/// </summary>
[TypeConverter(typeof(EMUTypeConverter))]
public struct EMU : IComparable<EMU>, IEquatable<EMU>
{
  const double emuMM = 36000; // 1440/25.4 = 56,692913385826771653543307086614
  const double emuInch = 914400;

  private long Value;

  /// <summary>
  /// Constructor converting from string. Units can be determined with a suffix "mm" or "in" or "in."
  /// </summary>
  public EMU(string str)
  {
    if (str.EndsWith("mm"))
    {
      str = str.Substring(0, str.Length - 2).Trim();
      var val = double.Parse(str.Replace(",", "."), CultureInfo.InvariantCulture) * emuMM;
      Value = (int)val;
    }
    else if (str.EndsWith("in"))
    {
      str = str.Substring(0, str.Length - 2).Trim();
      var val = double.Parse(str.Replace(",", "."), CultureInfo.InvariantCulture) * emuInch;
      Value = (int)val;
    }
    else if (str.EndsWith("in."))
    {
      str = str.Substring(0, str.Length - 3).Trim();
      var val = double.Parse(str.Replace(",", "."), CultureInfo.InvariantCulture) * emuInch;
      Value = (int)val;
    }
    else Value = int.Parse(str);
  }

  /// <summary>
  /// Converting constructor from UInt32 value.
  /// </summary>
  public EMU(uint value)
  {
    Value = (int)value;
  }

  /// <summary>
  /// Converting constructor from Int32 value.
  /// </summary>
  public EMU(int value)
  {
    Value = value;
  }

  /// <summary>
  /// Converting constructor from UInt64 value.
  /// </summary>
  public EMU(ulong value)
  {
    Value = (long)value;
  }

  /// <summary>
  /// Converting constructor from Int64 value.
  /// </summary>
  public EMU(long value)
  {
    Value = value;
  }

  /// <summary>
  /// Converts value to millimeters. Result is a double number.
  /// </summary>
  public double ToMM()
    => Value / emuMM;

  /// <summary>
  /// Converts value to inches. Result is a double number.
  /// </summary>
  public double ToInch()
    => Value / emuInch;

  /// <summary>
  /// Converts integer value to string.
  /// </summary>
  public override string ToString()
  {
    return Value.ToString();
  }

  /// <summary>
  /// Converts double value to string using unit.
  /// Unit can be determined as suffix "mm" or "in" or "in."
  /// </summary>
  public string ToString(string unit)
  {
    return ToString(CultureInfo.InvariantCulture, unit);
  }

  /// <summary>
  /// Converts double value to string using unit and specific precision (fractional digits count).
  /// Unit can be determined as suffix "mm" or "in" or "in."
  /// </summary>
  public string ToString(int precision, string unit)
  {
    return ToString(precision, CultureInfo.InvariantCulture, unit);
  }

  /// <summary>
  /// Converts double value to string using unit, specific precision (fractional digits count),
  /// and format provider to determine digits separator.
  /// Fixed format is used.
  /// Unit can be determined as suffix "mm" or "in" or "in."
  /// </summary>
  public string ToString(int precision, IFormatProvider provider, string unit)
  {
    string format = $"F{precision}";
    if (unit.EndsWith("mm"))
      return (Value / emuMM).ToString(format, provider) + unit;
    if (unit.EndsWith("in") || unit.EndsWith("in."))
      return (Value / emuInch).ToString(format, provider) + unit;
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
      return (Value / emuMM).ToString(provider) + unit;
    if (unit.EndsWith("in") || unit.EndsWith("in."))
      return (Value / emuInch).ToString(provider) + unit;
    return Value.ToString();
  }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
  public static implicit operator EMU(string value) { return new EMU(value); }
  public static implicit operator string(EMU value) { return value.Value.ToString(); }
  public static implicit operator EMU(short value) { return new EMU(value); }
  public static implicit operator short(EMU value) { return (short)value.Value; }
  public static implicit operator EMU(ushort value) { return new EMU(value); }
  public static implicit operator ushort(EMU value) { return (ushort)value.Value; }
  public static implicit operator EMU(int value) { return new EMU(value); }
  public static implicit operator int(EMU value) { return (int)value.Value; }
  public static implicit operator EMU(uint value) { return new EMU(value); }
  public static implicit operator uint(EMU value) { return (uint)value.Value; }
  public static implicit operator EMU(long value) { return new EMU(value); }
  public static implicit operator long(EMU value) { return value.Value; }
  public static implicit operator EMU(ulong value) { return new EMU(value); }
  public static implicit operator ulong(EMU value) { return (ulong)value.Value; }
  public static bool operator ==(EMU value1, EMU value2)
  {
    return value1.Value == value2.Value;
  }
  public static bool operator !=(EMU value1, EMU value2)
  {
    return value1.Value != value2.Value;
  }

  public int CompareTo(EMU other)
  {
    return Value.CompareTo(other.Value);
  }

  public override int GetHashCode()
  {
    return Value.GetHashCode();
  }

  public override bool Equals(object? obj)
  {
    if (obj is EMU other)
      return Value.Equals(other.Value);
    return false;
  }

  public bool Equals(EMU other)
  {
    return Value.Equals(other.Value);
  }
}
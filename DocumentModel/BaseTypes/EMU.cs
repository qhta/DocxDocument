namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
/// English Metric Unit (used in Drawings)
/// </summary>
[TypeConverter(typeof(EMUTypeConverter))]
public struct EMU: IComparable<EMU>
{
  const double emuMM = 36000; // 1440/25.4 = 56,692913385826771653543307086614
  const double emuInch = 914400;

  private Int64 Value;

  public EMU(string str)
  {
    if (str.EndsWith("mm"))
    {
      str = str.Substring(0, str.Length -2).Trim();
      var val = Double.Parse(str.Replace(",","."), System.Globalization.CultureInfo.InvariantCulture)*emuMM;
      Value = (int)val;
    }
    else if (str.EndsWith("in"))
    {
      str = str.Substring(0, str.Length -2).Trim();
      var val = Double.Parse(str.Replace(",","."),System.Globalization.CultureInfo.InvariantCulture)*emuInch;
      Value = (int)val;
    }
    else if (str.EndsWith("in."))
    {
      str = str.Substring(0, str.Length -3).Trim();
      var val = Double.Parse(str.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture)*emuInch;
      Value = (int)val;
    }
    else  Value = Int32.Parse(str);
  }

  public EMU(UInt32 value)
  {
    Value = (int)value;
  }

  public EMU(Int32 value)
  {
    Value = value;
  }

   public EMU(UInt64 value)
  {
    Value = (Int64)value;
  }

  public EMU(Int64 value)
  {
    Value = value;
  }

  public double ToMM()
    => Value/emuMM;

  public double ToInch()
    => Value/emuInch;

  public override string ToString()
  {
    return Value.ToString();
  }

  public string ToString(string unit)
  {
    return ToString(System.Globalization.CultureInfo.InvariantCulture, unit);
  }

  public string ToString(int precision, string unit)
  {
    return ToString(precision, System.Globalization.CultureInfo.InvariantCulture, unit);
  }

  public string ToString(int precision, IFormatProvider provider, string unit)
  {
    string format=$"F{precision}";
    if (unit.EndsWith("mm"))
      return (Value/emuMM).ToString(format, provider)+unit;
    if (unit.EndsWith("in") || unit.EndsWith("in."))
      return (Value/emuInch).ToString(format, provider)+unit;
    return Value.ToString();
  }

  public string ToString(IFormatProvider provider, string unit)
  {
    if (unit.EndsWith("mm"))
      return (Value/emuMM).ToString(provider)+unit;
    if (unit.EndsWith("in") || unit.EndsWith("in."))
      return (Value/emuInch).ToString(provider)+unit;
    return Value.ToString();
  }

  public static implicit operator EMU(string value) { return new EMU(value); }
  public static implicit operator string(EMU value) { return value.Value.ToString(); }
  public static implicit operator EMU(Int16 value) { return new EMU(value); }
  public static implicit operator Int16(EMU value) { return (Int16)value.Value; }
  public static implicit operator EMU(UInt16 value) { return new EMU(value); }
  public static implicit operator UInt16(EMU value) { return (UInt16)value.Value; }
  public static implicit operator EMU(Int32 value) { return new EMU(value); }
  public static implicit operator Int32(EMU value) { return (Int32)value.Value; }
  public static implicit operator EMU(UInt32 value) { return new EMU(value); }
  public static implicit operator UInt32(EMU value) { return (UInt32)value.Value; }

  public int CompareTo(EMU other)
  {
    return Value.CompareTo(other.Value);
  }

  public override int GetHashCode()
  {
    return Value.GetHashCode();
  }
}
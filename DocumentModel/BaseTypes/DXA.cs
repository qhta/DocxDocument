namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

[TypeConverter(typeof(DXATypeConverter))]
public struct DXA: IComparable<DXA>
{
  const double dxaMM = 56.695238095238095238095238095238; // 1440/25.4 = 56,692913385826771653543307086614
  const double dxaInch = 1440;

  private Int64 Value;

  public DXA(string str)
  {
    if (str.EndsWith("mm"))
    {
      str = str.Substring(0, str.Length -2).Trim();
      var val = Double.Parse(str.Replace(",","."), System.Globalization.CultureInfo.InvariantCulture)*dxaMM;
      Value = (Int64)val;
    }
    else if (str.EndsWith("in"))
    {
      str = str.Substring(0, str.Length -2).Trim();
      var val = Double.Parse(str.Replace(",","."),System.Globalization.CultureInfo.InvariantCulture)*dxaInch;
      Value = (int)val;
    }
    else if (str.EndsWith("in."))
    {
      str = str.Substring(0, str.Length -3).Trim();
      var val = Double.Parse(str.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture)*dxaInch;
      Value = (Int64)val;
    }
    else  Value = Int32.Parse(str);
  }

  public DXA(UInt32 value)
  {
    Value = value;
  }

  public DXA(Int32 value)
  {
    Value = value;
  }

  public DXA(UInt64 value)
  {
    Value = (Int64)value;
  }

  public DXA(Int64 value)
  {
    Value = value;
  }

  public double ToMM()
    => Value/dxaMM;

  public double ToInch()
    => Value/dxaInch;

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
      return (Value/dxaMM).ToString(format, provider)+unit;
    if (unit.EndsWith("in") || unit.EndsWith("in."))
      return (Value/dxaInch).ToString(format, provider)+unit;
    return Value.ToString();
  }

  public string ToString(IFormatProvider provider, string unit)
  {
    if (unit.EndsWith("mm"))
      return (Value/dxaMM).ToString(provider)+unit;
    if (unit.EndsWith("in") || unit.EndsWith("in."))
      return (Value/dxaInch).ToString(provider)+unit;
    return Value.ToString();
  }

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

  public int CompareTo(DXA other)
  {
    return Value.CompareTo(other.Value);
  }

  public override int GetHashCode()
  {
    return Value.GetHashCode();
  }
}
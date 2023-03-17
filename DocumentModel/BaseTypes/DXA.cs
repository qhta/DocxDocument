namespace DocumentModel;

[TypeConverter(typeof(DXATypeConverter))]
public struct DXA
{
  const double dxaMM = 56.695238095238095238095238095238;
  const double dxaInch = 1440;

  private int Value;

  public DXA(string str)
  {
    if (str.EndsWith("mm"))
    {
      str = str.Substring(0, str.Length -2).Trim();
      var val = Double.Parse(str)*dxaMM;
      Value = (int)val;
    }
    else if (str.EndsWith("in"))
    {
      str = str.Substring(0, str.Length -2).Trim();
      var val = Double.Parse(str)*dxaInch;
      Value = (int)val;
    }
    else  Value = Int32.Parse(str);
  }

  public DXA(UInt32 value)
  {
    Value = (int)value;
  }

  public DXA(Int32 value)
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
    if (unit == "mm")
      return Value/dxaMM+"mm";
    if (unit == "in")
      return Value/dxaInch+"in";

    return Value.ToString();
  }
}
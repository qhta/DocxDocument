using DocumentFormat.OpenXml.Vml;

namespace DocxDocument.Model;

public struct HexInt
{
  private int value;


  public static implicit operator HexInt(string val) => new HexInt { value = int.Parse(val, NumberStyles.HexNumber) };


  public static implicit operator int(HexInt val) => val.value;

  public static implicit operator HexInt(int val) => new HexInt { value = val };

  public HexInt(string val)
  {
    value = int.Parse(val, NumberStyles.HexNumber);
  }

  public HexInt(int val)
  {
    value = val;
  }

  public override string ToString()
  {
    return value.ToString("X8");
  }
}
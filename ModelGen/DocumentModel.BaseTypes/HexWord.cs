namespace DocumentModel.BaseTypes;

public struct HexWord
{
  private ushort value;


  public static implicit operator HexWord(string val) => new HexWord { value = ushort.Parse(val, NumberStyles.HexNumber) };


  public static implicit operator int(HexWord val) => val.value;

  public static implicit operator HexWord(ushort val) => new HexWord { value = val };

  public HexWord(string val)
  {
    value = ushort.Parse(val, NumberStyles.HexNumber);
  }

  public HexWord(ushort val)
  {
    value = val;
  }

  public override string ToString()
  {
    return value.ToString("X4");
  }
}
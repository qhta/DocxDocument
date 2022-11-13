namespace DocxDocument.Model;

public struct Pixels
{
  private int value;

  public static implicit operator Pixels(string val) => new Pixels { value = int.Parse(val)};


  public static implicit operator int(Pixels val) => val.value;

  public static implicit operator Pixels(int val) => new Pixels { value = val };


  public static implicit operator uint(Pixels val) => (uint)val.value;

  public static implicit operator Pixels(uint val) => new Pixels { value = (int)val };

  public override string ToString()
  {
    return value.ToString()+"pcx";
  }
}
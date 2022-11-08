namespace DocxDocument.Model;

public struct Twips
{
  private int value;

  public static implicit operator Twips(string val) => new Twips { value = int.Parse(val)};


  public static implicit operator int(Twips val) => val.value;

  public static implicit operator Twips(int val) => new Twips { value = val };


  public static implicit operator double(Twips val) => (double)val.value / 1440.0;

  public static implicit operator Twips(double val) => new Twips { value = (int)(val*1440) };

  public override string ToString()
  {
    return value.ToString()+"twp";
  }
}
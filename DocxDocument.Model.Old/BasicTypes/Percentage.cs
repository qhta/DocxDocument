namespace DocxDocument.Model;

public struct Percentage
{
  private decimal value;

  public static implicit operator Percentage(string val)
  {
    if (val.EndsWith("%"))
      return new Percentage { value = decimal.Parse(val.Substring(0,val.Length-1)) };
    else
      return new Percentage { value = decimal.Parse(val) };
  }

  public static implicit operator decimal(Percentage val) => (decimal)val.value;

  public static implicit operator Percentage(decimal val) => new Percentage { value = val };


  public static implicit operator int(Percentage val) => (int)val.value;

  public static implicit operator Percentage(int val) => new Percentage { value = val };


  public static implicit operator double(Percentage val) => (double)(val.value / 100);

  public static implicit operator Percentage(double val) => new Percentage { value = (decimal)(val*100) };

  public override string ToString()
  {
    return value.ToString() + "%";
  }
}
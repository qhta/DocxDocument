namespace DocxDocument.Model;

public struct Hps
{
  private decimal value;

  public static implicit operator Hps(string val) => new Hps { value = int.Parse(val)};


  public static implicit operator decimal(Hps val) => val.value;

  public static implicit operator Hps(decimal val) => new Hps { value = val };


  public static implicit operator double(Hps val) => (double)val.value / 72.0;

  public static implicit operator Hps(double val) => new Hps { value = (int)(val*72) };

  public Hps(int val)
  {
    value = (decimal)val/2;
  }

  public override string ToString()
  {
    return value.ToString()+"pt";
  }
}
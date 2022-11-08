namespace DocxDocument.Model.Drawing;

public struct Angle
{
  private int value;

  public static implicit operator string(Angle val) => val.value.ToString();

  public static implicit operator Angle(string val) => new Angle { value = int.Parse(val) };


  public static implicit operator int(Angle val) => val.value;

  public static implicit operator Angle(int val) => new Angle { value = val };


  public static implicit operator float(Angle val) => (float)(val.value / 60000.0 / 180 * System.Math.PI);

  public static implicit operator Angle(float val) => new Angle { value = (int)(val/System.Math.PI *180 * 60000) };
}
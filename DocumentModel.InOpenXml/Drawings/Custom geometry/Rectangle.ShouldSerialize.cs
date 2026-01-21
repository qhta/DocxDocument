namespace DocumentModel.Drawings;

public partial class Rectangle
{
  public bool ShouldSerializeLeft() => Left is not null;
  public bool ShouldSerializeTop() => Top is not null;
  public bool ShouldSerializeRight() => Right is not null;
  public bool ShouldSerializeBottom() => Bottom is not null;
}

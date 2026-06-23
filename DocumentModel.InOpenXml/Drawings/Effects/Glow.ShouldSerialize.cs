namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class Glow
{
  public bool ShouldSerializeRadius() => Radius is not null;
  public bool ShouldSerializeColor() => Color is not null;

}

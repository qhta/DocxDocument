namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class Blur
{
  public bool ShouldSerializeRadius() => Radius is not null;
  public bool ShouldSerializeGrow() => Grow is not null;
}

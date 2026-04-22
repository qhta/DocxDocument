namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class SoftEdge
{
  public bool ShouldSerializeRadius() => Radius is not null;
}

namespace DocumentModel.Drawings;

public partial class SoftEdge
{
  public bool ShouldSerializeRadius() => Radius is not null;
}

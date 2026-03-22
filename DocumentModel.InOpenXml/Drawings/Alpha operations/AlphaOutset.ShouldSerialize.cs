namespace DocumentModel.Drawings;
#pragma warning disable CS1591
public partial class AlphaOutset
{
  public bool ShouldSerializeRadius() => Radius is not null;
}

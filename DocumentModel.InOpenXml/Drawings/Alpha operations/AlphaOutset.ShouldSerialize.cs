namespace DocumentModel.Drawings;

public partial class AlphaOutset
{
  public bool ShouldSerializeRadius() => Radius is not null;
}

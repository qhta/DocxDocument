namespace DocumentModel.Vml;

public partial class ColorMostRecentlyUsed
{
  public bool ShouldSerializeExtension() => Extension is not null;
  public bool ShouldSerializeColors() => Colors is not null;
}

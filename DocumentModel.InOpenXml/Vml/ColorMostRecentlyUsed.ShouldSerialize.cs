namespace DocumentModel.Vml;

#pragma warning disable CS1591

public partial class ColorMostRecentlyUsed
{
  public bool ShouldSerializeExtension() => Extension is not null;
  public bool ShouldSerializeColors() => Colors is not null;
}

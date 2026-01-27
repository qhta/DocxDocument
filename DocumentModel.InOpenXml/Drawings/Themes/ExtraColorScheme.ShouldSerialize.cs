namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class ExtraColorScheme
{
  public bool ShouldSerializeColorScheme() => ColorScheme is not null;
  public bool ShouldSerializeColorMap() => ColorMap is not null;
}

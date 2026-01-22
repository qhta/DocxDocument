namespace DocumentModel.Drawings;

public partial class ExtraColorScheme
{
  public bool ShouldSerializeColorScheme() => ColorScheme is not null;
  public bool ShouldSerializeColorMap() => ColorMap is not null;
}

namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class Zoom
{
  public bool ShouldSerializeKind() => Preset is not null;
  public bool ShouldSerializePercent() => Percent is not null;
}

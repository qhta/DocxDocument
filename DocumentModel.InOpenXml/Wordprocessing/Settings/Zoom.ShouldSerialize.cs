namespace DocumentModel.Wordprocessing;

public partial class Zoom
{
  public bool ShouldSerializeKind() => Kind is not null;
  public bool ShouldSerializePercent() => Percent is not null;
}

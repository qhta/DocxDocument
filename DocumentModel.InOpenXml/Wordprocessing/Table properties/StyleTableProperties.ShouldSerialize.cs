namespace DocumentModel.Wordprocessing;

public partial class StyleTableProperties
{
  public bool ShouldSerializeTableStyleRowBandSize() => TableStyleRowBandSize is not null;
  public bool ShouldSerializeTableStyleColumnBandSize() => TableStyleColumnBandSize is not null;
}

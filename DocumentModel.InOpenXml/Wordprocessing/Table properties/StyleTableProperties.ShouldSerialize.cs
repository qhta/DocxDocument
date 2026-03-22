namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class StyleTableProperties
{
  public bool ShouldSerializeTableStyleRowBandSize() => TableStyleRowBandSize is not null;
  public bool ShouldSerializeTableStyleColumnBandSize() => TableStyleColumnBandSize is not null;
}

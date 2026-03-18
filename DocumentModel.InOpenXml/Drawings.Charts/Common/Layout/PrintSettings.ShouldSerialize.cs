namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class PrintSettings
{
  public bool ShouldSerializeHeaderFooter() => HeaderFooter is not null;
  public bool ShouldSerializePageMargins() => PageMargins is not null;
  public bool ShouldSerializePageSetup() => PageSetup is not null;
  public bool ShouldSerializeLegacyDrawingHeaderFooter() => LegacyDrawingHeaderFooter is not null;
}

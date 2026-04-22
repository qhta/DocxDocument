namespace DocumentModel.Drawings.ChartDrawings;

#pragma warning disable CS1591

public partial class ChartSpace
{
  public bool ShouldSerializeChartData() => ChartData is not null;
  public bool ShouldSerializeChart() => Chart is not null;
  public bool ShouldSerializeShapeProperties() => ShapeProperties is not null;
  public bool ShouldSerializeTxPrTextBody() => TxPrTextBody is not null;
  public bool ShouldSerializeColorMappingType() => ColorMappingType is not null;
  public bool ShouldSerializeFormatOverrides() => FormatOverrides is not null;
  public bool ShouldSerializePrintSettings() => PrintSettings is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}

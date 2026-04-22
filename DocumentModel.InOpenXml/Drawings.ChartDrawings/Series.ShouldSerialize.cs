namespace DocumentModel.Drawings.ChartDrawings;

#pragma warning disable CS1591

public partial class Series
{
  public bool ShouldSerializeLayoutId() => LayoutId is not null;
  public bool ShouldSerializeHidden() => Hidden is not null;
  public bool ShouldSerializeOwnerIdx() => OwnerIdx is not null;
  public bool ShouldSerializeUniqueId() => !String.IsNullOrEmpty(UniqueId);
  public bool ShouldSerializeFormatIdx() => FormatIdx is not null;
  public bool ShouldSerializeText() => Text is not null;
  public bool ShouldSerializeShapeProperties() => ShapeProperties is not null;
  public bool ShouldSerializeValueColors() => ValueColors is not null;
  public bool ShouldSerializeValueColorPositions() => ValueColorPositions is not null;
  public bool ShouldSerializeDataPoints() => DataPoints is not null;
  public bool ShouldSerializeDataLabels() => DataLabels is not null;
  public bool ShouldSerializeDataId() => DataId is not null;
  public bool ShouldSerializeSeriesLayoutProperties() => SeriesLayoutProperties is not null;
  public bool ShouldSerializeAxisIds() => AxisIds is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}

namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class ChartSpace
{
  public bool ShouldSerializeDate1904() => Date1904 is not null;
  public bool ShouldSerializeEditingLanguage() => !String.IsNullOrEmpty(EditingLanguage);
  public bool ShouldSerializeRoundedCorners() => RoundedCorners is not null;
  public bool ShouldSerializeStyle() => Style is not null;
  public bool ShouldSerializeColorMapOverride() => ColorMapOverride is not null;
  public bool ShouldSerializePivotSource() => PivotSource is not null;
  public bool ShouldSerializeProtection() => Protection is not null;
  public bool ShouldSerializeChart() => Chart is not null;
  public bool ShouldSerializeShapeProperties() => ShapeProperties is not null;
  public bool ShouldSerializeTextProperties() => TextProperties is not null;
  public bool ShouldSerializeExternalData() => ExternalData is not null;
  public bool ShouldSerializePrintSettings() => PrintSettings is not null;
  public bool ShouldSerializeUserShapesReference() => UserShapesReference is not null;
  public bool ShouldSerializeChartSpaceExtensionList() => ChartSpaceExtensionList is not null && ChartSpaceExtensionList.Count > 0;
}

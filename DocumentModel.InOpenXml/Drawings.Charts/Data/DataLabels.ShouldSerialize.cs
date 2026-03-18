namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class DataLabels
{
  public bool ShouldSerializeDelete() => Delete is not null;
  public bool ShouldSerializeNumberingFormat() => NumberingFormat is not null;
  public bool ShouldSerializeChartShapeProperties() => ChartShapeProperties is not null;
  public bool ShouldSerializeTextProperties() => TextProperties is not null;
  public bool ShouldSerializeDataLabelPosition() => DataLabelPosition is not null;
  public bool ShouldSerializeShowLegendKey() => ShowLegendKey is not null;
  public bool ShouldSerializeShowValue() => ShowValue is not null;
  public bool ShouldSerializeShowCategoryName() => ShowCategoryName is not null;
  public bool ShouldSerializeShowSeriesName() => ShowSeriesName is not null;
  public bool ShouldSerializeShowPercent() => ShowPercent is not null;
  public bool ShouldSerializeShowBubbleSize() => ShowBubbleSize is not null;
  public bool ShouldSerializeSeparator() => !String.IsNullOrEmpty(Separator);
  public bool ShouldSerializeShowLeaderLines() => ShowLeaderLines is not null;
  public bool ShouldSerializeLeaderLines() => LeaderLines is not null;
  public bool ShouldSerializeDLblsExtensionList() => DLblsExtensionList is not null && DLblsExtensionList.Count > 0;
}

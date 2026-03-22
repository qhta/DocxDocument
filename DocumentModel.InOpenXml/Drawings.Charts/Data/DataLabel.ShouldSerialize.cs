namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591
public partial class DataLabel
{
  public bool ShouldSerializeIndex() => Index is not null;
  public bool ShouldSerializeDelete() => Delete is not null;
  public bool ShouldSerializeLayout() => Layout is not null;
  public bool ShouldSerializeChartText() => ChartText is not null;
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
  public bool ShouldSerializeDLblExtensionList() => DLblExtensionList is not null && DLblExtensionList.Count > 0;
}

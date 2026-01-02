namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Data Labels.
/// </summary>
public class DataLabels: ModelElement
{
  public Collection<DataLabel>? Items { get; set; }
  public bool? Delete { get; set; }
  public NumberingFormat? NumberingFormat { get; set; }
  public ChartShapeProperties? ChartShapeProperties { get; set; }
  public TextProperties? TextProperties { get; set; }
  public DataLabelPositionKind? DataLabelPosition { get; set; }
  public bool? ShowLegendKey { get; set; }
  public bool? ShowValue { get; set; }
  public bool? ShowCategoryName { get; set; }
  public bool? ShowSeriesName { get; set; }
  public bool? ShowPercent { get; set; }
  public bool? ShowBubbleSize { get; set; }
  public string? Separator { get; set; }
  public bool? ShowLeaderLines { get; set; }
  public LeaderLines? LeaderLines { get; set; }
  public DLblsExtensionList? DLblsExtensionList { get; set; }
}
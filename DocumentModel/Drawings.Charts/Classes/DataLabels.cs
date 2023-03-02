namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Data Labels.
/// </summary>
public record DataLabels
{
  public Collection<DataLabel>? Items { get; set; }

  public Boolean? Delete { get; set; }

  public NumberingFormat? NumberingFormat { get; set; }

  public ChartShapeProperties? ChartShapeProperties { get; set; }

  public TextProperties? TextProperties { get; set; }

  public DataLabelPositionKind? DataLabelPosition { get; set; }

  public Boolean? ShowLegendKey { get; set; }

  public Boolean? ShowValue { get; set; }

  public Boolean? ShowCategoryName { get; set; }

  public Boolean? ShowSeriesName { get; set; }

  public Boolean? ShowPercent { get; set; }

  public Boolean? ShowBubbleSize { get; set; }

  public String? Separator { get; set; }

  public Boolean? ShowLeaderLines { get; set; }

  public LeaderLines? LeaderLines { get; set; }

  public DLblsExtensionList? DLblsExtensionList { get; set; }
}
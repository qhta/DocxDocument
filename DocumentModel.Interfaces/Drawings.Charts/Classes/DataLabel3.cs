namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the DataLabel Class.
/// </summary>
public class DataLabel3: ModelElement
{
  /// <summary>
  ///   Index.
  /// </summary>
  public UInt32? Index { get; set; }
  public bool? Delete { get; set; }
  public Layout? Layout { get; set; }
  public ChartText? ChartText { get; set; }
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
  public DLblExtensionList? DLblExtensionList { get; set; }
}
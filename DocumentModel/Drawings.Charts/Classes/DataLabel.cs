namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Data Label.
/// </summary>
public class IDataLabel: ModelElement
{
  /// <summary>
  ///   IIndex.
  /// </summary>
  public UInt32? IIndex { get; set; }

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

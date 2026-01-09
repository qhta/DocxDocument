namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents the legend that identifies data series and categories in a chart visualization.
/// </summary>
public interface Legend: ExtendableElement
{
  /// <summary>
  ///   Gets or sets the side position where the legend is displayed relative to the chart.
  /// </summary>
  public SidePos? Pos { get; set; }

  /// <summary>
  ///   Gets or sets the alignment of the legend within its positioned area.
  /// </summary>
  public PosAlign? Align { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the legend overlays the plot area.
  /// </summary>
  public bool? Overlay { get; set; }

  /// <summary>
  ///   Gets or sets the visual styling properties for the legend.
  /// </summary>
  public ShapeProperties? ShapeProperties { get; set; }

  /// <summary>
  ///   Gets or sets the text formatting properties for legend text.
  /// </summary>
  public TxPrTextBody? TxPrTextBody { get; set; }
}
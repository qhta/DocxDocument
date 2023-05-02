namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Data Table.
/// </summary>
public class DataTable: ModelElement
{
  /// <summary>
  ///   Show Horizontal Border.
  /// </summary>
  public bool? ShowHorizontalBorder { get; set; }

  /// <summary>
  ///   Show Vertical Border.
  /// </summary>
  public bool? ShowVerticalBorder { get; set; }

  /// <summary>
  ///   Show Outline Border.
  /// </summary>
  public bool? ShowOutlineBorder { get; set; }

  /// <summary>
  ///   Show Legend Keys.
  /// </summary>
  public bool? ShowKeys { get; set; }

  /// <summary>
  ///   ChartShapeProperties.
  /// </summary>
  public ChartShapeProperties? ChartShapeProperties { get; set; }

  /// <summary>
  ///   Text Properties.
  /// </summary>
  public TextProperties? TextProperties { get; set; }

  /// <summary>
  ///   Chart Extensibility.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}
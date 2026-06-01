namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Data ITable.
/// </summary>
public class IDataTable: ModelElement
{
  /// <summary>
  ///   Show Horizontal IBorder.
  /// </summary>
  public bool? ShowHorizontalBorder { get; set; }

  /// <summary>
  ///   Show Vertical IBorder.
  /// </summary>
  public bool? ShowVerticalBorder { get; set; }

  /// <summary>
  ///   Show Outline IBorder.
  /// </summary>
  public bool? ShowOutlineBorder { get; set; }

  /// <summary>
  ///   Show ILegend Keys.
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
  ///   IChart Extensibility.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}

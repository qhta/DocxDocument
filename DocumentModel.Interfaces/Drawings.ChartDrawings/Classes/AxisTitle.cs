namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the AxisTitle Class.
/// </summary>
public class AxisTitle: ModelElement
{
  /// <summary>
  ///   Text.
  /// </summary>
  public Text? Text { get; set; }
  /// <summary>
  ///   ShapeProperties.
  /// </summary>
  public ShapeProperties? ShapeProperties { get; set; }
  /// <summary>
  ///   TxPrTextBody.
  /// </summary>
  public TxPrTextBody? TxPrTextBody { get; set; }
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}
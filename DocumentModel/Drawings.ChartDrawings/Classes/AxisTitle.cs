namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the IAxisTitle Class.
/// </summary>
public class IAxisTitle: ModelElement
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

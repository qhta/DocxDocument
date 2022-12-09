namespace DocumentModel.Drawings;

/// <summary>
/// Defines the AxisUnitsLabel Class.
/// </summary>
public interface AxisUnitsLabel
{
  /// <summary>
  /// Text.
  /// </summary>
  public Text2? Text { get ; set; }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public ShapeProperties8? ShapeProperties { get ; set; }
  
  /// <summary>
  /// TxPrTextBody.
  /// </summary>
  public TxPrTextBody? TxPrTextBody { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList2? ExtensionList { get ; set; }
  
}

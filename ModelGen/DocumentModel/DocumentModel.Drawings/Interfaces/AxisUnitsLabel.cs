namespace DocumentModel.Drawings;

/// <summary>
/// Defines the AxisUnitsLabel Class.
/// </summary>
public interface AxisUnitsLabel
{
  /// <summary>
  /// Text.
  /// </summary>
  public Text1? Text { get ; set; }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public ShapeProperties6? ShapeProperties { get ; set; }
  
  /// <summary>
  /// TxPrTextBody.
  /// </summary>
  public TxPrTextBody? TxPrTextBody { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList2? ExtensionList { get ; set; }
  
}

namespace DocumentModel.Drawings13.Charts;

/// <summary>
/// Defines the Marker Class.
/// </summary>
public interface Marker
{
  /// <summary>
  /// Symbol.
  /// </summary>
  public DocumentModel.Drawings.Charts.MarkerStyleKind? Symbol { get ; set; }
  
  /// <summary>
  /// Size.
  /// </summary>
  public Byte? Size { get ; set; }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public DocumentModel.Drawings.Charts.ChartShapeProperties? ChartShapeProperties { get ; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public DocumentModel.Drawings.Charts.ExtensionList? ExtensionList { get ; set; }
  
}

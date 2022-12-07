namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Marker Class.
/// </summary>
public interface Marker2
{
  /// <summary>
  /// Symbol.
  /// </summary>
  public MarkerStyleKind? Symbol { get ; set; }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public ChartShapeProperties? ChartShapeProperties { get ; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public ExtensionList4? ExtensionList { get ; set; }
  
}

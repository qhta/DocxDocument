namespace DocumentModel.Drawing;

/// <summary>
/// Defines the Marker Class.
/// </summary>
public interface IMarker // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Symbol.
  /// </summary>
  public MarkerStyleKind? Symbol { get ; set; }
  
  /// <summary>
  /// Size.
  /// </summary>
  public Byte? Size { get ; set; }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public IChartShapeProperties? ChartShapeProperties { get ; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}

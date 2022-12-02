namespace DocumentModel.Drawing;

/// <summary>
/// Defines the Marker Class.
/// </summary>
public interface IMarker // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Symbol.
  /// </summary>
  public DocumentModel.Drawing.MarkerStyleKind? Symbol { get ; set; }
  
  /// <summary>
  /// Size.
  /// </summary>
  public System.Byte? Size { get ; set; }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public DocumentModel.Drawing.IChartShapeProperties? ChartShapeProperties { get ; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}

namespace DocumentModel.Office2013.Drawing.Chart;

/// <summary>
/// Defines the Marker Class.
/// </summary>
public interface IMarker // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Symbol.
  /// </summary>
  public DocumentModel.Drawing.Charts.MarkerStyleKind? Symbol { get ; set; }
  
  /// <summary>
  /// Size.
  /// </summary>
  public System.Byte? Size { get ; set; }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public DocumentModel.Drawing.Charts.IChartShapeProperties? ChartShapeProperties { get ; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public DocumentModel.Drawing.Charts.IExtensionList? ExtensionList { get ; set; }
  
}

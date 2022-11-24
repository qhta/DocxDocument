namespace DocumentModel.Office2013.Drawing.Chart;

/// <summary>
/// Defines the Marker Class.
/// </summary>
public interface IMarker // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Symbol.
  /// </summary>
  public ISymbol? Symbol { get ; set; }
  
  /// <summary>
  /// Size.
  /// </summary>
  public ISize? Size { get ; set; }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public IChartShapeProperties? ChartShapeProperties { get ; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}

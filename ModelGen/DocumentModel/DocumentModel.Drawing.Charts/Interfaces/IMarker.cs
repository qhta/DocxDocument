namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Marker.
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

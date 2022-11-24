namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the ErrorBars Class.
/// </summary>
public interface IErrorBars // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Error Bar Direction.
  /// </summary>
  public IErrorDirection? ErrorDirection { get ; set; }
  
  /// <summary>
  /// Error Bar Type.
  /// </summary>
  public IErrorBarType? ErrorBarType { get ; set; }
  
  /// <summary>
  /// Error Bar Value Type.
  /// </summary>
  public IErrorBarValueType? ErrorBarValueType { get ; set; }
  
  /// <summary>
  /// No End Cap.
  /// </summary>
  public INoEndCap? NoEndCap { get ; set; }
  
  /// <summary>
  /// Plus.
  /// </summary>
  public IPlus? Plus { get ; set; }
  
  /// <summary>
  /// Minus.
  /// </summary>
  public IMinus? Minus { get ; set; }
  
  /// <summary>
  /// Error Bar Value.
  /// </summary>
  public IErrorBarValue? ErrorBarValue { get ; set; }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public IChartShapeProperties? ChartShapeProperties { get ; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}

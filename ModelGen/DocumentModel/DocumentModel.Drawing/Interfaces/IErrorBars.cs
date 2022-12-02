namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ErrorBars Class.
/// </summary>
public interface IErrorBars // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Error Bar Direction.
  /// </summary>
  public ErrorBarDirectionKind? ErrorDirection { get ; set; }
  
  /// <summary>
  /// Error Bar Type.
  /// </summary>
  public ErrorBarKind? ErrorBarType { get ; set; }
  
  /// <summary>
  /// Error Bar Value Type.
  /// </summary>
  public ErrorKind? ErrorBarValueType { get ; set; }
  
  /// <summary>
  /// No End Cap.
  /// </summary>
  public Boolean? NoEndCap { get ; set; }
  
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
  public Double? ErrorBarValue { get ; set; }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public IChartShapeProperties? ChartShapeProperties { get ; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}

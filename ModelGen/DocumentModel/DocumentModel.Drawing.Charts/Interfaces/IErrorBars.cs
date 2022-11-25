namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the ErrorBars Class.
/// </summary>
public interface IErrorBars // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Error Bar Direction.
  /// </summary>
  public DocumentModel.Drawing.Charts.ErrorBarDirectionKind? ErrorDirection { get ; set; }
  
  /// <summary>
  /// Error Bar Type.
  /// </summary>
  public DocumentModel.Drawing.Charts.ErrorBarKind? ErrorBarType { get ; set; }
  
  /// <summary>
  /// Error Bar Value Type.
  /// </summary>
  public DocumentModel.Drawing.Charts.ErrorKind? ErrorBarValueType { get ; set; }
  
  /// <summary>
  /// No End Cap.
  /// </summary>
  public System.Boolean? NoEndCap { get ; set; }
  
  /// <summary>
  /// Plus.
  /// </summary>
  public DocumentModel.Drawing.Charts.INumberDataSourceType? Plus { get ; set; }
  
  /// <summary>
  /// Minus.
  /// </summary>
  public DocumentModel.Drawing.Charts.INumberDataSourceType? Minus { get ; set; }
  
  /// <summary>
  /// Error Bar Value.
  /// </summary>
  public System.Double? ErrorBarValue { get ; set; }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public DocumentModel.Drawing.Charts.IChartShapeProperties? ChartShapeProperties { get ; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ExtensionList { get ; set; }
  
}

namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ErrorBars Class.
/// </summary>
public interface IErrorBars // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Error Bar Direction.
  /// </summary>
  public DocumentModel.Drawing.ErrorBarDirectionKind? ErrorDirection { get ; set; }
  
  /// <summary>
  /// Error Bar Type.
  /// </summary>
  public DocumentModel.Drawing.ErrorBarKind? ErrorBarType { get ; set; }
  
  /// <summary>
  /// Error Bar Value Type.
  /// </summary>
  public DocumentModel.Drawing.ErrorKind? ErrorBarValueType { get ; set; }
  
  /// <summary>
  /// No End Cap.
  /// </summary>
  public System.Boolean? NoEndCap { get ; set; }
  
  /// <summary>
  /// Plus.
  /// </summary>
  public DocumentModel.Drawing.IPlus? Plus { get ; set; }
  
  /// <summary>
  /// Minus.
  /// </summary>
  public DocumentModel.Drawing.IMinus? Minus { get ; set; }
  
  /// <summary>
  /// Error Bar Value.
  /// </summary>
  public System.Double? ErrorBarValue { get ; set; }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public DocumentModel.Drawing.IChartShapeProperties? ChartShapeProperties { get ; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}

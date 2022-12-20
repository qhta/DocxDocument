namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the ErrorBars Class.
/// </summary>
public partial interface ErrorBars
{
  /// <summary>
  /// Error Bar Direction.
  /// </summary>
  public DocumentModel.Drawings.Charts.ErrorBarDirectionKind? ErrorDirection { get; set; }
  
  /// <summary>
  /// Error Bar Type.
  /// </summary>
  public DocumentModel.Drawings.Charts.ErrorBarKind? ErrorBarType { get; set; }
  
  /// <summary>
  /// Error Bar Value Type.
  /// </summary>
  public DocumentModel.Drawings.Charts.ErrorKind? ErrorBarValueType { get; set; }
  
  /// <summary>
  /// No End Cap.
  /// </summary>
  public Boolean? NoEndCap { get; set; }
  
  /// <summary>
  /// Plus.
  /// </summary>
  public DocumentModel.Drawings.Charts.Plus? Plus { get; set; }
  
  /// <summary>
  /// Minus.
  /// </summary>
  public DocumentModel.Drawings.Charts.Minus? Minus { get; set; }
  
  /// <summary>
  /// Error Bar Value.
  /// </summary>
  public Double? ErrorBarValue { get; set; }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public DocumentModel.Drawings.Charts.ChartShapeProperties? ChartShapeProperties { get; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public DocumentModel.Drawings.Charts.ExtensionList? ExtensionList { get; set; }
  
}

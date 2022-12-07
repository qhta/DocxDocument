namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ErrorBars Class.
/// </summary>
public interface ErrorBars
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
  /// Plus.
  /// </summary>
  public Plus? Plus { get ; set; }
  
  /// <summary>
  /// Minus.
  /// </summary>
  public Minus? Minus { get ; set; }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public ChartShapeProperties? ChartShapeProperties { get ; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public ExtensionList4? ExtensionList { get ; set; }
  
}

namespace DocumentModel.Spreadsheet;

/// <summary>
/// Gradient.
/// </summary>
public interface IGradientFill // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Gradient Fill Type
  /// </summary>
  public DocumentModel.Spreadsheet.GradientKind? Type { get ; set; }
  
  /// <summary>
  /// Linear Gradient Degree
  /// </summary>
  public System.Double? Degree { get ; set; }
  
  /// <summary>
  /// Left Convergence
  /// </summary>
  public System.Double? Left { get ; set; }
  
  /// <summary>
  /// Right Convergence
  /// </summary>
  public System.Double? Right { get ; set; }
  
  /// <summary>
  /// Top Gradient Convergence
  /// </summary>
  public System.Double? Top { get ; set; }
  
  /// <summary>
  /// Bottom Convergence
  /// </summary>
  public System.Double? Bottom { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IGradientStop>? GradientStops { get ; set; }
  
}

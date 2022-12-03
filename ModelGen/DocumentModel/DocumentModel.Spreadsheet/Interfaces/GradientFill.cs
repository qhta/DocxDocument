namespace DocumentModel.Spreadsheet;

/// <summary>
/// Gradient.
/// </summary>
public interface GradientFill // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Gradient Fill Type
  /// </summary>
  public GradientKind? Type { get ; set; }
  
  /// <summary>
  /// Linear Gradient Degree
  /// </summary>
  public Double? Degree { get ; set; }
  
  /// <summary>
  /// Left Convergence
  /// </summary>
  public Double? Left { get ; set; }
  
  /// <summary>
  /// Right Convergence
  /// </summary>
  public Double? Right { get ; set; }
  
  /// <summary>
  /// Top Gradient Convergence
  /// </summary>
  public Double? Top { get ; set; }
  
  /// <summary>
  /// Bottom Convergence
  /// </summary>
  public Double? Bottom { get ; set; }
  
  public Collection<GradientStop>? GradientStops { get ; set; }
  
}

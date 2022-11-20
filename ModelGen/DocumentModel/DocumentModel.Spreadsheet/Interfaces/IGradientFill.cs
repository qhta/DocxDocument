namespace DocumentModel.Spreadsheet;

/// <summary>
/// Gradient.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IGradientStop))]
public interface IGradientFill // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Gradient Fill Type
  /// </summary>
  public GradientValues? Type { get ; set; }
  
  /// <summary>
  /// Linear Gradient Degree
  /// </summary>
  public double? Degree { get ; set; }
  
  /// <summary>
  /// Left Convergence
  /// </summary>
  public double? Left { get ; set; }
  
  /// <summary>
  /// Right Convergence
  /// </summary>
  public double? Right { get ; set; }
  
  /// <summary>
  /// Top Gradient Convergence
  /// </summary>
  public double? Top { get ; set; }
  
  /// <summary>
  /// Bottom Convergence
  /// </summary>
  public double? Bottom { get ; set; }
  
}

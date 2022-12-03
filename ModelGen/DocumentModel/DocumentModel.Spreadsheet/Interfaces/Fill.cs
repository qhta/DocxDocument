namespace DocumentModel.Spreadsheet;

/// <summary>
/// Fill.
/// </summary>
public interface Fill // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Pattern.
  /// </summary>
  public PatternFill? PatternFill { get ; set; }
  
  /// <summary>
  /// Gradient.
  /// </summary>
  public GradientFill? GradientFill { get ; set; }
  
}

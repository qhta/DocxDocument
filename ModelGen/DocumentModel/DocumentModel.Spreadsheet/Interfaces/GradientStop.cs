namespace DocumentModel.Spreadsheet;

/// <summary>
/// Gradient Stop.
/// </summary>
public interface GradientStop // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Gradient Stop Position
  /// </summary>
  public Double? Position { get ; set; }
  
  /// <summary>
  /// Color.
  /// </summary>
  public ColorType? Color { get ; set; }
  
}

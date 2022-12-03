namespace DocumentModel.Spreadsheet;

/// <summary>
/// Pattern.
/// </summary>
public interface PatternFill // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Pattern Type
  /// </summary>
  public PatternKind? PatternType { get ; set; }
  
  /// <summary>
  /// Foreground Color.
  /// </summary>
  public ColorType? ForegroundColor { get ; set; }
  
  /// <summary>
  /// Background Color.
  /// </summary>
  public ColorType? BackgroundColor { get ; set; }
  
}

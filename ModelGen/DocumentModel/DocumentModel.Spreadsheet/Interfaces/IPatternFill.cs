namespace DocumentModel.Spreadsheet;

/// <summary>
/// Pattern.
/// </summary>
public interface IPatternFill // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Pattern Type
  /// </summary>
  public PatternKind? PatternType { get ; set; }
  
  /// <summary>
  /// Foreground Color.
  /// </summary>
  public IColorType? ForegroundColor { get ; set; }
  
  /// <summary>
  /// Background Color.
  /// </summary>
  public IColorType? BackgroundColor { get ; set; }
  
}

namespace DocumentModel.Spreadsheet;

/// <summary>
/// Pattern.
/// </summary>
public interface IPatternFill // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Pattern Type
  /// </summary>
  public DocumentModel.Spreadsheet.PatternKind? PatternType { get ; set; }
  
  /// <summary>
  /// Foreground Color.
  /// </summary>
  public DocumentModel.Spreadsheet.IColorType? ForegroundColor { get ; set; }
  
  /// <summary>
  /// Background Color.
  /// </summary>
  public DocumentModel.Spreadsheet.IColorType? BackgroundColor { get ; set; }
  
}

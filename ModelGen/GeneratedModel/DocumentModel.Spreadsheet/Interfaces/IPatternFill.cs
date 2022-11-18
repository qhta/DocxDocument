namespace DocumentModel.Spreadsheet;

/// <summary>
/// Pattern.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IForegroundColor))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IBackgroundColor))]
public interface IPatternFill // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Pattern Type
  /// </summary>
  public Pattern? PatternType { get ; set; }
  
  /// <summary>
  /// Foreground Color.
  /// </summary>
  public DocumentModel.Spreadsheet.IForegroundColor? ForegroundColor { get ; set; }
  
  /// <summary>
  /// Background Color.
  /// </summary>
  public DocumentModel.Spreadsheet.IBackgroundColor? BackgroundColor { get ; set; }
  
}

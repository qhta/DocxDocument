namespace DocumentModel.Spreadsheet;

/// <summary>
/// Pattern.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IForegroundColor))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IBackgroundColor))]
public class PatternFill: IPatternFill
{
  /// <summary>
  /// Pattern Type
  /// </summary>
  public PatternValues? PatternType
  {
    get;
    set;
  }
  
  /// <summary>
  /// Foreground Color.
  /// </summary>
  public DocumentModel.Spreadsheet.IForegroundColor? ForegroundColor
  {
    get;
    set;
  }
  
  /// <summary>
  /// Background Color.
  /// </summary>
  public DocumentModel.Spreadsheet.IBackgroundColor? BackgroundColor
  {
    get;
    set;
  }
  
}

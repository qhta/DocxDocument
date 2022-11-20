namespace DocumentModel.Spreadsheet;

/// <summary>
/// Fill.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IGradientFill))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IPatternFill))]
public class Fill: IFill
{
  /// <summary>
  /// Pattern.
  /// </summary>
  public DocumentModel.Spreadsheet.IPatternFill? PatternFill
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gradient.
  /// </summary>
  public DocumentModel.Spreadsheet.IGradientFill? GradientFill
  {
    get;
    set;
  }
  
}

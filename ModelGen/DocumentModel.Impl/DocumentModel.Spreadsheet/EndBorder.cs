namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the EndBorder Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IColor))]
public class EndBorder: IEndBorder
{
  /// <summary>
  /// Line Style
  /// </summary>
  public BorderStyleValues? Style
  {
    get;
    set;
  }
  
  /// <summary>
  /// Color.
  /// </summary>
  public DocumentModel.Spreadsheet.IColor? Color
  {
    get;
    set;
  }
  
}

namespace DocumentModel.Spreadsheet;

/// <summary>
/// Right Border.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IColor))]
public class RightBorder: IRightBorder
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

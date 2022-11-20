namespace DocumentModel.Spreadsheet;

/// <summary>
/// Bottom Border.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IColor))]
public class BottomBorder: IBottomBorder
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

namespace DocumentModel.Spreadsheet;

/// <summary>
/// Vertical Inner Border.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IColor))]
public class VerticalBorder: IVerticalBorder
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

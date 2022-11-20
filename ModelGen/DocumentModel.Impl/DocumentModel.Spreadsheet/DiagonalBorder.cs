namespace DocumentModel.Spreadsheet;

/// <summary>
/// Diagonal.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IColor))]
public class DiagonalBorder: IDiagonalBorder
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

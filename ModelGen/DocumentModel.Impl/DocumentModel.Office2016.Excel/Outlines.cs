namespace DocumentModel.Office2016.Excel;

/// <summary>
/// Defines the Outlines Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2016.Excel.IOutline))]
public class Outlines: IOutlines
{
  /// <summary>
  /// isRow, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? IsRow
  {
    get;
    set;
  }
  
}

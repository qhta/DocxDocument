namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the CustomFilters Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.ICustomFilter))]
public class CustomFilters: ICustomFilters
{
  /// <summary>
  /// and, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? And
  {
    get;
    set;
  }
  
}

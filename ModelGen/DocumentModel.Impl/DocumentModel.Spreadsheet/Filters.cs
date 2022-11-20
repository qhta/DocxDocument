namespace DocumentModel.Spreadsheet;

/// <summary>
/// Filter Criteria.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IDateGroupItem))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IFilter))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IFilter))]
public class Filters: IFilters
{
  /// <summary>
  /// Filter by Blank
  /// </summary>
  public bool? Blank
  {
    get;
    set;
  }
  
  /// <summary>
  /// Calendar Type
  /// </summary>
  public DocumentModel.Spreadsheet.CalendarValues? CalendarType
  {
    get;
    set;
  }
  
}

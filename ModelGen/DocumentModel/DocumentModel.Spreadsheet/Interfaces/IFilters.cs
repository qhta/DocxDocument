namespace DocumentModel.Spreadsheet;

/// <summary>
/// Filter Criteria.
/// </summary>
public interface IFilters // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Filter by Blank
  /// </summary>
  public System.Boolean? Blank { get ; set; }
  
  /// <summary>
  /// Calendar Type
  /// </summary>
  public DocumentModel.Spreadsheet.CalendarKind? CalendarType { get ; set; }
  
}

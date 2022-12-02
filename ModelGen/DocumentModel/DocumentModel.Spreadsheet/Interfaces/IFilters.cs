namespace DocumentModel.Spreadsheet;

/// <summary>
/// Filter Criteria.
/// </summary>
public interface IFilters // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Filter by Blank
  /// </summary>
  public Boolean? Blank { get ; set; }
  
  /// <summary>
  /// Calendar Type
  /// </summary>
  public CalendarKind? CalendarType { get ; set; }
  
  public Collection<String>? Filters { get ; set; }
  
  public Collection<IDateGroupItem>? DateGroupItems { get ; set; }
  
}

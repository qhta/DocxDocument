namespace DocumentModel.Spreadsheet;

/// <summary>
/// Filter Criteria.
/// </summary>
public interface Filters // : DocumentModel.BaseTypes.ModelElement
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
  
  public Collection<DateGroupItem>? DateGroupItems { get ; set; }
  
}

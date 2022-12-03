namespace DocumentModel.Spreadsheet;

/// <summary>
/// PivotCache Record.
/// </summary>
public interface PivotCacheRecord // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<MissingItem>? MissingItems { get ; set; }
  
  public Collection<NumberItem>? NumberItems { get ; set; }
  
  public Collection<BooleanItem>? BooleanItems { get ; set; }
  
  public Collection<ErrorItem>? ErrorItems { get ; set; }
  
  public Collection<StringItem>? StringItems { get ; set; }
  
  public Collection<DateTimeItem>? DateTimeItems { get ; set; }
  
  public Collection<UInt32>? FieldItems { get ; set; }
  
}

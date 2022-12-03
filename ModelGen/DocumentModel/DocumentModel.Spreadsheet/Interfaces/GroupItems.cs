namespace DocumentModel.Spreadsheet;

/// <summary>
/// OLAP Group Items.
/// </summary>
public interface GroupItems // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Items Created Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<MissingItem>? MissingItems { get ; set; }
  
  public Collection<NumberItem>? NumberItems { get ; set; }
  
  public Collection<BooleanItem>? BooleanItems { get ; set; }
  
  public Collection<ErrorItem>? ErrorItems { get ; set; }
  
  public Collection<StringItem>? StringItems { get ; set; }
  
  public Collection<DateTimeItem>? DateTimeItems { get ; set; }
  
}

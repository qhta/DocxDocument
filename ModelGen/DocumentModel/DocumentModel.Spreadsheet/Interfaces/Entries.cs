namespace DocumentModel.Spreadsheet;

/// <summary>
/// Entries.
/// </summary>
public interface Entries // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Tuple Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<MissingItem>? MissingItems { get ; set; }
  
  public Collection<NumberItem>? NumberItems { get ; set; }
  
  public Collection<ErrorItem>? ErrorItems { get ; set; }
  
  public Collection<StringItem>? StringItems { get ; set; }
  
}

namespace DocumentModel.Spreadsheet;

/// <summary>
/// OLAP Level Groups.
/// </summary>
public interface Groups // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Level Group Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<Group>? Groups { get ; set; }
  
}

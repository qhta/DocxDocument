namespace DocumentModel.Spreadsheet;

/// <summary>
/// Members.
/// </summary>
public interface Members // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Item Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  /// <summary>
  /// Hierarchy Level
  /// </summary>
  public UInt32? Level { get ; set; }
  
  public Collection<Member>? Members { get ; set; }
  
}

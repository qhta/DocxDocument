namespace DocumentModel.Spreadsheet;

/// <summary>
/// Page Items.
/// </summary>
public interface Page // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Page Item String Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<PageItem>? PageItems { get ; set; }
  
}

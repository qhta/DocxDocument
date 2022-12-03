namespace DocumentModel.Spreadsheet;

/// <summary>
/// Page Item Values.
/// </summary>
public interface Pages // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Page Item String Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<Page>? Pages { get ; set; }
  
}

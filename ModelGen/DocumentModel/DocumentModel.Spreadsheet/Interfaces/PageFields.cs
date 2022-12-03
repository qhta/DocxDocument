namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PageFields Class.
/// </summary>
public interface PageFields // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Page Item Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<PageField>? PageFields { get ; set; }
  
}

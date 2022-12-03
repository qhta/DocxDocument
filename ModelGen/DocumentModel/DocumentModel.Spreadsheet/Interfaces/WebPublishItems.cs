namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the WebPublishItems Class.
/// </summary>
public interface WebPublishItems // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Web Publishing Items Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<WebPublishItem>? WebPublishItems { get ; set; }
  
}

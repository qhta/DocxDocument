namespace DocumentModel.Office2013.Word;

/// <summary>
/// Defines the PersistentDocumentId Class.
/// </summary>
public class PersistentDocumentId: IPersistentDocumentId
{
  /// <summary>
  /// val, this property is only available in Office 2013 and later.
  /// </summary>
  public string? Val
  {
    get;
    set;
  }
  
}

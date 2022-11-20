namespace DocumentModel.Wordprocessing;

/// <summary>
/// Listing of All Revision Save ID Values.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IRsidRoot))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IRsid))]
public class Rsids: IRsids
{
  /// <summary>
  /// Original Document Revision Save ID.
  /// </summary>
  public IRsidRoot? RsidRoot
  {
    get;
    set;
  }
  
}

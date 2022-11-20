namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the TupleCache Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IEntries))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IQueryCache))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IServerFormats))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ISets))]
public class TupleCache: ITupleCache
{
  /// <summary>
  /// Entries.
  /// </summary>
  public IEntries? Entries
  {
    get;
    set;
  }
  
  /// <summary>
  /// Sets.
  /// </summary>
  public ISets? Sets
  {
    get;
    set;
  }
  
  /// <summary>
  /// OLAP Query Cache.
  /// </summary>
  public IQueryCache? QueryCache
  {
    get;
    set;
  }
  
  /// <summary>
  /// Server Formats.
  /// </summary>
  public IServerFormats? ServerFormats
  {
    get;
    set;
  }
  
  /// <summary>
  /// Future Feature Data Storage Area.
  /// </summary>
  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList
  {
    get;
    set;
  }
  
}

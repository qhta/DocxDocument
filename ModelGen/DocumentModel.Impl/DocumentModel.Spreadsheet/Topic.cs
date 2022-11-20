namespace DocumentModel.Spreadsheet;

/// <summary>
/// Topic.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ITopicReferences))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ISubtopic))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IXstring))]
public class Topic: ITopic
{
  /// <summary>
  /// Type
  /// </summary>
  public VolatileValues? ValueType
  {
    get;
    set;
  }
  
  /// <summary>
  /// Topic Value.
  /// </summary>
  public DocumentModel.Spreadsheet.IXstring? Xstring
  {
    get;
    set;
  }
  
}

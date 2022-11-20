namespace DocumentModel.Presentation;

/// <summary>
/// Defines the OleObjectLink Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.IExtensionList))]
public class OleObjectLink: IOleObjectLink
{
  /// <summary>
  /// Update Linked OLE Objects Automatically
  /// </summary>
  public bool? AutoUpdate
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Presentation.IExtensionList? ExtensionList
  {
    get;
    set;
  }
  
}

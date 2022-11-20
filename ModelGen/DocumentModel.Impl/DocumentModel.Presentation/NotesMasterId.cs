namespace DocumentModel.Presentation;

/// <summary>
/// Notes Master ID.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.IExtensionList))]
public class NotesMasterId: INotesMasterId
{
  /// <summary>
  /// Relationship Identifier
  /// </summary>
  public string? Id
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

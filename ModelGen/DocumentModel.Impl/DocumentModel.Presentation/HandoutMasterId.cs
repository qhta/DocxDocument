namespace DocumentModel.Presentation;

/// <summary>
/// Handout Master ID.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.IExtensionList))]
public class HandoutMasterId: IHandoutMasterId
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

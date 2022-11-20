namespace DocumentModel.Presentation;

/// <summary>
/// Slide Master ID.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.IExtensionList))]
public class SlideMasterId: ISlideMasterId
{
  /// <summary>
  /// Slide Master Identifier
  /// </summary>
  public uint? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// Relationship Identifier
  /// </summary>
  public string? RelationshipId
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

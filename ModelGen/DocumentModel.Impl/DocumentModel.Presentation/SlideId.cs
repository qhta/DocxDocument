namespace DocumentModel.Presentation;

/// <summary>
/// Slide ID.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.IExtensionList))]
public class SlideId: ISlideId
{
  /// <summary>
  /// Slide Identifier
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

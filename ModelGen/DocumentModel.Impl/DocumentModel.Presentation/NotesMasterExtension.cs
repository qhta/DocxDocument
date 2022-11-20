namespace DocumentModel.Presentation;

/// <summary>
/// Defines the NotesMasterExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.PowerPoint.ISlideGuideList))]
public class NotesMasterExtension: INotesMasterExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public string? Uri
  {
    get;
    set;
  }
  
}

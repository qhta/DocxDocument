namespace DocumentModel.Presentation;

/// <summary>
/// Defines the SlideMasterExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.PowerPoint.ISlideGuideList))]
public class SlideMasterExtension: ISlideMasterExtension
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

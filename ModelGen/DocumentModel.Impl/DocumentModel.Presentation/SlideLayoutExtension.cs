namespace DocumentModel.Presentation;

/// <summary>
/// Defines the SlideLayoutExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.PowerPoint.ISlideGuideList))]
public class SlideLayoutExtension: ISlideLayoutExtension
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

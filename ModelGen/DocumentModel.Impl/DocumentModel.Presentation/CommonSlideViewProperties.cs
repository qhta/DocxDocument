namespace DocumentModel.Presentation;

/// <summary>
/// Defines the CommonSlideViewProperties Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.ICommonViewProperties))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IGuideList))]
public class CommonSlideViewProperties: ICommonSlideViewProperties
{
  /// <summary>
  /// Snap Objects to Grid
  /// </summary>
  public bool? SnapToGrid
  {
    get;
    set;
  }
  
  /// <summary>
  /// Snap Objects to Objects
  /// </summary>
  public bool? SnapToObjects
  {
    get;
    set;
  }
  
  /// <summary>
  /// Show Guides in View
  /// </summary>
  public bool? ShowGuides
  {
    get;
    set;
  }
  
  /// <summary>
  /// Base properties for Slide View.
  /// </summary>
  public ICommonViewProperties? CommonViewProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// List of Guides.
  /// </summary>
  public IGuideList? GuideList
  {
    get;
    set;
  }
  
}

namespace DocumentModel.Presentation;

/// <summary>
/// Target Element Trigger Choice.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.ISoundTarget))]
[ChildElementInfo(typeof(DocumentModel.Presentation.ISlideTarget))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IShapeTarget))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IInkTarget))]
[ChildElementInfo(typeof(DocumentModel.Office2010.PowerPoint.IBookmarkTarget))]
public class TargetElement: ITargetElement
{
  /// <summary>
  /// Slide Target.
  /// </summary>
  public ISlideTarget? SlideTarget
  {
    get;
    set;
  }
  
  /// <summary>
  /// Sound Target.
  /// </summary>
  public ISoundTarget? SoundTarget
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shape Target.
  /// </summary>
  public IShapeTarget? ShapeTarget
  {
    get;
    set;
  }
  
  /// <summary>
  /// Ink Target.
  /// </summary>
  public IInkTarget? InkTarget
  {
    get;
    set;
  }
  
  /// <summary>
  /// BookmarkTarget, this property is only available in Office 2010 and later..
  /// </summary>
  public IBookmarkTarget? BookmarkTarget
  {
    get;
    set;
  }
  
}

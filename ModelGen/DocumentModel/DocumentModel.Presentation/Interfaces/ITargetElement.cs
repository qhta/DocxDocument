namespace DocumentModel.Presentation;

/// <summary>
/// Target Element Trigger Choice.
/// </summary>
public interface ITargetElement // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Slide Target.
  /// </summary>
  public ISlideTarget? SlideTarget { get ; set; }
  
  /// <summary>
  /// Sound Target.
  /// </summary>
  public ISoundTarget? SoundTarget { get ; set; }
  
  /// <summary>
  /// Shape Target.
  /// </summary>
  public IShapeTarget? ShapeTarget { get ; set; }
  
  /// <summary>
  /// Ink Target.
  /// </summary>
  public InkTarget? InkTarget { get ; set; }
  
  /// <summary>
  /// BookmarkTarget, this property is only available in Office 2010 and later..
  /// </summary>
  public IBookmarkTarget? BookmarkTarget { get ; set; }
  
}

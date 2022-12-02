namespace DocumentModel.Presentation;

/// <summary>
/// Target Element Trigger Choice.
/// </summary>
public interface ITargetElement // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Slide Target.
  /// </summary>
  public Boolean? SlideTarget { get ; set; }
  
  /// <summary>
  /// Sound Target.
  /// </summary>
  public IEmbeddedWavAudioFileType? SoundTarget { get ; set; }
  
  /// <summary>
  /// Shape Target.
  /// </summary>
  public IShapeTarget? ShapeTarget { get ; set; }
  
  /// <summary>
  /// Ink Target.
  /// </summary>
  public ITimeListSubShapeIdType? InkTarget { get ; set; }
  
  /// <summary>
  /// BookmarkTarget, this property is only available in Office 2010 and later..
  /// </summary>
  public IBookmarkTarget? BookmarkTarget { get ; set; }
  
}

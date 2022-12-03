namespace DocumentModel.Presentation;

/// <summary>
/// Target Element Trigger Choice.
/// </summary>
public interface TargetElement // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Slide Target.
  /// </summary>
  public Boolean? SlideTarget { get ; set; }
  
  /// <summary>
  /// Sound Target.
  /// </summary>
  public EmbeddedWavAudioFileType? SoundTarget { get ; set; }
  
  /// <summary>
  /// Shape Target.
  /// </summary>
  public ShapeTarget? ShapeTarget { get ; set; }
  
  /// <summary>
  /// Ink Target.
  /// </summary>
  public TimeListSubShapeIdType? InkTarget { get ; set; }
  
  /// <summary>
  /// BookmarkTarget, this property is only available in Office 2010 and later..
  /// </summary>
  public BookmarkTarget? BookmarkTarget { get ; set; }
  
}

namespace DocumentModel.Presentation;

/// <summary>
/// Target Element Trigger Choice.
/// </summary>
public interface ITargetElement // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Slide Target.
  /// </summary>
  public System.Boolean? SlideTarget { get ; set; }
  
  /// <summary>
  /// Sound Target.
  /// </summary>
  public DocumentModel.Presentation.IEmbeddedWavAudioFileType? SoundTarget { get ; set; }
  
  /// <summary>
  /// Shape Target.
  /// </summary>
  public DocumentModel.Presentation.IShapeTarget? ShapeTarget { get ; set; }
  
  /// <summary>
  /// Ink Target.
  /// </summary>
  public DocumentModel.Presentation.ITimeListSubShapeIdType? InkTarget { get ; set; }
  
  /// <summary>
  /// BookmarkTarget, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Presentation.IBookmarkTarget? BookmarkTarget { get ; set; }
  
}

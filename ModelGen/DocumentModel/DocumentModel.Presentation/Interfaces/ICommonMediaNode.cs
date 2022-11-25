namespace DocumentModel.Presentation;

/// <summary>
/// Common Media Node Properties.
/// </summary>
public interface ICommonMediaNode // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Volume
  /// </summary>
  public System.Int32? Volume { get ; set; }
  
  /// <summary>
  /// Mute
  /// </summary>
  public System.Boolean? Mute { get ; set; }
  
  /// <summary>
  /// Number of Slides
  /// </summary>
  public System.UInt32? SlideCount { get ; set; }
  
  /// <summary>
  /// Show When Stopped
  /// </summary>
  public System.Boolean? ShowWhenStopped { get ; set; }
  
  /// <summary>
  /// Common Time Node Properties.
  /// </summary>
  public DocumentModel.Presentation.ICommonTimeNode? CommonTimeNode { get ; set; }
  
  /// <summary>
  /// TargetElement.
  /// </summary>
  public DocumentModel.Presentation.ITargetElement? TargetElement { get ; set; }
  
}

namespace DocumentModel.Presentation;

/// <summary>
/// Common Media Node Properties.
/// </summary>
public interface CommonMediaNode // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Volume
  /// </summary>
  public Int32? Volume { get ; set; }
  
  /// <summary>
  /// Mute
  /// </summary>
  public Boolean? Mute { get ; set; }
  
  /// <summary>
  /// Number of Slides
  /// </summary>
  public UInt32? SlideCount { get ; set; }
  
  /// <summary>
  /// Show When Stopped
  /// </summary>
  public Boolean? ShowWhenStopped { get ; set; }
  
  /// <summary>
  /// Common Time Node Properties.
  /// </summary>
  public CommonTimeNode? CommonTimeNode { get ; set; }
  
  /// <summary>
  /// TargetElement.
  /// </summary>
  public TargetElement? TargetElement { get ; set; }
  
}

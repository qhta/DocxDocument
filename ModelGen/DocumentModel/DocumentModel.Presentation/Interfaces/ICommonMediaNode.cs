namespace DocumentModel.Presentation;

/// <summary>
/// Common Media Node Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.ICommonTimeNode))]
[ChildElementInfo(typeof(DocumentModel.Presentation.ITargetElement))]
public interface ICommonMediaNode // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Volume
  /// </summary>
  public int? Volume { get ; set; }
  
  /// <summary>
  /// Mute
  /// </summary>
  public bool? Mute { get ; set; }
  
  /// <summary>
  /// Number of Slides
  /// </summary>
  public uint? SlideCount { get ; set; }
  
  /// <summary>
  /// Show When Stopped
  /// </summary>
  public bool? ShowWhenStopped { get ; set; }
  
  /// <summary>
  /// Common Time Node Properties.
  /// </summary>
  public ICommonTimeNode? CommonTimeNode { get ; set; }
  
  /// <summary>
  /// TargetElement.
  /// </summary>
  public ITargetElement? TargetElement { get ; set; }
  
}

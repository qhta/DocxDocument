namespace DocumentModel.Presentation;

/// <summary>
/// Defines the SoundAction Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.IEndSoundAction))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IStartSoundAction))]
public interface ISoundAction // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Start Sound Action.
  /// </summary>
  public IStartSoundAction? StartSoundAction { get ; set; }
  
  /// <summary>
  /// Stop Sound Action.
  /// </summary>
  public IEndSoundAction? EndSoundAction { get ; set; }
  
}

namespace DocumentModel.Presentation;

/// <summary>
/// Defines the SoundAction Class.
/// </summary>
public interface ISoundAction // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Start Sound Action.
  /// </summary>
  public DocumentModel.Presentation.IStartSoundAction? StartSoundAction { get ; set; }
  
  /// <summary>
  /// Stop Sound Action.
  /// </summary>
  public System.Boolean? EndSoundAction { get ; set; }
  
}

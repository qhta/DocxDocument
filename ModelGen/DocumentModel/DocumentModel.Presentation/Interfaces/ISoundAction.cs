namespace DocumentModel.Presentation;

/// <summary>
/// Defines the SoundAction Class.
/// </summary>
public interface ISoundAction // : DocumentModel.ITypedOpenXmlCompositeElement
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

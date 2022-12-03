namespace DocumentModel.Presentation;

/// <summary>
/// Defines the SoundAction Class.
/// </summary>
public interface SoundAction // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Start Sound Action.
  /// </summary>
  public StartSoundAction? StartSoundAction { get ; set; }
  
  /// <summary>
  /// Stop Sound Action.
  /// </summary>
  public Boolean? EndSoundAction { get ; set; }
  
}

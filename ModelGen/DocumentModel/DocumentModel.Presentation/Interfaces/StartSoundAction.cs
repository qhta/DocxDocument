namespace DocumentModel.Presentation;

/// <summary>
/// Start Sound Action.
/// </summary>
public interface StartSoundAction // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Loop Sound
  /// </summary>
  public Boolean? Loop { get ; set; }
  
  /// <summary>
  /// Sound.
  /// </summary>
  public EmbeddedWavAudioFileType? Sound { get ; set; }
  
}

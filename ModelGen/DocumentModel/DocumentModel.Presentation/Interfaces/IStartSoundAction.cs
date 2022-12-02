namespace DocumentModel.Presentation;

/// <summary>
/// Start Sound Action.
/// </summary>
public interface IStartSoundAction // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Loop Sound
  /// </summary>
  public Boolean? Loop { get ; set; }
  
  /// <summary>
  /// Sound.
  /// </summary>
  public IEmbeddedWavAudioFileType? Sound { get ; set; }
  
}

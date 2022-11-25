namespace DocumentModel.Presentation;

/// <summary>
/// Start Sound Action.
/// </summary>
public interface IStartSoundAction // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Loop Sound
  /// </summary>
  public System.Boolean? Loop { get ; set; }
  
  /// <summary>
  /// Sound.
  /// </summary>
  public DocumentModel.Presentation.IEmbeddedWavAudioFileType? Sound { get ; set; }
  
}

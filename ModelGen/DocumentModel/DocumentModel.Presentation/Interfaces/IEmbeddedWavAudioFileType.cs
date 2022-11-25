namespace DocumentModel.Presentation;

/// <summary>
/// Defines the EmbeddedWavAudioFileType Class.
/// </summary>
public interface IEmbeddedWavAudioFileType // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Embedded Audio File Relationship ID
  /// </summary>
  public System.String? Embed { get ; set; }
  
  /// <summary>
  /// Sound Name
  /// </summary>
  public System.String? Name { get ; set; }
  
  /// <summary>
  /// Recognized Built-In Sound
  /// </summary>
  public System.Boolean? BuiltIn { get ; set; }
  
}

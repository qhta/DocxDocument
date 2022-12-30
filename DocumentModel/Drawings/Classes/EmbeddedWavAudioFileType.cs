namespace DocumentModel.Drawings;

/// <summary>
/// Defines the EmbeddedWavAudioFileType Class.
/// </summary>
public partial class EmbeddedWavAudioFileType
{
  /// <summary>
  /// Embedded Audio File Relationship ID
  /// </summary>
  public String? Embed { get; set; }
  
  /// <summary>
  /// Sound Name
  /// </summary>
  public String? Name { get; set; }
  
  /// <summary>
  /// Recognized Built-In Sound
  /// </summary>
  public Boolean? BuiltIn { get; set; }
  
}

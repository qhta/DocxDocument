namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the EmbeddedWavAudioFileType Class.
/// </summary>
public class EmbeddedWavAudioFileType: ModelElement
{
  /// <summary>
  ///   Embedded Audio File Relationship ID
  /// </summary>
  public String? Embed { get; set; }

  /// <summary>
  ///   Sound Name
  /// </summary>
  public String? Name { get; set; }

  /// <summary>
  ///   Recognized Built-In Sound
  /// </summary>
  public Boolean? BuiltIn { get; set; }
}
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
  public string? Embed { get; set; }

  /// <summary>
  ///   Sound Name
  /// </summary>
  public string? Name { get; set; }

  /// <summary>
  ///   Recognized Built-In Sound
  /// </summary>
  public bool? BuiltIn { get; set; }
}
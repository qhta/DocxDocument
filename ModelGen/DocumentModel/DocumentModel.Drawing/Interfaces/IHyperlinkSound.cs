namespace DocumentModel.Drawing;

/// <summary>
/// Sound to play..
/// </summary>
public interface IHyperlinkSound // : DocumentFormat.OpenXml.Drawing.EmbeddedWavAudioFileType
{
  /// <summary>
  /// Embedded Audio File Relationship ID
  /// </summary>
  public string? Embed { get ; set; }
  
  /// <summary>
  /// Sound Name
  /// </summary>
  public string? Name { get ; set; }
  
  /// <summary>
  /// Recognized Built-In Sound
  /// </summary>
  public bool? BuiltIn { get ; set; }
  
}

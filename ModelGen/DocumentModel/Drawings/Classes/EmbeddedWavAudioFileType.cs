namespace DocumentModel.Drawings;


/// <summary>
///   Defines the EmbeddedWavAudioFileType Class.
/// </summary>
public partial class EmbeddedWavAudioFileType
{
  
  /// <summary>
  ///   Embedded Audio File Relationship ID
  /// </summary>
  [SchemaAttr("r:embed")]
  public String? Embed { get; set; }
  
  
  /// <summary>
  ///   Sound Name
  /// </summary>
  [SchemaAttr("name")]
  public String? Name { get; set; }
  
  
  /// <summary>
  ///   Recognized Built-In Sound
  /// </summary>
  [SchemaAttr("builtIn")]
  public Boolean? BuiltIn { get; set; }
  
}

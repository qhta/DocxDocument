namespace DocumentModel.Drawings;


/// <summary>
///   Defines the EmbeddedWavAudioFileType Class.
/// </summary>
public partial class EmbeddedWavAudioFileType: ModelElement<DXD.EmbeddedWavAudioFileType>
{
  public EmbeddedWavAudioFileType(): base(){ }
  
  public EmbeddedWavAudioFileType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public EmbeddedWavAudioFileType(DXD.EmbeddedWavAudioFileType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Embedded Audio File Relationship ID
  /// </summary>
  [DataMember]
  public String? Embed
  {
    get => _Element?.Embed;
    set => _ExistingElement.Embed = value;
  }
  
  
  /// <summary>
  ///   Sound Name
  /// </summary>
  [DataMember]
  public String? Name
  {
    get => _Element?.Name;
    set => _ExistingElement.Name = value;
  }
  
  
  /// <summary>
  ///   Recognized Built-In Sound
  /// </summary>
  [DataMember]
  public Boolean? BuiltIn
  {
    get => _Element?.BuiltIn?.Value;
    set => _ExistingElement.BuiltIn = value;
  }
  
}

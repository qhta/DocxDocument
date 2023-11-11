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
    get
    {
      return StringValueConverter.GetValue(_Element?.Embed);
    }
    set
    {
      _ExistingElement.Embed = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Sound Name
  /// </summary>
  [DataMember]
  public String? Name
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Name);
    }
    set
    {
      _ExistingElement.Name = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Recognized Built-In Sound
  /// </summary>
  [DataMember]
  public Boolean? BuiltIn
  {
    get
    {
      return _Element?.BuiltIn?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.BuiltIn = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.BuiltIn = null;
    }
  }
  
}

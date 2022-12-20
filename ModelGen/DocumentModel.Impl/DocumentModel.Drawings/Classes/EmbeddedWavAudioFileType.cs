namespace DocumentModel.Drawings;

/// <summary>
/// Defines the EmbeddedWavAudioFileType Class.
/// </summary>
public partial class EmbeddedWavAudioFileTypeImpl: ModelElementImpl, EmbeddedWavAudioFileType
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.EmbeddedWavAudioFileType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.EmbeddedWavAudioFileType?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public EmbeddedWavAudioFileTypeImpl(): base() {}
  
  public EmbeddedWavAudioFileTypeImpl(DocumentFormat.OpenXml.Drawing.EmbeddedWavAudioFileType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Embedded Audio File Relationship ID
  /// </summary>
  public String? Embed
  {
    get => (System.String?)OpenXmlElement?.Embed?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Embed = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Sound Name
  /// </summary>
  public String? Name
  {
    get => (System.String?)OpenXmlElement?.Name?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Name = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Recognized Built-In Sound
  /// </summary>
  public Boolean? BuiltIn
  {
    get => (System.Boolean?)OpenXmlElement?.BuiltIn?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.BuiltIn = (System.Boolean?)value;
    }
  }
  
}

namespace DocumentModel.Drawings;

/// <summary>
/// Defines the AudioCDTimeType Class.
/// </summary>
public partial class AudioCDTimeTypeImpl: ModelElementImpl, AudioCDTimeType
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.AudioCDTimeType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.AudioCDTimeType?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public AudioCDTimeTypeImpl(): base() {}
  
  public AudioCDTimeTypeImpl(DocumentFormat.OpenXml.Drawing.AudioCDTimeType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Track
  /// </summary>
  public Byte? Track
  {
    get => (System.Byte?)OpenXmlElement?.Track?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Track = (System.Byte?)value;
    }
  }
  
  /// <summary>
  /// Time
  /// </summary>
  public UInt32? Time
  {
    get => (System.UInt32?)OpenXmlElement?.Time?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Time = (System.UInt32?)value;
    }
  }
  
}

namespace DocumentModel.Drawings;

/// <summary>
/// Defines the AudioCDTimeType Class.
/// </summary>
public class AudioCDTimeTypeImpl: ModelElementImpl, AudioCDTimeType
{
  public DocumentFormat.OpenXml.Drawing.AudioCDTimeType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.AudioCDTimeType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Track
  /// </summary>
  public Byte? Track
  {
    get => (Byte?)OpenXmlElement?.Track?.Value;
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
    get => (UInt32?)OpenXmlElement?.Time?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Time = (System.UInt32?)value;
    }
  }
  
}

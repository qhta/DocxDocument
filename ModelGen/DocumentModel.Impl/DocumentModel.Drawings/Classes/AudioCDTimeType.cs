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
    get;
    set;
  }
  
  /// <summary>
  /// Time
  /// </summary>
  public UInt32? Time
  {
    get;
    set;
  }
  
}

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the AudioCDTimeType Class.
/// </summary>
public static class AudioCDTimeTypeConverter
{
  /// <summary>
  /// Track
  /// </summary>
  public static Byte? GetTrack(DocumentFormat.OpenXml.Drawing.AudioCDTimeType? openXmlElement)
  {
    return openXmlElement?.Track?.Value;
  }
  
  public static void SetTrack(DocumentFormat.OpenXml.Drawing.AudioCDTimeType? openXmlElement, Byte? value)
  {
    if (openXmlElement != null)
      openXmlElement.Track = value;
  }
  
  /// <summary>
  /// Time
  /// </summary>
  public static UInt32? GetTime(DocumentFormat.OpenXml.Drawing.AudioCDTimeType? openXmlElement)
  {
    return openXmlElement?.Time?.Value;
  }
  
  public static void SetTime(DocumentFormat.OpenXml.Drawing.AudioCDTimeType? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Time = value;
  }
  
  public static DocumentModel.Drawings.AudioCDTimeType? CreateModelElement(DocumentFormat.OpenXml.Drawing.AudioCDTimeType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.AudioCDTimeType();
      value.Track = GetTrack(openXmlElement);
      value.Time = GetTime(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.AudioCDTimeType? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.AudioCDTimeType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTrack(openXmlElement, value?.Track);
      SetTime(openXmlElement, value?.Time);
      return openXmlElement;
    }
    return default;
  }
}

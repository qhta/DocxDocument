namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the AudioCDTimeType Class.
/// </summary>
public static class AudioCDTimeTypeConverter
{
  /// <summary>
  /// Track
  /// </summary>
  private static Byte? GetTrack(DXDraw.AudioCDTimeType openXmlElement)
  {
    return openXmlElement.Track?.Value;
  }
  
  private static void SetTrack(DXDraw.AudioCDTimeType openXmlElement, Byte? value)
  {
    openXmlElement.Track = value;
  }
  
  /// <summary>
  /// Time
  /// </summary>
  private static UInt32? GetTime(DXDraw.AudioCDTimeType openXmlElement)
  {
    return openXmlElement.Time?.Value;
  }
  
  private static void SetTime(DXDraw.AudioCDTimeType openXmlElement, UInt32? value)
  {
    openXmlElement.Time = value;
  }
  
  public static DMDraws.AudioCDTimeType? CreateModelElement(DXDraw.AudioCDTimeType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.AudioCDTimeType();
      value.Track = GetTrack(openXmlElement);
      value.Time = GetTime(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.AudioCDTimeType? value)
    where OpenXmlElementType: DXDraw.AudioCDTimeType, new()
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

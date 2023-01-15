using DocumentFormat.OpenXml.Drawing;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the AudioCDTimeType Class.
/// </summary>
public static class AudioCDTimeTypeConverter
{
  /// <summary>
  ///   Track
  /// </summary>
  public static Byte? GetTrack(AudioCDTimeType? openXmlElement)
  {
    return openXmlElement?.Track?.Value;
  }

  public static void SetTrack(AudioCDTimeType? openXmlElement, Byte? value)
  {
    if (openXmlElement != null)
      openXmlElement.Track = value;
  }

  /// <summary>
  ///   Time
  /// </summary>
  public static UInt32? GetTime(AudioCDTimeType? openXmlElement)
  {
    return openXmlElement?.Time?.Value;
  }

  public static void SetTime(AudioCDTimeType? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Time = value;
  }

  public static DocumentModel.Drawings.AudioCDTimeType? CreateModelElement(AudioCDTimeType? openXmlElement)
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
    where OpenXmlElementType : AudioCDTimeType, new()
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
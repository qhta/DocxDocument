using DocumentFormat.OpenXml.Drawing;
using AudioCDTimeType = DocumentModel.Drawings.AudioCDTimeType;
using AudioFromCD = DocumentFormat.OpenXml.Drawing.AudioFromCD;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Audio from CD.
/// </summary>
public static class AudioFromCDConverter
{
  /// <summary>
  ///   Audio Start Time.
  /// </summary>
  public static AudioCDTimeType? GetStartTime(AudioFromCD? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<StartTime>();
    if (itemElement != null)
      return AudioCDTimeTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetStartTime(AudioFromCD? openXmlElement, AudioCDTimeType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<StartTime>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AudioCDTimeTypeConverter.CreateOpenXmlElement<StartTime>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Audio End Time.
  /// </summary>
  public static AudioCDTimeType? GetEndTime(AudioFromCD? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<EndTime>();
    if (itemElement != null)
      return AudioCDTimeTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetEndTime(AudioFromCD? openXmlElement, AudioCDTimeType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<EndTime>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AudioCDTimeTypeConverter.CreateOpenXmlElement<EndTime>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.ExtensionList? GetExtensionList(AudioFromCD? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
    if (itemElement != null)
      return ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(AudioFromCD? openXmlElement, DocumentModel.Drawings.ExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.AudioFromCD? CreateModelElement(AudioFromCD? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.AudioFromCD();
      value.StartTime = GetStartTime(openXmlElement);
      value.EndTime = GetEndTime(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.AudioFromCD? value)
    where OpenXmlElementType : AudioFromCD, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetStartTime(openXmlElement, value?.StartTime);
      SetEndTime(openXmlElement, value?.EndTime);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
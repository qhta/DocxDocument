using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using Zoom = DocumentFormat.OpenXml.Wordprocessing.Zoom;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Magnification Setting.
/// </summary>
public static class ZoomConverter
{
  /// <summary>
  ///   Zoom Type
  /// </summary>
  public static PresetZoomKind? GetVal(Zoom? openXmlElement)
  {
    return EnumValueConverter.GetValue<PresetZoomValues, PresetZoomKind>(openXmlElement?.Val?.Value);
  }

  public static void SetVal(Zoom? openXmlElement, PresetZoomKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Val = EnumValueConverter.CreateEnumValue<PresetZoomValues, PresetZoomKind>(value);
  }

  /// <summary>
  ///   Zoom Percentage
  /// </summary>
  public static String? GetPercent(Zoom? openXmlElement)
  {
    return openXmlElement?.Percent?.Value;
  }

  public static void SetPercent(Zoom? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Percent = new StringValue { Value = value };
      else
        openXmlElement.Percent = null;
  }

  public static DocumentModel.Wordprocessing.Zoom? CreateModelElement(Zoom? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Zoom();
      value.Val = GetVal(openXmlElement);
      value.Percent = GetPercent(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Zoom? value)
    where OpenXmlElementType : Zoom, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetVal(openXmlElement, value?.Val);
      SetPercent(openXmlElement, value?.Percent);
      return openXmlElement;
    }
    return default;
  }
}
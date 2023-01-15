using DocumentFormat.OpenXml.Office2019.Drawing;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the PictureAttributionSourceURL Class.
/// </summary>
public static class PictureAttributionSourceURLConverter
{
  /// <summary>
  ///   id, this property is only available in Office 2019 and later.
  /// </summary>
  public static String? GetId(PictureAttributionSourceURL? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(PictureAttributionSourceURL? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }

  public static DocumentModel.Drawings.PictureAttributionSourceURL? CreateModelElement(PictureAttributionSourceURL? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.PictureAttributionSourceURL();
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.PictureAttributionSourceURL? value)
    where OpenXmlElementType : PictureAttributionSourceURL, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      return openXmlElement;
    }
    return default;
  }
}
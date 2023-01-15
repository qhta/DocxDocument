using DocumentModel.Wordprocessing;
using AutoCaptions = DocumentFormat.OpenXml.Wordprocessing.AutoCaptions;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Automatic Captioning Settings.
/// </summary>
public static class AutoCaptionsConverter
{
  public static AutoCaption? GetAutoCaption(AutoCaptions? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AutoCaption>();
    if (itemElement != null)
      return AutoCaptionConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetAutoCaption(AutoCaptions? openXmlElement, AutoCaption? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AutoCaption>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AutoCaptionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.AutoCaption>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.AutoCaptions? CreateModelElement(AutoCaptions? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.AutoCaptions();
      value.AutoCaption = GetAutoCaption(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.AutoCaptions? value)
    where OpenXmlElementType : AutoCaptions, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAutoCaption(openXmlElement, value?.AutoCaption);
      return openXmlElement;
    }
    return default;
  }
}
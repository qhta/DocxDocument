using DocumentModel.Wordprocessing;
using Captions = DocumentFormat.OpenXml.Wordprocessing.Captions;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Caption Settings.
/// </summary>
public static class CaptionsConverter
{
  public static Caption? GetCaption(Captions? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Caption>();
    if (itemElement != null)
      return CaptionConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCaption(Captions? openXmlElement, Caption? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Caption>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CaptionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Caption>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static AutoCaptions? GetAutoCaptions(Captions? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AutoCaptions>();
    if (itemElement != null)
      return AutoCaptionsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetAutoCaptions(Captions? openXmlElement, AutoCaptions? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AutoCaptions>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AutoCaptionsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.AutoCaptions>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.Captions? CreateModelElement(Captions? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Captions();
      value.Caption = GetCaption(openXmlElement);
      value.AutoCaptions = GetAutoCaptions(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Captions? value)
    where OpenXmlElementType : Captions, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetCaption(openXmlElement, value?.Caption);
      SetAutoCaptions(openXmlElement, value?.AutoCaptions);
      return openXmlElement;
    }
    return default;
  }
}
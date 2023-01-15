using DocumentFormat.OpenXml.Drawing;
using EmbeddedWavAudioFileType = DocumentModel.Drawings.EmbeddedWavAudioFileType;
using HyperlinkExtensionList = DocumentModel.Drawings.HyperlinkExtensionList;
using HyperlinkOnHover = DocumentFormat.OpenXml.Drawing.HyperlinkOnHover;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the HyperlinkOnHover Class.
/// </summary>
public static class HyperlinkOnHoverConverter
{
  public static EmbeddedWavAudioFileType? GetHyperlinkSound(HyperlinkOnHover? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<HyperlinkSound>();
    if (itemElement != null)
      return EmbeddedWavAudioFileTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetHyperlinkSound(HyperlinkOnHover? openXmlElement, EmbeddedWavAudioFileType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<HyperlinkSound>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EmbeddedWavAudioFileTypeConverter.CreateOpenXmlElement<HyperlinkSound>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static HyperlinkExtensionList? GetHyperlinkExtensionList(HyperlinkOnHover? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.HyperlinkExtensionList>();
    if (itemElement != null)
      return HyperlinkExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetHyperlinkExtensionList(HyperlinkOnHover? openXmlElement, HyperlinkExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.HyperlinkExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HyperlinkExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.HyperlinkExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.HyperlinkOnHover? CreateModelElement(HyperlinkOnHover? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.HyperlinkOnHover();
      value.HyperlinkSound = GetHyperlinkSound(openXmlElement);
      value.HyperlinkExtensionList = GetHyperlinkExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.HyperlinkOnHover? value)
    where OpenXmlElementType : HyperlinkOnHover, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetHyperlinkSound(openXmlElement, value?.HyperlinkSound);
      SetHyperlinkExtensionList(openXmlElement, value?.HyperlinkExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
using DocumentFormat.OpenXml.Office2019.Drawing.HyperLinkColor;
using HyperlinkColorEnum = DocumentModel.Drawings.HyperlinkColorEnum;
using HyperlinkExtension = DocumentFormat.OpenXml.Drawing.HyperlinkExtension;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the HyperlinkExtension Class.
/// </summary>
public static class HyperlinkExtensionConverter
{
  /// <summary>
  ///   URI
  /// </summary>
  public static String? GetUri(HyperlinkExtension? openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }

  public static void SetUri(HyperlinkExtension? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Uri = new StringValue { Value = value };
      else
        openXmlElement.Uri = null;
  }

  public static HyperlinkColorEnum? GetHyperlinkColor(HyperlinkExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<HyperlinkColor>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2019.Drawing.HyperLinkColor.HyperlinkColorEnum, HyperlinkColorEnum>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetHyperlinkColor(HyperlinkExtension? openXmlElement, HyperlinkColorEnum? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<HyperlinkColor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<HyperlinkColor, DocumentFormat.OpenXml.Office2019.Drawing.HyperLinkColor.HyperlinkColorEnum, HyperlinkColorEnum>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.HyperlinkExtension? CreateModelElement(HyperlinkExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.HyperlinkExtension();
      value.Uri = GetUri(openXmlElement);
      value.HyperlinkColor = GetHyperlinkColor(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.HyperlinkExtension? value)
    where OpenXmlElementType : HyperlinkExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetHyperlinkColor(openXmlElement, value?.HyperlinkColor);
      return openXmlElement;
    }
    return default;
  }
}
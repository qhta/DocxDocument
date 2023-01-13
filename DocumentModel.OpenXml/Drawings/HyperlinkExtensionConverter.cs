namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the HyperlinkExtension Class.
/// </summary>
public static class HyperlinkExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  public static String? GetUri(DocumentFormat.OpenXml.Drawing.HyperlinkExtension? openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  public static void SetUri(DocumentFormat.OpenXml.Drawing.HyperlinkExtension? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Uri = new StringValue { Value = value };
      else
        openXmlElement.Uri = null;
  }
  
  public static DocumentModel.Drawings.HyperlinkColorEnum? GetHyperlinkColor(DocumentFormat.OpenXml.Drawing.HyperlinkExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2019.Drawing.HyperLinkColor.HyperlinkColor>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2019.Drawing.HyperLinkColor.HyperlinkColorEnum, DocumentModel.Drawings.HyperlinkColorEnum>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetHyperlinkColor(DocumentFormat.OpenXml.Drawing.HyperlinkExtension? openXmlElement, DocumentModel.Drawings.HyperlinkColorEnum? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2019.Drawing.HyperLinkColor.HyperlinkColor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2019.Drawing.HyperLinkColor.HyperlinkColor, DocumentFormat.OpenXml.Office2019.Drawing.HyperLinkColor.HyperlinkColorEnum, DocumentModel.Drawings.HyperlinkColorEnum>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.HyperlinkExtension? CreateModelElement(DocumentFormat.OpenXml.Drawing.HyperlinkExtension? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.HyperlinkExtension, new()
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

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the HyperlinkExtension Class.
/// </summary>
public static class HyperlinkExtensionConverter
{
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
  
}

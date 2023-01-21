namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the HyperlinkExtension Class.
/// </summary>
public static class HyperlinkExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDraw.HyperlinkExtension openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  private static void SetUri(DXDraw.HyperlinkExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  private static DMDraws.HyperlinkColorEnum? GetHyperlinkColor(DXDraw.HyperlinkExtension openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2019DrawHLnkClr.HyperlinkColor>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2019.Drawing.HyperLinkColor.HyperlinkColorEnum, DMDraws.HyperlinkColorEnum>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetHyperlinkColor(DXDraw.HyperlinkExtension openXmlElement, DMDraws.HyperlinkColorEnum? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2019DrawHLnkClr.HyperlinkColor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXO2019DrawHLnkClr.HyperlinkColor, DocumentFormat.OpenXml.Office2019.Drawing.HyperLinkColor.HyperlinkColorEnum, DMDraws.HyperlinkColorEnum>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDraws.HyperlinkExtension? CreateModelElement(DXDraw.HyperlinkExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.HyperlinkExtension();
      value.Uri = GetUri(openXmlElement);
      value.HyperlinkColor = GetHyperlinkColor(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.HyperlinkExtension? value)
    where OpenXmlElementType: DXDraw.HyperlinkExtension, new()
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

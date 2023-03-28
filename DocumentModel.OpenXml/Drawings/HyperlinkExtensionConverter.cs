namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the HyperlinkExtension Class converter from/to OpenXml.
///</summary>
public static class HyperlinkExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDraw.HyperlinkExtension openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Uri);
  }
  
  private static bool CmpUri(DXDraw.HyperlinkExtension openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Uri, value, diffs, objName, "Uri");
  }
  
  private static void SetUri(DXDraw.HyperlinkExtension openXmlElement, String? value)
  {
    openXmlElement.Uri = StringValueConverter.CreateStringValue(value);
  }
  
  private static DMDraws.HyperlinkColorEnum? GetHyperlinkColor(DXDraw.HyperlinkExtension openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2019.Drawing.HyperLinkColor.HyperlinkColorEnum, DMDraws.HyperlinkColorEnum>(openXmlElement.GetFirstChild<DXO2019DrawHLnkClr.HyperlinkColor>()?.Val?.Value);
  }
  
  private static bool CmpHyperlinkColor(DXDraw.HyperlinkExtension openXmlElement, DMDraws.HyperlinkColorEnum? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2019.Drawing.HyperLinkColor.HyperlinkColorEnum, DMDraws.HyperlinkColorEnum>(openXmlElement.GetFirstChild<DXO2019DrawHLnkClr.HyperlinkColor>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetHyperlinkColor(DXDraw.HyperlinkExtension openXmlElement, DMDraws.HyperlinkColorEnum? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2019DrawHLnkClr.HyperlinkColor>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Office2019.Drawing.HyperLinkColor.HyperlinkColorEnum, DMDraws.HyperlinkColorEnum>(itemElement, (DMDraws.HyperlinkColorEnum)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXO2019DrawHLnkClr.HyperlinkColor, DocumentFormat.OpenXml.Office2019.Drawing.HyperLinkColor.HyperlinkColorEnum, DMDraws.HyperlinkColorEnum>((DMDraws.HyperlinkColorEnum)value));
  }
  
  public static DocumentModel.Drawings.HyperlinkExtension? CreateModelElement(DXDraw.HyperlinkExtension? openXmlElement)
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
  
  public static bool CompareModelElement(DXDraw.HyperlinkExtension? openXmlElement, DMDraws.HyperlinkExtension? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName))
        ok = false;
      if (!CmpHyperlinkColor(openXmlElement, value.HyperlinkColor, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.HyperlinkExtension value)
    where OpenXmlElementType: DXDraw.HyperlinkExtension, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.HyperlinkExtension openXmlElement, DMDraws.HyperlinkExtension value)
  {
    SetUri(openXmlElement, value?.Uri);
    SetHyperlinkColor(openXmlElement, value?.HyperlinkColor);
  }
}

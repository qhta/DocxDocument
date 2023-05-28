namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the HyperlinkExtension Class.
/// </summary>
public static class HyperlinkExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXD.HyperlinkExtension openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Uri);
  }
  
  private static bool CmpUri(DXD.HyperlinkExtension openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Uri, value, diffs, objName, "Uri");
  }
  
  private static void SetUri(DXD.HyperlinkExtension openXmlElement, String? value)
  {
    openXmlElement.Uri = StringValueConverter.CreateStringValue(value);
  }
  
  private static DMD.HyperlinkColorEnum? GetHyperlinkColor(DXD.HyperlinkExtension openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2019.Drawing.HyperLinkColor.HyperlinkColorEnum, DMD.HyperlinkColorEnum>(openXmlElement.GetFirstChild<DXO19DHLC.HyperlinkColor>()?.Val?.Value);
  }
  
  private static bool CmpHyperlinkColor(DXD.HyperlinkExtension openXmlElement, DMD.HyperlinkColorEnum? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2019.Drawing.HyperLinkColor.HyperlinkColorEnum, DMD.HyperlinkColorEnum>(openXmlElement.GetFirstChild<DXO19DHLC.HyperlinkColor>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetHyperlinkColor(DXD.HyperlinkExtension openXmlElement, DMD.HyperlinkColorEnum? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO19DHLC.HyperlinkColor>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Office2019.Drawing.HyperLinkColor.HyperlinkColorEnum, DMD.HyperlinkColorEnum>(itemElement, (DMD.HyperlinkColorEnum)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXO19DHLC.HyperlinkColor, DocumentFormat.OpenXml.Office2019.Drawing.HyperLinkColor.HyperlinkColorEnum, DMD.HyperlinkColorEnum>((DMD.HyperlinkColorEnum)value));
  }
  
  public static DMD.HyperlinkExtension? CreateModelElement(DXD.HyperlinkExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.HyperlinkExtension();
      value.Uri = GetUri(openXmlElement);
      value.HyperlinkColor = GetHyperlinkColor(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.HyperlinkExtension? openXmlElement, DMD.HyperlinkExtension? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName, propName))
        ok = false;
      if (!CmpHyperlinkColor(openXmlElement, value.HyperlinkColor, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.HyperlinkExtension value)
    where OpenXmlElementType: DXD.HyperlinkExtension, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.HyperlinkExtension openXmlElement, DMD.HyperlinkExtension value)
  {
    SetUri(openXmlElement, value?.Uri);
    SetHyperlinkColor(openXmlElement, value?.HyperlinkColor);
  }
}

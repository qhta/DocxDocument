namespace DocumentModel.OpenXml.Drawings.SVG;

/// <summary>
/// Defines the SVGBlip Class.
/// </summary>
public static class SVGBlipConverter
{
  /// <summary>
  /// Embedded Picture Reference
  /// </summary>
  private static String? GetEmbed(DXO19DSVG.SVGBlip openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Embed);
  }
  
  private static bool CmpEmbed(DXO19DSVG.SVGBlip openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Embed, value, diffs, objName, "Embed");
  }
  
  private static void SetEmbed(DXO19DSVG.SVGBlip openXmlElement, String? value)
  {
    openXmlElement.Embed = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Linked Picture Reference
  /// </summary>
  private static String? GetLink(DXO19DSVG.SVGBlip openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Link);
  }
  
  private static bool CmpLink(DXO19DSVG.SVGBlip openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Link, value, diffs, objName, "Link");
  }
  
  private static void SetLink(DXO19DSVG.SVGBlip openXmlElement, String? value)
  {
    openXmlElement.Link = StringValueConverter.CreateStringValue(value);
  }
  
  public static DMD.SVG.SVGBlip? CreateModelElement(DXO19DSVG.SVGBlip? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.SVG.SVGBlip();
      value.Embed = GetEmbed(openXmlElement);
      value.Link = GetLink(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO19DSVG.SVGBlip? openXmlElement, DMDSVG.SVGBlip? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpEmbed(openXmlElement, value.Embed, diffs, objName, propName))
        ok = false;
      if (!CmpLink(openXmlElement, value.Link, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDSVG.SVGBlip value)
    where OpenXmlElementType: DXO19DSVG.SVGBlip, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO19DSVG.SVGBlip openXmlElement, DMDSVG.SVGBlip value)
  {
    SetEmbed(openXmlElement, value?.Embed);
    SetLink(openXmlElement, value?.Link);
  }
}

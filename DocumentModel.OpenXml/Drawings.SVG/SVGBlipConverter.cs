namespace DocumentModel.OpenXml.Drawings.SVG;

/// <summary>
/// Defines the SVGBlip Class converter from/to OpenXml.
///</summary>
public static class SVGBlipConverter
{
  /// <summary>
  /// Embedded Picture Reference
  /// </summary>
  private static String? GetEmbed(DXO2019DrawSVG.SVGBlip openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Embed);
  }
  
  private static bool CmpEmbed(DXO2019DrawSVG.SVGBlip openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Embed, value, diffs, objName, "Embed");
  }
  
  private static void SetEmbed(DXO2019DrawSVG.SVGBlip openXmlElement, String? value)
  {
    openXmlElement.Embed = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Linked Picture Reference
  /// </summary>
  private static String? GetLink(DXO2019DrawSVG.SVGBlip openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Link);
  }
  
  private static bool CmpLink(DXO2019DrawSVG.SVGBlip openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Link, value, diffs, objName, "Link");
  }
  
  private static void SetLink(DXO2019DrawSVG.SVGBlip openXmlElement, String? value)
  {
    openXmlElement.Link = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.Drawings.SVG.SVGBlip? CreateModelElement(DXO2019DrawSVG.SVGBlip? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.SVG.SVGBlip();
      value.Embed = GetEmbed(openXmlElement);
      value.Link = GetLink(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2019DrawSVG.SVGBlip? openXmlElement, DMDrawsSVG.SVGBlip? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpEmbed(openXmlElement, value.Embed, diffs, objName))
        ok = false;
      if (!CmpLink(openXmlElement, value.Link, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsSVG.SVGBlip value)
    where OpenXmlElementType: DXO2019DrawSVG.SVGBlip, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2019DrawSVG.SVGBlip openXmlElement, DMDrawsSVG.SVGBlip value)
  {
    SetEmbed(openXmlElement, value?.Embed);
    SetLink(openXmlElement, value?.Link);
  }
}

namespace DocumentModel.OpenXml.Drawings.SVG;

/// <summary>
/// Defines the SVGBlip Class.
/// </summary>
public static class SVGBlipConverter
{
  /// <summary>
  /// Embedded Picture Reference
  /// </summary>
  private static String? GetEmbed(DXO2019DrawSVG.SVGBlip openXmlElement)
  {
    return openXmlElement?.Embed?.Value;
  }
  
  private static bool CmpEmbed(DXO2019DrawSVG.SVGBlip openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Embed?.Value == value;
  }
  
  private static void SetEmbed(DXO2019DrawSVG.SVGBlip openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Embed = new StringValue { Value = value };
    else
      openXmlElement.Embed = null;
  }
  
  /// <summary>
  /// Linked Picture Reference
  /// </summary>
  private static String? GetLink(DXO2019DrawSVG.SVGBlip openXmlElement)
  {
    return openXmlElement?.Link?.Value;
  }
  
  private static bool CmpLink(DXO2019DrawSVG.SVGBlip openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Link?.Value == value;
  }
  
  private static void SetLink(DXO2019DrawSVG.SVGBlip openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Link = new StringValue { Value = value };
    else
      openXmlElement.Link = null;
  }
  
  public static DMDrawsSVG.SVGBlip? CreateModelElement(DXO2019DrawSVG.SVGBlip? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsSVG.SVGBlip();
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
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsSVG.SVGBlip? value)
    where OpenXmlElementType: DXO2019DrawSVG.SVGBlip, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetEmbed(openXmlElement, value?.Embed);
      SetLink(openXmlElement, value?.Link);
      return openXmlElement;
    }
    return default;
  }
}

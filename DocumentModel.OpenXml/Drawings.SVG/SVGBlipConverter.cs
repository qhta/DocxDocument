namespace DocumentModel.OpenXml.Drawings.SVG;

/// <summary>
/// Defines the SVGBlip Class.
/// </summary>
public static class SVGBlipConverter
{
  /// <summary>
  /// Embedded Picture Reference
  /// </summary>
  private static String? GetEmbed(DocumentFormat.OpenXml.Office2019.Drawing.SVG.SVGBlip openXmlElement)
  {
    return openXmlElement?.Embed?.Value;
  }
  
  private static void SetEmbed(DocumentFormat.OpenXml.Office2019.Drawing.SVG.SVGBlip openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Embed = new StringValue { Value = value };
    else
      openXmlElement.Embed = null;
  }
  
  /// <summary>
  /// Linked Picture Reference
  /// </summary>
  private static String? GetLink(DocumentFormat.OpenXml.Office2019.Drawing.SVG.SVGBlip openXmlElement)
  {
    return openXmlElement?.Link?.Value;
  }
  
  private static void SetLink(DocumentFormat.OpenXml.Office2019.Drawing.SVG.SVGBlip openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Link = new StringValue { Value = value };
    else
      openXmlElement.Link = null;
  }
  
  public static DocumentModel.Drawings.SVG.SVGBlip? CreateModelElement(DocumentFormat.OpenXml.Office2019.Drawing.SVG.SVGBlip? openXmlElement)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.SVG.SVGBlip? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2019.Drawing.SVG.SVGBlip, new()
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

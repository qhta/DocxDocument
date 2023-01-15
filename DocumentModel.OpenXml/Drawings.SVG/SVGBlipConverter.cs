using DocumentFormat.OpenXml.Office2019.Drawing.SVG;

namespace DocumentModel.OpenXml.Drawings.SVG;

/// <summary>
///   Defines the SVGBlip Class.
/// </summary>
public static class SVGBlipConverter
{
  /// <summary>
  ///   Embedded Picture Reference
  /// </summary>
  public static String? GetEmbed(SVGBlip? openXmlElement)
  {
    return openXmlElement?.Embed?.Value;
  }

  public static void SetEmbed(SVGBlip? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Embed = new StringValue { Value = value };
      else
        openXmlElement.Embed = null;
  }

  /// <summary>
  ///   Linked Picture Reference
  /// </summary>
  public static String? GetLink(SVGBlip? openXmlElement)
  {
    return openXmlElement?.Link?.Value;
  }

  public static void SetLink(SVGBlip? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Link = new StringValue { Value = value };
      else
        openXmlElement.Link = null;
  }

  public static DocumentModel.Drawings.SVG.SVGBlip? CreateModelElement(SVGBlip? openXmlElement)
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
    where OpenXmlElementType : SVGBlip, new()
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
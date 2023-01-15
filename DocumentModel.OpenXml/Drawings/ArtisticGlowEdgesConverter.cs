using DocumentFormat.OpenXml.Office2010.Drawing;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the ArtisticGlowEdges Class.
/// </summary>
public static class ArtisticGlowEdgesConverter
{
  /// <summary>
  ///   trans, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetTransparancy(ArtisticGlowEdges? openXmlElement)
  {
    return openXmlElement?.Transparancy?.Value;
  }

  public static void SetTransparancy(ArtisticGlowEdges? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Transparancy = value;
  }

  /// <summary>
  ///   smoothness, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetSmoothness(ArtisticGlowEdges? openXmlElement)
  {
    return openXmlElement?.Smoothness?.Value;
  }

  public static void SetSmoothness(ArtisticGlowEdges? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Smoothness = value;
  }

  public static DocumentModel.Drawings.ArtisticGlowEdges? CreateModelElement(ArtisticGlowEdges? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ArtisticGlowEdges();
      value.Transparancy = GetTransparancy(openXmlElement);
      value.Smoothness = GetSmoothness(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ArtisticGlowEdges? value)
    where OpenXmlElementType : ArtisticGlowEdges, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTransparancy(openXmlElement, value?.Transparancy);
      SetSmoothness(openXmlElement, value?.Smoothness);
      return openXmlElement;
    }
    return default;
  }
}
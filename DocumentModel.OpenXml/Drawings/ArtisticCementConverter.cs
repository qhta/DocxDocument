using DocumentFormat.OpenXml.Office2010.Drawing;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the ArtisticCement Class.
/// </summary>
public static class ArtisticCementConverter
{
  /// <summary>
  ///   trans, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetTransparancy(ArtisticCement? openXmlElement)
  {
    return openXmlElement?.Transparancy?.Value;
  }

  public static void SetTransparancy(ArtisticCement? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Transparancy = value;
  }

  /// <summary>
  ///   crackSpacing, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetCrackSpacing(ArtisticCement? openXmlElement)
  {
    return openXmlElement?.CrackSpacing?.Value;
  }

  public static void SetCrackSpacing(ArtisticCement? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.CrackSpacing = value;
  }

  public static DocumentModel.Drawings.ArtisticCement? CreateModelElement(ArtisticCement? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ArtisticCement();
      value.Transparancy = GetTransparancy(openXmlElement);
      value.CrackSpacing = GetCrackSpacing(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ArtisticCement? value)
    where OpenXmlElementType : ArtisticCement, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTransparancy(openXmlElement, value?.Transparancy);
      SetCrackSpacing(openXmlElement, value?.CrackSpacing);
      return openXmlElement;
    }
    return default;
  }
}
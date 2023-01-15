using DocumentFormat.OpenXml.Office2010.Drawing;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the ArtisticTexturizer Class.
/// </summary>
public static class ArtisticTexturizerConverter
{
  /// <summary>
  ///   trans, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetTransparancy(ArtisticTexturizer? openXmlElement)
  {
    return openXmlElement?.Transparancy?.Value;
  }

  public static void SetTransparancy(ArtisticTexturizer? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Transparancy = value;
  }

  /// <summary>
  ///   scaling, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetScaling(ArtisticTexturizer? openXmlElement)
  {
    return openXmlElement?.Scaling?.Value;
  }

  public static void SetScaling(ArtisticTexturizer? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Scaling = value;
  }

  public static DocumentModel.Drawings.ArtisticTexturizer? CreateModelElement(ArtisticTexturizer? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ArtisticTexturizer();
      value.Transparancy = GetTransparancy(openXmlElement);
      value.Scaling = GetScaling(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ArtisticTexturizer? value)
    where OpenXmlElementType : ArtisticTexturizer, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTransparancy(openXmlElement, value?.Transparancy);
      SetScaling(openXmlElement, value?.Scaling);
      return openXmlElement;
    }
    return default;
  }
}
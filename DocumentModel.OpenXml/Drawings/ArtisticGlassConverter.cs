using DocumentFormat.OpenXml.Office2010.Drawing;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the ArtisticGlass Class.
/// </summary>
public static class ArtisticGlassConverter
{
  /// <summary>
  ///   trans, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetTransparancy(ArtisticGlass? openXmlElement)
  {
    return openXmlElement?.Transparancy?.Value;
  }

  public static void SetTransparancy(ArtisticGlass? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Transparancy = value;
  }

  /// <summary>
  ///   scaling, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetScaling(ArtisticGlass? openXmlElement)
  {
    return openXmlElement?.Scaling?.Value;
  }

  public static void SetScaling(ArtisticGlass? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Scaling = value;
  }

  public static DocumentModel.Drawings.ArtisticGlass? CreateModelElement(ArtisticGlass? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ArtisticGlass();
      value.Transparancy = GetTransparancy(openXmlElement);
      value.Scaling = GetScaling(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ArtisticGlass? value)
    where OpenXmlElementType : ArtisticGlass, new()
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
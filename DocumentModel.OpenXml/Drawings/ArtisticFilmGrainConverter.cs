using DocumentFormat.OpenXml.Office2010.Drawing;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the ArtisticFilmGrain Class.
/// </summary>
public static class ArtisticFilmGrainConverter
{
  /// <summary>
  ///   trans, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetTransparancy(ArtisticFilmGrain? openXmlElement)
  {
    return openXmlElement?.Transparancy?.Value;
  }

  public static void SetTransparancy(ArtisticFilmGrain? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Transparancy = value;
  }

  /// <summary>
  ///   grainSize, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetGrainSize(ArtisticFilmGrain? openXmlElement)
  {
    return openXmlElement?.GrainSize?.Value;
  }

  public static void SetGrainSize(ArtisticFilmGrain? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.GrainSize = value;
  }

  public static DocumentModel.Drawings.ArtisticFilmGrain? CreateModelElement(ArtisticFilmGrain? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ArtisticFilmGrain();
      value.Transparancy = GetTransparancy(openXmlElement);
      value.GrainSize = GetGrainSize(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ArtisticFilmGrain? value)
    where OpenXmlElementType : ArtisticFilmGrain, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTransparancy(openXmlElement, value?.Transparancy);
      SetGrainSize(openXmlElement, value?.GrainSize);
      return openXmlElement;
    }
    return default;
  }
}
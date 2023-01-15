using DocumentFormat.OpenXml.Office2010.Drawing;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the ArtisticMarker Class.
/// </summary>
public static class ArtisticMarkerConverter
{
  /// <summary>
  ///   trans, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetTransparancy(ArtisticMarker? openXmlElement)
  {
    return openXmlElement?.Transparancy?.Value;
  }

  public static void SetTransparancy(ArtisticMarker? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Transparancy = value;
  }

  /// <summary>
  ///   size, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetSize(ArtisticMarker? openXmlElement)
  {
    return openXmlElement?.Size?.Value;
  }

  public static void SetSize(ArtisticMarker? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Size = value;
  }

  public static DocumentModel.Drawings.ArtisticMarker? CreateModelElement(ArtisticMarker? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ArtisticMarker();
      value.Transparancy = GetTransparancy(openXmlElement);
      value.Size = GetSize(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ArtisticMarker? value)
    where OpenXmlElementType : ArtisticMarker, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTransparancy(openXmlElement, value?.Transparancy);
      SetSize(openXmlElement, value?.Size);
      return openXmlElement;
    }
    return default;
  }
}
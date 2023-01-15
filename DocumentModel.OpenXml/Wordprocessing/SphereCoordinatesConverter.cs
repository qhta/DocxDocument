using DocumentFormat.OpenXml.Office2010.Word;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the SphereCoordinates Class.
/// </summary>
public static class SphereCoordinatesConverter
{
  /// <summary>
  ///   lat, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetLattitude(SphereCoordinates? openXmlElement)
  {
    return openXmlElement?.Lattitude?.Value;
  }

  public static void SetLattitude(SphereCoordinates? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Lattitude = value;
  }

  /// <summary>
  ///   lon, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetLongitude(SphereCoordinates? openXmlElement)
  {
    return openXmlElement?.Longitude?.Value;
  }

  public static void SetLongitude(SphereCoordinates? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Longitude = value;
  }

  /// <summary>
  ///   rev, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetRevolution(SphereCoordinates? openXmlElement)
  {
    return openXmlElement?.Revolution?.Value;
  }

  public static void SetRevolution(SphereCoordinates? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Revolution = value;
  }

  public static DocumentModel.Wordprocessing.SphereCoordinates? CreateModelElement(SphereCoordinates? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.SphereCoordinates();
      value.Lattitude = GetLattitude(openXmlElement);
      value.Longitude = GetLongitude(openXmlElement);
      value.Revolution = GetRevolution(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.SphereCoordinates? value)
    where OpenXmlElementType : SphereCoordinates, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLattitude(openXmlElement, value?.Lattitude);
      SetLongitude(openXmlElement, value?.Longitude);
      SetRevolution(openXmlElement, value?.Revolution);
      return openXmlElement;
    }
    return default;
  }
}
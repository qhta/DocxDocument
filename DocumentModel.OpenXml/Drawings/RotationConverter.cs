using DocumentFormat.OpenXml.Drawing;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Rotation.
/// </summary>
public static class RotationConverter
{
  /// <summary>
  ///   Latitude
  /// </summary>
  public static Int32? GetLatitude(Rotation? openXmlElement)
  {
    return openXmlElement?.Latitude?.Value;
  }

  public static void SetLatitude(Rotation? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Latitude = value;
  }

  /// <summary>
  ///   Longitude
  /// </summary>
  public static Int32? GetLongitude(Rotation? openXmlElement)
  {
    return openXmlElement?.Longitude?.Value;
  }

  public static void SetLongitude(Rotation? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Longitude = value;
  }

  /// <summary>
  ///   Revolution
  /// </summary>
  public static Int32? GetRevolution(Rotation? openXmlElement)
  {
    return openXmlElement?.Revolution?.Value;
  }

  public static void SetRevolution(Rotation? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Revolution = value;
  }

  public static DocumentModel.Drawings.Rotation? CreateModelElement(Rotation? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Rotation();
      value.Latitude = GetLatitude(openXmlElement);
      value.Longitude = GetLongitude(openXmlElement);
      value.Revolution = GetRevolution(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Rotation? value)
    where OpenXmlElementType : Rotation, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLatitude(openXmlElement, value?.Latitude);
      SetLongitude(openXmlElement, value?.Longitude);
      SetRevolution(openXmlElement, value?.Revolution);
      return openXmlElement;
    }
    return default;
  }
}
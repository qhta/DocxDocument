namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Rotation.
/// </summary>
public static class RotationConverter
{
  /// <summary>
  /// Latitude
  /// </summary>
  private static Int32? GetLatitude(DXDraw.Rotation openXmlElement)
  {
    return openXmlElement.Latitude?.Value;
  }
  
  private static void SetLatitude(DXDraw.Rotation openXmlElement, Int32? value)
  {
    openXmlElement.Latitude = value;
  }
  
  /// <summary>
  /// Longitude
  /// </summary>
  private static Int32? GetLongitude(DXDraw.Rotation openXmlElement)
  {
    return openXmlElement.Longitude?.Value;
  }
  
  private static void SetLongitude(DXDraw.Rotation openXmlElement, Int32? value)
  {
    openXmlElement.Longitude = value;
  }
  
  /// <summary>
  /// Revolution
  /// </summary>
  private static Int32? GetRevolution(DXDraw.Rotation openXmlElement)
  {
    return openXmlElement.Revolution?.Value;
  }
  
  private static void SetRevolution(DXDraw.Rotation openXmlElement, Int32? value)
  {
    openXmlElement.Revolution = value;
  }
  
  public static DMDraws.Rotation? CreateModelElement(DXDraw.Rotation? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.Rotation();
      value.Latitude = GetLatitude(openXmlElement);
      value.Longitude = GetLongitude(openXmlElement);
      value.Revolution = GetRevolution(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.Rotation? value)
    where OpenXmlElementType: DXDraw.Rotation, new()
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

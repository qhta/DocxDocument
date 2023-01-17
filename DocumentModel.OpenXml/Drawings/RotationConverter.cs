namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Rotation.
/// </summary>
public static class RotationConverter
{
  /// <summary>
  /// Latitude
  /// </summary>
  private static Int32? GetLatitude(DocumentFormat.OpenXml.Drawing.Rotation openXmlElement)
  {
    return openXmlElement.Latitude?.Value;
  }
  
  private static void SetLatitude(DocumentFormat.OpenXml.Drawing.Rotation openXmlElement, Int32? value)
  {
    openXmlElement.Latitude = value;
  }
  
  /// <summary>
  /// Longitude
  /// </summary>
  private static Int32? GetLongitude(DocumentFormat.OpenXml.Drawing.Rotation openXmlElement)
  {
    return openXmlElement.Longitude?.Value;
  }
  
  private static void SetLongitude(DocumentFormat.OpenXml.Drawing.Rotation openXmlElement, Int32? value)
  {
    openXmlElement.Longitude = value;
  }
  
  /// <summary>
  /// Revolution
  /// </summary>
  private static Int32? GetRevolution(DocumentFormat.OpenXml.Drawing.Rotation openXmlElement)
  {
    return openXmlElement.Revolution?.Value;
  }
  
  private static void SetRevolution(DocumentFormat.OpenXml.Drawing.Rotation openXmlElement, Int32? value)
  {
    openXmlElement.Revolution = value;
  }
  
  public static DocumentModel.Drawings.Rotation? CreateModelElement(DocumentFormat.OpenXml.Drawing.Rotation? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Rotation, new()
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

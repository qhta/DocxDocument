namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Rotation.
/// </summary>
public static class RotationConverter
{
  /// <summary>
  /// Latitude
  /// </summary>
  public static Int32? GetLatitude(DocumentFormat.OpenXml.Drawing.Rotation? openXmlElement)
  {
    return openXmlElement?.Latitude?.Value;
  }
  
  public static void SetLatitude(DocumentFormat.OpenXml.Drawing.Rotation? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Latitude = value;
  }
  
  /// <summary>
  /// Longitude
  /// </summary>
  public static Int32? GetLongitude(DocumentFormat.OpenXml.Drawing.Rotation? openXmlElement)
  {
    return openXmlElement?.Longitude?.Value;
  }
  
  public static void SetLongitude(DocumentFormat.OpenXml.Drawing.Rotation? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Longitude = value;
  }
  
  /// <summary>
  /// Revolution
  /// </summary>
  public static Int32? GetRevolution(DocumentFormat.OpenXml.Drawing.Rotation? openXmlElement)
  {
    return openXmlElement?.Revolution?.Value;
  }
  
  public static void SetRevolution(DocumentFormat.OpenXml.Drawing.Rotation? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}

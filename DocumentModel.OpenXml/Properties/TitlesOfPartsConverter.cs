namespace DocumentModel.OpenXml.Properties;

/// <summary>
/// Part Titles.
/// </summary>
public static class TitlesOfPartsConverter
{
  /// <summary>
  /// Vector.
  /// </summary>
  public static DocumentModel.VectorVariant? GetVTVector(DocumentFormat.OpenXml.ExtendedProperties.TitlesOfParts? openXmlElement)
  {
    return VTVectorConverter.GetValue(openXmlElement?.VTVector);
  }
  
  public static void SetVTVector(DocumentFormat.OpenXml.ExtendedProperties.TitlesOfParts? openXmlElement, DocumentModel.VectorVariant? value)
  {
    if (openXmlElement != null)
      openXmlElement.VTVector = VTVectorConverter.CreateOpenXmlElement(value);
  }
  
  public static DocumentModel.VectorVariant? CreateModelElement(DocumentFormat.OpenXml.ExtendedProperties.TitlesOfParts? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = GetVTVector(openXmlElement);
      return value;
    }
    return null;
  }
  
  
  public static DocumentFormat.OpenXml.ExtendedProperties.TitlesOfParts? CreateOpenXmlElement(DocumentModel.VectorVariant? value)
  {
    if (value != null)
    {
      var openXmlElement = new DocumentFormat.OpenXml.ExtendedProperties.TitlesOfParts();
      SetVTVector(openXmlElement, value);
      return openXmlElement;
    }
    return null;
  }
}

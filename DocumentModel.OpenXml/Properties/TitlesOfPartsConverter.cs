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
  
  public static DocumentModel.Properties.TitlesOfParts? GetValue(DocumentFormat.OpenXml.ExtendedProperties.TitlesOfParts? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Properties.TitlesOfParts();
      value.VTVector = GetVTVector(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static void SetValue(DocumentFormat.OpenXml.ExtendedProperties.TitlesOfParts? openXmlElement, DocumentModel.Properties.TitlesOfParts? value)
  {
    if (openXmlElement != null)
    {
      SetVTVector(openXmlElement, value?.VTVector);
    }
  }
  
  public static DocumentFormat.OpenXml.ExtendedProperties.TitlesOfParts? CreateOpenXmlElement(DocumentModel.Properties.TitlesOfParts? value)
  {
    if (value != null)
    {
      var openXmlElement = new DocumentFormat.OpenXml.ExtendedProperties.TitlesOfParts();
      SetValue(openXmlElement, value);
      return openXmlElement;
    }
    return null;
  }
}

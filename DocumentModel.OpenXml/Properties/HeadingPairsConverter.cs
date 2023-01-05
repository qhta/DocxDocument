namespace DocumentModel.OpenXml.Properties;

/// <summary>
/// Heading Pairs.
/// </summary>
public static class HeadingPairsConverter
{
  public static DocumentModel.VectorVariant? GetVTVector(DocumentFormat.OpenXml.ExtendedProperties.HeadingPairs? openXmlElement)
  {
    return VTVectorConverter.GetValue(openXmlElement?.VTVector);
  }
  
  public static void SetVTVector(DocumentFormat.OpenXml.ExtendedProperties.HeadingPairs? openXmlElement, DocumentModel.VectorVariant? value)
  {
    if (openXmlElement != null)
      openXmlElement.VTVector = VTVectorConverter.CreateOpenXmlElement(value);
  }
  
  public static DocumentModel.VectorVariant? GetValue(DocumentFormat.OpenXml.ExtendedProperties.HeadingPairs? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = GetVTVector(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static void SetValue(DocumentFormat.OpenXml.ExtendedProperties.HeadingPairs? openXmlElement, DocumentModel.VectorVariant? value)
  {
    if (openXmlElement != null)
    {
      SetVTVector(openXmlElement, value);
    }
  }
  
  public static DocumentFormat.OpenXml.ExtendedProperties.HeadingPairs? CreateOpenXmlElement(DocumentModel.VectorVariant? value)
  {
    if (value != null)
    {
      var openXmlElement = new DocumentFormat.OpenXml.ExtendedProperties.HeadingPairs();
      SetValue(openXmlElement, value);
      return openXmlElement;
    }
    return null;
  }
}

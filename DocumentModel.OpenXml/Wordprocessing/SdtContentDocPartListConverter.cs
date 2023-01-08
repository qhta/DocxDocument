namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the SdtContentDocPartList Class.
/// </summary>
public static class SdtContentDocPartListConverter
{
  public static String? GetDocPartGallery(DocumentFormat.OpenXml.Wordprocessing.SdtContentDocPartList? openXmlElement)
  {
    return openXmlElement?.DocPartGallery?.Val?.Value;
  }
  
  public static void SetDocPartGallery(DocumentFormat.OpenXml.Wordprocessing.SdtContentDocPartList? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static String? GetDocPartCategory(DocumentFormat.OpenXml.Wordprocessing.SdtContentDocPartList? openXmlElement)
  {
    return openXmlElement?.DocPartCategory?.Val?.Value;
  }
  
  public static void SetDocPartCategory(DocumentFormat.OpenXml.Wordprocessing.SdtContentDocPartList? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetDocPartUnique(DocumentFormat.OpenXml.Wordprocessing.SdtContentDocPartList? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDocPartUnique(DocumentFormat.OpenXml.Wordprocessing.SdtContentDocPartList? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}

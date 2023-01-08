namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the SdtContentDocPartObject Class.
/// </summary>
public static class SdtContentDocPartObjectConverter
{
  public static String? GetDocPartGallery(DocumentFormat.OpenXml.Wordprocessing.SdtContentDocPartObject? openXmlElement)
  {
    return openXmlElement?.DocPartGallery?.Val?.Value;
  }
  
  public static void SetDocPartGallery(DocumentFormat.OpenXml.Wordprocessing.SdtContentDocPartObject? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static String? GetDocPartCategory(DocumentFormat.OpenXml.Wordprocessing.SdtContentDocPartObject? openXmlElement)
  {
    return openXmlElement?.DocPartCategory?.Val?.Value;
  }
  
  public static void SetDocPartCategory(DocumentFormat.OpenXml.Wordprocessing.SdtContentDocPartObject? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetDocPartUnique(DocumentFormat.OpenXml.Wordprocessing.SdtContentDocPartObject? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDocPartUnique(DocumentFormat.OpenXml.Wordprocessing.SdtContentDocPartObject? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}

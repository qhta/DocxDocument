namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the SdtDocPartType Class.
/// </summary>
public static class SdtDocPartTypeConverter
{
  /// <summary>
  /// Document Part Gallery Filter.
  /// </summary>
  public static String? GetDocPartGallery(DocumentFormat.OpenXml.Wordprocessing.SdtDocPartType? openXmlElement)
  {
    return openXmlElement?.DocPartGallery?.Val?.Value;
  }
  
  public static void SetDocPartGallery(DocumentFormat.OpenXml.Wordprocessing.SdtDocPartType? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Document Part Category Filter.
  /// </summary>
  public static String? GetDocPartCategory(DocumentFormat.OpenXml.Wordprocessing.SdtDocPartType? openXmlElement)
  {
    return openXmlElement?.DocPartCategory?.Val?.Value;
  }
  
  public static void SetDocPartCategory(DocumentFormat.OpenXml.Wordprocessing.SdtDocPartType? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Built-In Document Part.
  /// </summary>
  public static Boolean? GetDocPartUnique(DocumentFormat.OpenXml.Wordprocessing.SdtDocPartType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDocPartUnique(DocumentFormat.OpenXml.Wordprocessing.SdtDocPartType? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}

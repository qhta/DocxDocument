namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the SdtPlaceholder Class.
/// </summary>
public static class SdtPlaceholderConverter
{
  /// <summary>
  /// Document Part Reference.
  /// </summary>
  public static String? GetDocPartReference(DocumentFormat.OpenXml.Wordprocessing.SdtPlaceholder? openXmlElement)
  {
    return openXmlElement?.DocPartReference?.Val?.Value;
  }
  
  public static void SetDocPartReference(DocumentFormat.OpenXml.Wordprocessing.SdtPlaceholder? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}

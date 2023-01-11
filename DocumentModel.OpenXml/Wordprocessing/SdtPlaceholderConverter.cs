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
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.DocPartReference = new DocumentFormat.OpenXml.Wordprocessing.DocPartReference { Val = value };
      else
        openXmlElement.DocPartReference = null;
    }
  }
  
  public static DocumentModel.Wordprocessing.SdtPlaceholder? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.SdtPlaceholder? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.SdtPlaceholder();
      value.DocPartReference = GetDocPartReference(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.SdtPlaceholder? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.SdtPlaceholder, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}

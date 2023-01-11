namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the ContentPart Class.
/// </summary>
public static class ContentPartConverter
{
  /// <summary>
  /// id
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Wordprocessing.ContentPart? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  public static void SetId(DocumentFormat.OpenXml.Wordprocessing.ContentPart? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }
  
  public static DocumentModel.Wordprocessing.ContentPart? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.ContentPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.ContentPart();
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.ContentPart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.ContentPart, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the MarkupType Class.
/// </summary>
public static class MarkupType2Converter
{
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Office2010.Word.MarkupType? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  public static void SetId(DocumentFormat.OpenXml.Office2010.Word.MarkupType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }
  
  public static DocumentModel.Wordprocessing.MarkupType2? CreateModelElement(DocumentFormat.OpenXml.Office2010.Word.MarkupType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.MarkupType2();
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.MarkupType2? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.Word.MarkupType, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}

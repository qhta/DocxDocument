namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the LineJoinMiterProperties Class.
/// </summary>
public static class LineJoinMiterPropertiesConverter
{
  /// <summary>
  /// lim, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetLimit(DocumentFormat.OpenXml.Office2010.Word.LineJoinMiterProperties openXmlElement)
  {
    return openXmlElement.Limit?.Value;
  }
  
  private static void SetLimit(DocumentFormat.OpenXml.Office2010.Word.LineJoinMiterProperties openXmlElement, Int32? value)
  {
    openXmlElement.Limit = value;
  }
  
  public static DocumentModel.Wordprocessing.LineJoinMiterProperties? CreateModelElement(DocumentFormat.OpenXml.Office2010.Word.LineJoinMiterProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.LineJoinMiterProperties();
      value.Limit = GetLimit(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.LineJoinMiterProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.Word.LineJoinMiterProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLimit(openXmlElement, value?.Limit);
      return openXmlElement;
    }
    return default;
  }
}

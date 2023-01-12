namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Entry Name.
/// </summary>
public static class DocPartNameConverter
{
  /// <summary>
  /// Name Value
  /// </summary>
  public static String? GetVal(DocumentFormat.OpenXml.Wordprocessing.DocPartName? openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }
  
  public static void SetVal(DocumentFormat.OpenXml.Wordprocessing.DocPartName? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Val = new StringValue { Value = value };
      else
        openXmlElement.Val = null;
  }
  
  /// <summary>
  /// Built-In Entry
  /// </summary>
  public static Boolean? GetDecorated(DocumentFormat.OpenXml.Wordprocessing.DocPartName? openXmlElement)
  {
    return openXmlElement?.Decorated?.Value;
  }
  
  public static void SetDecorated(DocumentFormat.OpenXml.Wordprocessing.DocPartName? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Decorated = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.Decorated = null;
  }
  
  public static DocumentModel.Wordprocessing.DocPartName? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.DocPartName? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.DocPartName();
      value.Val = GetVal(openXmlElement);
      value.Decorated = GetDecorated(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.DocPartName? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.DocPartName, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetVal(openXmlElement, value?.Val);
      SetDecorated(openXmlElement, value?.Decorated);
      return openXmlElement;
    }
    return default;
  }
}

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the SdtContentText Class.
/// </summary>
public static class SdtContentTextConverter
{
  /// <summary>
  /// Allow Soft Line Breaks
  /// </summary>
  public static Boolean? GetMultiLine(DocumentFormat.OpenXml.Wordprocessing.SdtContentText? openXmlElement)
  {
    return openXmlElement?.MultiLine?.Value;
  }
  
  public static void SetMultiLine(DocumentFormat.OpenXml.Wordprocessing.SdtContentText? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.MultiLine = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.MultiLine = null;
  }
  
  public static DocumentModel.Wordprocessing.SdtContentText? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.SdtContentText? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.SdtContentText();
      value.MultiLine = GetMultiLine(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.SdtContentText? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.SdtContentText, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetMultiLine(openXmlElement, value?.MultiLine);
      return openXmlElement;
    }
    return default;
  }
}

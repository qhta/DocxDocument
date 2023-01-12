namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the FitText Class.
/// </summary>
public static class FitTextConverter
{
  /// <summary>
  /// Value
  /// </summary>
  public static UInt32? GetVal(DocumentFormat.OpenXml.Wordprocessing.FitText? openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }
  
  public static void SetVal(DocumentFormat.OpenXml.Wordprocessing.FitText? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Val = value;
  }
  
  /// <summary>
  /// Fit Text Run ID
  /// </summary>
  public static Int32? GetId(DocumentFormat.OpenXml.Wordprocessing.FitText? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  public static void SetId(DocumentFormat.OpenXml.Wordprocessing.FitText? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Id = value;
  }
  
  public static DocumentModel.Wordprocessing.FitText? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.FitText? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.FitText();
      value.Val = GetVal(openXmlElement);
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.FitText? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.FitText, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetVal(openXmlElement, value?.Val);
      SetId(openXmlElement, value?.Id);
      return openXmlElement;
    }
    return default;
  }
}

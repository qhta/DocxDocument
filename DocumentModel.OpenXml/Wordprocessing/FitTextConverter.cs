namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the FitText Class.
/// </summary>
public static class FitTextConverter
{
  /// <summary>
  /// Value
  /// </summary>
  private static UInt32? GetVal(DocumentFormat.OpenXml.Wordprocessing.FitText openXmlElement)
  {
    return openXmlElement.Val?.Value;
  }
  
  private static void SetVal(DocumentFormat.OpenXml.Wordprocessing.FitText openXmlElement, UInt32? value)
  {
    openXmlElement.Val = value;
  }
  
  /// <summary>
  /// Fit Text Run ID
  /// </summary>
  private static Int32? GetId(DocumentFormat.OpenXml.Wordprocessing.FitText openXmlElement)
  {
    return openXmlElement.Id?.Value;
  }
  
  private static void SetId(DocumentFormat.OpenXml.Wordprocessing.FitText openXmlElement, Int32? value)
  {
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

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Custom XSL Transform To Use When Saving As XML File.
/// </summary>
public static class SaveThroughXsltConverter
{
  /// <summary>
  /// XSL Transformation Location
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Wordprocessing.SaveThroughXslt? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  public static void SetId(DocumentFormat.OpenXml.Wordprocessing.SaveThroughXslt? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }
  
  /// <summary>
  /// Local Identifier for XSL Transform
  /// </summary>
  public static String? GetSolutionId(DocumentFormat.OpenXml.Wordprocessing.SaveThroughXslt? openXmlElement)
  {
    return openXmlElement?.SolutionId?.Value;
  }
  
  public static void SetSolutionId(DocumentFormat.OpenXml.Wordprocessing.SaveThroughXslt? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.SolutionId = new StringValue { Value = value };
      else
        openXmlElement.SolutionId = null;
  }
  
  public static DocumentModel.Wordprocessing.SaveThroughXslt? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.SaveThroughXslt? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.SaveThroughXslt();
      value.Id = GetId(openXmlElement);
      value.SolutionId = GetSolutionId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.SaveThroughXslt? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.SaveThroughXslt, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetSolutionId(openXmlElement, value?.SolutionId);
      return openXmlElement;
    }
    return default;
  }
}

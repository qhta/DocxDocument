namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the ToolbarData Class.
/// </summary>
public static class ToolbarDataConverter
{
  /// <summary>
  /// id
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Office.Word.ToolbarData? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  public static void SetId(DocumentFormat.OpenXml.Office.Word.ToolbarData? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }
  
  public static DocumentModel.Wordprocessing.ToolbarData? CreateModelElement(DocumentFormat.OpenXml.Office.Word.ToolbarData? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.ToolbarData();
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.ToolbarData? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office.Word.ToolbarData, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}

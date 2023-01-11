namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Combo Box List Item.
/// </summary>
public static class ListItemConverter
{
  /// <summary>
  /// List Entry Display Text
  /// </summary>
  public static String? GetDisplayText(DocumentFormat.OpenXml.Wordprocessing.ListItem? openXmlElement)
  {
    return openXmlElement?.DisplayText?.Value;
  }
  
  public static void SetDisplayText(DocumentFormat.OpenXml.Wordprocessing.ListItem? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.DisplayText = new StringValue { Value = value };
      else
        openXmlElement.DisplayText = null;
  }
  
  /// <summary>
  /// List Entry Value
  /// </summary>
  public static String? GetValue(DocumentFormat.OpenXml.Wordprocessing.ListItem? openXmlElement)
  {
    return openXmlElement?.Value?.Value;
  }
  
  public static void SetValue(DocumentFormat.OpenXml.Wordprocessing.ListItem? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Value = new StringValue { Value = value };
      else
        openXmlElement.Value = null;
  }
  
  public static DocumentModel.Wordprocessing.ListItem? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.ListItem? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.ListItem();
      value.DisplayText = GetDisplayText(openXmlElement);
      value.Value = GetValue(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.ListItem? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.ListItem, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}

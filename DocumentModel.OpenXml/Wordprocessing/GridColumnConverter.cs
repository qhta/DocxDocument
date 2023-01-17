namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Grid Column Definition.
/// </summary>
public static class GridColumnConverter
{
  /// <summary>
  /// Grid Column Width
  /// </summary>
  private static String? GetWidth(DocumentFormat.OpenXml.Wordprocessing.GridColumn openXmlElement)
  {
    return openXmlElement?.Width?.Value;
  }
  
  private static void SetWidth(DocumentFormat.OpenXml.Wordprocessing.GridColumn openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Width = new StringValue { Value = value };
    else
      openXmlElement.Width = null;
  }
  
  public static DocumentModel.Wordprocessing.GridColumn? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.GridColumn? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.GridColumn();
      value.Width = GetWidth(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.GridColumn? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.GridColumn, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetWidth(openXmlElement, value?.Width);
      return openXmlElement;
    }
    return default;
  }
}

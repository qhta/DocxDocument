namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Single Column Definition.
/// </summary>
public static class ColumnConverter
{
  /// <summary>
  /// Column Width
  /// </summary>
  public static String? GetWidth(DocumentFormat.OpenXml.Wordprocessing.Column? openXmlElement)
  {
    return openXmlElement?.Width?.Value;
  }
  
  public static void SetWidth(DocumentFormat.OpenXml.Wordprocessing.Column? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Width = new StringValue { Value = value };
      else
        openXmlElement.Width = null;
  }
  
  /// <summary>
  /// Space Before Following Column
  /// </summary>
  public static String? GetSpace(DocumentFormat.OpenXml.Wordprocessing.Column? openXmlElement)
  {
    return openXmlElement?.Space?.Value;
  }
  
  public static void SetSpace(DocumentFormat.OpenXml.Wordprocessing.Column? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Space = new StringValue { Value = value };
      else
        openXmlElement.Space = null;
  }
  
  public static DocumentModel.Wordprocessing.Column? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.Column? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Column();
      value.Width = GetWidth(openXmlElement);
      value.Space = GetSpace(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Column? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.Column, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetWidth(openXmlElement, value?.Width);
      SetSpace(openXmlElement, value?.Space);
      return openXmlElement;
    }
    return default;
  }
}

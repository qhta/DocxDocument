namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Miter Line Join.
/// </summary>
public static class MiterConverter
{
  /// <summary>
  /// Miter Join Limit
  /// </summary>
  private static Int32? GetLimit(DocumentFormat.OpenXml.Drawing.Miter openXmlElement)
  {
    return openXmlElement.Limit?.Value;
  }
  
  private static void SetLimit(DocumentFormat.OpenXml.Drawing.Miter openXmlElement, Int32? value)
  {
    openXmlElement.Limit = value;
  }
  
  public static DocumentModel.Drawings.Miter? CreateModelElement(DocumentFormat.OpenXml.Drawing.Miter? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Miter();
      value.Limit = GetLimit(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Miter? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Miter, new()
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

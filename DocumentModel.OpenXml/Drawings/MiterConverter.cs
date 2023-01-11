namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Miter Line Join.
/// </summary>
public static class MiterConverter
{
  /// <summary>
  /// Miter Join Limit
  /// </summary>
  public static Int32? GetLimit(DocumentFormat.OpenXml.Drawing.Miter? openXmlElement)
  {
    return openXmlElement?.Limit?.Value;
  }
  
  public static void SetLimit(DocumentFormat.OpenXml.Drawing.Miter? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}

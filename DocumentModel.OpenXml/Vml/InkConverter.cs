namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Ink.
/// </summary>
public static class InkConverter
{
  /// <summary>
  /// Ink Data
  /// </summary>
  private static Byte[]? GetInkData(DocumentFormat.OpenXml.Vml.Office.Ink openXmlElement)
  {
    if (openXmlElement.InkData?.Value != null)
      return Convert.FromBase64String(openXmlElement.InkData.Value);
    return null;
  }
  
  private static void SetInkData(DocumentFormat.OpenXml.Vml.Office.Ink openXmlElement, Byte[]? value)
  {
    if (value != null)
      openXmlElement.InkData = Convert.ToBase64String(value);
    else
      openXmlElement.InkData = null;
  }
  
  /// <summary>
  /// Annotation Flag
  /// </summary>
  private static Boolean? GetAnnotationFlag(DocumentFormat.OpenXml.Vml.Office.Ink openXmlElement)
  {
    return openXmlElement?.AnnotationFlag?.Value;
  }
  
  private static void SetAnnotationFlag(DocumentFormat.OpenXml.Vml.Office.Ink openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AnnotationFlag = value;
    else
      openXmlElement.AnnotationFlag = null;
  }
  
  public static DocumentModel.Vml.Ink? CreateModelElement(DocumentFormat.OpenXml.Vml.Office.Ink? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.Ink();
      value.InkData = GetInkData(openXmlElement);
      value.AnnotationFlag = GetAnnotationFlag(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Vml.Ink? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Vml.Office.Ink, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetInkData(openXmlElement, value?.InkData);
      SetAnnotationFlag(openXmlElement, value?.AnnotationFlag);
      return openXmlElement;
    }
    return default;
  }
}

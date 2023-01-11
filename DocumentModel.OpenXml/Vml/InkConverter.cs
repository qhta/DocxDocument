namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Ink.
/// </summary>
public static class InkConverter
{
  /// <summary>
  /// Ink Data
  /// </summary>
  public static DocumentModel.Base64Binary? GetInkData(DocumentFormat.OpenXml.Vml.Office.Ink? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Base64BinaryValue");
  }
  
  public static void SetInkData(DocumentFormat.OpenXml.Vml.Office.Ink? openXmlElement, DocumentModel.Base64Binary? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Base64BinaryValue");
  }
  
  /// <summary>
  /// Annotation Flag
  /// </summary>
  public static Boolean? GetAnnotationFlag(DocumentFormat.OpenXml.Vml.Office.Ink? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetAnnotationFlag(DocumentFormat.OpenXml.Vml.Office.Ink? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}

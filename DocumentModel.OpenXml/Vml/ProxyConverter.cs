namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Shape Reference.
/// </summary>
public static class ProxyConverter
{
  /// <summary>
  /// Start Point Connection Flag
  /// </summary>
  public static Boolean? GetStart(DocumentFormat.OpenXml.Vml.Office.Proxy? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseBlankValue");
  }
  
  public static void SetStart(DocumentFormat.OpenXml.Vml.Office.Proxy? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseBlankValue");
  }
  
  /// <summary>
  /// End Point Connection Flag
  /// </summary>
  public static Boolean? GetEnd(DocumentFormat.OpenXml.Vml.Office.Proxy? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseBlankValue");
  }
  
  public static void SetEnd(DocumentFormat.OpenXml.Vml.Office.Proxy? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseBlankValue");
  }
  
  /// <summary>
  /// Proxy Shape Reference
  /// </summary>
  public static String? GetShapeReference(DocumentFormat.OpenXml.Vml.Office.Proxy? openXmlElement)
  {
    return openXmlElement?.ShapeReference?.Value;
  }
  
  public static void SetShapeReference(DocumentFormat.OpenXml.Vml.Office.Proxy? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ShapeReference = new StringValue { Value = value };
      else
        openXmlElement.ShapeReference = null;
  }
  
  /// <summary>
  /// Connection Location
  /// </summary>
  public static Int32? GetConnectionLocation(DocumentFormat.OpenXml.Vml.Office.Proxy? openXmlElement)
  {
    return openXmlElement?.ConnectionLocation?.Value;
  }
  
  public static void SetConnectionLocation(DocumentFormat.OpenXml.Vml.Office.Proxy? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.ConnectionLocation = value;
  }
  
  public static DocumentModel.Vml.Proxy? CreateModelElement(DocumentFormat.OpenXml.Vml.Office.Proxy? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.Proxy();
      value.Start = GetStart(openXmlElement);
      value.End = GetEnd(openXmlElement);
      value.ShapeReference = GetShapeReference(openXmlElement);
      value.ConnectionLocation = GetConnectionLocation(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Vml.Proxy? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Vml.Office.Proxy, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetStart(openXmlElement, value?.Start);
      SetEnd(openXmlElement, value?.End);
      SetShapeReference(openXmlElement, value?.ShapeReference);
      SetConnectionLocation(openXmlElement, value?.ConnectionLocation);
      return openXmlElement;
    }
    return default;
  }
}

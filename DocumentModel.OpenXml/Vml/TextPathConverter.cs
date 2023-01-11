namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Defines the TextPath Class.
/// </summary>
public static class TextPathConverter
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Vml.TextPath? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  public static void SetId(DocumentFormat.OpenXml.Vml.TextPath? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }
  
  /// <summary>
  /// Shape Styling Properties
  /// </summary>
  public static String? GetStyle(DocumentFormat.OpenXml.Vml.TextPath? openXmlElement)
  {
    return openXmlElement?.Style?.Value;
  }
  
  public static void SetStyle(DocumentFormat.OpenXml.Vml.TextPath? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Style = new StringValue { Value = value };
      else
        openXmlElement.Style = null;
  }
  
  /// <summary>
  /// Text Path Toggle
  /// </summary>
  public static Boolean? GetOn(DocumentFormat.OpenXml.Vml.TextPath? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetOn(DocumentFormat.OpenXml.Vml.TextPath? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  /// <summary>
  /// Shape Fit Toggle
  /// </summary>
  public static Boolean? GetFitShape(DocumentFormat.OpenXml.Vml.TextPath? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetFitShape(DocumentFormat.OpenXml.Vml.TextPath? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  /// <summary>
  /// Path Fit Toggle
  /// </summary>
  public static Boolean? GetFitPath(DocumentFormat.OpenXml.Vml.TextPath? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetFitPath(DocumentFormat.OpenXml.Vml.TextPath? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  /// <summary>
  /// Text Path Trim Toggle
  /// </summary>
  public static Boolean? GetTrim(DocumentFormat.OpenXml.Vml.TextPath? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetTrim(DocumentFormat.OpenXml.Vml.TextPath? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  /// <summary>
  /// Text X-Scaling
  /// </summary>
  public static Boolean? GetXScale(DocumentFormat.OpenXml.Vml.TextPath? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetXScale(DocumentFormat.OpenXml.Vml.TextPath? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  /// <summary>
  /// Text Path Text
  /// </summary>
  public static String? GetString(DocumentFormat.OpenXml.Vml.TextPath? openXmlElement)
  {
    return openXmlElement?.String?.Value;
  }
  
  public static void SetString(DocumentFormat.OpenXml.Vml.TextPath? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.String = new StringValue { Value = value };
      else
        openXmlElement.String = null;
  }
  
  public static DocumentModel.Vml.TextPath? CreateModelElement(DocumentFormat.OpenXml.Vml.TextPath? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.TextPath();
      value.Id = GetId(openXmlElement);
      value.Style = GetStyle(openXmlElement);
      value.On = GetOn(openXmlElement);
      value.FitShape = GetFitShape(openXmlElement);
      value.FitPath = GetFitPath(openXmlElement);
      value.Trim = GetTrim(openXmlElement);
      value.XScale = GetXScale(openXmlElement);
      value.String = GetString(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Vml.TextPath? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Vml.TextPath, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}

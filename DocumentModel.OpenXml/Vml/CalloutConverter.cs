namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Defines the Callout Class.
/// </summary>
public static class CalloutConverter
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public static DocumentModel.Vml.ExtensionHandlingBehaviorKind? GetExtension(DocumentFormat.OpenXml.Vml.Office.Callout? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DocumentModel.Vml.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }
  
  public static void SetExtension(DocumentFormat.OpenXml.Vml.Office.Callout? openXmlElement, DocumentModel.Vml.ExtensionHandlingBehaviorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Extension = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DocumentModel.Vml.ExtensionHandlingBehaviorKind>(value);
  }
  
  /// <summary>
  /// Callout toggle
  /// </summary>
  public static Boolean? GetOn(DocumentFormat.OpenXml.Vml.Office.Callout? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetOn(DocumentFormat.OpenXml.Vml.Office.Callout? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  /// <summary>
  /// Callout type
  /// </summary>
  public static String? GetType(DocumentFormat.OpenXml.Vml.Office.Callout? openXmlElement)
  {
    return openXmlElement?.Type?.Value;
  }
  
  public static void SetType(DocumentFormat.OpenXml.Vml.Office.Callout? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Type = new StringValue { Value = value };
      else
        openXmlElement.Type = null;
  }
  
  /// <summary>
  /// Callout gap
  /// </summary>
  public static String? GetGap(DocumentFormat.OpenXml.Vml.Office.Callout? openXmlElement)
  {
    return openXmlElement?.Gap?.Value;
  }
  
  public static void SetGap(DocumentFormat.OpenXml.Vml.Office.Callout? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Gap = new StringValue { Value = value };
      else
        openXmlElement.Gap = null;
  }
  
  /// <summary>
  /// Callout angle
  /// </summary>
  public static DocumentModel.Vml.AngleKind? GetAngle(DocumentFormat.OpenXml.Vml.Office.Callout? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.AngleValues, DocumentModel.Vml.AngleKind>(openXmlElement?.Angle?.Value);
  }
  
  public static void SetAngle(DocumentFormat.OpenXml.Vml.Office.Callout? openXmlElement, DocumentModel.Vml.AngleKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Angle = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.AngleValues, DocumentModel.Vml.AngleKind>(value);
  }
  
  /// <summary>
  /// Callout automatic drop toggle
  /// </summary>
  public static Boolean? GetDropAuto(DocumentFormat.OpenXml.Vml.Office.Callout? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetDropAuto(DocumentFormat.OpenXml.Vml.Office.Callout? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  /// <summary>
  /// Callout drop position
  /// </summary>
  public static String? GetDrop(DocumentFormat.OpenXml.Vml.Office.Callout? openXmlElement)
  {
    return openXmlElement?.Drop?.Value;
  }
  
  public static void SetDrop(DocumentFormat.OpenXml.Vml.Office.Callout? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Drop = new StringValue { Value = value };
      else
        openXmlElement.Drop = null;
  }
  
  /// <summary>
  /// Callout drop distance
  /// </summary>
  public static String? GetDistance(DocumentFormat.OpenXml.Vml.Office.Callout? openXmlElement)
  {
    return openXmlElement?.Distance?.Value;
  }
  
  public static void SetDistance(DocumentFormat.OpenXml.Vml.Office.Callout? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Distance = new StringValue { Value = value };
      else
        openXmlElement.Distance = null;
  }
  
  /// <summary>
  /// Callout length toggle
  /// </summary>
  public static Boolean? GetLengthSpecified(DocumentFormat.OpenXml.Vml.Office.Callout? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetLengthSpecified(DocumentFormat.OpenXml.Vml.Office.Callout? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  /// <summary>
  /// Callout length
  /// </summary>
  public static String? GetLength(DocumentFormat.OpenXml.Vml.Office.Callout? openXmlElement)
  {
    return openXmlElement?.Length?.Value;
  }
  
  public static void SetLength(DocumentFormat.OpenXml.Vml.Office.Callout? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Length = new StringValue { Value = value };
      else
        openXmlElement.Length = null;
  }
  
  /// <summary>
  /// Callout accent bar toggle
  /// </summary>
  public static Boolean? GetAccentBar(DocumentFormat.OpenXml.Vml.Office.Callout? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetAccentBar(DocumentFormat.OpenXml.Vml.Office.Callout? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  /// <summary>
  /// Callout text border toggle
  /// </summary>
  public static Boolean? GetTextBorder(DocumentFormat.OpenXml.Vml.Office.Callout? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetTextBorder(DocumentFormat.OpenXml.Vml.Office.Callout? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  /// <summary>
  /// Callout flip x
  /// </summary>
  public static Boolean? GetMinusX(DocumentFormat.OpenXml.Vml.Office.Callout? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetMinusX(DocumentFormat.OpenXml.Vml.Office.Callout? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  /// <summary>
  /// Callout flip y
  /// </summary>
  public static Boolean? GetMinusY(DocumentFormat.OpenXml.Vml.Office.Callout? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetMinusY(DocumentFormat.OpenXml.Vml.Office.Callout? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static DocumentModel.Vml.Callout? CreateModelElement(DocumentFormat.OpenXml.Vml.Office.Callout? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.Callout();
      value.Extension = GetExtension(openXmlElement);
      value.On = GetOn(openXmlElement);
      value.Type = GetType(openXmlElement);
      value.Gap = GetGap(openXmlElement);
      value.Angle = GetAngle(openXmlElement);
      value.DropAuto = GetDropAuto(openXmlElement);
      value.Drop = GetDrop(openXmlElement);
      value.Distance = GetDistance(openXmlElement);
      value.LengthSpecified = GetLengthSpecified(openXmlElement);
      value.Length = GetLength(openXmlElement);
      value.AccentBar = GetAccentBar(openXmlElement);
      value.TextBorder = GetTextBorder(openXmlElement);
      value.MinusX = GetMinusX(openXmlElement);
      value.MinusY = GetMinusY(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Vml.Callout? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Vml.Office.Callout, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}

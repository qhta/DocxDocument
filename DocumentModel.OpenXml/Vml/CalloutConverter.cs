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
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetOn(DocumentFormat.OpenXml.Vml.Office.Callout? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Callout type
  /// </summary>
  public static String? GetType(DocumentFormat.OpenXml.Vml.Office.Callout? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetType(DocumentFormat.OpenXml.Vml.Office.Callout? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Callout gap
  /// </summary>
  public static String? GetGap(DocumentFormat.OpenXml.Vml.Office.Callout? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetGap(DocumentFormat.OpenXml.Vml.Office.Callout? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
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
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDropAuto(DocumentFormat.OpenXml.Vml.Office.Callout? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Callout drop position
  /// </summary>
  public static String? GetDrop(DocumentFormat.OpenXml.Vml.Office.Callout? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetDrop(DocumentFormat.OpenXml.Vml.Office.Callout? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Callout drop distance
  /// </summary>
  public static String? GetDistance(DocumentFormat.OpenXml.Vml.Office.Callout? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetDistance(DocumentFormat.OpenXml.Vml.Office.Callout? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Callout length toggle
  /// </summary>
  public static Boolean? GetLengthSpecified(DocumentFormat.OpenXml.Vml.Office.Callout? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLengthSpecified(DocumentFormat.OpenXml.Vml.Office.Callout? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Callout length
  /// </summary>
  public static String? GetLength(DocumentFormat.OpenXml.Vml.Office.Callout? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetLength(DocumentFormat.OpenXml.Vml.Office.Callout? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Callout accent bar toggle
  /// </summary>
  public static Boolean? GetAccentBar(DocumentFormat.OpenXml.Vml.Office.Callout? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAccentBar(DocumentFormat.OpenXml.Vml.Office.Callout? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Callout text border toggle
  /// </summary>
  public static Boolean? GetTextBorder(DocumentFormat.OpenXml.Vml.Office.Callout? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTextBorder(DocumentFormat.OpenXml.Vml.Office.Callout? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Callout flip x
  /// </summary>
  public static Boolean? GetMinusX(DocumentFormat.OpenXml.Vml.Office.Callout? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetMinusX(DocumentFormat.OpenXml.Vml.Office.Callout? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Callout flip y
  /// </summary>
  public static Boolean? GetMinusY(DocumentFormat.OpenXml.Vml.Office.Callout? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetMinusY(DocumentFormat.OpenXml.Vml.Office.Callout? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}

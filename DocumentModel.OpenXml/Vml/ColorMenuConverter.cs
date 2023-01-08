namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// UI Default Colors.
/// </summary>
public static class ColorMenuConverter
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public static DocumentModel.Vml.ExtensionHandlingBehaviorKind? GetExtension(DocumentFormat.OpenXml.Vml.Office.ColorMenu? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DocumentModel.Vml.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }
  
  public static void SetExtension(DocumentFormat.OpenXml.Vml.Office.ColorMenu? openXmlElement, DocumentModel.Vml.ExtensionHandlingBehaviorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Extension = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DocumentModel.Vml.ExtensionHandlingBehaviorKind>(value);
  }
  
  /// <summary>
  /// Default stroke color
  /// </summary>
  public static String? GetStrokeColor(DocumentFormat.OpenXml.Vml.Office.ColorMenu? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetStrokeColor(DocumentFormat.OpenXml.Vml.Office.ColorMenu? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Default fill color
  /// </summary>
  public static String? GetFillColor(DocumentFormat.OpenXml.Vml.Office.ColorMenu? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetFillColor(DocumentFormat.OpenXml.Vml.Office.ColorMenu? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Default shadow color
  /// </summary>
  public static String? GetShadowColor(DocumentFormat.OpenXml.Vml.Office.ColorMenu? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetShadowColor(DocumentFormat.OpenXml.Vml.Office.ColorMenu? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Default extrusion color
  /// </summary>
  public static String? GetExtrusionColor(DocumentFormat.OpenXml.Vml.Office.ColorMenu? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetExtrusionColor(DocumentFormat.OpenXml.Vml.Office.ColorMenu? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}

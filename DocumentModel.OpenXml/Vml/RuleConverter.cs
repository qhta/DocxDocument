namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Rule.
/// </summary>
public static class RuleConverter
{
  /// <summary>
  /// Rule ID
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Vml.Office.Rule? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetId(DocumentFormat.OpenXml.Vml.Office.Rule? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Rule Type
  /// </summary>
  public static DocumentModel.Vml.RuleKind? GetType(DocumentFormat.OpenXml.Vml.Office.Rule? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.RuleValues, DocumentModel.Vml.RuleKind>(openXmlElement?.Type?.Value);
  }
  
  public static void SetType(DocumentFormat.OpenXml.Vml.Office.Rule? openXmlElement, DocumentModel.Vml.RuleKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.RuleValues, DocumentModel.Vml.RuleKind>(value);
  }
  
  /// <summary>
  /// Alignment Rule Type
  /// </summary>
  public static DocumentModel.Vml.AlignmentKind? GetHow(DocumentFormat.OpenXml.Vml.Office.Rule? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.AlignmentValues, DocumentModel.Vml.AlignmentKind>(openXmlElement?.How?.Value);
  }
  
  public static void SetHow(DocumentFormat.OpenXml.Vml.Office.Rule? openXmlElement, DocumentModel.Vml.AlignmentKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.How = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.AlignmentValues, DocumentModel.Vml.AlignmentKind>(value);
  }
  
  /// <summary>
  /// Rule Shape Reference
  /// </summary>
  public static String? GetShapeReference(DocumentFormat.OpenXml.Vml.Office.Rule? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetShapeReference(DocumentFormat.OpenXml.Vml.Office.Rule? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Vml.Proxy>? GetProxies(DocumentFormat.OpenXml.Vml.Office.Rule? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetProxies(DocumentFormat.OpenXml.Vml.Office.Rule? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Vml.Proxy>? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}

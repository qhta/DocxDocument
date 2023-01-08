namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Parameter.
/// </summary>
public static class ParameterConverter
{
  /// <summary>
  /// Parameter Type
  /// </summary>
  public static DocumentModel.Drawings.Diagrams.ParameterIdKind? GetType(DocumentFormat.OpenXml.Drawing.Diagrams.Parameter? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.ParameterIdValues, DocumentModel.Drawings.Diagrams.ParameterIdKind>(openXmlElement?.Type?.Value);
  }
  
  public static void SetType(DocumentFormat.OpenXml.Drawing.Diagrams.Parameter? openXmlElement, DocumentModel.Drawings.Diagrams.ParameterIdKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ParameterIdValues, DocumentModel.Drawings.Diagrams.ParameterIdKind>(value);
  }
  
  /// <summary>
  /// Value
  /// </summary>
  public static String? GetVal(DocumentFormat.OpenXml.Drawing.Diagrams.Parameter? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetVal(DocumentFormat.OpenXml.Drawing.Diagrams.Parameter? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}

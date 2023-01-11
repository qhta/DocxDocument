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
    return openXmlElement?.Val?.Value;
  }
  
  public static void SetVal(DocumentFormat.OpenXml.Drawing.Diagrams.Parameter? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Val = new StringValue { Value = value };
      else
        openXmlElement.Val = null;
  }
  
  public static DocumentModel.Drawings.Diagrams.Parameter? CreateModelElement(DocumentFormat.OpenXml.Drawing.Diagrams.Parameter? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.Parameter();
      value.Type = GetType(openXmlElement);
      value.Val = GetVal(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.Parameter? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Diagrams.Parameter, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}

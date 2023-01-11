namespace DocumentModel.OpenXml.Drawings.ChartsStyle;

/// <summary>
/// Defines the StyleReference Class.
/// </summary>
public static class StyleReferenceConverter
{
  /// <summary>
  /// idx, this property is only available in Office 2013 and later.
  /// </summary>
  public static UInt32? GetIndex(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleReference? openXmlElement)
  {
    return openXmlElement?.Index?.Value;
  }
  
  public static void SetIndex(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleReference? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Index = value;
  }
  
  /// <summary>
  /// mods, this property is only available in Office 2013 and later.
  /// </summary>
  public static DocumentModel.ListOf<String>? GetModifiers(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleReference? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.ListValue`1[DocumentFormat.OpenXml.StringValue]");
  }
  
  public static void SetModifiers(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleReference? openXmlElement, DocumentModel.ListOf<String>? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.ListValue`1[DocumentFormat.OpenXml.StringValue]");
  }
  
  public static DocumentModel.Drawings.ChartsStyle.StyleReference? CreateModelElement(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleReference? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartsStyle.StyleReference();
      value.Index = GetIndex(openXmlElement);
      value.Modifiers = GetModifiers(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartsStyle.StyleReference? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleReference, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}

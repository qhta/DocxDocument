namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the CheckBoxSymbolType Class.
/// </summary>
public static class CheckBoxSymbolTypeConverter
{
  /// <summary>
  /// font, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetFont(DocumentFormat.OpenXml.Office2010.Word.CheckBoxSymbolType? openXmlElement)
  {
    return openXmlElement?.Font?.Value;
  }
  
  public static void SetFont(DocumentFormat.OpenXml.Office2010.Word.CheckBoxSymbolType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Font = new StringValue { Value = value };
      else
        openXmlElement.Font = null;
  }
  
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public static DocumentModel.HexBinary? GetVal(DocumentFormat.OpenXml.Office2010.Word.CheckBoxSymbolType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.HexBinaryValue");
  }
  
  public static void SetVal(DocumentFormat.OpenXml.Office2010.Word.CheckBoxSymbolType? openXmlElement, DocumentModel.HexBinary? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.HexBinaryValue");
  }
  
  public static DocumentModel.Wordprocessing.CheckBoxSymbolType? CreateModelElement(DocumentFormat.OpenXml.Office2010.Word.CheckBoxSymbolType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.CheckBoxSymbolType();
      value.Font = GetFont(openXmlElement);
      value.Val = GetVal(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.CheckBoxSymbolType? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.Word.CheckBoxSymbolType, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}

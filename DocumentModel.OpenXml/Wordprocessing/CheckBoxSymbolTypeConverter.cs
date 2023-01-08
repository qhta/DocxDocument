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
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetFont(DocumentFormat.OpenXml.Office2010.Word.CheckBoxSymbolType? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public static DocumentModel.HexBinary? GetVal(DocumentFormat.OpenXml.Office2010.Word.CheckBoxSymbolType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetVal(DocumentFormat.OpenXml.Office2010.Word.CheckBoxSymbolType? openXmlElement, DocumentModel.HexBinary? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}

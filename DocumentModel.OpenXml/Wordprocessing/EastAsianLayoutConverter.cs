namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the EastAsianLayout Class.
/// </summary>
public static class EastAsianLayoutConverter
{
  /// <summary>
  /// East Asian Typography Run ID
  /// </summary>
  public static Int32? GetId(DocumentFormat.OpenXml.Wordprocessing.EastAsianLayout? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetId(DocumentFormat.OpenXml.Wordprocessing.EastAsianLayout? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Two Lines in One
  /// </summary>
  public static Boolean? GetCombine(DocumentFormat.OpenXml.Wordprocessing.EastAsianLayout? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetCombine(DocumentFormat.OpenXml.Wordprocessing.EastAsianLayout? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Display Brackets Around Two Lines in One
  /// </summary>
  public static DocumentModel.Wordprocessing.CombineBracketKind? GetCombineBrackets(DocumentFormat.OpenXml.Wordprocessing.EastAsianLayout? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.CombineBracketValues, DocumentModel.Wordprocessing.CombineBracketKind>(openXmlElement?.CombineBrackets?.Value);
  }
  
  public static void SetCombineBrackets(DocumentFormat.OpenXml.Wordprocessing.EastAsianLayout? openXmlElement, DocumentModel.Wordprocessing.CombineBracketKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.CombineBrackets = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.CombineBracketValues, DocumentModel.Wordprocessing.CombineBracketKind>(value);
  }
  
  /// <summary>
  /// Horizontal in Vertical (Rotate Text)
  /// </summary>
  public static Boolean? GetVertical(DocumentFormat.OpenXml.Wordprocessing.EastAsianLayout? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetVertical(DocumentFormat.OpenXml.Wordprocessing.EastAsianLayout? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Compress Rotated Text to Line Height
  /// </summary>
  public static Boolean? GetVerticalCompress(DocumentFormat.OpenXml.Wordprocessing.EastAsianLayout? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetVerticalCompress(DocumentFormat.OpenXml.Wordprocessing.EastAsianLayout? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the TextFontType Class.
/// </summary>
public static class TextFontTypeConverter
{
  /// <summary>
  /// Text Typeface
  /// </summary>
  public static String? GetTypeface(DocumentFormat.OpenXml.Drawing.TextFontType? openXmlElement)
  {
    return openXmlElement?.Typeface?.Value;
  }
  
  public static void SetTypeface(DocumentFormat.OpenXml.Drawing.TextFontType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Typeface = new StringValue { Value = value };
      else
        openXmlElement.Typeface = null;
  }
  
  /// <summary>
  /// Panose Setting
  /// </summary>
  public static DocumentModel.HexBinary? GetPanose(DocumentFormat.OpenXml.Drawing.TextFontType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.HexBinaryValue");
  }
  
  public static void SetPanose(DocumentFormat.OpenXml.Drawing.TextFontType? openXmlElement, DocumentModel.HexBinary? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.HexBinaryValue");
  }
  
  /// <summary>
  /// Similar Font Family
  /// </summary>
  public static SByte? GetPitchFamily(DocumentFormat.OpenXml.Drawing.TextFontType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.SByteValue");
  }
  
  public static void SetPitchFamily(DocumentFormat.OpenXml.Drawing.TextFontType? openXmlElement, SByte? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.SByteValue");
  }
  
  /// <summary>
  /// Similar Character Set
  /// </summary>
  public static SByte? GetCharacterSet(DocumentFormat.OpenXml.Drawing.TextFontType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.SByteValue");
  }
  
  public static void SetCharacterSet(DocumentFormat.OpenXml.Drawing.TextFontType? openXmlElement, SByte? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.SByteValue");
  }
  
  public static DocumentModel.Drawings.TextFontType? CreateModelElement(DocumentFormat.OpenXml.Drawing.TextFontType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.TextFontType();
      value.Typeface = GetTypeface(openXmlElement);
      value.Panose = GetPanose(openXmlElement);
      value.PitchFamily = GetPitchFamily(openXmlElement);
      value.CharacterSet = GetCharacterSet(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.TextFontType? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.TextFontType, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}

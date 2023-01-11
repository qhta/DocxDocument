namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the FontSignature Class.
/// </summary>
public static class FontSignatureConverter
{
  /// <summary>
  /// First 32 Bits of Unicode Subset Bitfield
  /// </summary>
  public static DocumentModel.HexBinary? GetUnicodeSignature0(DocumentFormat.OpenXml.Wordprocessing.FontSignature? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.HexBinaryValue");
  }
  
  public static void SetUnicodeSignature0(DocumentFormat.OpenXml.Wordprocessing.FontSignature? openXmlElement, DocumentModel.HexBinary? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.HexBinaryValue");
  }
  
  /// <summary>
  /// Second 32 Bits of Unicode Subset Bitfield
  /// </summary>
  public static DocumentModel.HexBinary? GetUnicodeSignature1(DocumentFormat.OpenXml.Wordprocessing.FontSignature? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.HexBinaryValue");
  }
  
  public static void SetUnicodeSignature1(DocumentFormat.OpenXml.Wordprocessing.FontSignature? openXmlElement, DocumentModel.HexBinary? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.HexBinaryValue");
  }
  
  /// <summary>
  /// Third 32 Bits of Unicode Subset Bitfield
  /// </summary>
  public static DocumentModel.HexBinary? GetUnicodeSignature2(DocumentFormat.OpenXml.Wordprocessing.FontSignature? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.HexBinaryValue");
  }
  
  public static void SetUnicodeSignature2(DocumentFormat.OpenXml.Wordprocessing.FontSignature? openXmlElement, DocumentModel.HexBinary? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.HexBinaryValue");
  }
  
  /// <summary>
  /// Fourth 32 Bits of Unicode Subset Bitfield
  /// </summary>
  public static DocumentModel.HexBinary? GetUnicodeSignature3(DocumentFormat.OpenXml.Wordprocessing.FontSignature? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.HexBinaryValue");
  }
  
  public static void SetUnicodeSignature3(DocumentFormat.OpenXml.Wordprocessing.FontSignature? openXmlElement, DocumentModel.HexBinary? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.HexBinaryValue");
  }
  
  /// <summary>
  /// Lower 32 Bits of Code Page Bit Field
  /// </summary>
  public static DocumentModel.HexBinary? GetCodePageSignature0(DocumentFormat.OpenXml.Wordprocessing.FontSignature? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.HexBinaryValue");
  }
  
  public static void SetCodePageSignature0(DocumentFormat.OpenXml.Wordprocessing.FontSignature? openXmlElement, DocumentModel.HexBinary? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.HexBinaryValue");
  }
  
  /// <summary>
  /// Upper 32 Bits of Code Page Bit Field
  /// </summary>
  public static DocumentModel.HexBinary? GetCodePageSignature1(DocumentFormat.OpenXml.Wordprocessing.FontSignature? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.HexBinaryValue");
  }
  
  public static void SetCodePageSignature1(DocumentFormat.OpenXml.Wordprocessing.FontSignature? openXmlElement, DocumentModel.HexBinary? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.HexBinaryValue");
  }
  
  public static DocumentModel.Wordprocessing.FontSignature? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.FontSignature? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.FontSignature();
      value.UnicodeSignature0 = GetUnicodeSignature0(openXmlElement);
      value.UnicodeSignature1 = GetUnicodeSignature1(openXmlElement);
      value.UnicodeSignature2 = GetUnicodeSignature2(openXmlElement);
      value.UnicodeSignature3 = GetUnicodeSignature3(openXmlElement);
      value.CodePageSignature0 = GetCodePageSignature0(openXmlElement);
      value.CodePageSignature1 = GetCodePageSignature1(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.FontSignature? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.FontSignature, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}

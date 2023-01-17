namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the FontSignature Class.
/// </summary>
public static class FontSignatureConverter
{
  /// <summary>
  /// First 32 Bits of Unicode Subset Bitfield
  /// </summary>
  private static UInt32? GetUnicodeSignature0(DocumentFormat.OpenXml.Wordprocessing.FontSignature openXmlElement)
  {
    if (openXmlElement.UnicodeSignature0?.Value != null)
      return UInt32.Parse(openXmlElement.UnicodeSignature0.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static void SetUnicodeSignature0(DocumentFormat.OpenXml.Wordprocessing.FontSignature openXmlElement, UInt32? value)
  {
      if (value != null)
        openXmlElement.UnicodeSignature0 = ((UInt32)value).ToString("X8");
      else
        openXmlElement.UnicodeSignature0 = null;
  }
  
  /// <summary>
  /// Second 32 Bits of Unicode Subset Bitfield
  /// </summary>
  private static UInt32? GetUnicodeSignature1(DocumentFormat.OpenXml.Wordprocessing.FontSignature openXmlElement)
  {
    if (openXmlElement.UnicodeSignature1?.Value != null)
      return UInt32.Parse(openXmlElement.UnicodeSignature1.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static void SetUnicodeSignature1(DocumentFormat.OpenXml.Wordprocessing.FontSignature openXmlElement, UInt32? value)
  {
      if (value != null)
        openXmlElement.UnicodeSignature1 = ((UInt32)value).ToString("X8");
      else
        openXmlElement.UnicodeSignature1 = null;
  }
  
  /// <summary>
  /// Third 32 Bits of Unicode Subset Bitfield
  /// </summary>
  private static UInt32? GetUnicodeSignature2(DocumentFormat.OpenXml.Wordprocessing.FontSignature openXmlElement)
  {
    if (openXmlElement.UnicodeSignature2?.Value != null)
      return UInt32.Parse(openXmlElement.UnicodeSignature2.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static void SetUnicodeSignature2(DocumentFormat.OpenXml.Wordprocessing.FontSignature openXmlElement, UInt32? value)
  {
      if (value != null)
        openXmlElement.UnicodeSignature2 = ((UInt32)value).ToString("X8");
      else
        openXmlElement.UnicodeSignature2 = null;
  }
  
  /// <summary>
  /// Fourth 32 Bits of Unicode Subset Bitfield
  /// </summary>
  private static UInt32? GetUnicodeSignature3(DocumentFormat.OpenXml.Wordprocessing.FontSignature openXmlElement)
  {
    if (openXmlElement.UnicodeSignature3?.Value != null)
      return UInt32.Parse(openXmlElement.UnicodeSignature3.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static void SetUnicodeSignature3(DocumentFormat.OpenXml.Wordprocessing.FontSignature openXmlElement, UInt32? value)
  {
      if (value != null)
        openXmlElement.UnicodeSignature3 = ((UInt32)value).ToString("X8");
      else
        openXmlElement.UnicodeSignature3 = null;
  }
  
  /// <summary>
  /// Lower 32 Bits of Code Page Bit Field
  /// </summary>
  private static UInt32? GetCodePageSignature0(DocumentFormat.OpenXml.Wordprocessing.FontSignature openXmlElement)
  {
    if (openXmlElement.CodePageSignature0?.Value != null)
      return UInt32.Parse(openXmlElement.CodePageSignature0.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static void SetCodePageSignature0(DocumentFormat.OpenXml.Wordprocessing.FontSignature openXmlElement, UInt32? value)
  {
      if (value != null)
        openXmlElement.CodePageSignature0 = ((UInt32)value).ToString("X8");
      else
        openXmlElement.CodePageSignature0 = null;
  }
  
  /// <summary>
  /// Upper 32 Bits of Code Page Bit Field
  /// </summary>
  private static UInt32? GetCodePageSignature1(DocumentFormat.OpenXml.Wordprocessing.FontSignature openXmlElement)
  {
    if (openXmlElement.CodePageSignature1?.Value != null)
      return UInt32.Parse(openXmlElement.CodePageSignature1.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static void SetCodePageSignature1(DocumentFormat.OpenXml.Wordprocessing.FontSignature openXmlElement, UInt32? value)
  {
      if (value != null)
        openXmlElement.CodePageSignature1 = ((UInt32)value).ToString("X8");
      else
        openXmlElement.CodePageSignature1 = null;
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
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUnicodeSignature0(openXmlElement, value?.UnicodeSignature0);
      SetUnicodeSignature1(openXmlElement, value?.UnicodeSignature1);
      SetUnicodeSignature2(openXmlElement, value?.UnicodeSignature2);
      SetUnicodeSignature3(openXmlElement, value?.UnicodeSignature3);
      SetCodePageSignature0(openXmlElement, value?.CodePageSignature0);
      SetCodePageSignature1(openXmlElement, value?.CodePageSignature1);
      return openXmlElement;
    }
    return default;
  }
}

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the FontSignature Class.
/// </summary>
public static class FontSignatureConverter
{
  /// <summary>
  /// First 32 Bits of Unicode Subset Bitfield
  /// </summary>
  public static Byte[]? GetUnicodeSignature0(DocumentFormat.OpenXml.Wordprocessing.FontSignature? openXmlElement)
  {
    if (openXmlElement?.UnicodeSignature0?.Value != null)
      return Convert.FromHexString(openXmlElement.UnicodeSignature0.Value);
    return null;
  }
  
  public static void SetUnicodeSignature0(DocumentFormat.OpenXml.Wordprocessing.FontSignature? openXmlElement, Byte[]? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.UnicodeSignature0 = Convert.ToHexString(value);
      else
        openXmlElement.UnicodeSignature0 = null;
    }
  }
  
  /// <summary>
  /// Second 32 Bits of Unicode Subset Bitfield
  /// </summary>
  public static Byte[]? GetUnicodeSignature1(DocumentFormat.OpenXml.Wordprocessing.FontSignature? openXmlElement)
  {
    if (openXmlElement?.UnicodeSignature1?.Value != null)
      return Convert.FromHexString(openXmlElement.UnicodeSignature1.Value);
    return null;
  }
  
  public static void SetUnicodeSignature1(DocumentFormat.OpenXml.Wordprocessing.FontSignature? openXmlElement, Byte[]? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.UnicodeSignature1 = Convert.ToHexString(value);
      else
        openXmlElement.UnicodeSignature1 = null;
    }
  }
  
  /// <summary>
  /// Third 32 Bits of Unicode Subset Bitfield
  /// </summary>
  public static Byte[]? GetUnicodeSignature2(DocumentFormat.OpenXml.Wordprocessing.FontSignature? openXmlElement)
  {
    if (openXmlElement?.UnicodeSignature2?.Value != null)
      return Convert.FromHexString(openXmlElement.UnicodeSignature2.Value);
    return null;
  }
  
  public static void SetUnicodeSignature2(DocumentFormat.OpenXml.Wordprocessing.FontSignature? openXmlElement, Byte[]? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.UnicodeSignature2 = Convert.ToHexString(value);
      else
        openXmlElement.UnicodeSignature2 = null;
    }
  }
  
  /// <summary>
  /// Fourth 32 Bits of Unicode Subset Bitfield
  /// </summary>
  public static Byte[]? GetUnicodeSignature3(DocumentFormat.OpenXml.Wordprocessing.FontSignature? openXmlElement)
  {
    if (openXmlElement?.UnicodeSignature3?.Value != null)
      return Convert.FromHexString(openXmlElement.UnicodeSignature3.Value);
    return null;
  }
  
  public static void SetUnicodeSignature3(DocumentFormat.OpenXml.Wordprocessing.FontSignature? openXmlElement, Byte[]? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.UnicodeSignature3 = Convert.ToHexString(value);
      else
        openXmlElement.UnicodeSignature3 = null;
    }
  }
  
  /// <summary>
  /// Lower 32 Bits of Code Page Bit Field
  /// </summary>
  public static Byte[]? GetCodePageSignature0(DocumentFormat.OpenXml.Wordprocessing.FontSignature? openXmlElement)
  {
    if (openXmlElement?.CodePageSignature0?.Value != null)
      return Convert.FromHexString(openXmlElement.CodePageSignature0.Value);
    return null;
  }
  
  public static void SetCodePageSignature0(DocumentFormat.OpenXml.Wordprocessing.FontSignature? openXmlElement, Byte[]? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.CodePageSignature0 = Convert.ToHexString(value);
      else
        openXmlElement.CodePageSignature0 = null;
    }
  }
  
  /// <summary>
  /// Upper 32 Bits of Code Page Bit Field
  /// </summary>
  public static Byte[]? GetCodePageSignature1(DocumentFormat.OpenXml.Wordprocessing.FontSignature? openXmlElement)
  {
    if (openXmlElement?.CodePageSignature1?.Value != null)
      return Convert.FromHexString(openXmlElement.CodePageSignature1.Value);
    return null;
  }
  
  public static void SetCodePageSignature1(DocumentFormat.OpenXml.Wordprocessing.FontSignature? openXmlElement, Byte[]? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.CodePageSignature1 = Convert.ToHexString(value);
      else
        openXmlElement.CodePageSignature1 = null;
    }
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

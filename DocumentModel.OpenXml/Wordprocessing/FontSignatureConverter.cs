namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the FontSignature Class.
/// </summary>
public static class FontSignatureConverter
{
  /// <summary>
  /// First 32 Bits of Unicode Subset Bitfield
  /// </summary>
  private static UInt32? GetUnicodeSignature0(DXW.FontSignature openXmlElement)
  {
    if (openXmlElement.UnicodeSignature0?.Value != null)
      return UInt32.Parse(openXmlElement.UnicodeSignature0.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static bool CmpUnicodeSignature0(DXW.FontSignature openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement.UnicodeSignature0?.Value != null)
      return UInt32.Parse(openXmlElement.UnicodeSignature0.Value, NumberStyles.HexNumber) == value;
    return openXmlElement == null && value == null;
  }
  
  private static void SetUnicodeSignature0(DXW.FontSignature openXmlElement, UInt32? value)
  {
      if (value != null)
        openXmlElement.UnicodeSignature0 = ((UInt32)value).ToString("X8");
      else
        openXmlElement.UnicodeSignature0 = null;
  }
  
  /// <summary>
  /// Second 32 Bits of Unicode Subset Bitfield
  /// </summary>
  private static UInt32? GetUnicodeSignature1(DXW.FontSignature openXmlElement)
  {
    if (openXmlElement.UnicodeSignature1?.Value != null)
      return UInt32.Parse(openXmlElement.UnicodeSignature1.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static bool CmpUnicodeSignature1(DXW.FontSignature openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement.UnicodeSignature1?.Value != null)
      return UInt32.Parse(openXmlElement.UnicodeSignature1.Value, NumberStyles.HexNumber) == value;
    return openXmlElement == null && value == null;
  }
  
  private static void SetUnicodeSignature1(DXW.FontSignature openXmlElement, UInt32? value)
  {
      if (value != null)
        openXmlElement.UnicodeSignature1 = ((UInt32)value).ToString("X8");
      else
        openXmlElement.UnicodeSignature1 = null;
  }
  
  /// <summary>
  /// Third 32 Bits of Unicode Subset Bitfield
  /// </summary>
  private static UInt32? GetUnicodeSignature2(DXW.FontSignature openXmlElement)
  {
    if (openXmlElement.UnicodeSignature2?.Value != null)
      return UInt32.Parse(openXmlElement.UnicodeSignature2.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static bool CmpUnicodeSignature2(DXW.FontSignature openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement.UnicodeSignature2?.Value != null)
      return UInt32.Parse(openXmlElement.UnicodeSignature2.Value, NumberStyles.HexNumber) == value;
    return openXmlElement == null && value == null;
  }
  
  private static void SetUnicodeSignature2(DXW.FontSignature openXmlElement, UInt32? value)
  {
      if (value != null)
        openXmlElement.UnicodeSignature2 = ((UInt32)value).ToString("X8");
      else
        openXmlElement.UnicodeSignature2 = null;
  }
  
  /// <summary>
  /// Fourth 32 Bits of Unicode Subset Bitfield
  /// </summary>
  private static UInt32? GetUnicodeSignature3(DXW.FontSignature openXmlElement)
  {
    if (openXmlElement.UnicodeSignature3?.Value != null)
      return UInt32.Parse(openXmlElement.UnicodeSignature3.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static bool CmpUnicodeSignature3(DXW.FontSignature openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement.UnicodeSignature3?.Value != null)
      return UInt32.Parse(openXmlElement.UnicodeSignature3.Value, NumberStyles.HexNumber) == value;
    return openXmlElement == null && value == null;
  }
  
  private static void SetUnicodeSignature3(DXW.FontSignature openXmlElement, UInt32? value)
  {
      if (value != null)
        openXmlElement.UnicodeSignature3 = ((UInt32)value).ToString("X8");
      else
        openXmlElement.UnicodeSignature3 = null;
  }
  
  /// <summary>
  /// Lower 32 Bits of Code Page Bit Field
  /// </summary>
  private static UInt32? GetCodePageSignature0(DXW.FontSignature openXmlElement)
  {
    if (openXmlElement.CodePageSignature0?.Value != null)
      return UInt32.Parse(openXmlElement.CodePageSignature0.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static bool CmpCodePageSignature0(DXW.FontSignature openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement.CodePageSignature0?.Value != null)
      return UInt32.Parse(openXmlElement.CodePageSignature0.Value, NumberStyles.HexNumber) == value;
    return openXmlElement == null && value == null;
  }
  
  private static void SetCodePageSignature0(DXW.FontSignature openXmlElement, UInt32? value)
  {
      if (value != null)
        openXmlElement.CodePageSignature0 = ((UInt32)value).ToString("X8");
      else
        openXmlElement.CodePageSignature0 = null;
  }
  
  /// <summary>
  /// Upper 32 Bits of Code Page Bit Field
  /// </summary>
  private static UInt32? GetCodePageSignature1(DXW.FontSignature openXmlElement)
  {
    if (openXmlElement.CodePageSignature1?.Value != null)
      return UInt32.Parse(openXmlElement.CodePageSignature1.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static bool CmpCodePageSignature1(DXW.FontSignature openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement.CodePageSignature1?.Value != null)
      return UInt32.Parse(openXmlElement.CodePageSignature1.Value, NumberStyles.HexNumber) == value;
    return openXmlElement == null && value == null;
  }
  
  private static void SetCodePageSignature1(DXW.FontSignature openXmlElement, UInt32? value)
  {
      if (value != null)
        openXmlElement.CodePageSignature1 = ((UInt32)value).ToString("X8");
      else
        openXmlElement.CodePageSignature1 = null;
  }
  
  public static DMW.FontSignature? CreateModelElement(DXW.FontSignature? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.FontSignature();
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
  
  public static bool CompareModelElement(DXW.FontSignature? openXmlElement, DMW.FontSignature? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUnicodeSignature0(openXmlElement, value.UnicodeSignature0, diffs, objName))
        ok = false;
      if (!CmpUnicodeSignature1(openXmlElement, value.UnicodeSignature1, diffs, objName))
        ok = false;
      if (!CmpUnicodeSignature2(openXmlElement, value.UnicodeSignature2, diffs, objName))
        ok = false;
      if (!CmpUnicodeSignature3(openXmlElement, value.UnicodeSignature3, diffs, objName))
        ok = false;
      if (!CmpCodePageSignature0(openXmlElement, value.CodePageSignature0, diffs, objName))
        ok = false;
      if (!CmpCodePageSignature1(openXmlElement, value.CodePageSignature1, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.FontSignature? value)
    where OpenXmlElementType: DXW.FontSignature, new()
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

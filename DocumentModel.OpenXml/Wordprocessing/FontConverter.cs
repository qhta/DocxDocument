namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Properties for a Single Font.
/// </summary>
public static class FontConverter
{
  /// <summary>
  /// name
  /// </summary>
  private static String? GetName(DXW.Font openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }
  
  private static bool CmpName(DXW.Font openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Name?.Value == value;
  }
  
  private static void SetName(DXW.Font openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Name = new StringValue { Value = value };
    else
      openXmlElement.Name = null;
  }
  
  /// <summary>
  /// AltName.
  /// </summary>
  private static String? GetAltName(DXW.Font openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.AltName>()?.Val?.Value;
  }
  
  private static bool CmpAltName(DXW.Font openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.AltName>()?.Val?.Value == value;
  }
  
  private static void SetAltName(DXW.Font openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.AltName>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.AltName { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Panose1Number.
  /// </summary>
  private static Byte[]? GetPanose1Number(DXW.Font openXmlElement)
  {
    return DMX.HexBinaryConverter.GetValue(openXmlElement?.GetFirstChild<DXW.Panose1Number>());
  }
  
  private static bool CmpPanose1Number(DXW.Font openXmlElement, Byte[]? value, DiffList? diffs, string? objName)
  {
    return DMX.HexBinaryConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.Panose1Number>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPanose1Number(DXW.Font openXmlElement, Byte[]? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Panose1Number>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.HexBinaryConverter.CreateOpenXmlElement<DXW.Panose1Number>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// FontCharSet.
  /// </summary>
  private static DMW.FontCharSet? GetFontCharSet(DXW.Font openXmlElement)
  {
    return DMXW.FontCharSetConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.FontCharSet>());
  }
  
  private static bool CmpFontCharSet(DXW.Font openXmlElement, DMW.FontCharSet? value, DiffList? diffs, string? objName)
  {
    return DMXW.FontCharSetConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.FontCharSet>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetFontCharSet(DXW.Font openXmlElement, DMW.FontCharSet? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.FontCharSet>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.FontCharSetConverter.CreateOpenXmlElement<DXW.FontCharSet>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// FontFamily.
  /// </summary>
  private static DMW.FontFamilyKind? GetFontFamily(DXW.Font openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.FontFamilyValues, DMW.FontFamilyKind>(openXmlElement.GetFirstChild<DXW.FontFamily>()?.Val?.Value);
  }
  
  private static bool CmpFontFamily(DXW.Font openXmlElement, DMW.FontFamilyKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.FontFamilyValues, DMW.FontFamilyKind>(openXmlElement.GetFirstChild<DXW.FontFamily>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetFontFamily(DXW.Font openXmlElement, DMW.FontFamilyKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.FontFamily>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.FontFamily, DocumentFormat.OpenXml.Wordprocessing.FontFamilyValues, DMW.FontFamilyKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// NotTrueType.
  /// </summary>
  private static Boolean? GetNotTrueType(DXW.Font openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.NotTrueType>()?.Val?.Value;
  }
  
  private static bool CmpNotTrueType(DXW.Font openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.NotTrueType>()?.Val?.Value == value;
  }
  
  private static void SetNotTrueType(DXW.Font openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.NotTrueType>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.NotTrueType();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Pitch.
  /// </summary>
  private static DMW.FontPitchKind? GetPitch(DXW.Font openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.FontPitchValues, DMW.FontPitchKind>(openXmlElement.GetFirstChild<DXW.Pitch>()?.Val?.Value);
  }
  
  private static bool CmpPitch(DXW.Font openXmlElement, DMW.FontPitchKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.FontPitchValues, DMW.FontPitchKind>(openXmlElement.GetFirstChild<DXW.Pitch>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPitch(DXW.Font openXmlElement, DMW.FontPitchKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Pitch>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.Pitch, DocumentFormat.OpenXml.Wordprocessing.FontPitchValues, DMW.FontPitchKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// FontSignature.
  /// </summary>
  private static DMW.FontSignature? GetFontSignature(DXW.Font openXmlElement)
  {
    return DMXW.FontSignatureConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.FontSignature>());
  }
  
  private static bool CmpFontSignature(DXW.Font openXmlElement, DMW.FontSignature? value, DiffList? diffs, string? objName)
  {
    return DMXW.FontSignatureConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.FontSignature>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetFontSignature(DXW.Font openXmlElement, DMW.FontSignature? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.FontSignature>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.FontSignatureConverter.CreateOpenXmlElement<DXW.FontSignature>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// EmbedRegularFont.
  /// </summary>
  private static DMW.FontRelationshipType? GetEmbedRegularFont(DXW.Font openXmlElement)
  {
    return DMXW.FontRelationshipTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.EmbedRegularFont>());
  }
  
  private static bool CmpEmbedRegularFont(DXW.Font openXmlElement, DMW.FontRelationshipType? value, DiffList? diffs, string? objName)
  {
    return DMXW.FontRelationshipTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.EmbedRegularFont>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetEmbedRegularFont(DXW.Font openXmlElement, DMW.FontRelationshipType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.EmbedRegularFont>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.FontRelationshipTypeConverter.CreateOpenXmlElement<DXW.EmbedRegularFont>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// EmbedBoldFont.
  /// </summary>
  private static DMW.FontRelationshipType? GetEmbedBoldFont(DXW.Font openXmlElement)
  {
    return DMXW.FontRelationshipTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.EmbedBoldFont>());
  }
  
  private static bool CmpEmbedBoldFont(DXW.Font openXmlElement, DMW.FontRelationshipType? value, DiffList? diffs, string? objName)
  {
    return DMXW.FontRelationshipTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.EmbedBoldFont>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetEmbedBoldFont(DXW.Font openXmlElement, DMW.FontRelationshipType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.EmbedBoldFont>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.FontRelationshipTypeConverter.CreateOpenXmlElement<DXW.EmbedBoldFont>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// EmbedItalicFont.
  /// </summary>
  private static DMW.FontRelationshipType? GetEmbedItalicFont(DXW.Font openXmlElement)
  {
    return DMXW.FontRelationshipTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.EmbedItalicFont>());
  }
  
  private static bool CmpEmbedItalicFont(DXW.Font openXmlElement, DMW.FontRelationshipType? value, DiffList? diffs, string? objName)
  {
    return DMXW.FontRelationshipTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.EmbedItalicFont>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetEmbedItalicFont(DXW.Font openXmlElement, DMW.FontRelationshipType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.EmbedItalicFont>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.FontRelationshipTypeConverter.CreateOpenXmlElement<DXW.EmbedItalicFont>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// EmbedBoldItalicFont.
  /// </summary>
  private static DMW.FontRelationshipType? GetEmbedBoldItalicFont(DXW.Font openXmlElement)
  {
    return DMXW.FontRelationshipTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.EmbedBoldItalicFont>());
  }
  
  private static bool CmpEmbedBoldItalicFont(DXW.Font openXmlElement, DMW.FontRelationshipType? value, DiffList? diffs, string? objName)
  {
    return DMXW.FontRelationshipTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.EmbedBoldItalicFont>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetEmbedBoldItalicFont(DXW.Font openXmlElement, DMW.FontRelationshipType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.EmbedBoldItalicFont>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.FontRelationshipTypeConverter.CreateOpenXmlElement<DXW.EmbedBoldItalicFont>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.Font? CreateModelElement(DXW.Font? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Font();
      value.Name = GetName(openXmlElement);
      value.AltName = GetAltName(openXmlElement);
      value.Panose1Number = GetPanose1Number(openXmlElement);
      value.FontCharSet = GetFontCharSet(openXmlElement);
      value.FontFamily = GetFontFamily(openXmlElement);
      value.NotTrueType = GetNotTrueType(openXmlElement);
      value.Pitch = GetPitch(openXmlElement);
      value.FontSignature = GetFontSignature(openXmlElement);
      value.EmbedRegularFont = GetEmbedRegularFont(openXmlElement);
      value.EmbedBoldFont = GetEmbedBoldFont(openXmlElement);
      value.EmbedItalicFont = GetEmbedItalicFont(openXmlElement);
      value.EmbedBoldItalicFont = GetEmbedBoldItalicFont(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.Font? openXmlElement, DMW.Font? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpName(openXmlElement, value.Name, diffs, objName))
        ok = false;
      if (!CmpAltName(openXmlElement, value.AltName, diffs, objName))
        ok = false;
      if (!CmpPanose1Number(openXmlElement, value.Panose1Number, diffs, objName))
        ok = false;
      if (!CmpFontCharSet(openXmlElement, value.FontCharSet, diffs, objName))
        ok = false;
      if (!CmpFontFamily(openXmlElement, value.FontFamily, diffs, objName))
        ok = false;
      if (!CmpNotTrueType(openXmlElement, value.NotTrueType, diffs, objName))
        ok = false;
      if (!CmpPitch(openXmlElement, value.Pitch, diffs, objName))
        ok = false;
      if (!CmpFontSignature(openXmlElement, value.FontSignature, diffs, objName))
        ok = false;
      if (!CmpEmbedRegularFont(openXmlElement, value.EmbedRegularFont, diffs, objName))
        ok = false;
      if (!CmpEmbedBoldFont(openXmlElement, value.EmbedBoldFont, diffs, objName))
        ok = false;
      if (!CmpEmbedItalicFont(openXmlElement, value.EmbedItalicFont, diffs, objName))
        ok = false;
      if (!CmpEmbedBoldItalicFont(openXmlElement, value.EmbedBoldItalicFont, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.Font? value)
    where OpenXmlElementType: DXW.Font, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetName(openXmlElement, value?.Name);
      SetAltName(openXmlElement, value?.AltName);
      SetPanose1Number(openXmlElement, value?.Panose1Number);
      SetFontCharSet(openXmlElement, value?.FontCharSet);
      SetFontFamily(openXmlElement, value?.FontFamily);
      SetNotTrueType(openXmlElement, value?.NotTrueType);
      SetPitch(openXmlElement, value?.Pitch);
      SetFontSignature(openXmlElement, value?.FontSignature);
      SetEmbedRegularFont(openXmlElement, value?.EmbedRegularFont);
      SetEmbedBoldFont(openXmlElement, value?.EmbedBoldFont);
      SetEmbedItalicFont(openXmlElement, value?.EmbedItalicFont);
      SetEmbedBoldItalicFont(openXmlElement, value?.EmbedBoldItalicFont);
      return openXmlElement;
    }
    return default;
  }
}

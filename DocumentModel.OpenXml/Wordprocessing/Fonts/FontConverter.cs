namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.Font"/> class from/to OpenXml converter.
/// </summary>
public static class FontConverter
{
  #region Font name conversion
  private static String? GetName(DXW.Font openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Name);
  }
  
  private static bool CmpName(DXW.Font openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Name, value, diffs, objName, "Name");
  }
  
  private static void SetName(DXW.Font openXmlElement, String? value)
  {
    openXmlElement.Name = StringValueConverter.CreateStringValue(value);
  }
  #endregion

  #region AltName conversion
  private static String? GetAltName(DXW.Font openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.AltName>()?.Val?.Value;
  }
  
  private static bool CmpAltName(DXW.Font openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.AltName>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "Aliases", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetAltName(DXW.Font openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.AltName>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.AltName { Val = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region Panose1Number conversion
  private static DM.HexBinary? GetPanose(DXW.Font openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Panose1Number>();
    if (element != null)
      return DMX.HexBinaryConverter.GetValue(element);
    return null;
  }
  
  private static bool CmpPanose(DXW.Font openXmlElement, DM.HexBinary? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMX.HexBinaryConverter.CmpValue(openXmlElement.GetFirstChild<DXW.Panose1Number>(), value, diffs, objName, propName);
  }
  
  private static void SetPanose(DXW.Font openXmlElement, DM.HexBinary? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Panose1Number>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.HexBinaryConverter.CreateOpenXmlElement<DXW.Panose1Number>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region FontCharSet conversion
  private static DMW.Charset? GetFontCharSet(DXW.Font openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.FontCharSet>();
    if (element != null)
      return DMXW.CharsetConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFontCharSet(DXW.Font openXmlElement, DMW.Charset? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.CharsetConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.FontCharSet>(), value, diffs, objName, propName);
  }
  
  private static void SetFontCharSet(DXW.Font openXmlElement, DMW.Charset? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.FontCharSet>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.CharsetConverter.CreateOpenXmlElement<DXW.FontCharSet>((DMW.Charset)value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region FontFamily conversion
  private static DMW.FontFamilyKind? GetFontFamily(DXW.Font openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.FontFamilyValues, DMW.FontFamilyKind>(openXmlElement.GetFirstChild<DXW.FontFamily>()?.Val?.Value);
  }
  
  private static bool CmpFontFamily(DXW.Font openXmlElement, DMW.FontFamilyKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DXW.FontFamilyValues, DMW.FontFamilyKind>(openXmlElement.GetFirstChild<DXW.FontFamily>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetFontFamily(DXW.Font openXmlElement, DMW.FontFamilyKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.FontFamily>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DXW.FontFamilyValues, DMW.FontFamilyKind>(itemElement, (DMW.FontFamilyKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXW.FontFamily, DXW.FontFamilyValues, DMW.FontFamilyKind>((DMW.FontFamilyKind)value));
  }
  #endregion

  #region NotTrueType conversion
  private static Boolean? GetNotTrueType(DXW.Font openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.NotTrueType>());
  }
  
  private static bool CmpNotTrueType(DXW.Font openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.NotTrueType>(), value, diffs, objName, propName);
  }
  
  private static void SetNotTrueType(DXW.Font openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.NotTrueType>(openXmlElement, value, "0", null);
  }
  #endregion

  #region Pitch conversion
  private static DMW.FontPitchKind? GetPitch(DXW.Font openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.FontPitchValues, DMW.FontPitchKind>(openXmlElement.GetFirstChild<DXW.Pitch>()?.Val?.Value);
  }
  
  private static bool CmpPitch(DXW.Font openXmlElement, DMW.FontPitchKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DXW.FontPitchValues, DMW.FontPitchKind>(openXmlElement.GetFirstChild<DXW.Pitch>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetPitch(DXW.Font openXmlElement, DMW.FontPitchKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Pitch>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DXW.FontPitchValues, DMW.FontPitchKind>(itemElement, (DMW.FontPitchKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXW.Pitch, DXW.FontPitchValues, DMW.FontPitchKind>((DMW.FontPitchKind)value));
  }
  #endregion

  #region FontSignature conversion
  private static DMW.FontSignature? GetFontSignature(DXW.Font openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.FontSignature>();
    if (element != null)
      return DMXW.FontSignatureConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFontSignature(DXW.Font openXmlElement, DMW.FontSignature? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.FontSignatureConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.FontSignature>(), value, diffs, objName, propName);
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
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region EmbedRegularFont conversion
  private static DMW.EmbeddedFont? GetEmbedRegularFont(DXW.Font openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.EmbedRegularFont>();
    if (element != null)
      return DMXW.EmbeddedFontConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEmbedRegularFont(DXW.Font openXmlElement, DMW.EmbeddedFont? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.EmbeddedFontConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.EmbedRegularFont>(), value, diffs, objName, propName);
  }
  
  private static void SetEmbedRegularFont(DXW.Font openXmlElement, DMW.EmbeddedFont? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.EmbedRegularFont>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.EmbeddedFontConverter.CreateOpenXmlElement<DXW.EmbedRegularFont>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region EmbedBoldFont conversion
  private static DMW.EmbeddedFont? GetEmbedBoldFont(DXW.Font openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.EmbedBoldFont>();
    if (element != null)
      return DMXW.EmbeddedFontConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEmbedBoldFont(DXW.Font openXmlElement, DMW.EmbeddedFont? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.EmbeddedFontConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.EmbedBoldFont>(), value, diffs, objName, propName);
  }
  
  private static void SetEmbedBoldFont(DXW.Font openXmlElement, DMW.EmbeddedFont? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.EmbedBoldFont>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.EmbeddedFontConverter.CreateOpenXmlElement<DXW.EmbedBoldFont>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region EmbedItalicFont conversion
  private static DMW.EmbeddedFont? GetEmbedItalicFont(DXW.Font openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.EmbedItalicFont>();
    if (element != null)
      return DMXW.EmbeddedFontConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEmbedItalicFont(DXW.Font openXmlElement, DMW.EmbeddedFont? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.EmbeddedFontConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.EmbedItalicFont>(), value, diffs, objName, propName);
  }
  
  private static void SetEmbedItalicFont(DXW.Font openXmlElement, DMW.EmbeddedFont? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.EmbedItalicFont>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.EmbeddedFontConverter.CreateOpenXmlElement<DXW.EmbedItalicFont>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region EmbedBoldItalicFont conversion
  private static DMW.EmbeddedFont? GetEmbedBoldItalicFont(DXW.Font openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.EmbedBoldItalicFont>();
    if (element != null)
      return DMXW.EmbeddedFontConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEmbedBoldItalicFont(DXW.Font openXmlElement, DMW.EmbeddedFont? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.EmbeddedFontConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.EmbedBoldItalicFont>(), value, diffs, objName, propName);
  }
  
  private static void SetEmbedBoldItalicFont(DXW.Font openXmlElement, DMW.EmbeddedFont? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.EmbedBoldItalicFont>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.EmbeddedFontConverter.CreateOpenXmlElement<DXW.EmbedBoldItalicFont>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region Font model conversion
  public static DMW.Font? CreateModelElement(DXW.Font? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.Font();
      model.Name = GetName(openXmlElement);
      model.Aliases = GetAltName(openXmlElement);
      model.Panose = GetPanose(openXmlElement);
      model.FontCharSet = GetFontCharSet(openXmlElement);
      model.FontFamily = GetFontFamily(openXmlElement);
      model.NotTrueType = GetNotTrueType(openXmlElement);
      model.Pitch = GetPitch(openXmlElement);
      model.FontSignature = GetFontSignature(openXmlElement);
      model.EmbedRegularFont = GetEmbedRegularFont(openXmlElement);
      model.EmbedBoldFont = GetEmbedBoldFont(openXmlElement);
      model.EmbedItalicFont = GetEmbedItalicFont(openXmlElement);
      model.EmbedBoldItalicFont = GetEmbedBoldItalicFont(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.Font? openXmlElement, DMW.Font? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpName(openXmlElement, model.Name, diffs, objName, propName))
        ok = false;
      if (!CmpAltName(openXmlElement, model.Aliases, diffs, objName, propName))
        ok = false;
      if (!CmpPanose(openXmlElement, model.Panose, diffs, objName, propName))
        ok = false;
      if (!CmpFontCharSet(openXmlElement, model.FontCharSet, diffs, objName, propName))
        ok = false;
      if (!CmpFontFamily(openXmlElement, model.FontFamily, diffs, objName, propName))
        ok = false;
      if (!CmpNotTrueType(openXmlElement, model.NotTrueType, diffs, objName, propName))
        ok = false;
      if (!CmpPitch(openXmlElement, model.Pitch, diffs, objName, propName))
        ok = false;
      if (!CmpFontSignature(openXmlElement, model.FontSignature, diffs, objName, propName))
        ok = false;
      if (!CmpEmbedRegularFont(openXmlElement, model.EmbedRegularFont, diffs, objName, propName))
        ok = false;
      if (!CmpEmbedBoldFont(openXmlElement, model.EmbedBoldFont, diffs, objName, propName))
        ok = false;
      if (!CmpEmbedItalicFont(openXmlElement, model.EmbedItalicFont, diffs, objName, propName))
        ok = false;
      if (!CmpEmbedBoldItalicFont(openXmlElement, model.EmbedBoldItalicFont, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.Font model)
    where OpenXmlElementType: DXW.Font, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.Font openXmlElement, DMW.Font model)
  {
    SetName(openXmlElement, model?.Name);
    SetAltName(openXmlElement, model?.Aliases);
    SetPanose(openXmlElement, model?.Panose);
    SetFontCharSet(openXmlElement, model?.FontCharSet);
    SetFontFamily(openXmlElement, model?.FontFamily);
    SetNotTrueType(openXmlElement, model?.NotTrueType);
    SetPitch(openXmlElement, model?.Pitch);
    SetFontSignature(openXmlElement, model?.FontSignature);
    SetEmbedRegularFont(openXmlElement, model?.EmbedRegularFont);
    SetEmbedBoldFont(openXmlElement, model?.EmbedBoldFont);
    SetEmbedItalicFont(openXmlElement, model?.EmbedItalicFont);
    SetEmbedBoldItalicFont(openXmlElement, model?.EmbedBoldItalicFont);
  }
  #endregion
}

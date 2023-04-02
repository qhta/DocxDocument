namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// RunPropertiesBaseStyle from/to OpenXml converter.
/// </summary>
public static class RunPropertiesBaseStyleConverter
{

  #region RunFonts conversion.
  public static DMW.RunFonts? GetRunFonts(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.RunFonts>();
    if (element != null)
      return DMXW.RunFontsConverter.CreateModelElement(element);
    return null;
  }

  public static bool CmpRunFonts(DX.OpenXmlCompositeElement openXmlElement, DMW.RunFonts? value, DiffList? diffs, string? objName)
  {
    return DMXW.RunFontsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.RunFonts>(), value, diffs, objName);
  }

  public static void SetRunFonts(DX.OpenXmlCompositeElement openXmlElement, DMW.RunFonts? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.RunFonts>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.RunFontsConverter.CreateOpenXmlElement<DXW.RunFonts>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region Bold & BoldComplexScript child elements conversion.
  public static DualBoolean? GetBold(DX.OpenXmlCompositeElement openXmlElement)
  {
    var val = BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.Bold>());
    var valCS = BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.BoldComplexScript>());
    if (val != null || valCS != null)
      return new DualBoolean(val, valCS);
    return null;
  }

  public static bool CmpBold(DX.OpenXmlCompositeElement openXmlElement, DualBoolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.Bold>(), value?.Val, diffs, objName, "Type")
        && BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.BoldComplexScript>(), value?.ValCS, diffs, objName, "ComplexScript");
  }

  public static void SetBold(DX.OpenXmlCompositeElement openXmlElement, DualBoolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.Bold>(openXmlElement, value?.Val);
    BooleanValueConverter.SetOnOffType<DXW.BoldComplexScript>(openXmlElement, value?.ValCS);
  }
  #endregion

  #region Italic & ItalicComplexScript child elements conversion.
  public static DualBoolean? GetItalic(DX.OpenXmlCompositeElement openXmlElement)
  {
    var val = BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.Italic>());
    var valCS = BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.ItalicComplexScript>());
    if (val != null || valCS != null)
      return new DualBoolean(val, valCS);
    return null;
  }

  public static bool CmpItalic(DX.OpenXmlCompositeElement openXmlElement, DualBoolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.Italic>(), value?.Val, diffs, objName, "Type")
        && BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.ItalicComplexScript>(), value?.ValCS, diffs, objName, "ComplexScript");
  }

  public static void SetItalic(DX.OpenXmlCompositeElement openXmlElement, DualBoolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.Italic>(openXmlElement, value?.Val);
    BooleanValueConverter.SetOnOffType<DXW.ItalicComplexScript>(openXmlElement, value?.ValCS);
  }
  #endregion

  #region FontSize & FontSizeCS child elements conversion.
  public static DualHPS? GetFontSize(DX.OpenXmlCompositeElement openXmlElement)
  {
    var val = Int32ValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.FontSize>()?.Val);
    var valCS = Int32ValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.FontSizeComplexScript>()?.Val);
    if (val != null || valCS != null)
      return new DualHPS(val, valCS);
    return null;
  }

  public static bool CmpFontSize(DX.OpenXmlCompositeElement openXmlElement, DualHPS? value, DiffList? diffs, string? objName)
  {
    return Int32ValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.FontSize>(), value?.Val, diffs, objName, "FontSize")
      && Int32ValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.FontSizeComplexScript>(), value?.ValCS, diffs, objName, "FontSizeCS");
  }

  public static void SetFontSize(DX.OpenXmlCompositeElement openXmlElement, DualHPS? value)
  {
    Int32ValueConverter.SetHpsMeasureType<DXW.FontSize>(openXmlElement, value?.Val);
    Int32ValueConverter.SetHpsMeasureType<DXW.FontSizeComplexScript>(openXmlElement, value?.ValCS);
  }
  #endregion

  #region Caps conversion.
  public static Boolean? GetCaps(DX.OpenXmlCompositeElement openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.Caps>());
  }

  public static bool CmpCaps(DX.OpenXmlCompositeElement openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.Caps>(), value, diffs, objName);
  }

  public static void SetCaps(DX.OpenXmlCompositeElement openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.Caps>(openXmlElement, value);
  }
  #endregion

  #region SmallCaps conversion.
  public static Boolean? GetSmallCaps(DX.OpenXmlCompositeElement openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.SmallCaps>());
  }

  public static bool CmpSmallCaps(DX.OpenXmlCompositeElement openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.SmallCaps>(), value, diffs, objName);
  }

  public static void SetSmallCaps(DX.OpenXmlCompositeElement openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.SmallCaps>(openXmlElement, value);
  }
  #endregion

  #region Strike conversion.
  public static Boolean? GetStrike(DX.OpenXmlCompositeElement openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.Strike>());
  }

  public static bool CmpStrike(DX.OpenXmlCompositeElement openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.Strike>(), value, diffs, objName);
  }

  public static void SetStrike(DX.OpenXmlCompositeElement openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.Strike>(openXmlElement, value);
  }
  #endregion

  #region DoubleStrike conversion.
  public static Boolean? GetDoubleStrike(DX.OpenXmlCompositeElement openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.DoubleStrike>());
  }

  public static bool CmpDoubleStrike(DX.OpenXmlCompositeElement openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.DoubleStrike>(), value, diffs, objName);
  }

  public static void SetDoubleStrike(DX.OpenXmlCompositeElement openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.DoubleStrike>(openXmlElement, value);
  }
  #endregion

  #region Outline conversion.
  public static Boolean? GetOutline(DX.OpenXmlCompositeElement openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.Outline>());
  }

  public static bool CmpOutline(DX.OpenXmlCompositeElement openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.Outline>(), value, diffs, objName);
  }

  public static void SetOutline(DX.OpenXmlCompositeElement openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.Outline>(openXmlElement, value);
  }
  #endregion

  #region Shadow conversion.
  public static Boolean? GetShadow(DX.OpenXmlCompositeElement openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.Shadow>());
  }

  public static bool CmpShadow(DX.OpenXmlCompositeElement openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.Shadow>(), value, diffs, objName);
  }

  public static void SetShadow(DX.OpenXmlCompositeElement openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.Shadow>(openXmlElement, value);
  }
  #endregion

  #region Emboss conversion.
  public static Boolean? GetEmboss(DX.OpenXmlCompositeElement openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.Emboss>());
  }

  public static bool CmpEmboss(DX.OpenXmlCompositeElement openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.Emboss>(), value, diffs, objName);
  }

  public static void SetEmboss(DX.OpenXmlCompositeElement openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.Emboss>(openXmlElement, value);
  }
  #endregion

  #region Imprint conversion.
  public static Boolean? GetImprint(DX.OpenXmlCompositeElement openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.Imprint>());
  }

  public static bool CmpImprint(DX.OpenXmlCompositeElement openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.Imprint>(), value, diffs, objName);
  }

  public static void SetImprint(DX.OpenXmlCompositeElement openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.Imprint>(openXmlElement, value);
  }
  #endregion

  #region NoProof conversion.
  public static Boolean? GetNoProof(DX.OpenXmlCompositeElement openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.NoProof>());
  }

  public static bool CmpNoProof(DX.OpenXmlCompositeElement openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.NoProof>(), value, diffs, objName);
  }

  public static void SetNoProof(DX.OpenXmlCompositeElement openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.NoProof>(openXmlElement, value);
  }
  #endregion

  #region SnapToGrid conversion.
  public static Boolean? GetSnapToGrid(DX.OpenXmlCompositeElement openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.SnapToGrid>());
  }

  public static bool CmpSnapToGrid(DX.OpenXmlCompositeElement openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.SnapToGrid>(), value, diffs, objName);
  }

  public static void SetSnapToGrid(DX.OpenXmlCompositeElement openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.SnapToGrid>(openXmlElement, value);
  }
  #endregion

  #region Vanish conversion.
  public static Boolean? GetVanish(DX.OpenXmlCompositeElement openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.Vanish>());
  }

  public static bool CmpVanish(DX.OpenXmlCompositeElement openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.Vanish>(), value, diffs, objName);
  }

  public static void SetVanish(DX.OpenXmlCompositeElement openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.Vanish>(openXmlElement, value);
  }
  #endregion

  #region WebHidden conversion.
  public static Boolean? GetWebHidden(DX.OpenXmlCompositeElement openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.WebHidden>());
  }

  public static bool CmpWebHidden(DX.OpenXmlCompositeElement openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.WebHidden>(), value, diffs, objName);
  }

  public static void SetWebHidden(DX.OpenXmlCompositeElement openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.WebHidden>(openXmlElement, value);
  }
  #endregion

  #region Color conversion.
  public static DMW.Color? GetColor(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Color>();
    if (element != null)
      return DMXW.ColorConverter.CreateModelElement(element);
    return null;
  }

  public static bool CmpColor(DX.OpenXmlCompositeElement openXmlElement, DMW.Color? value, DiffList? diffs, string? objName)
  {
    return DMXW.ColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Color>(), value, diffs, objName);
  }

  public static void SetColor(DX.OpenXmlCompositeElement openXmlElement, DMW.Color? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Color>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.ColorConverter.CreateOpenXmlElement<DXW.Color>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region Spacing conversion.
  public static Int32? GetSpacing(DX.OpenXmlCompositeElement openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.Spacing>()?.Val);
  }

  public static bool CmpSpacing(DX.OpenXmlCompositeElement openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.Spacing>()?.Val, value, diffs, objName, "Spacing");
  }

  public static void SetSpacing(DX.OpenXmlCompositeElement openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXW.Spacing, System.Int32>(openXmlElement, value);
  }
  #endregion

  #region CharacterScale conversion.
  public static Int64? GetCharacterScale(DX.OpenXmlCompositeElement openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.CharacterScale>()?.Val);
  }

  public static bool CmpCharacterScale(DX.OpenXmlCompositeElement openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.CharacterScale>()?.Val, value, diffs, objName, "CharacterScale");
  }

  public static void SetCharacterScale(DX.OpenXmlCompositeElement openXmlElement, Int64? value)
  {
    SimpleValueConverter.SetValue<DXW.CharacterScale, System.Int64>(openXmlElement, value);
  }
  #endregion

  #region Kern conversion.
  public static UInt32? GetKern(DX.OpenXmlCompositeElement openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.Kern>()?.Val);
  }

  public static bool CmpKern(DX.OpenXmlCompositeElement openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.Kern>()?.Val, value, diffs, objName, "Kern");
  }

  public static void SetKern(DX.OpenXmlCompositeElement openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXW.Kern, System.UInt32>(openXmlElement, value);
  }
  #endregion

  #region Position conversion.
  public static Int32? GetPosition(DX.OpenXmlCompositeElement openXmlElement)
  {
    return Int32ValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.Position>()?.Val);
  }

  public static bool CmpPosition(DX.OpenXmlCompositeElement openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return Int32ValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.Position>()?.Val, value, diffs, objName, "Position");
  }

  public static void SetPosition(DX.OpenXmlCompositeElement openXmlElement, Int32? value)
  {
    var element = openXmlElement.GetFirstChild<DXW.Position>();
    if (element!=null && value!=null)
    {
      element.Val = ((Int32)value).ToString();
    }
    else if (element==null && value!=null)
    {
      element = new DXW.Position();
      element.Val = ((Int32)value).ToString();
      openXmlElement.AddChild(element);
    }
    else if (element!=null && value==null)
    {
      element.Remove();
    }
  }
  #endregion

  #region Underline conversion.
  public static DMW.Underline? GetUnderline(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Underline>();
    if (element != null)
      return DMXW.UnderlineConverter.CreateModelElement(element);
    return null;
  }

  public static bool CmpUnderline(DX.OpenXmlCompositeElement openXmlElement, DMW.Underline? value, DiffList? diffs, string? objName)
  {
    return DMXW.UnderlineConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Underline>(), value, diffs, objName);
  }

  public static void SetUnderline(DX.OpenXmlCompositeElement openXmlElement, DMW.Underline? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Underline>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.UnderlineConverter.CreateOpenXmlElement<DXW.Underline>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region TextEffect conversion.
  public static DMW.TextEffectKind? GetTextEffect(DX.OpenXmlCompositeElement openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TextEffectValues, DMW.TextEffectKind>(openXmlElement.GetFirstChild<DXW.TextEffect>()?.Val?.Value);
  }

  public static bool CmpTextEffect(DX.OpenXmlCompositeElement openXmlElement, DMW.TextEffectKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.TextEffectValues, DMW.TextEffectKind>(openXmlElement.GetFirstChild<DXW.TextEffect>()?.Val?.Value, value, diffs, objName);
  }

  public static void SetTextEffect(DX.OpenXmlCompositeElement openXmlElement, DMW.TextEffectKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TextEffect>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TextEffectValues, DMW.TextEffectKind>(itemElement, (DMW.TextEffectKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.TextEffect, DocumentFormat.OpenXml.Wordprocessing.TextEffectValues, DMW.TextEffectKind>((DMW.TextEffectKind)value));
  }
  #endregion

  #region Border conversion.
  public static DMW.BorderType? GetBorder(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Border>();
    if (element != null)
      return DMXW.BorderTypeConverter.CreateModelElement(element);
    return null;
  }

  public static bool CmpBorder(DX.OpenXmlCompositeElement openXmlElement, DMW.BorderType? value, DiffList? diffs, string? objName)
  {
    return DMXW.BorderTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Border>(), value, diffs, objName);
  }

  public static void SetBorder(DX.OpenXmlCompositeElement openXmlElement, DMW.BorderType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Border>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BorderTypeConverter.CreateOpenXmlElement<DXW.Border>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region Shading conversion.
  public static DMW.Shading? GetShading(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Shading>();
    if (element != null)
      return DMXW.ShadingConverter.CreateModelElement(element);
    return null;
  }

  public static bool CmpShading(DX.OpenXmlCompositeElement openXmlElement, DMW.Shading? value, DiffList? diffs, string? objName)
  {
    return DMXW.ShadingConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Shading>(), value, diffs, objName);
  }

  public static void SetShading(DX.OpenXmlCompositeElement openXmlElement, DMW.Shading? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Shading>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.ShadingConverter.CreateOpenXmlElement<DXW.Shading>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }

  #endregion

  #region FitText conversion.
  public static DMW.FitText? GetFitText(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.FitText>();
    if (element != null)
      return DMXW.FitTextConverter.CreateModelElement(element);
    return null;
  }

  public static bool CmpFitText(DX.OpenXmlCompositeElement openXmlElement, DMW.FitText? value, DiffList? diffs, string? objName)
  {
    return DMXW.FitTextConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.FitText>(), value, diffs, objName);
  }

  public static void SetFitText(DX.OpenXmlCompositeElement openXmlElement, DMW.FitText? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.FitText>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.FitTextConverter.CreateOpenXmlElement<DXW.FitText>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }

  #endregion

  #region VerticalTextAlignment conversion.
  public static DMW.VerticalPositionKind? GetVerticalTextAlignment(DX.OpenXmlCompositeElement openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.VerticalPositionValues, DMW.VerticalPositionKind>(openXmlElement.GetFirstChild<DXW.VerticalTextAlignment>()?.Val?.Value);
  }

  public static bool CmpVerticalTextAlignment(DX.OpenXmlCompositeElement openXmlElement, DMW.VerticalPositionKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.VerticalPositionValues, DMW.VerticalPositionKind>(openXmlElement.GetFirstChild<DXW.VerticalTextAlignment>()?.Val?.Value, value, diffs, objName);
  }

  public static void SetVerticalTextAlignment(DX.OpenXmlCompositeElement openXmlElement, DMW.VerticalPositionKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.VerticalTextAlignment>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.VerticalPositionValues, DMW.VerticalPositionKind>(itemElement, (DMW.VerticalPositionKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.VerticalTextAlignment, DocumentFormat.OpenXml.Wordprocessing.VerticalPositionValues, DMW.VerticalPositionKind>((DMW.VerticalPositionKind)value));
  }

  #endregion

  #region Emphasis conversion.
  public static DMW.EmphasisMarkKind? GetEmphasis(DX.OpenXmlCompositeElement openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.EmphasisMarkValues, DMW.EmphasisMarkKind>(openXmlElement.GetFirstChild<DXW.Emphasis>()?.Val?.Value);
  }

  public static bool CmpEmphasis(DX.OpenXmlCompositeElement openXmlElement, DMW.EmphasisMarkKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.EmphasisMarkValues, DMW.EmphasisMarkKind>(openXmlElement.GetFirstChild<DXW.Emphasis>()?.Val?.Value, value, diffs, objName);
  }

  public static void SetEmphasis(DX.OpenXmlCompositeElement openXmlElement, DMW.EmphasisMarkKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Emphasis>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.EmphasisMarkValues, DMW.EmphasisMarkKind>(itemElement, (DMW.EmphasisMarkKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.Emphasis, DocumentFormat.OpenXml.Wordprocessing.EmphasisMarkValues, DMW.EmphasisMarkKind>((DMW.EmphasisMarkKind)value));
  }

  #endregion

  #region Languages conversion.
  public static DMW.Languages? GetLanguages(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Languages>();
    if (element != null)
      return DMXW.LanguageTypeConverter.CreateModelElement(element);
    return null;
  }

  public static bool CmpLanguages(DX.OpenXmlCompositeElement openXmlElement, DMW.Languages? value, DiffList? diffs, string? objName)
  {
    return DMXW.LanguageTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Languages>(), value, diffs, objName);
  }

  public static void SetLanguages(DX.OpenXmlCompositeElement openXmlElement, DMW.Languages? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Languages>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.LanguageTypeConverter.CreateOpenXmlElement<DXW.Languages>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }

  #endregion

  #region EastAsianLayout conversion.
  public static DMW.EastAsianLayout? GetEastAsianLayout(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.EastAsianLayout>();
    if (element != null)
      return DMXW.EastAsianLayoutConverter.CreateModelElement(element);
    return null;
  }

  public static bool CmpEastAsianLayout(DX.OpenXmlCompositeElement openXmlElement, DMW.EastAsianLayout? value, DiffList? diffs, string? objName)
  {
    return DMXW.EastAsianLayoutConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.EastAsianLayout>(), value, diffs, objName);
  }

  public static void SetEastAsianLayout(DX.OpenXmlCompositeElement openXmlElement, DMW.EastAsianLayout? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.EastAsianLayout>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.EastAsianLayoutConverter.CreateOpenXmlElement<DXW.EastAsianLayout>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }

  #endregion

  #region SpecVanish conversion.
  public static Boolean? GetSpecVanish(DX.OpenXmlCompositeElement openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.SpecVanish>());
  }

  public static bool CmpSpecVanish(DX.OpenXmlCompositeElement openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.SpecVanish>(), value, diffs, objName);
  }

  public static void SetSpecVanish(DX.OpenXmlCompositeElement openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.SpecVanish>(openXmlElement, value);
  }
  #endregion

  #region RunPropertiesBaseStyle base model conversion methods - for use in other RunProperties converters
  public static void UpdateModelElement(DMW.RunPropertiesBaseStyle value, DX.OpenXmlCompositeElement openXmlElement)
  {
    value.RunFonts = GetRunFonts(openXmlElement);
    value.Bold = GetBold(openXmlElement);
    value.Italic = GetItalic(openXmlElement);
    value.FontSize = GetFontSize(openXmlElement);
    value.Caps = GetCaps(openXmlElement);
    value.SmallCaps = GetSmallCaps(openXmlElement);
    value.Strike = GetStrike(openXmlElement);
    value.DoubleStrike = GetDoubleStrike(openXmlElement);
    value.Outline = GetOutline(openXmlElement);
    value.Shadow = GetShadow(openXmlElement);
    value.Emboss = GetEmboss(openXmlElement);
    value.Imprint = GetImprint(openXmlElement);
    value.NoProof = GetNoProof(openXmlElement);
    value.SnapToGrid = GetSnapToGrid(openXmlElement);
    value.Vanish = GetVanish(openXmlElement);
    value.WebHidden = GetWebHidden(openXmlElement);
    value.Color = GetColor(openXmlElement);
    value.Spacing = GetSpacing(openXmlElement);
    value.CharacterScale = GetCharacterScale(openXmlElement);
    value.Kern = GetKern(openXmlElement);
    value.Position = GetPosition(openXmlElement);
    value.Underline = GetUnderline(openXmlElement);
    value.TextEffect = GetTextEffect(openXmlElement);
    value.Border = GetBorder(openXmlElement);
    value.Shading = GetShading(openXmlElement);
    value.FitText = GetFitText(openXmlElement);
    value.VerticalTextAlignment = GetVerticalTextAlignment(openXmlElement);
    value.Emphasis = GetEmphasis(openXmlElement);
    value.Language = GetLanguages(openXmlElement);
    value.EastAsianLayout = GetEastAsianLayout(openXmlElement);
    value.SpecVanish = GetSpecVanish(openXmlElement);
  }

  public static bool CompareModelElement(DX.OpenXmlCompositeElement? openXmlElement, DMW.RunPropertiesBaseStyle? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRunFonts(openXmlElement, value.RunFonts, diffs, objName))
        ok = false;
      if (!CmpBold(openXmlElement, value.Bold, diffs, objName))
        ok = false;
      if (!CmpItalic(openXmlElement, value.Italic, diffs, objName))
        ok = false;
      if (!CmpFontSize(openXmlElement, value.FontSize, diffs, objName))
        ok = false;
      if (!CmpCaps(openXmlElement, value.Caps, diffs, objName))
        ok = false;
      if (!CmpSmallCaps(openXmlElement, value.SmallCaps, diffs, objName))
        ok = false;
      if (!CmpStrike(openXmlElement, value.Strike, diffs, objName))
        ok = false;
      if (!CmpDoubleStrike(openXmlElement, value.DoubleStrike, diffs, objName))
        ok = false;
      if (!CmpOutline(openXmlElement, value.Outline, diffs, objName))
        ok = false;
      if (!CmpShadow(openXmlElement, value.Shadow, diffs, objName))
        ok = false;
      if (!CmpEmboss(openXmlElement, value.Emboss, diffs, objName))
        ok = false;
      if (!CmpImprint(openXmlElement, value.Imprint, diffs, objName))
        ok = false;
      if (!CmpNoProof(openXmlElement, value.NoProof, diffs, objName))
        ok = false;
      if (!CmpSnapToGrid(openXmlElement, value.SnapToGrid, diffs, objName))
        ok = false;
      if (!CmpVanish(openXmlElement, value.Vanish, diffs, objName))
        ok = false;
      if (!CmpWebHidden(openXmlElement, value.WebHidden, diffs, objName))
        ok = false;
      if (!CmpColor(openXmlElement, value.Color, diffs, objName))
        ok = false;
      if (!CmpSpacing(openXmlElement, value.Spacing, diffs, objName))
        ok = false;
      if (!CmpCharacterScale(openXmlElement, value.CharacterScale, diffs, objName))
        ok = false;
      if (!CmpKern(openXmlElement, value.Kern, diffs, objName))
        ok = false;
      if (!CmpPosition(openXmlElement, value.Position, diffs, objName))
        ok = false;
      if (!CmpUnderline(openXmlElement, value.Underline, diffs, objName))
        ok = false;
      if (!CmpTextEffect(openXmlElement, value.TextEffect, diffs, objName))
        ok = false;
      if (!CmpBorder(openXmlElement, value.Border, diffs, objName))
        ok = false;
      if (!CmpShading(openXmlElement, value.Shading, diffs, objName))
        ok = false;
      if (!CmpFitText(openXmlElement, value.FitText, diffs, objName))
        ok = false;
      if (!CmpVerticalTextAlignment(openXmlElement, value.VerticalTextAlignment, diffs, objName))
        ok = false;
      if (!CmpEmphasis(openXmlElement, value.Emphasis, diffs, objName))
        ok = false;
      if (!CmpLanguages(openXmlElement, value.Language, diffs, objName))
        ok = false;
      if (!CmpEastAsianLayout(openXmlElement, value.EastAsianLayout, diffs, objName))
        ok = false;
      if (!CmpSpecVanish(openXmlElement, value.SpecVanish, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }

  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.RunPropertiesBase value)
    where OpenXmlElementType : DX.OpenXmlCompositeElement, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }

  public static void UpdateOpenXmlElement(DX.OpenXmlCompositeElement openXmlElement, DMW.RunPropertiesBaseStyle value)
  {
    SetRunFonts(openXmlElement, value.RunFonts);
    SetBold(openXmlElement, value.Bold);
    SetItalic(openXmlElement, value.Italic);
    SetFontSize(openXmlElement, value.FontSize);
    SetCaps(openXmlElement, value.Caps);
    SetSmallCaps(openXmlElement, value.SmallCaps);
    SetStrike(openXmlElement, value.Strike);
    SetDoubleStrike(openXmlElement, value.DoubleStrike);
    SetOutline(openXmlElement, value.Outline);
    SetShadow(openXmlElement, value.Shadow);
    SetEmboss(openXmlElement, value.Emboss);
    SetImprint(openXmlElement, value.Imprint);
    SetNoProof(openXmlElement, value.NoProof);
    SetSnapToGrid(openXmlElement, value.SnapToGrid);
    SetVanish(openXmlElement, value.Vanish);
    SetWebHidden(openXmlElement, value.WebHidden);
    SetColor(openXmlElement, value.Color);
    SetSpacing(openXmlElement, value.Spacing);
    SetCharacterScale(openXmlElement, value.CharacterScale);
    SetKern(openXmlElement, value.Kern);
    SetPosition(openXmlElement, value.Position);
    SetUnderline(openXmlElement, value.Underline);
    SetTextEffect(openXmlElement, value.TextEffect);
    SetBorder(openXmlElement, value.Border);
    SetShading(openXmlElement, value.Shading);
    SetFitText(openXmlElement, value.FitText);
    SetVerticalTextAlignment(openXmlElement, value.VerticalTextAlignment);
    SetEmphasis(openXmlElement, value.Emphasis);
    SetLanguages(openXmlElement, value.Language);
    SetEastAsianLayout(openXmlElement, value.EastAsianLayout);
    SetSpecVanish(openXmlElement, value.SpecVanish);
  }
  #endregion

  #region RunPropertiesBaseStyle specific model conversion methods - for use in other elements converters
  public static DMW.RunPropertiesBaseStyle? CreateModelElement(DXW.RunPropertiesBaseStyle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.RunPropertiesBaseStyle();
      RunPropertiesBaseStyleConverter.UpdateModelElement(value, openXmlElement);
      return value;
    }
    return null;
  }
  
  public static DXW.RunPropertiesBaseStyle CreateOpenXmlElement(DMW.RunPropertiesBaseStyle value)
  {
    var openXmlElement = new DXW.RunPropertiesBaseStyle();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  #endregion
}

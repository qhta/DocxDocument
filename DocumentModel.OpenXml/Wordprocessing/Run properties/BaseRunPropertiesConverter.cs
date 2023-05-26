using DocumentModel.OpenXml.Drawings;
using DocumentModel.Wordprocessing;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.BaseRunProperties"/> class from/to OpenXml converter.
/// </summary>
public static class BaseRunPropertiesConverter
{
  #region RunFonts conversion.
  public static DMW.RunFonts? GetRunFonts(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.RunFonts>();
    if (element == null)
      return null;
    if (element != null)
      return DMXW.RunFontsConverter.CreateModelElement(element);
    return null;
  }

  public static bool CmpRunFonts(DX.OpenXmlCompositeElement openXmlElement, DMW.RunFonts? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var element = openXmlElement.GetFirstChild<DXW.RunFonts>();
    return DMXW.RunFontsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.RunFonts>(), value, diffs, objName, propName);
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
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region Bold & BoldComplexScript child elements conversion.
  public static BoldFonts? GetBold(DX.OpenXmlCompositeElement openXmlElement)
  {
    var val = BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.Bold>());
    var valCS = BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.BoldComplexScript>());
    if (val != null || valCS != null)
      return new BoldFonts{ Val=val, CS = valCS };
    return null;
  }

  public static bool CmpBold(DX.OpenXmlCompositeElement openXmlElement, BoldFonts? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.Bold>(), value?.Val, diffs, objName, "Type")
        && BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.BoldComplexScript>(), value?.CS, diffs, objName, "ComplexScript");
  }

  public static void SetBold(DX.OpenXmlCompositeElement openXmlElement, BoldFonts? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.Bold>(openXmlElement, value?.Val, "0", null);
    BooleanValueConverter.SetOnOffType<DXW.BoldComplexScript>(openXmlElement, value?.CS, "0", null);
  }
  #endregion

  #region Italic & ItalicComplexScript child elements conversion.
  public static ItalicFonts? GetItalic(DX.OpenXmlCompositeElement openXmlElement)
  {
    var val = BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.Italic>());
    var valCS = BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.ItalicComplexScript>());
    if (val != null || valCS != null)
      return new ItalicFonts { Val = val, CS = valCS };
    return null;
  }

  public static bool CmpItalic(DX.OpenXmlCompositeElement openXmlElement, ItalicFonts? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.Italic>(), value?.Val, diffs, objName, "Type")
        && BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.ItalicComplexScript>(), value?.CS, diffs, objName, "ComplexScript");
  }

  public static void SetItalic(DX.OpenXmlCompositeElement openXmlElement, ItalicFonts? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.Italic>(openXmlElement, value?.Val, "0", null);
    BooleanValueConverter.SetOnOffType<DXW.ItalicComplexScript>(openXmlElement, value?.CS, "0", null);
  }
  #endregion

  #region FontSize & FontSizeCS child elements conversion.
  public static FontSizes? GetFontSize(DX.OpenXmlCompositeElement openXmlElement)
  {
    var val = Int32ValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.FontSize>()?.Val);
    var valCS = Int32ValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.FontSizeComplexScript>()?.Val);
    if (val != null || valCS != null)
    {
      //Debug.WriteLine($"{val}; {valCS}");
      return new FontSizes(val*10, valCS*10);
    }
    return null;
  }

  public static bool CmpFontSize(DX.OpenXmlCompositeElement openXmlElement, FontSizes? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return Int32ValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.FontSize>(), value?.Val/10, diffs, objName, "FontSize")
      && Int32ValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.FontSizeComplexScript>(), value?.ValCS/10, diffs, objName, "FontSizeCS");
  }

  public static void SetFontSize(DX.OpenXmlCompositeElement openXmlElement, FontSizes? value)
  {
    Int32ValueConverter.SetHpsMeasureType<DXW.FontSize>(openXmlElement, value?.Val/10);
    Int32ValueConverter.SetHpsMeasureType<DXW.FontSizeComplexScript>(openXmlElement, value?.ValCS/10);
  }
  #endregion

  #region Caps conversion.
  public static Boolean? GetCaps(DX.OpenXmlCompositeElement openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.Caps>());
  }

  public static bool CmpCaps(DX.OpenXmlCompositeElement openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.Caps>(), value, diffs, objName, propName);
  }

  public static void SetCaps(DX.OpenXmlCompositeElement openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.Caps>(openXmlElement, value, "0", null);
  }
  #endregion

  #region SmallCaps conversion.
  public static Boolean? GetSmallCaps(DX.OpenXmlCompositeElement openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.SmallCaps>());
  }

  public static bool CmpSmallCaps(DX.OpenXmlCompositeElement openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.SmallCaps>(), value, diffs, objName, propName);
  }

  public static void SetSmallCaps(DX.OpenXmlCompositeElement openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.SmallCaps>(openXmlElement, value, "0", null);
  }
  #endregion

  #region Strike conversion.
  public static Boolean? GetStrike(DX.OpenXmlCompositeElement openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.Strike>());
  }

  public static bool CmpStrike(DX.OpenXmlCompositeElement openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.Strike>(), value, diffs, objName, propName);
  }

  public static void SetStrike(DX.OpenXmlCompositeElement openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.Strike>(openXmlElement, value, "0", null);
  }
  #endregion

  #region DoubleStrike conversion.
  public static Boolean? GetDoubleStrike(DX.OpenXmlCompositeElement openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.DoubleStrike>());
  }

  public static bool CmpDoubleStrike(DX.OpenXmlCompositeElement openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.DoubleStrike>(), value, diffs, objName, propName);
  }

  public static void SetDoubleStrike(DX.OpenXmlCompositeElement openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.DoubleStrike>(openXmlElement, value, "0", null);
  }
  #endregion

  #region Outline conversion.
  public static Boolean? GetOutline(DX.OpenXmlCompositeElement openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.Outline>());
  }

  public static bool CmpOutline(DX.OpenXmlCompositeElement openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.Outline>(), value, diffs, objName, propName);
  }

  public static void SetOutline(DX.OpenXmlCompositeElement openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.Outline>(openXmlElement, value, "0", null);
  }
  #endregion

  #region Shadow conversion.
  public static Boolean? GetShadow(DX.OpenXmlCompositeElement openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.Shadow>());
  }

  public static bool CmpShadow(DX.OpenXmlCompositeElement openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.Shadow>(), value, diffs, objName, propName);
  }

  public static void SetShadow(DX.OpenXmlCompositeElement openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.Shadow>(openXmlElement, value, "0", null);
  }
  #endregion

  #region Emboss conversion.
  public static Boolean? GetEmboss(DX.OpenXmlCompositeElement openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.Emboss>());
  }

  public static bool CmpEmboss(DX.OpenXmlCompositeElement openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.Emboss>(), value, diffs, objName, propName);
  }

  public static void SetEmboss(DX.OpenXmlCompositeElement openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.Emboss>(openXmlElement, value, "0", null);
  }
  #endregion

  #region Imprint conversion.
  public static Boolean? GetImprint(DX.OpenXmlCompositeElement openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.Imprint>());
  }

  public static bool CmpImprint(DX.OpenXmlCompositeElement openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.Imprint>(), value, diffs, objName, propName);
  }

  public static void SetImprint(DX.OpenXmlCompositeElement openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.Imprint>(openXmlElement, value, "0", null);
  }
  #endregion

  #region NoProof conversion.
  public static Boolean? GetNoProof(DX.OpenXmlCompositeElement openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.NoProof>());
  }

  public static bool CmpNoProof(DX.OpenXmlCompositeElement openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.NoProof>(), value, diffs, objName, propName);
  }

  public static void SetNoProof(DX.OpenXmlCompositeElement openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.NoProof>(openXmlElement, value, "0", null);
  }
  #endregion

  #region SnapToGrid conversion.
  public static Boolean? GetSnapToGrid(DX.OpenXmlCompositeElement openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.SnapToGrid>());
  }

  public static bool CmpSnapToGrid(DX.OpenXmlCompositeElement openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.SnapToGrid>(), value, diffs, objName, propName);
  }

  public static void SetSnapToGrid(DX.OpenXmlCompositeElement openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.SnapToGrid>(openXmlElement, value, "0", null);
  }
  #endregion

  #region Vanish conversion.
  public static Boolean? GetVanish(DX.OpenXmlCompositeElement openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.Vanish>());
  }

  public static bool CmpVanish(DX.OpenXmlCompositeElement openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.Vanish>(), value, diffs, objName, propName);
  }

  public static void SetVanish(DX.OpenXmlCompositeElement openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.Vanish>(openXmlElement, value, "0", null);
  }
  #endregion

  #region WebHidden conversion.
  public static Boolean? GetWebHidden(DX.OpenXmlCompositeElement openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.WebHidden>());
  }

  public static bool CmpWebHidden(DX.OpenXmlCompositeElement openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.WebHidden>(), value, diffs, objName, propName);
  }

  public static void SetWebHidden(DX.OpenXmlCompositeElement openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.WebHidden>(openXmlElement, value, "0", null);
  }
  #endregion

  #region Color conversion.
  public static DM.Color? GetColor(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Color>();
    if (element != null)
      return DMXW.ColorConverter.CreateModelElement(element);
    return null;
  }

  public static bool CmpColor(DX.OpenXmlCompositeElement openXmlElement, DM.Color? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.ColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Color>(), value, diffs, objName, propName);
  }

  public static void SetColor(DX.OpenXmlCompositeElement openXmlElement, DM.Color? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Color>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.ColorConverter.CreateOpenXmlElement<DXW.Color>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region Spacing conversion.
  public static Int32? GetSpacing(DX.OpenXmlCompositeElement openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.Spacing>()?.Val);
  }

  public static bool CmpSpacing(DX.OpenXmlCompositeElement openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
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

  public static bool CmpCharacterScale(DX.OpenXmlCompositeElement openXmlElement, Int64? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.CharacterScale>()?.Val, value, diffs, objName, "CharacterScale");
  }

  public static void SetCharacterScale(DX.OpenXmlCompositeElement openXmlElement, Int64? value)
  {
    SimpleValueConverter.SetValue<DXW.CharacterScale, System.Int64>(openXmlElement, value);
  }
  #endregion

  #region Kern conversion.
  public static Twips? GetKern(DX.OpenXmlCompositeElement openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.Kern>()?.Val)*10;
  }

  public static bool CmpKern(DX.OpenXmlCompositeElement openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.Kern>()?.Val, value/10, diffs, objName, "Kern");
  }

  public static void SetKern(DX.OpenXmlCompositeElement openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXW.Kern, System.UInt32>(openXmlElement, value/10);
  }
  #endregion

  #region Position conversion.
  public static Int32? GetPosition(DX.OpenXmlCompositeElement openXmlElement)
  {
    return Int32ValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.Position>()?.Val)*10;
  }

  public static bool CmpPosition(DX.OpenXmlCompositeElement openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return Int32ValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.Position>()?.Val, value/10, diffs, objName, "Position");
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
      element.Val = ((Int32)value/10).ToString();
      openXmlElement.AppendChild(element);
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

  public static bool CmpUnderline(DX.OpenXmlCompositeElement openXmlElement, DMW.Underline? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.UnderlineConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Underline>(), value, diffs, objName, propName);
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
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region TextEffect conversion.
  public static DMW.TextEffectKind? GetTextEffect(DX.OpenXmlCompositeElement openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.TextEffectValues, DMW.TextEffectKind>(openXmlElement.GetFirstChild<DXW.TextEffect>()?.Val?.Value);
  }

  public static bool CmpTextEffect(DX.OpenXmlCompositeElement openXmlElement, DMW.TextEffectKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DXW.TextEffectValues, DMW.TextEffectKind>(openXmlElement.GetFirstChild<DXW.TextEffect>()?.Val?.Value, value, diffs, objName, propName);
  }

  public static void SetTextEffect(DX.OpenXmlCompositeElement openXmlElement, DMW.TextEffectKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TextEffect>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DXW.TextEffectValues, DMW.TextEffectKind>(itemElement, (DMW.TextEffectKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXW.TextEffect, DXW.TextEffectValues, DMW.TextEffectKind>((DMW.TextEffectKind)value));
  }
  #endregion

  #region Border conversion.
  public static DMW.Border? GetBorder(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Border>();
    if (element != null)
      return DMXW.BorderConverter.CreateModelElement(element);
    return null;
  }

  public static bool CmpBorder(DX.OpenXmlCompositeElement openXmlElement, DMW.Border? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.BorderConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Border>(), value, diffs, objName, propName);
  }

  public static void SetBorder(DX.OpenXmlCompositeElement openXmlElement, DMW.Border? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Border>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BorderConverter.CreateOpenXmlElement<DXW.Border>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
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

  public static bool CmpShading(DX.OpenXmlCompositeElement openXmlElement, DMW.Shading? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.ShadingConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Shading>(), value, diffs, objName, propName);
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
        openXmlElement.AppendChild(itemElement);
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

  public static bool CmpFitText(DX.OpenXmlCompositeElement openXmlElement, DMW.FitText? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.FitTextConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.FitText>(), value, diffs, objName, propName);
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
        openXmlElement.AppendChild(itemElement);
    }
  }

  #endregion

  #region VerticalTextAlignment conversion.
  public static DMW.VerticalPositionKind? GetVerticalTextAlignment(DX.OpenXmlCompositeElement openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.VerticalPositionValues, DMW.VerticalPositionKind>(openXmlElement.GetFirstChild<DXW.VerticalTextAlignment>()?.Val?.Value);
  }

  public static bool CmpVerticalTextAlignment(DX.OpenXmlCompositeElement openXmlElement, DMW.VerticalPositionKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DXW.VerticalPositionValues, DMW.VerticalPositionKind>(openXmlElement.GetFirstChild<DXW.VerticalTextAlignment>()?.Val?.Value, value, diffs, objName, propName);
  }

  public static void SetVerticalTextAlignment(DX.OpenXmlCompositeElement openXmlElement, DMW.VerticalPositionKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.VerticalTextAlignment>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DXW.VerticalPositionValues, DMW.VerticalPositionKind>(itemElement, (DMW.VerticalPositionKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXW.VerticalTextAlignment, DXW.VerticalPositionValues, DMW.VerticalPositionKind>((DMW.VerticalPositionKind)value));
  }

  #endregion

  #region Emphasis conversion.
  public static DMW.EmphasisMarkKind? GetEmphasis(DX.OpenXmlCompositeElement openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.EmphasisMarkValues, DMW.EmphasisMarkKind>(openXmlElement.GetFirstChild<DXW.Emphasis>()?.Val?.Value);
  }

  public static bool CmpEmphasis(DX.OpenXmlCompositeElement openXmlElement, DMW.EmphasisMarkKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DXW.EmphasisMarkValues, DMW.EmphasisMarkKind>(openXmlElement.GetFirstChild<DXW.Emphasis>()?.Val?.Value, value, diffs, objName, propName);
  }

  public static void SetEmphasis(DX.OpenXmlCompositeElement openXmlElement, DMW.EmphasisMarkKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Emphasis>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DXW.EmphasisMarkValues, DMW.EmphasisMarkKind>(itemElement, (DMW.EmphasisMarkKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXW.Emphasis, DXW.EmphasisMarkValues, DMW.EmphasisMarkKind>((DMW.EmphasisMarkKind)value));
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

  public static bool CmpLanguages(DX.OpenXmlCompositeElement openXmlElement, DMW.Languages? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.LanguageTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Languages>(), value, diffs, objName, propName);
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
        openXmlElement.AppendChild(itemElement);
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

  public static bool CmpEastAsianLayout(DX.OpenXmlCompositeElement openXmlElement, DMW.EastAsianLayout? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.EastAsianLayoutConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.EastAsianLayout>(), value, diffs, objName, propName);
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
        openXmlElement.AppendChild(itemElement);
    }
  }

  #endregion

  #region SpecVanish conversion.
  public static Boolean? GetSpecVanish(DX.OpenXmlCompositeElement openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.SpecVanish>());
  }

  public static bool CmpSpecVanish(DX.OpenXmlCompositeElement openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.SpecVanish>(), value, diffs, objName, propName);
  }

  public static void SetSpecVanish(DX.OpenXmlCompositeElement openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.SpecVanish>(openXmlElement, value, "0", null);
  }
  #endregion

  #region BaseRunProperties model conversion.
  public static ModelElementType? CreateModelElement<ModelElementType>(DX.OpenXmlCompositeElement? openXmlElement)
    where ModelElementType : DMW.BaseRunProperties, new()
  {
    if (openXmlElement != null)
    {
      var model = new ModelElementType();
      UpdateModelElement(model, openXmlElement);
      return model;
    }
    return null;
  }

  public static DXW.RunPropertiesBaseStyle CreateOpenXmlElement(DMW.BaseRunProperties model)
  {
    var openXmlElement = new DXW.RunPropertiesBaseStyle();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }

  public static void UpdateModelElement(DMW.BaseRunProperties model, DX.OpenXmlCompositeElement openXmlElement)
  {
    model.RunFonts = GetRunFonts(openXmlElement);
    model.Bold = GetBold(openXmlElement);
    model.Italic = GetItalic(openXmlElement);
    model.FontSize = GetFontSize(openXmlElement);
    model.Caps = GetCaps(openXmlElement);
    model.SmallCaps = GetSmallCaps(openXmlElement);
    model.Strike = GetStrike(openXmlElement);
    model.DoubleStrike = GetDoubleStrike(openXmlElement);
    model.Outline = GetOutline(openXmlElement);
    model.Shadow = GetShadow(openXmlElement);
    model.Emboss = GetEmboss(openXmlElement);
    model.Imprint = GetImprint(openXmlElement);
    model.NoProof = GetNoProof(openXmlElement);
    model.SnapToGrid = GetSnapToGrid(openXmlElement);
    model.Vanish = GetVanish(openXmlElement);
    model.WebHidden = GetWebHidden(openXmlElement);
    model.Color = GetColor(openXmlElement);
    model.Spacing = GetSpacing(openXmlElement);
    model.CharacterScale = GetCharacterScale(openXmlElement);
    model.Kern = GetKern(openXmlElement);
    model.Position = GetPosition(openXmlElement);
    model.Underline = GetUnderline(openXmlElement);
    model.TextEffect = GetTextEffect(openXmlElement);
    model.Border = GetBorder(openXmlElement);
    model.Shading = GetShading(openXmlElement);
    model.FitText = GetFitText(openXmlElement);
    model.VerticalTextAlignment = GetVerticalTextAlignment(openXmlElement);
    model.Emphasis = GetEmphasis(openXmlElement);
    model.Language = GetLanguages(openXmlElement);
    model.EastAsianLayout = GetEastAsianLayout(openXmlElement);
    model.SpecVanish = GetSpecVanish(openXmlElement);
    DXO10WPropertiesConverter.UpdateRunProperties(model, openXmlElement);
  }

  public static bool CompareModelElement(DX.OpenXmlCompositeElement? openXmlElement, DMW.BaseRunProperties? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpRunFonts(openXmlElement, model.RunFonts, diffs, objName, propName))
        ok = false;
      if (!CmpBold(openXmlElement, model.Bold, diffs, objName, propName))
        ok = false;
      if (!CmpItalic(openXmlElement, model.Italic, diffs, objName, propName))
        ok = false;
      if (!CmpFontSize(openXmlElement, model.FontSize, diffs, objName, propName))
        ok = false;
      if (!CmpCaps(openXmlElement, model.Caps, diffs, objName, propName))
        ok = false;
      if (!CmpSmallCaps(openXmlElement, model.SmallCaps, diffs, objName, propName))
        ok = false;
      if (!CmpStrike(openXmlElement, model.Strike, diffs, objName, propName))
        ok = false;
      if (!CmpDoubleStrike(openXmlElement, model.DoubleStrike, diffs, objName, propName))
        ok = false;
      if (!CmpOutline(openXmlElement, model.Outline, diffs, objName, propName))
        ok = false;
      if (!CmpShadow(openXmlElement, model.Shadow, diffs, objName, propName))
        ok = false;
      if (!CmpEmboss(openXmlElement, model.Emboss, diffs, objName, propName))
        ok = false;
      if (!CmpImprint(openXmlElement, model.Imprint, diffs, objName, propName))
        ok = false;
      if (!CmpNoProof(openXmlElement, model.NoProof, diffs, objName, propName))
        ok = false;
      if (!CmpSnapToGrid(openXmlElement, model.SnapToGrid, diffs, objName, propName))
        ok = false;
      if (!CmpVanish(openXmlElement, model.Vanish, diffs, objName, propName))
        ok = false;
      if (!CmpWebHidden(openXmlElement, model.WebHidden, diffs, objName, propName))
        ok = false;
      if (!CmpColor(openXmlElement, model.Color, diffs, objName, propName))
        ok = false;
      if (!CmpSpacing(openXmlElement, model.Spacing, diffs, objName, propName))
        ok = false;
      if (!CmpCharacterScale(openXmlElement, model.CharacterScale, diffs, objName, propName))
        ok = false;
      if (!CmpKern(openXmlElement, model.Kern, diffs, objName, propName))
        ok = false;
      if (!CmpPosition(openXmlElement, model.Position, diffs, objName, propName))
        ok = false;
      if (!CmpUnderline(openXmlElement, model.Underline, diffs, objName, propName))
        ok = false;
      if (!CmpTextEffect(openXmlElement, model.TextEffect, diffs, objName, propName))
        ok = false;
      if (!CmpBorder(openXmlElement, model.Border, diffs, objName, propName))
        ok = false;
      if (!CmpShading(openXmlElement, model.Shading, diffs, objName, propName))
        ok = false;
      if (!CmpFitText(openXmlElement, model.FitText, diffs, objName, propName))
        ok = false;
      if (!CmpVerticalTextAlignment(openXmlElement, model.VerticalTextAlignment, diffs, objName, propName))
        ok = false;
      if (!CmpEmphasis(openXmlElement, model.Emphasis, diffs, objName, propName))
        ok = false;
      if (!CmpLanguages(openXmlElement, model.Language, diffs, objName, propName))
        ok = false;
      if (!CmpEastAsianLayout(openXmlElement, model.EastAsianLayout, diffs, objName, propName))
        ok = false;
      if (!CmpSpecVanish(openXmlElement, model.SpecVanish, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  public static void UpdateOpenXmlElement(DX.OpenXmlCompositeElement openXmlElement, DMW.BaseRunProperties model)
  {
    SetRunFonts(openXmlElement, model.RunFonts);
    SetBold(openXmlElement, model.Bold);
    SetItalic(openXmlElement, model.Italic);
    SetFontSize(openXmlElement, model.FontSize);
    SetCaps(openXmlElement, model.Caps);
    SetSmallCaps(openXmlElement, model.SmallCaps);
    SetStrike(openXmlElement, model.Strike);
    SetDoubleStrike(openXmlElement, model.DoubleStrike);
    SetOutline(openXmlElement, model.Outline);
    SetShadow(openXmlElement, model.Shadow);
    SetEmboss(openXmlElement, model.Emboss);
    SetImprint(openXmlElement, model.Imprint);
    SetNoProof(openXmlElement, model.NoProof);
    SetSnapToGrid(openXmlElement, model.SnapToGrid);
    SetVanish(openXmlElement, model.Vanish);
    SetWebHidden(openXmlElement, model.WebHidden);
    SetColor(openXmlElement, model.Color);
    SetSpacing(openXmlElement, model.Spacing);
    SetCharacterScale(openXmlElement, model.CharacterScale);
    SetKern(openXmlElement, model.Kern);
    SetPosition(openXmlElement, model.Position);
    SetUnderline(openXmlElement, model.Underline);
    SetTextEffect(openXmlElement, model.TextEffect);
    SetBorder(openXmlElement, model.Border);
    SetShading(openXmlElement, model.Shading);
    SetFitText(openXmlElement, model.FitText);
    SetVerticalTextAlignment(openXmlElement, model.VerticalTextAlignment);
    SetEmphasis(openXmlElement, model.Emphasis);
    SetLanguages(openXmlElement, model.Language);
    SetEastAsianLayout(openXmlElement, model.EastAsianLayout);
    SetSpecVanish(openXmlElement, model.SpecVanish);
  }

  #endregion
}

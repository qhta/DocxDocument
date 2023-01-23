namespace DocumentModel.OpenXml.Drawings.ChartsStyle;

/// <summary>
/// Defines the TextCharacterPropertiesType Class.
/// </summary>
public static class TextCharacterPropertiesTypeConverter
{
  /// <summary>
  /// Gets or sets the  value. It is only available for backwards compatibility
  /// </summary>
  private static Boolean? GetSmtClean(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.SmtClean?.Value;
  }
  
  private static bool CmpSmtClean(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.SmtClean?.Value == value;
  }
  
  private static void SetSmtClean(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.SmtClean = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.SmtClean = null;
  }
  
  /// <summary>
  /// Gets or sets the  value. It is only available for backwards compatibility
  /// </summary>
  private static UInt32? GetSmtId(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement.SmtId?.Value;
  }
  
  private static bool CmpSmtId(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.SmtId?.Value == value;
  }
  
  private static void SetSmtId(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, UInt32? value)
  {
    openXmlElement.SmtId = value;
  }
  
  /// <summary>
  /// kumimoji
  /// </summary>
  private static Boolean? GetKumimoji(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.Kumimoji?.Value;
  }
  
  private static bool CmpKumimoji(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Kumimoji?.Value == value;
  }
  
  private static void SetKumimoji(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Kumimoji = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Kumimoji = null;
  }
  
  /// <summary>
  /// lang
  /// </summary>
  private static String? GetLanguage(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.Language?.Value;
  }
  
  private static bool CmpLanguage(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Language?.Value == value;
  }
  
  private static void SetLanguage(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Language = new StringValue { Value = value };
    else
      openXmlElement.Language = null;
  }
  
  /// <summary>
  /// altLang
  /// </summary>
  private static String? GetAlternativeLanguage(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.AlternativeLanguage?.Value;
  }
  
  private static bool CmpAlternativeLanguage(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.AlternativeLanguage?.Value == value;
  }
  
  private static void SetAlternativeLanguage(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.AlternativeLanguage = new StringValue { Value = value };
    else
      openXmlElement.AlternativeLanguage = null;
  }
  
  /// <summary>
  /// sz
  /// </summary>
  private static Int32? GetFontSize(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement.FontSize?.Value;
  }
  
  private static bool CmpFontSize(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.FontSize?.Value == value;
  }
  
  private static void SetFontSize(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, Int32? value)
  {
    openXmlElement.FontSize = value;
  }
  
  /// <summary>
  /// b
  /// </summary>
  private static Boolean? GetBold(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.Bold?.Value;
  }
  
  private static bool CmpBold(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Bold?.Value == value;
  }
  
  private static void SetBold(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Bold = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Bold = null;
  }
  
  /// <summary>
  /// i
  /// </summary>
  private static Boolean? GetItalic(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.Italic?.Value;
  }
  
  private static bool CmpItalic(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Italic?.Value == value;
  }
  
  private static void SetItalic(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Italic = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Italic = null;
  }
  
  /// <summary>
  /// u
  /// </summary>
  private static DMDraws.TextUnderlineKind? GetUnderline(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextUnderlineValues, DMDraws.TextUnderlineKind>(openXmlElement?.Underline?.Value);
  }
  
  private static bool CmpUnderline(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, DMDraws.TextUnderlineKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.TextUnderlineValues, DMDraws.TextUnderlineKind>(openXmlElement?.Underline?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetUnderline(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, DMDraws.TextUnderlineKind? value)
  {
    openXmlElement.Underline = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextUnderlineValues, DMDraws.TextUnderlineKind>(value);
  }
  
  /// <summary>
  /// strike
  /// </summary>
  private static DMDraws.TextStrikeKind? GetStrike(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextStrikeValues, DMDraws.TextStrikeKind>(openXmlElement?.Strike?.Value);
  }
  
  private static bool CmpStrike(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, DMDraws.TextStrikeKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.TextStrikeValues, DMDraws.TextStrikeKind>(openXmlElement?.Strike?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetStrike(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, DMDraws.TextStrikeKind? value)
  {
    openXmlElement.Strike = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextStrikeValues, DMDraws.TextStrikeKind>(value);
  }
  
  /// <summary>
  /// kern
  /// </summary>
  private static Int32? GetKerning(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement.Kerning?.Value;
  }
  
  private static bool CmpKerning(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.Kerning?.Value == value;
  }
  
  private static void SetKerning(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, Int32? value)
  {
    openXmlElement.Kerning = value;
  }
  
  /// <summary>
  /// cap
  /// </summary>
  private static DMDraws.TextCapsKind? GetCapital(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextCapsValues, DMDraws.TextCapsKind>(openXmlElement?.Capital?.Value);
  }
  
  private static bool CmpCapital(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, DMDraws.TextCapsKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.TextCapsValues, DMDraws.TextCapsKind>(openXmlElement?.Capital?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCapital(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, DMDraws.TextCapsKind? value)
  {
    openXmlElement.Capital = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextCapsValues, DMDraws.TextCapsKind>(value);
  }
  
  /// <summary>
  /// spc
  /// </summary>
  private static Int32? GetSpacing(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement.Spacing?.Value;
  }
  
  private static bool CmpSpacing(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.Spacing?.Value == value;
  }
  
  private static void SetSpacing(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, Int32? value)
  {
    openXmlElement.Spacing = value;
  }
  
  /// <summary>
  /// normalizeH
  /// </summary>
  private static Boolean? GetNormalizeHeight(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.NormalizeHeight?.Value;
  }
  
  private static bool CmpNormalizeHeight(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.NormalizeHeight?.Value == value;
  }
  
  private static void SetNormalizeHeight(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NormalizeHeight = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NormalizeHeight = null;
  }
  
  /// <summary>
  /// baseline
  /// </summary>
  private static Int32? GetBaseline(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement.Baseline?.Value;
  }
  
  private static bool CmpBaseline(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.Baseline?.Value == value;
  }
  
  private static void SetBaseline(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, Int32? value)
  {
    openXmlElement.Baseline = value;
  }
  
  /// <summary>
  /// noProof
  /// </summary>
  private static Boolean? GetNoProof(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.NoProof?.Value;
  }
  
  private static bool CmpNoProof(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.NoProof?.Value == value;
  }
  
  private static void SetNoProof(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoProof = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoProof = null;
  }
  
  /// <summary>
  /// dirty
  /// </summary>
  private static Boolean? GetDirty(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.Dirty?.Value;
  }
  
  private static bool CmpDirty(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Dirty?.Value == value;
  }
  
  private static void SetDirty(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Dirty = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Dirty = null;
  }
  
  /// <summary>
  /// err
  /// </summary>
  private static Boolean? GetSpellingError(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.SpellingError?.Value;
  }
  
  private static bool CmpSpellingError(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.SpellingError?.Value == value;
  }
  
  private static void SetSpellingError(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.SpellingError = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.SpellingError = null;
  }
  
  /// <summary>
  /// smtClean
  /// </summary>
  private static Boolean? GetSmartTagClean(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.SmartTagClean?.Value;
  }
  
  private static bool CmpSmartTagClean(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.SmartTagClean?.Value == value;
  }
  
  private static void SetSmartTagClean(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.SmartTagClean = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.SmartTagClean = null;
  }
  
  /// <summary>
  /// smtId
  /// </summary>
  private static UInt32? GetSmartTagId(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement.SmartTagId?.Value;
  }
  
  private static bool CmpSmartTagId(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.SmartTagId?.Value == value;
  }
  
  private static void SetSmartTagId(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, UInt32? value)
  {
    openXmlElement.SmartTagId = value;
  }
  
  /// <summary>
  /// bmk
  /// </summary>
  private static String? GetBookmark(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.Bookmark?.Value;
  }
  
  private static bool CmpBookmark(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Bookmark?.Value == value;
  }
  
  private static void SetBookmark(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Bookmark = new StringValue { Value = value };
    else
      openXmlElement.Bookmark = null;
  }
  
  /// <summary>
  /// Outline.
  /// </summary>
  private static DMDraws.Outline? GetOutline(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement)
  {
    return DMXDraws.OutlineConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.Outline>());
  }
  
  private static bool CmpOutline(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, DMDraws.Outline? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.OutlineConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.Outline>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetOutline(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, DMDraws.Outline? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Outline>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.OutlineConverter.CreateOpenXmlElement<DXDraw.Outline>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetNoFill(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDraw.NoFill>() != null;
  }
  
  private static bool CmpNoFill(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXDraw.NoFill>() != null == value;
  }
  
  private static void SetNoFill(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDraw.NoFill>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDraw.NoFill();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.SolidFill? GetSolidFill(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement)
  {
    return DMXDraws.SolidFillConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.SolidFill>());
  }
  
  private static bool CmpSolidFill(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, DMDraws.SolidFill? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.SolidFillConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.SolidFill>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSolidFill(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, DMDraws.SolidFill? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.SolidFill>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.SolidFillConverter.CreateOpenXmlElement<DXDraw.SolidFill>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.GradientFill? GetGradientFill(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement)
  {
    return DMXDraws.GradientFillConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.GradientFill>());
  }
  
  private static bool CmpGradientFill(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, DMDraws.GradientFill? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.GradientFillConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.GradientFill>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetGradientFill(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, DMDraws.GradientFill? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.GradientFill>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.GradientFillConverter.CreateOpenXmlElement<DXDraw.GradientFill>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.BlipFill? GetBlipFill(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement)
  {
    return DMXDraws.BlipFillConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.BlipFill>());
  }
  
  private static bool CmpBlipFill(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, DMDraws.BlipFill? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.BlipFillConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.BlipFill>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBlipFill(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, DMDraws.BlipFill? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.BlipFill>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.BlipFillConverter.CreateOpenXmlElement<DXDraw.BlipFill>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.PatternFill? GetPatternFill(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement)
  {
    return DMXDraws.PatternFillConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.PatternFill>());
  }
  
  private static bool CmpPatternFill(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, DMDraws.PatternFill? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.PatternFillConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.PatternFill>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPatternFill(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, DMDraws.PatternFill? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.PatternFill>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.PatternFillConverter.CreateOpenXmlElement<DXDraw.PatternFill>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetGroupFill(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDraw.GroupFill>() != null;
  }
  
  private static bool CmpGroupFill(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXDraw.GroupFill>() != null == value;
  }
  
  private static void SetGroupFill(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDraw.GroupFill>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDraw.GroupFill();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.EffectList? GetEffectList(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement)
  {
    return DMXDraws.EffectListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.EffectList>());
  }
  
  private static bool CmpEffectList(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, DMDraws.EffectList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.EffectListConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.EffectList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetEffectList(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, DMDraws.EffectList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.EffectList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.EffectListConverter.CreateOpenXmlElement<DXDraw.EffectList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.EffectDag? GetEffectDag(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement)
  {
    return DMXDraws.EffectDagConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.EffectDag>());
  }
  
  private static bool CmpEffectDag(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, DMDraws.EffectDag? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.EffectDagConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.EffectDag>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetEffectDag(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, DMDraws.EffectDag? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.EffectDag>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.EffectDagConverter.CreateOpenXmlElement<DXDraw.EffectDag>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.Highlight? GetHighlight(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement)
  {
    return DMXDraws.HighlightConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.Highlight>());
  }
  
  private static bool CmpHighlight(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, DMDraws.Highlight? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.HighlightConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.Highlight>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetHighlight(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, DMDraws.Highlight? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Highlight>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.HighlightConverter.CreateOpenXmlElement<DXDraw.Highlight>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetUnderlineFollowsText(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDraw.UnderlineFollowsText>() != null;
  }
  
  private static bool CmpUnderlineFollowsText(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXDraw.UnderlineFollowsText>() != null == value;
  }
  
  private static void SetUnderlineFollowsText(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDraw.UnderlineFollowsText>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDraw.UnderlineFollowsText();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetUnderlineFillText(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDraw.UnderlineFillText>() != null;
  }
  
  private static bool CmpUnderlineFillText(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXDraw.UnderlineFillText>() != null == value;
  }
  
  private static void SetUnderlineFillText(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDraw.UnderlineFillText>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDraw.UnderlineFillText();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.UnderlineFill? GetUnderlineFill(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement)
  {
    return DMXDraws.UnderlineFillConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.UnderlineFill>());
  }
  
  private static bool CmpUnderlineFill(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, DMDraws.UnderlineFill? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.UnderlineFillConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.UnderlineFill>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetUnderlineFill(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, DMDraws.UnderlineFill? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.UnderlineFill>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.UnderlineFillConverter.CreateOpenXmlElement<DXDraw.UnderlineFill>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.TextFontType? GetLatinFont(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement)
  {
    return DMXDraws.TextFontTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.LatinFont>());
  }
  
  private static bool CmpLatinFont(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, DMDraws.TextFontType? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.TextFontTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.LatinFont>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLatinFont(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, DMDraws.TextFontType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.LatinFont>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.TextFontTypeConverter.CreateOpenXmlElement<DXDraw.LatinFont>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.TextFontType? GetEastAsianFont(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement)
  {
    return DMXDraws.TextFontTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.EastAsianFont>());
  }
  
  private static bool CmpEastAsianFont(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, DMDraws.TextFontType? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.TextFontTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.EastAsianFont>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetEastAsianFont(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, DMDraws.TextFontType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.EastAsianFont>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.TextFontTypeConverter.CreateOpenXmlElement<DXDraw.EastAsianFont>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.TextFontType? GetComplexScriptFont(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement)
  {
    return DMXDraws.TextFontTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.ComplexScriptFont>());
  }
  
  private static bool CmpComplexScriptFont(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, DMDraws.TextFontType? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.TextFontTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.ComplexScriptFont>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetComplexScriptFont(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, DMDraws.TextFontType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.ComplexScriptFont>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.TextFontTypeConverter.CreateOpenXmlElement<DXDraw.ComplexScriptFont>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.TextFontType? GetSymbolFont(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement)
  {
    return DMXDraws.TextFontTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.SymbolFont>());
  }
  
  private static bool CmpSymbolFont(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, DMDraws.TextFontType? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.TextFontTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.SymbolFont>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSymbolFont(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, DMDraws.TextFontType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.SymbolFont>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.TextFontTypeConverter.CreateOpenXmlElement<DXDraw.SymbolFont>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.HyperlinkOnClick? GetHyperlinkOnClick(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement)
  {
    return DMXDraws.HyperlinkOnClickConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.HyperlinkOnClick>());
  }
  
  private static bool CmpHyperlinkOnClick(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, DMDraws.HyperlinkOnClick? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.HyperlinkOnClickConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.HyperlinkOnClick>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetHyperlinkOnClick(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, DMDraws.HyperlinkOnClick? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.HyperlinkOnClick>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.HyperlinkOnClickConverter.CreateOpenXmlElement<DXDraw.HyperlinkOnClick>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.HyperlinkOnMouseOver? GetHyperlinkOnMouseOver(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement)
  {
    return DMXDraws.HyperlinkOnMouseOverConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.HyperlinkOnMouseOver>());
  }
  
  private static bool CmpHyperlinkOnMouseOver(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, DMDraws.HyperlinkOnMouseOver? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.HyperlinkOnMouseOverConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.HyperlinkOnMouseOver>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetHyperlinkOnMouseOver(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, DMDraws.HyperlinkOnMouseOver? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.HyperlinkOnMouseOver>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.HyperlinkOnMouseOverConverter.CreateOpenXmlElement<DXDraw.HyperlinkOnMouseOver>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetRightToLeft(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDraw.RightToLeft>() != null;
  }
  
  private static bool CmpRightToLeft(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXDraw.RightToLeft>() != null == value;
  }
  
  private static void SetRightToLeft(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDraw.RightToLeft>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDraw.RightToLeft();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.ExtensionList? GetExtensionList(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement)
  {
    return DMXDraws.ExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.ExtensionList>());
  }
  
  private static bool CmpExtensionList(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, DMDraws.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ExtensionListConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtensionList(DXO2013DrawChartStyle.TextCharacterPropertiesType openXmlElement, DMDraws.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ExtensionListConverter.CreateOpenXmlElement<DXDraw.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsChartsStyle.TextCharacterPropertiesType? CreateModelElement(DXO2013DrawChartStyle.TextCharacterPropertiesType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartsStyle.TextCharacterPropertiesType();
      value.SmtClean = GetSmtClean(openXmlElement);
      value.SmtId = GetSmtId(openXmlElement);
      value.Kumimoji = GetKumimoji(openXmlElement);
      value.Language = GetLanguage(openXmlElement);
      value.AlternativeLanguage = GetAlternativeLanguage(openXmlElement);
      value.FontSize = GetFontSize(openXmlElement);
      value.Bold = GetBold(openXmlElement);
      value.Italic = GetItalic(openXmlElement);
      value.Underline = GetUnderline(openXmlElement);
      value.Strike = GetStrike(openXmlElement);
      value.Kerning = GetKerning(openXmlElement);
      value.Capital = GetCapital(openXmlElement);
      value.Spacing = GetSpacing(openXmlElement);
      value.NormalizeHeight = GetNormalizeHeight(openXmlElement);
      value.Baseline = GetBaseline(openXmlElement);
      value.NoProof = GetNoProof(openXmlElement);
      value.Dirty = GetDirty(openXmlElement);
      value.SpellingError = GetSpellingError(openXmlElement);
      value.SmartTagClean = GetSmartTagClean(openXmlElement);
      value.SmartTagId = GetSmartTagId(openXmlElement);
      value.Bookmark = GetBookmark(openXmlElement);
      value.Outline = GetOutline(openXmlElement);
      value.NoFill = GetNoFill(openXmlElement);
      value.SolidFill = GetSolidFill(openXmlElement);
      value.GradientFill = GetGradientFill(openXmlElement);
      value.BlipFill = GetBlipFill(openXmlElement);
      value.PatternFill = GetPatternFill(openXmlElement);
      value.GroupFill = GetGroupFill(openXmlElement);
      value.EffectList = GetEffectList(openXmlElement);
      value.EffectDag = GetEffectDag(openXmlElement);
      value.Highlight = GetHighlight(openXmlElement);
      value.UnderlineFollowsText = GetUnderlineFollowsText(openXmlElement);
      value.UnderlineFillText = GetUnderlineFillText(openXmlElement);
      value.UnderlineFill = GetUnderlineFill(openXmlElement);
      value.LatinFont = GetLatinFont(openXmlElement);
      value.EastAsianFont = GetEastAsianFont(openXmlElement);
      value.ComplexScriptFont = GetComplexScriptFont(openXmlElement);
      value.SymbolFont = GetSymbolFont(openXmlElement);
      value.HyperlinkOnClick = GetHyperlinkOnClick(openXmlElement);
      value.HyperlinkOnMouseOver = GetHyperlinkOnMouseOver(openXmlElement);
      value.RightToLeft = GetRightToLeft(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2013DrawChartStyle.TextCharacterPropertiesType? openXmlElement, DMDrawsChartsStyle.TextCharacterPropertiesType? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpSmtClean(openXmlElement, value.SmtClean, diffs, objName))
        ok = false;
      if (!CmpSmtId(openXmlElement, value.SmtId, diffs, objName))
        ok = false;
      if (!CmpKumimoji(openXmlElement, value.Kumimoji, diffs, objName))
        ok = false;
      if (!CmpLanguage(openXmlElement, value.Language, diffs, objName))
        ok = false;
      if (!CmpAlternativeLanguage(openXmlElement, value.AlternativeLanguage, diffs, objName))
        ok = false;
      if (!CmpFontSize(openXmlElement, value.FontSize, diffs, objName))
        ok = false;
      if (!CmpBold(openXmlElement, value.Bold, diffs, objName))
        ok = false;
      if (!CmpItalic(openXmlElement, value.Italic, diffs, objName))
        ok = false;
      if (!CmpUnderline(openXmlElement, value.Underline, diffs, objName))
        ok = false;
      if (!CmpStrike(openXmlElement, value.Strike, diffs, objName))
        ok = false;
      if (!CmpKerning(openXmlElement, value.Kerning, diffs, objName))
        ok = false;
      if (!CmpCapital(openXmlElement, value.Capital, diffs, objName))
        ok = false;
      if (!CmpSpacing(openXmlElement, value.Spacing, diffs, objName))
        ok = false;
      if (!CmpNormalizeHeight(openXmlElement, value.NormalizeHeight, diffs, objName))
        ok = false;
      if (!CmpBaseline(openXmlElement, value.Baseline, diffs, objName))
        ok = false;
      if (!CmpNoProof(openXmlElement, value.NoProof, diffs, objName))
        ok = false;
      if (!CmpDirty(openXmlElement, value.Dirty, diffs, objName))
        ok = false;
      if (!CmpSpellingError(openXmlElement, value.SpellingError, diffs, objName))
        ok = false;
      if (!CmpSmartTagClean(openXmlElement, value.SmartTagClean, diffs, objName))
        ok = false;
      if (!CmpSmartTagId(openXmlElement, value.SmartTagId, diffs, objName))
        ok = false;
      if (!CmpBookmark(openXmlElement, value.Bookmark, diffs, objName))
        ok = false;
      if (!CmpOutline(openXmlElement, value.Outline, diffs, objName))
        ok = false;
      if (!CmpNoFill(openXmlElement, value.NoFill, diffs, objName))
        ok = false;
      if (!CmpSolidFill(openXmlElement, value.SolidFill, diffs, objName))
        ok = false;
      if (!CmpGradientFill(openXmlElement, value.GradientFill, diffs, objName))
        ok = false;
      if (!CmpBlipFill(openXmlElement, value.BlipFill, diffs, objName))
        ok = false;
      if (!CmpPatternFill(openXmlElement, value.PatternFill, diffs, objName))
        ok = false;
      if (!CmpGroupFill(openXmlElement, value.GroupFill, diffs, objName))
        ok = false;
      if (!CmpEffectList(openXmlElement, value.EffectList, diffs, objName))
        ok = false;
      if (!CmpEffectDag(openXmlElement, value.EffectDag, diffs, objName))
        ok = false;
      if (!CmpHighlight(openXmlElement, value.Highlight, diffs, objName))
        ok = false;
      if (!CmpUnderlineFollowsText(openXmlElement, value.UnderlineFollowsText, diffs, objName))
        ok = false;
      if (!CmpUnderlineFillText(openXmlElement, value.UnderlineFillText, diffs, objName))
        ok = false;
      if (!CmpUnderlineFill(openXmlElement, value.UnderlineFill, diffs, objName))
        ok = false;
      if (!CmpLatinFont(openXmlElement, value.LatinFont, diffs, objName))
        ok = false;
      if (!CmpEastAsianFont(openXmlElement, value.EastAsianFont, diffs, objName))
        ok = false;
      if (!CmpComplexScriptFont(openXmlElement, value.ComplexScriptFont, diffs, objName))
        ok = false;
      if (!CmpSymbolFont(openXmlElement, value.SymbolFont, diffs, objName))
        ok = false;
      if (!CmpHyperlinkOnClick(openXmlElement, value.HyperlinkOnClick, diffs, objName))
        ok = false;
      if (!CmpHyperlinkOnMouseOver(openXmlElement, value.HyperlinkOnMouseOver, diffs, objName))
        ok = false;
      if (!CmpRightToLeft(openXmlElement, value.RightToLeft, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartsStyle.TextCharacterPropertiesType? value)
    where OpenXmlElementType: DXO2013DrawChartStyle.TextCharacterPropertiesType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSmtClean(openXmlElement, value?.SmtClean);
      SetSmtId(openXmlElement, value?.SmtId);
      SetKumimoji(openXmlElement, value?.Kumimoji);
      SetLanguage(openXmlElement, value?.Language);
      SetAlternativeLanguage(openXmlElement, value?.AlternativeLanguage);
      SetFontSize(openXmlElement, value?.FontSize);
      SetBold(openXmlElement, value?.Bold);
      SetItalic(openXmlElement, value?.Italic);
      SetUnderline(openXmlElement, value?.Underline);
      SetStrike(openXmlElement, value?.Strike);
      SetKerning(openXmlElement, value?.Kerning);
      SetCapital(openXmlElement, value?.Capital);
      SetSpacing(openXmlElement, value?.Spacing);
      SetNormalizeHeight(openXmlElement, value?.NormalizeHeight);
      SetBaseline(openXmlElement, value?.Baseline);
      SetNoProof(openXmlElement, value?.NoProof);
      SetDirty(openXmlElement, value?.Dirty);
      SetSpellingError(openXmlElement, value?.SpellingError);
      SetSmartTagClean(openXmlElement, value?.SmartTagClean);
      SetSmartTagId(openXmlElement, value?.SmartTagId);
      SetBookmark(openXmlElement, value?.Bookmark);
      SetOutline(openXmlElement, value?.Outline);
      SetNoFill(openXmlElement, value?.NoFill);
      SetSolidFill(openXmlElement, value?.SolidFill);
      SetGradientFill(openXmlElement, value?.GradientFill);
      SetBlipFill(openXmlElement, value?.BlipFill);
      SetPatternFill(openXmlElement, value?.PatternFill);
      SetGroupFill(openXmlElement, value?.GroupFill);
      SetEffectList(openXmlElement, value?.EffectList);
      SetEffectDag(openXmlElement, value?.EffectDag);
      SetHighlight(openXmlElement, value?.Highlight);
      SetUnderlineFollowsText(openXmlElement, value?.UnderlineFollowsText);
      SetUnderlineFillText(openXmlElement, value?.UnderlineFillText);
      SetUnderlineFill(openXmlElement, value?.UnderlineFill);
      SetLatinFont(openXmlElement, value?.LatinFont);
      SetEastAsianFont(openXmlElement, value?.EastAsianFont);
      SetComplexScriptFont(openXmlElement, value?.ComplexScriptFont);
      SetSymbolFont(openXmlElement, value?.SymbolFont);
      SetHyperlinkOnClick(openXmlElement, value?.HyperlinkOnClick);
      SetHyperlinkOnMouseOver(openXmlElement, value?.HyperlinkOnMouseOver);
      SetRightToLeft(openXmlElement, value?.RightToLeft);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}

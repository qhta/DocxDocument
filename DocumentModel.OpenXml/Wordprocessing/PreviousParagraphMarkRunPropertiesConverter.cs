namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Previous Run Properties for the Paragraph Mark.
/// </summary>
public static class PreviousParagraphMarkRunPropertiesConverter
{
  /// <summary>
  /// Inserted Paragraph.
  /// </summary>
  private static DMW.TrackChangeType? GetInserted(DXW.PreviousParagraphMarkRunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Inserted>();
    if (element != null)
      return DMXW.TrackChangeTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpInserted(DXW.PreviousParagraphMarkRunProperties openXmlElement, DMW.TrackChangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Inserted>(), value, diffs, objName);
  }
  
  private static void SetInserted(DXW.PreviousParagraphMarkRunProperties openXmlElement, DMW.TrackChangeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Inserted>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TrackChangeTypeConverter.CreateOpenXmlElement<DXW.Inserted>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Deleted Paragraph.
  /// </summary>
  private static DMW.TrackChangeType? GetDeleted(DXW.PreviousParagraphMarkRunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Deleted>();
    if (element != null)
      return DMXW.TrackChangeTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDeleted(DXW.PreviousParagraphMarkRunProperties openXmlElement, DMW.TrackChangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Deleted>(), value, diffs, objName);
  }
  
  private static void SetDeleted(DXW.PreviousParagraphMarkRunProperties openXmlElement, DMW.TrackChangeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Deleted>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TrackChangeTypeConverter.CreateOpenXmlElement<DXW.Deleted>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Move Source Paragraph.
  /// </summary>
  private static DMW.TrackChangeType? GetMoveFrom(DXW.PreviousParagraphMarkRunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.MoveFrom>();
    if (element != null)
      return DMXW.TrackChangeTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMoveFrom(DXW.PreviousParagraphMarkRunProperties openXmlElement, DMW.TrackChangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.MoveFrom>(), value, diffs, objName);
  }
  
  private static void SetMoveFrom(DXW.PreviousParagraphMarkRunProperties openXmlElement, DMW.TrackChangeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.MoveFrom>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TrackChangeTypeConverter.CreateOpenXmlElement<DXW.MoveFrom>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Move Destination Paragraph.
  /// </summary>
  private static DMW.TrackChangeType? GetMoveTo(DXW.PreviousParagraphMarkRunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.MoveTo>();
    if (element != null)
      return DMXW.TrackChangeTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMoveTo(DXW.PreviousParagraphMarkRunProperties openXmlElement, DMW.TrackChangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.MoveTo>(), value, diffs, objName);
  }
  
  private static void SetMoveTo(DXW.PreviousParagraphMarkRunProperties openXmlElement, DMW.TrackChangeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.MoveTo>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TrackChangeTypeConverter.CreateOpenXmlElement<DXW.MoveTo>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.TrackChangeType2? GetConflictInsertion(DXW.PreviousParagraphMarkRunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.ConflictInsertion>();
    if (element != null)
      return DMXW.TrackChangeType2Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpConflictInsertion(DXW.PreviousParagraphMarkRunProperties openXmlElement, DMW.TrackChangeType2? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeType2Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.ConflictInsertion>(), value, diffs, objName);
  }
  
  private static void SetConflictInsertion(DXW.PreviousParagraphMarkRunProperties openXmlElement, DMW.TrackChangeType2? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.ConflictInsertion>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TrackChangeType2Converter.CreateOpenXmlElement<DXO2010W.ConflictInsertion>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.TrackChangeType2? GetConflictDeletion(DXW.PreviousParagraphMarkRunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.ConflictDeletion>();
    if (element != null)
      return DMXW.TrackChangeType2Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpConflictDeletion(DXW.PreviousParagraphMarkRunProperties openXmlElement, DMW.TrackChangeType2? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeType2Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.ConflictDeletion>(), value, diffs, objName);
  }
  
  private static void SetConflictDeletion(DXW.PreviousParagraphMarkRunProperties openXmlElement, DMW.TrackChangeType2? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.ConflictDeletion>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TrackChangeType2Converter.CreateOpenXmlElement<DXO2010W.ConflictDeletion>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static String? GetRunStyle(DXW.PreviousParagraphMarkRunProperties openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.RunStyle>()?.Val);
  }
  
  private static bool CmpRunStyle(DXW.PreviousParagraphMarkRunProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.RunStyle>()?.Val, value, diffs, objName, "RunStyle");
  }
  
  private static void SetRunStyle(DXW.PreviousParagraphMarkRunProperties openXmlElement, String? value)
  {
    StringValueConverter.SetValue<DXW.RunStyle>(openXmlElement, value);
  }
  
  private static DMW.RunFonts? GetRunFonts(DXW.PreviousParagraphMarkRunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.RunFonts>();
    if (element != null)
      return DMXW.RunFontsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRunFonts(DXW.PreviousParagraphMarkRunProperties openXmlElement, DMW.RunFonts? value, DiffList? diffs, string? objName)
  {
    return DMXW.RunFontsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.RunFonts>(), value, diffs, objName);
  }
  
  private static void SetRunFonts(DXW.PreviousParagraphMarkRunProperties openXmlElement, DMW.RunFonts? value)
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
  
  private static Boolean? GetBold(DXW.PreviousParagraphMarkRunProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.Bold>());
  }
  
  private static bool CmpBold(DXW.PreviousParagraphMarkRunProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.Bold>(), value, diffs, objName);
  }
  
  private static void SetBold(DXW.PreviousParagraphMarkRunProperties openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.Bold>(openXmlElement, value);
  }
  
  private static Boolean? GetBoldComplexScript(DXW.PreviousParagraphMarkRunProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.BoldComplexScript>());
  }
  
  private static bool CmpBoldComplexScript(DXW.PreviousParagraphMarkRunProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.BoldComplexScript>(), value, diffs, objName);
  }
  
  private static void SetBoldComplexScript(DXW.PreviousParagraphMarkRunProperties openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.BoldComplexScript>(openXmlElement, value);
  }
  
  private static Boolean? GetItalic(DXW.PreviousParagraphMarkRunProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.Italic>());
  }
  
  private static bool CmpItalic(DXW.PreviousParagraphMarkRunProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.Italic>(), value, diffs, objName);
  }
  
  private static void SetItalic(DXW.PreviousParagraphMarkRunProperties openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.Italic>(openXmlElement, value);
  }
  
  private static Boolean? GetItalicComplexScript(DXW.PreviousParagraphMarkRunProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.ItalicComplexScript>());
  }
  
  private static bool CmpItalicComplexScript(DXW.PreviousParagraphMarkRunProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.ItalicComplexScript>(), value, diffs, objName);
  }
  
  private static void SetItalicComplexScript(DXW.PreviousParagraphMarkRunProperties openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.ItalicComplexScript>(openXmlElement, value);
  }
  
  private static Boolean? GetCaps(DXW.PreviousParagraphMarkRunProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.Caps>());
  }
  
  private static bool CmpCaps(DXW.PreviousParagraphMarkRunProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.Caps>(), value, diffs, objName);
  }
  
  private static void SetCaps(DXW.PreviousParagraphMarkRunProperties openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.Caps>(openXmlElement, value);
  }
  
  private static Boolean? GetSmallCaps(DXW.PreviousParagraphMarkRunProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.SmallCaps>());
  }
  
  private static bool CmpSmallCaps(DXW.PreviousParagraphMarkRunProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.SmallCaps>(), value, diffs, objName);
  }
  
  private static void SetSmallCaps(DXW.PreviousParagraphMarkRunProperties openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.SmallCaps>(openXmlElement, value);
  }
  
  private static Boolean? GetStrike(DXW.PreviousParagraphMarkRunProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.Strike>());
  }
  
  private static bool CmpStrike(DXW.PreviousParagraphMarkRunProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.Strike>(), value, diffs, objName);
  }
  
  private static void SetStrike(DXW.PreviousParagraphMarkRunProperties openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.Strike>(openXmlElement, value);
  }
  
  private static Boolean? GetDoubleStrike(DXW.PreviousParagraphMarkRunProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.DoubleStrike>());
  }
  
  private static bool CmpDoubleStrike(DXW.PreviousParagraphMarkRunProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.DoubleStrike>(), value, diffs, objName);
  }
  
  private static void SetDoubleStrike(DXW.PreviousParagraphMarkRunProperties openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.DoubleStrike>(openXmlElement, value);
  }
  
  private static Boolean? GetOutline(DXW.PreviousParagraphMarkRunProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.Outline>());
  }
  
  private static bool CmpOutline(DXW.PreviousParagraphMarkRunProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.Outline>(), value, diffs, objName);
  }
  
  private static void SetOutline(DXW.PreviousParagraphMarkRunProperties openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.Outline>(openXmlElement, value);
  }
  
  private static Boolean? GetShadow(DXW.PreviousParagraphMarkRunProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.Shadow>());
  }
  
  private static bool CmpShadow(DXW.PreviousParagraphMarkRunProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.Shadow>(), value, diffs, objName);
  }
  
  private static void SetShadow(DXW.PreviousParagraphMarkRunProperties openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.Shadow>(openXmlElement, value);
  }
  
  private static Boolean? GetEmboss(DXW.PreviousParagraphMarkRunProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.Emboss>());
  }
  
  private static bool CmpEmboss(DXW.PreviousParagraphMarkRunProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.Emboss>(), value, diffs, objName);
  }
  
  private static void SetEmboss(DXW.PreviousParagraphMarkRunProperties openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.Emboss>(openXmlElement, value);
  }
  
  private static Boolean? GetImprint(DXW.PreviousParagraphMarkRunProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.Imprint>());
  }
  
  private static bool CmpImprint(DXW.PreviousParagraphMarkRunProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.Imprint>(), value, diffs, objName);
  }
  
  private static void SetImprint(DXW.PreviousParagraphMarkRunProperties openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.Imprint>(openXmlElement, value);
  }
  
  private static Boolean? GetNoProof(DXW.PreviousParagraphMarkRunProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.NoProof>());
  }
  
  private static bool CmpNoProof(DXW.PreviousParagraphMarkRunProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.NoProof>(), value, diffs, objName);
  }
  
  private static void SetNoProof(DXW.PreviousParagraphMarkRunProperties openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.NoProof>(openXmlElement, value);
  }
  
  private static Boolean? GetSnapToGrid(DXW.PreviousParagraphMarkRunProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.SnapToGrid>());
  }
  
  private static bool CmpSnapToGrid(DXW.PreviousParagraphMarkRunProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.SnapToGrid>(), value, diffs, objName);
  }
  
  private static void SetSnapToGrid(DXW.PreviousParagraphMarkRunProperties openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.SnapToGrid>(openXmlElement, value);
  }
  
  private static Boolean? GetVanish(DXW.PreviousParagraphMarkRunProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.Vanish>());
  }
  
  private static bool CmpVanish(DXW.PreviousParagraphMarkRunProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.Vanish>(), value, diffs, objName);
  }
  
  private static void SetVanish(DXW.PreviousParagraphMarkRunProperties openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.Vanish>(openXmlElement, value);
  }
  
  private static Boolean? GetWebHidden(DXW.PreviousParagraphMarkRunProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.WebHidden>());
  }
  
  private static bool CmpWebHidden(DXW.PreviousParagraphMarkRunProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.WebHidden>(), value, diffs, objName);
  }
  
  private static void SetWebHidden(DXW.PreviousParagraphMarkRunProperties openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.WebHidden>(openXmlElement, value);
  }
  
  private static DMW.Color? GetColor(DXW.PreviousParagraphMarkRunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Color>();
    if (element != null)
      return DMXW.ColorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpColor(DXW.PreviousParagraphMarkRunProperties openXmlElement, DMW.Color? value, DiffList? diffs, string? objName)
  {
    return DMXW.ColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Color>(), value, diffs, objName);
  }
  
  private static void SetColor(DXW.PreviousParagraphMarkRunProperties openXmlElement, DMW.Color? value)
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
  
  private static Int32? GetSpacing(DXW.PreviousParagraphMarkRunProperties openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.Spacing>()?.Val);
  }
  
  private static bool CmpSpacing(DXW.PreviousParagraphMarkRunProperties openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.Spacing>()?.Val, value, diffs, objName, "Spacing");
  }
  
  private static void SetSpacing(DXW.PreviousParagraphMarkRunProperties openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXW.Spacing,System.Int32>(openXmlElement, value);
  }
  
  private static Int64? GetCharacterScale(DXW.PreviousParagraphMarkRunProperties openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.CharacterScale>()?.Val);
  }
  
  private static bool CmpCharacterScale(DXW.PreviousParagraphMarkRunProperties openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.CharacterScale>()?.Val, value, diffs, objName, "CharacterScale");
  }
  
  private static void SetCharacterScale(DXW.PreviousParagraphMarkRunProperties openXmlElement, Int64? value)
  {
    SimpleValueConverter.SetValue<DXW.CharacterScale,System.Int64>(openXmlElement, value);
  }
  
  private static UInt32? GetKern(DXW.PreviousParagraphMarkRunProperties openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.Kern>()?.Val);
  }
  
  private static bool CmpKern(DXW.PreviousParagraphMarkRunProperties openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.Kern>()?.Val, value, diffs, objName, "Kern");
  }
  
  private static void SetKern(DXW.PreviousParagraphMarkRunProperties openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXW.Kern,System.UInt32>(openXmlElement, value);
  }
  
  private static String? GetPosition(DXW.PreviousParagraphMarkRunProperties openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.Position>()?.Val);
  }
  
  private static bool CmpPosition(DXW.PreviousParagraphMarkRunProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.Position>()?.Val, value, diffs, objName, "Position");
  }
  
  private static void SetPosition(DXW.PreviousParagraphMarkRunProperties openXmlElement, String? value)
  {
    StringValueConverter.SetValue<DXW.Position>(openXmlElement, value);
  }
  
  private static String? GetFontSize(DXW.PreviousParagraphMarkRunProperties openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.FontSize>()?.Val);
  }
  
  private static bool CmpFontSize(DXW.PreviousParagraphMarkRunProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.FontSize>()?.Val, value, diffs, objName, "FontSize");
  }
  
  private static void SetFontSize(DXW.PreviousParagraphMarkRunProperties openXmlElement, String? value)
  {
    StringValueConverter.SetValue<DXW.FontSize>(openXmlElement, value);
  }
  
  private static String? GetFontSizeComplexScript(DXW.PreviousParagraphMarkRunProperties openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.FontSizeComplexScript>()?.Val);
  }
  
  private static bool CmpFontSizeComplexScript(DXW.PreviousParagraphMarkRunProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.FontSizeComplexScript>()?.Val, value, diffs, objName, "FontSizeComplexScript");
  }
  
  private static void SetFontSizeComplexScript(DXW.PreviousParagraphMarkRunProperties openXmlElement, String? value)
  {
    StringValueConverter.SetValue<DXW.FontSizeComplexScript>(openXmlElement, value);
  }
  
  private static DMW.HighlightColorKind? GetHighlight(DXW.PreviousParagraphMarkRunProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.HighlightColorValues, DMW.HighlightColorKind>(openXmlElement.GetFirstChild<DXW.Highlight>()?.Val?.Value);
  }
  
  private static bool CmpHighlight(DXW.PreviousParagraphMarkRunProperties openXmlElement, DMW.HighlightColorKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.HighlightColorValues, DMW.HighlightColorKind>(openXmlElement.GetFirstChild<DXW.Highlight>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetHighlight(DXW.PreviousParagraphMarkRunProperties openXmlElement, DMW.HighlightColorKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Highlight>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.HighlightColorValues, DMW.HighlightColorKind>(itemElement, (DMW.HighlightColorKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.Highlight, DocumentFormat.OpenXml.Wordprocessing.HighlightColorValues, DMW.HighlightColorKind>((DMW.HighlightColorKind)value));
  }
  
  private static DMW.Underline? GetUnderline(DXW.PreviousParagraphMarkRunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Underline>();
    if (element != null)
      return DMXW.UnderlineConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpUnderline(DXW.PreviousParagraphMarkRunProperties openXmlElement, DMW.Underline? value, DiffList? diffs, string? objName)
  {
    return DMXW.UnderlineConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Underline>(), value, diffs, objName);
  }
  
  private static void SetUnderline(DXW.PreviousParagraphMarkRunProperties openXmlElement, DMW.Underline? value)
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
  
  private static DMW.TextEffectKind? GetTextEffect(DXW.PreviousParagraphMarkRunProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TextEffectValues, DMW.TextEffectKind>(openXmlElement.GetFirstChild<DXW.TextEffect>()?.Val?.Value);
  }
  
  private static bool CmpTextEffect(DXW.PreviousParagraphMarkRunProperties openXmlElement, DMW.TextEffectKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.TextEffectValues, DMW.TextEffectKind>(openXmlElement.GetFirstChild<DXW.TextEffect>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetTextEffect(DXW.PreviousParagraphMarkRunProperties openXmlElement, DMW.TextEffectKind? value)
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
  
  private static DMW.BorderType? GetBorder(DXW.PreviousParagraphMarkRunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Border>();
    if (element != null)
      return DMXW.BorderTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBorder(DXW.PreviousParagraphMarkRunProperties openXmlElement, DMW.BorderType? value, DiffList? diffs, string? objName)
  {
    return DMXW.BorderTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Border>(), value, diffs, objName);
  }
  
  private static void SetBorder(DXW.PreviousParagraphMarkRunProperties openXmlElement, DMW.BorderType? value)
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
  
  private static DMW.Shading? GetShading(DXW.PreviousParagraphMarkRunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Shading>();
    if (element != null)
      return DMXW.ShadingConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShading(DXW.PreviousParagraphMarkRunProperties openXmlElement, DMW.Shading? value, DiffList? diffs, string? objName)
  {
    return DMXW.ShadingConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Shading>(), value, diffs, objName);
  }
  
  private static void SetShading(DXW.PreviousParagraphMarkRunProperties openXmlElement, DMW.Shading? value)
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
  
  private static DMW.FitText? GetFitText(DXW.PreviousParagraphMarkRunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.FitText>();
    if (element != null)
      return DMXW.FitTextConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFitText(DXW.PreviousParagraphMarkRunProperties openXmlElement, DMW.FitText? value, DiffList? diffs, string? objName)
  {
    return DMXW.FitTextConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.FitText>(), value, diffs, objName);
  }
  
  private static void SetFitText(DXW.PreviousParagraphMarkRunProperties openXmlElement, DMW.FitText? value)
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
  
  private static DMW.VerticalPositionKind? GetVerticalTextAlignment(DXW.PreviousParagraphMarkRunProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.VerticalPositionValues, DMW.VerticalPositionKind>(openXmlElement.GetFirstChild<DXW.VerticalTextAlignment>()?.Val?.Value);
  }
  
  private static bool CmpVerticalTextAlignment(DXW.PreviousParagraphMarkRunProperties openXmlElement, DMW.VerticalPositionKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.VerticalPositionValues, DMW.VerticalPositionKind>(openXmlElement.GetFirstChild<DXW.VerticalTextAlignment>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetVerticalTextAlignment(DXW.PreviousParagraphMarkRunProperties openXmlElement, DMW.VerticalPositionKind? value)
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
  
  private static Boolean? GetRightToLeftText(DXW.PreviousParagraphMarkRunProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.RightToLeftText>());
  }
  
  private static bool CmpRightToLeftText(DXW.PreviousParagraphMarkRunProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.RightToLeftText>(), value, diffs, objName);
  }
  
  private static void SetRightToLeftText(DXW.PreviousParagraphMarkRunProperties openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.RightToLeftText>(openXmlElement, value);
  }
  
  private static Boolean? GetComplexScript(DXW.PreviousParagraphMarkRunProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.ComplexScript>());
  }
  
  private static bool CmpComplexScript(DXW.PreviousParagraphMarkRunProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.ComplexScript>(), value, diffs, objName);
  }
  
  private static void SetComplexScript(DXW.PreviousParagraphMarkRunProperties openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.ComplexScript>(openXmlElement, value);
  }
  
  private static DMW.EmphasisMarkKind? GetEmphasis(DXW.PreviousParagraphMarkRunProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.EmphasisMarkValues, DMW.EmphasisMarkKind>(openXmlElement.GetFirstChild<DXW.Emphasis>()?.Val?.Value);
  }
  
  private static bool CmpEmphasis(DXW.PreviousParagraphMarkRunProperties openXmlElement, DMW.EmphasisMarkKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.EmphasisMarkValues, DMW.EmphasisMarkKind>(openXmlElement.GetFirstChild<DXW.Emphasis>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetEmphasis(DXW.PreviousParagraphMarkRunProperties openXmlElement, DMW.EmphasisMarkKind? value)
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
  
  private static DMW.Language? GetLanguages(DXW.PreviousParagraphMarkRunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Languages>();
    if (element != null)
      return DMXW.LanguageTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLanguages(DXW.PreviousParagraphMarkRunProperties openXmlElement, DMW.Language? value, DiffList? diffs, string? objName)
  {
    return DMXW.LanguageTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Languages>(), value, diffs, objName);
  }
  
  private static void SetLanguages(DXW.PreviousParagraphMarkRunProperties openXmlElement, DMW.Language? value)
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
  
  private static DMW.EastAsianLayout? GetEastAsianLayout(DXW.PreviousParagraphMarkRunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.EastAsianLayout>();
    if (element != null)
      return DMXW.EastAsianLayoutConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEastAsianLayout(DXW.PreviousParagraphMarkRunProperties openXmlElement, DMW.EastAsianLayout? value, DiffList? diffs, string? objName)
  {
    return DMXW.EastAsianLayoutConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.EastAsianLayout>(), value, diffs, objName);
  }
  
  private static void SetEastAsianLayout(DXW.PreviousParagraphMarkRunProperties openXmlElement, DMW.EastAsianLayout? value)
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
  
  private static Boolean? GetSpecVanish(DXW.PreviousParagraphMarkRunProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.SpecVanish>());
  }
  
  private static bool CmpSpecVanish(DXW.PreviousParagraphMarkRunProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.SpecVanish>(), value, diffs, objName);
  }
  
  private static void SetSpecVanish(DXW.PreviousParagraphMarkRunProperties openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.SpecVanish>(openXmlElement, value);
  }
  
  private static DMW.Glow? GetGlow(DXW.PreviousParagraphMarkRunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.Glow>();
    if (element != null)
      return DMXW.GlowConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGlow(DXW.PreviousParagraphMarkRunProperties openXmlElement, DMW.Glow? value, DiffList? diffs, string? objName)
  {
    return DMXW.GlowConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.Glow>(), value, diffs, objName);
  }
  
  private static void SetGlow(DXW.PreviousParagraphMarkRunProperties openXmlElement, DMW.Glow? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.Glow>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.GlowConverter.CreateOpenXmlElement<DXO2010W.Glow>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.Reflection? GetReflection(DXW.PreviousParagraphMarkRunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.Reflection>();
    if (element != null)
      return DMXW.ReflectionConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpReflection(DXW.PreviousParagraphMarkRunProperties openXmlElement, DMW.Reflection? value, DiffList? diffs, string? objName)
  {
    return DMXW.ReflectionConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.Reflection>(), value, diffs, objName);
  }
  
  private static void SetReflection(DXW.PreviousParagraphMarkRunProperties openXmlElement, DMW.Reflection? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.Reflection>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.ReflectionConverter.CreateOpenXmlElement<DXO2010W.Reflection>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.TextOutlineEffect? GetTextOutlineEffect(DXW.PreviousParagraphMarkRunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.TextOutlineEffect>();
    if (element != null)
      return DMXW.TextOutlineEffectConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTextOutlineEffect(DXW.PreviousParagraphMarkRunProperties openXmlElement, DMW.TextOutlineEffect? value, DiffList? diffs, string? objName)
  {
    return DMXW.TextOutlineEffectConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.TextOutlineEffect>(), value, diffs, objName);
  }
  
  private static void SetTextOutlineEffect(DXW.PreviousParagraphMarkRunProperties openXmlElement, DMW.TextOutlineEffect? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.TextOutlineEffect>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TextOutlineEffectConverter.CreateOpenXmlElement<DXO2010W.TextOutlineEffect>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.FillTextEffect? GetFillTextEffect(DXW.PreviousParagraphMarkRunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.FillTextEffect>();
    if (element != null)
      return DMXW.FillTextEffectConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFillTextEffect(DXW.PreviousParagraphMarkRunProperties openXmlElement, DMW.FillTextEffect? value, DiffList? diffs, string? objName)
  {
    return DMXW.FillTextEffectConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.FillTextEffect>(), value, diffs, objName);
  }
  
  private static void SetFillTextEffect(DXW.PreviousParagraphMarkRunProperties openXmlElement, DMW.FillTextEffect? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.FillTextEffect>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.FillTextEffectConverter.CreateOpenXmlElement<DXO2010W.FillTextEffect>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.Scene3D? GetScene3D(DXW.PreviousParagraphMarkRunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.Scene3D>();
    if (element != null)
      return DMXW.Scene3DConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpScene3D(DXW.PreviousParagraphMarkRunProperties openXmlElement, DMW.Scene3D? value, DiffList? diffs, string? objName)
  {
    return DMXW.Scene3DConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.Scene3D>(), value, diffs, objName);
  }
  
  private static void SetScene3D(DXW.PreviousParagraphMarkRunProperties openXmlElement, DMW.Scene3D? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.Scene3D>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.Scene3DConverter.CreateOpenXmlElement<DXO2010W.Scene3D>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.Properties3D? GetProperties3D(DXW.PreviousParagraphMarkRunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.Properties3D>();
    if (element != null)
      return DMXW.Properties3DConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpProperties3D(DXW.PreviousParagraphMarkRunProperties openXmlElement, DMW.Properties3D? value, DiffList? diffs, string? objName)
  {
    return DMXW.Properties3DConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.Properties3D>(), value, diffs, objName);
  }
  
  private static void SetProperties3D(DXW.PreviousParagraphMarkRunProperties openXmlElement, DMW.Properties3D? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.Properties3D>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.Properties3DConverter.CreateOpenXmlElement<DXO2010W.Properties3D>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.LigaturesKind? GetLigatures(DXW.PreviousParagraphMarkRunProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.LigaturesValues, DMW.LigaturesKind>(openXmlElement.GetFirstChild<DXO2010W.Ligatures>()?.Val?.Value);
  }
  
  private static bool CmpLigatures(DXW.PreviousParagraphMarkRunProperties openXmlElement, DMW.LigaturesKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.Word.LigaturesValues, DMW.LigaturesKind>(openXmlElement.GetFirstChild<DXO2010W.Ligatures>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetLigatures(DXW.PreviousParagraphMarkRunProperties openXmlElement, DMW.LigaturesKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.Ligatures>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.LigaturesValues, DMW.LigaturesKind>(itemElement, (DMW.LigaturesKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXO2010W.Ligatures, DocumentFormat.OpenXml.Office2010.Word.LigaturesValues, DMW.LigaturesKind>((DMW.LigaturesKind)value));
  }
  
  private static DMW.NumberFormKind? GetNumberingFormat(DXW.PreviousParagraphMarkRunProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.NumberFormValues, DMW.NumberFormKind>(openXmlElement.GetFirstChild<DXO2010W.NumberingFormat>()?.Val?.Value);
  }
  
  private static bool CmpNumberingFormat(DXW.PreviousParagraphMarkRunProperties openXmlElement, DMW.NumberFormKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.Word.NumberFormValues, DMW.NumberFormKind>(openXmlElement.GetFirstChild<DXO2010W.NumberingFormat>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetNumberingFormat(DXW.PreviousParagraphMarkRunProperties openXmlElement, DMW.NumberFormKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.NumberingFormat>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.NumberFormValues, DMW.NumberFormKind>(itemElement, (DMW.NumberFormKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXO2010W.NumberingFormat, DocumentFormat.OpenXml.Office2010.Word.NumberFormValues, DMW.NumberFormKind>((DMW.NumberFormKind)value));
  }
  
  private static DMW.NumberSpacingKind? GetNumberSpacing(DXW.PreviousParagraphMarkRunProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.NumberSpacingValues, DMW.NumberSpacingKind>(openXmlElement.GetFirstChild<DXO2010W.NumberSpacing>()?.Val?.Value);
  }
  
  private static bool CmpNumberSpacing(DXW.PreviousParagraphMarkRunProperties openXmlElement, DMW.NumberSpacingKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.Word.NumberSpacingValues, DMW.NumberSpacingKind>(openXmlElement.GetFirstChild<DXO2010W.NumberSpacing>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetNumberSpacing(DXW.PreviousParagraphMarkRunProperties openXmlElement, DMW.NumberSpacingKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.NumberSpacing>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.NumberSpacingValues, DMW.NumberSpacingKind>(itemElement, (DMW.NumberSpacingKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXO2010W.NumberSpacing, DocumentFormat.OpenXml.Office2010.Word.NumberSpacingValues, DMW.NumberSpacingKind>((DMW.NumberSpacingKind)value));
  }
  
  private static DMW.StylisticSets? GetStylisticSets(DXW.PreviousParagraphMarkRunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.StylisticSets>();
    if (element != null)
      return DMXW.StylisticSetsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStylisticSets(DXW.PreviousParagraphMarkRunProperties openXmlElement, DMW.StylisticSets? value, DiffList? diffs, string? objName)
  {
    return DMXW.StylisticSetsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.StylisticSets>(), value, diffs, objName);
  }
  
  private static void SetStylisticSets(DXW.PreviousParagraphMarkRunProperties openXmlElement, DMW.StylisticSets? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.StylisticSets>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.StylisticSetsConverter.CreateOpenXmlElement<DXO2010W.StylisticSets>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.OnOffKind? GetContextualAlternatives(DXW.PreviousParagraphMarkRunProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.OnOffValues, DMW.OnOffKind>(openXmlElement.GetFirstChild<DXO2010W.ContextualAlternatives>()?.Val?.Value);
  }
  
  private static bool CmpContextualAlternatives(DXW.PreviousParagraphMarkRunProperties openXmlElement, DMW.OnOffKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.Word.OnOffValues, DMW.OnOffKind>(openXmlElement.GetFirstChild<DXO2010W.ContextualAlternatives>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetContextualAlternatives(DXW.PreviousParagraphMarkRunProperties openXmlElement, DMW.OnOffKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.ContextualAlternatives>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.OnOffValues, DMW.OnOffKind>(itemElement, (DMW.OnOffKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXO2010W.ContextualAlternatives, DocumentFormat.OpenXml.Office2010.Word.OnOffValues, DMW.OnOffKind>((DMW.OnOffKind)value));
  }
  
  private static Boolean? GetOfficeMath(DXW.PreviousParagraphMarkRunProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.OfficeMath>());
  }
  
  private static bool CmpOfficeMath(DXW.PreviousParagraphMarkRunProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.OfficeMath>(), value, diffs, objName);
  }
  
  private static void SetOfficeMath(DXW.PreviousParagraphMarkRunProperties openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.OfficeMath>(openXmlElement, value);
  }
  
  public static DMW.PreviousParagraphMarkRunProperties? CreateModelElement(DXW.PreviousParagraphMarkRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.PreviousParagraphMarkRunProperties();
      value.Inserted = GetInserted(openXmlElement);
      value.Deleted = GetDeleted(openXmlElement);
      value.MoveFrom = GetMoveFrom(openXmlElement);
      value.MoveTo = GetMoveTo(openXmlElement);
      value.ConflictInsertion = GetConflictInsertion(openXmlElement);
      value.ConflictDeletion = GetConflictDeletion(openXmlElement);
      value.RunStyle = GetRunStyle(openXmlElement);
      value.RunFonts = GetRunFonts(openXmlElement);
      value.Bold = GetBold(openXmlElement);
      value.BoldComplexScript = GetBoldComplexScript(openXmlElement);
      value.Italic = GetItalic(openXmlElement);
      value.ItalicComplexScript = GetItalicComplexScript(openXmlElement);
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
      value.FontSize = GetFontSize(openXmlElement);
      value.FontSizeComplexScript = GetFontSizeComplexScript(openXmlElement);
      value.Highlight = GetHighlight(openXmlElement);
      value.Underline = GetUnderline(openXmlElement);
      value.TextEffect = GetTextEffect(openXmlElement);
      value.Border = GetBorder(openXmlElement);
      value.Shading = GetShading(openXmlElement);
      value.FitText = GetFitText(openXmlElement);
      value.VerticalTextAlignment = GetVerticalTextAlignment(openXmlElement);
      value.RightToLeftText = GetRightToLeftText(openXmlElement);
      value.ComplexScript = GetComplexScript(openXmlElement);
      value.Emphasis = GetEmphasis(openXmlElement);
      value.Language = GetLanguages(openXmlElement);
      value.EastAsianLayout = GetEastAsianLayout(openXmlElement);
      value.SpecVanish = GetSpecVanish(openXmlElement);
      value.Glow = GetGlow(openXmlElement);
      value.Reflection = GetReflection(openXmlElement);
      value.TextOutlineEffect = GetTextOutlineEffect(openXmlElement);
      value.FillTextEffect = GetFillTextEffect(openXmlElement);
      value.Scene3D = GetScene3D(openXmlElement);
      value.Properties3D = GetProperties3D(openXmlElement);
      value.Ligatures = GetLigatures(openXmlElement);
      value.NumberingFormat = GetNumberingFormat(openXmlElement);
      value.NumberSpacing = GetNumberSpacing(openXmlElement);
      value.StylisticSets = GetStylisticSets(openXmlElement);
      value.ContextualAlternatives = GetContextualAlternatives(openXmlElement);
      value.OfficeMath = GetOfficeMath(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.PreviousParagraphMarkRunProperties? openXmlElement, DMW.PreviousParagraphMarkRunProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpInserted(openXmlElement, value.Inserted, diffs, objName))
        ok = false;
      if (!CmpDeleted(openXmlElement, value.Deleted, diffs, objName))
        ok = false;
      if (!CmpMoveFrom(openXmlElement, value.MoveFrom, diffs, objName))
        ok = false;
      if (!CmpMoveTo(openXmlElement, value.MoveTo, diffs, objName))
        ok = false;
      if (!CmpConflictInsertion(openXmlElement, value.ConflictInsertion, diffs, objName))
        ok = false;
      if (!CmpConflictDeletion(openXmlElement, value.ConflictDeletion, diffs, objName))
        ok = false;
      if (!CmpRunStyle(openXmlElement, value.RunStyle, diffs, objName))
        ok = false;
      if (!CmpRunFonts(openXmlElement, value.RunFonts, diffs, objName))
        ok = false;
      if (!CmpBold(openXmlElement, value.Bold, diffs, objName))
        ok = false;
      if (!CmpBoldComplexScript(openXmlElement, value.BoldComplexScript, diffs, objName))
        ok = false;
      if (!CmpItalic(openXmlElement, value.Italic, diffs, objName))
        ok = false;
      if (!CmpItalicComplexScript(openXmlElement, value.ItalicComplexScript, diffs, objName))
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
      if (!CmpFontSize(openXmlElement, value.FontSize, diffs, objName))
        ok = false;
      if (!CmpFontSizeComplexScript(openXmlElement, value.FontSizeComplexScript, diffs, objName))
        ok = false;
      if (!CmpHighlight(openXmlElement, value.Highlight, diffs, objName))
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
      if (!CmpRightToLeftText(openXmlElement, value.RightToLeftText, diffs, objName))
        ok = false;
      if (!CmpComplexScript(openXmlElement, value.ComplexScript, diffs, objName))
        ok = false;
      if (!CmpEmphasis(openXmlElement, value.Emphasis, diffs, objName))
        ok = false;
      if (!CmpLanguages(openXmlElement, value.Language, diffs, objName))
        ok = false;
      if (!CmpEastAsianLayout(openXmlElement, value.EastAsianLayout, diffs, objName))
        ok = false;
      if (!CmpSpecVanish(openXmlElement, value.SpecVanish, diffs, objName))
        ok = false;
      if (!CmpGlow(openXmlElement, value.Glow, diffs, objName))
        ok = false;
      if (!CmpReflection(openXmlElement, value.Reflection, diffs, objName))
        ok = false;
      if (!CmpTextOutlineEffect(openXmlElement, value.TextOutlineEffect, diffs, objName))
        ok = false;
      if (!CmpFillTextEffect(openXmlElement, value.FillTextEffect, diffs, objName))
        ok = false;
      if (!CmpScene3D(openXmlElement, value.Scene3D, diffs, objName))
        ok = false;
      if (!CmpProperties3D(openXmlElement, value.Properties3D, diffs, objName))
        ok = false;
      if (!CmpLigatures(openXmlElement, value.Ligatures, diffs, objName))
        ok = false;
      if (!CmpNumberingFormat(openXmlElement, value.NumberingFormat, diffs, objName))
        ok = false;
      if (!CmpNumberSpacing(openXmlElement, value.NumberSpacing, diffs, objName))
        ok = false;
      if (!CmpStylisticSets(openXmlElement, value.StylisticSets, diffs, objName))
        ok = false;
      if (!CmpContextualAlternatives(openXmlElement, value.ContextualAlternatives, diffs, objName))
        ok = false;
      if (!CmpOfficeMath(openXmlElement, value.OfficeMath, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.PreviousParagraphMarkRunProperties value)
    where OpenXmlElementType: DXW.PreviousParagraphMarkRunProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.PreviousParagraphMarkRunProperties openXmlElement, DMW.PreviousParagraphMarkRunProperties value)
  {
    SetInserted(openXmlElement, value.Inserted);
    SetDeleted(openXmlElement, value.Deleted);
    SetMoveFrom(openXmlElement, value.MoveFrom);
    SetMoveTo(openXmlElement, value.MoveTo);
    SetConflictInsertion(openXmlElement, value.ConflictInsertion);
    SetConflictDeletion(openXmlElement, value.ConflictDeletion);
    SetRunStyle(openXmlElement, value.RunStyle);
    SetRunFonts(openXmlElement, value.RunFonts);
    SetBold(openXmlElement, value.Bold);
    SetBoldComplexScript(openXmlElement, value.BoldComplexScript);
    SetItalic(openXmlElement, value.Italic);
    SetItalicComplexScript(openXmlElement, value.ItalicComplexScript);
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
    SetFontSize(openXmlElement, value.FontSize);
    SetFontSizeComplexScript(openXmlElement, value.FontSizeComplexScript);
    SetHighlight(openXmlElement, value.Highlight);
    SetUnderline(openXmlElement, value.Underline);
    SetTextEffect(openXmlElement, value.TextEffect);
    SetBorder(openXmlElement, value.Border);
    SetShading(openXmlElement, value.Shading);
    SetFitText(openXmlElement, value.FitText);
    SetVerticalTextAlignment(openXmlElement, value.VerticalTextAlignment);
    SetRightToLeftText(openXmlElement, value.RightToLeftText);
    SetComplexScript(openXmlElement, value.ComplexScript);
    SetEmphasis(openXmlElement, value.Emphasis);
    SetLanguages(openXmlElement, value.Language);
    SetEastAsianLayout(openXmlElement, value.EastAsianLayout);
    SetSpecVanish(openXmlElement, value.SpecVanish);
    SetGlow(openXmlElement, value.Glow);
    SetReflection(openXmlElement, value.Reflection);
    SetTextOutlineEffect(openXmlElement, value.TextOutlineEffect);
    SetFillTextEffect(openXmlElement, value.FillTextEffect);
    SetScene3D(openXmlElement, value.Scene3D);
    SetProperties3D(openXmlElement, value.Properties3D);
    SetLigatures(openXmlElement, value.Ligatures);
    SetNumberingFormat(openXmlElement, value.NumberingFormat);
    SetNumberSpacing(openXmlElement, value.NumberSpacing);
    SetStylisticSets(openXmlElement, value.StylisticSets);
    SetContextualAlternatives(openXmlElement, value.ContextualAlternatives);
    SetOfficeMath(openXmlElement, value.OfficeMath);
  }
}

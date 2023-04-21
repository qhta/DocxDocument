namespace DocumentModel.OpenXml;

/// <summary>
/// Document Settings.
/// </summary>
public static class DocumentSettingsConverter
{
  /// <summary>
  /// Write Protection.
  /// </summary>
  private static DMW.WriteProtection? GetWriteProtection(DXW.Settings openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.WriteProtection>();
    if (element != null)
      return DMXW.WriteProtectionConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpWriteProtection(DXW.Settings openXmlElement, DMW.WriteProtection? value, DiffList? diffs, string? objName)
  {
    return DMXW.WriteProtectionConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.WriteProtection>(), value, diffs, objName);
  }
  
  private static void SetWriteProtection(DXW.Settings openXmlElement, DMW.WriteProtection? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.WriteProtection>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.WriteProtectionConverter.CreateOpenXmlElement<DXW.WriteProtection>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Document View Setting.
  /// </summary>
  private static DMW.ViewKind? GetView(DXW.Settings openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ViewValues, DMW.ViewKind>(openXmlElement.GetFirstChild<DXW.View>()?.Val?.Value);
  }
  
  private static bool CmpView(DXW.Settings openXmlElement, DMW.ViewKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.ViewValues, DMW.ViewKind>(openXmlElement.GetFirstChild<DXW.View>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetView(DXW.Settings openXmlElement, DMW.ViewKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.View>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.ViewValues, DMW.ViewKind>(itemElement, (DMW.ViewKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.View, DocumentFormat.OpenXml.Wordprocessing.ViewValues, DMW.ViewKind>((DMW.ViewKind)value));
  }
  
  /// <summary>
  /// Magnification Setting.
  /// </summary>
  private static DMW.Zoom? GetZoom(DXW.Settings openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Zoom>();
    if (element != null)
      return DMXW.ZoomConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpZoom(DXW.Settings openXmlElement, DMW.Zoom? value, DiffList? diffs, string? objName)
  {
    return DMXW.ZoomConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Zoom>(), value, diffs, objName);
  }
  
  private static void SetZoom(DXW.Settings openXmlElement, DMW.Zoom? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Zoom>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.ZoomConverter.CreateOpenXmlElement<DXW.Zoom>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Remove Personal Information from Document Properties.
  /// </summary>
  private static Boolean? GetRemovePersonalInformation(DXW.Settings openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.RemovePersonalInformation>());
  }
  
  private static bool CmpRemovePersonalInformation(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.RemovePersonalInformation>(), value, diffs, objName);
  }
  
  private static void SetRemovePersonalInformation(DXW.Settings openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.RemovePersonalInformation>(openXmlElement, value);
  }
  
  /// <summary>
  /// Remove Date and Time from Annotations.
  /// </summary>
  private static Boolean? GetRemoveDateAndTime(DXW.Settings openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.RemoveDateAndTime>());
  }
  
  private static bool CmpRemoveDateAndTime(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.RemoveDateAndTime>(), value, diffs, objName);
  }
  
  private static void SetRemoveDateAndTime(DXW.Settings openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.RemoveDateAndTime>(openXmlElement, value);
  }
  
  /// <summary>
  /// Do Not Display Visual Boundary For Header/Footer or Between Pages.
  /// </summary>
  private static Boolean? GetDoNotDisplayPageBoundaries(DXW.Settings openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.DoNotDisplayPageBoundaries>());
  }
  
  private static bool CmpDoNotDisplayPageBoundaries(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.DoNotDisplayPageBoundaries>(), value, diffs, objName);
  }
  
  private static void SetDoNotDisplayPageBoundaries(DXW.Settings openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.DoNotDisplayPageBoundaries>(openXmlElement, value);
  }
  
  /// <summary>
  /// Display Background Objects When Displaying Document.
  /// </summary>
  private static Boolean? GetDisplayBackgroundShape(DXW.Settings openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.DisplayBackgroundShape>());
  }
  
  private static bool CmpDisplayBackgroundShape(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.DisplayBackgroundShape>(), value, diffs, objName);
  }
  
  private static void SetDisplayBackgroundShape(DXW.Settings openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.DisplayBackgroundShape>(openXmlElement, value);
  }
  
  /// <summary>
  /// Print PostScript Codes With Document Text.
  /// </summary>
  private static Boolean? GetPrintPostScriptOverText(DXW.Settings openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.PrintPostScriptOverText>());
  }
  
  private static bool CmpPrintPostScriptOverText(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.PrintPostScriptOverText>(), value, diffs, objName);
  }
  
  private static void SetPrintPostScriptOverText(DXW.Settings openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.PrintPostScriptOverText>(openXmlElement, value);
  }
  
  /// <summary>
  /// Print Fractional Character Widths.
  /// </summary>
  private static Boolean? GetPrintFractionalCharacterWidth(DXW.Settings openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.PrintFractionalCharacterWidth>());
  }
  
  private static bool CmpPrintFractionalCharacterWidth(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.PrintFractionalCharacterWidth>(), value, diffs, objName);
  }
  
  private static void SetPrintFractionalCharacterWidth(DXW.Settings openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.PrintFractionalCharacterWidth>(openXmlElement, value);
  }
  
  /// <summary>
  /// Only Print Form Field Content.
  /// </summary>
  private static Boolean? GetPrintFormsData(DXW.Settings openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.PrintFormsData>());
  }
  
  private static bool CmpPrintFormsData(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.PrintFormsData>(), value, diffs, objName);
  }
  
  private static void SetPrintFormsData(DXW.Settings openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.PrintFormsData>(openXmlElement, value);
  }
  
  /// <summary>
  /// Embed TrueType Fonts.
  /// </summary>
  private static Boolean? GetEmbedTrueTypeFonts(DXW.Settings openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.EmbedTrueTypeFonts>());
  }
  
  private static bool CmpEmbedTrueTypeFonts(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.EmbedTrueTypeFonts>(), value, diffs, objName);
  }
  
  private static void SetEmbedTrueTypeFonts(DXW.Settings openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.EmbedTrueTypeFonts>(openXmlElement, value);
  }
  
  /// <summary>
  /// Embed Common System Fonts.
  /// </summary>
  private static Boolean? GetEmbedSystemFonts(DXW.Settings openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.EmbedSystemFonts>());
  }
  
  private static bool CmpEmbedSystemFonts(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.EmbedSystemFonts>(), value, diffs, objName);
  }
  
  private static void SetEmbedSystemFonts(DXW.Settings openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.EmbedSystemFonts>(openXmlElement, value);
  }
  
  /// <summary>
  /// Subset Fonts When Embedding.
  /// </summary>
  private static Boolean? GetSaveSubsetFonts(DXW.Settings openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.SaveSubsetFonts>());
  }
  
  private static bool CmpSaveSubsetFonts(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.SaveSubsetFonts>(), value, diffs, objName);
  }
  
  private static void SetSaveSubsetFonts(DXW.Settings openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.SaveSubsetFonts>(openXmlElement, value);
  }
  
  /// <summary>
  /// Only Save Form Field Content.
  /// </summary>
  private static Boolean? GetSaveFormsData(DXW.Settings openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.SaveFormsData>());
  }
  
  private static bool CmpSaveFormsData(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.SaveFormsData>(), value, diffs, objName);
  }
  
  private static void SetSaveFormsData(DXW.Settings openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.SaveFormsData>(openXmlElement, value);
  }
  
  /// <summary>
  /// Mirror Page Margins.
  /// </summary>
  private static Boolean? GetMirrorMargins(DXW.Settings openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.MirrorMargins>());
  }
  
  private static bool CmpMirrorMargins(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.MirrorMargins>(), value, diffs, objName);
  }
  
  private static void SetMirrorMargins(DXW.Settings openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.MirrorMargins>(openXmlElement, value);
  }
  
  /// <summary>
  /// Align Paragraph and Table Borders with Page Border.
  /// </summary>
  private static Boolean? GetAlignBorderAndEdges(DXW.Settings openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.AlignBorderAndEdges>());
  }
  
  private static bool CmpAlignBorderAndEdges(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.AlignBorderAndEdges>(), value, diffs, objName);
  }
  
  private static void SetAlignBorderAndEdges(DXW.Settings openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.AlignBorderAndEdges>(openXmlElement, value);
  }
  
  /// <summary>
  /// Page Border Excludes Header.
  /// </summary>
  private static Boolean? GetBordersDoNotSurroundHeader(DXW.Settings openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.BordersDoNotSurroundHeader>());
  }
  
  private static bool CmpBordersDoNotSurroundHeader(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.BordersDoNotSurroundHeader>(), value, diffs, objName);
  }
  
  private static void SetBordersDoNotSurroundHeader(DXW.Settings openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.BordersDoNotSurroundHeader>(openXmlElement, value);
  }
  
  /// <summary>
  /// Page Border Excludes Footer.
  /// </summary>
  private static Boolean? GetBordersDoNotSurroundFooter(DXW.Settings openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.BordersDoNotSurroundFooter>());
  }
  
  private static bool CmpBordersDoNotSurroundFooter(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.BordersDoNotSurroundFooter>(), value, diffs, objName);
  }
  
  private static void SetBordersDoNotSurroundFooter(DXW.Settings openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.BordersDoNotSurroundFooter>(openXmlElement, value);
  }
  
  /// <summary>
  /// Position Gutter At Top of Page.
  /// </summary>
  private static Boolean? GetGutterAtTop(DXW.Settings openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.GutterAtTop>());
  }
  
  private static bool CmpGutterAtTop(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.GutterAtTop>(), value, diffs, objName);
  }
  
  private static void SetGutterAtTop(DXW.Settings openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.GutterAtTop>(openXmlElement, value);
  }
  
  /// <summary>
  /// Do Not Display Visual Indication of Spelling Errors.
  /// </summary>
  private static Boolean? GetHideSpellingErrors(DXW.Settings openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.HideSpellingErrors>());
  }
  
  private static bool CmpHideSpellingErrors(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.HideSpellingErrors>(), value, diffs, objName);
  }
  
  private static void SetHideSpellingErrors(DXW.Settings openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.HideSpellingErrors>(openXmlElement, value);
  }
  
  /// <summary>
  /// Do Not Display Visual Indication of Grammatical Errors.
  /// </summary>
  private static Boolean? GetHideGrammaticalErrors(DXW.Settings openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.HideGrammaticalErrors>());
  }
  
  private static bool CmpHideGrammaticalErrors(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.HideGrammaticalErrors>(), value, diffs, objName);
  }
  
  private static void SetHideGrammaticalErrors(DXW.Settings openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.HideGrammaticalErrors>(openXmlElement, value);
  }
  
  private static Collection<DMW.ActiveWritingStyle>? GetActiveWritingStyles(DXW.Settings openXmlElement)
  {
    var collection = new Collection<DMW.ActiveWritingStyle>();
    foreach (var item in openXmlElement.Elements<DXW.ActiveWritingStyle>())
    {
      var newItem = DMXW.ActiveWritingStyleConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpActiveWritingStyles(DXW.Settings openXmlElement, Collection<DMW.ActiveWritingStyle>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXW.ActiveWritingStyle>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXW.ActiveWritingStyleConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetActiveWritingStyles(DXW.Settings openXmlElement, Collection<DMW.ActiveWritingStyle>? value)
  {
    openXmlElement.RemoveAllChildren<DXW.ActiveWritingStyle>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXW.ActiveWritingStyleConverter.CreateOpenXmlElement<DXW.ActiveWritingStyle>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DMW.ProofState? GetProofState(DXW.Settings openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.ProofState>();
    if (element != null)
      return DMXW.ProofStateConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpProofState(DXW.Settings openXmlElement, DMW.ProofState? value, DiffList? diffs, string? objName)
  {
    return DMXW.ProofStateConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.ProofState>(), value, diffs, objName);
  }
  
  private static void SetProofState(DXW.Settings openXmlElement, DMW.ProofState? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.ProofState>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.ProofStateConverter.CreateOpenXmlElement<DXW.ProofState>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetFormsDesign(DXW.Settings openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.FormsDesign>());
  }
  
  private static bool CmpFormsDesign(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.FormsDesign>(), value, diffs, objName);
  }
  
  private static void SetFormsDesign(DXW.Settings openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.FormsDesign>(openXmlElement, value);
  }
  
  private static DMW.RelationshipType? GetAttachedTemplate(DXW.Settings openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.AttachedTemplate>();
    if (element != null)
      return DMXW.RelationshipTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAttachedTemplate(DXW.Settings openXmlElement, DMW.RelationshipType? value, DiffList? diffs, string? objName)
  {
    return DMXW.RelationshipTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.AttachedTemplate>(), value, diffs, objName);
  }
  
  private static void SetAttachedTemplate(DXW.Settings openXmlElement, DMW.RelationshipType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.AttachedTemplate>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.RelationshipTypeConverter.CreateOpenXmlElement<DXW.AttachedTemplate>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetLinkStyles(DXW.Settings openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.LinkStyles>());
  }
  
  private static bool CmpLinkStyles(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.LinkStyles>(), value, diffs, objName);
  }
  
  private static void SetLinkStyles(DXW.Settings openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.LinkStyles>(openXmlElement, value);
  }
  
  private static DMW.StylePaneFormatFilter? GetStylePaneFormatFilter(DXW.Settings openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.StylePaneFormatFilter>();
    if (element != null)
      return DMXW.StylePaneFormatFilterConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStylePaneFormatFilter(DXW.Settings openXmlElement, DMW.StylePaneFormatFilter? value, DiffList? diffs, string? objName)
  {
    return DMXW.StylePaneFormatFilterConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.StylePaneFormatFilter>(), value, diffs, objName);
  }
  
  private static void SetStylePaneFormatFilter(DXW.Settings openXmlElement, DMW.StylePaneFormatFilter? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.StylePaneFormatFilter>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.StylePaneFormatFilterConverter.CreateOpenXmlElement<DXW.StylePaneFormatFilter>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static String? GetStylePaneSortMethods(DXW.Settings openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.StylePaneSortMethods>()?.Val);
  }
  
  private static bool CmpStylePaneSortMethods(DXW.Settings openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.StylePaneSortMethods>()?.Val, value, diffs, objName, "StylePaneSortMethods");
  }
  
  private static void SetStylePaneSortMethods(DXW.Settings openXmlElement, String? value)
  {
    StringValueConverter.SetValue<DXW.StylePaneSortMethods>(openXmlElement, value);
  }
  
  private static DMW.DocumentKind? GetDocumentType(DXW.Settings openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.DocumentTypeValues, DMW.DocumentKind>(openXmlElement.GetFirstChild<DXW.DocumentType>()?.Val?.Value);
  }
  
  private static bool CmpDocumentType(DXW.Settings openXmlElement, DMW.DocumentKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.DocumentTypeValues, DMW.DocumentKind>(openXmlElement.GetFirstChild<DXW.DocumentType>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetDocumentType(DXW.Settings openXmlElement, DMW.DocumentKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DocumentType>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.DocumentTypeValues, DMW.DocumentKind>(itemElement, (DMW.DocumentKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.DocumentType, DocumentFormat.OpenXml.Wordprocessing.DocumentTypeValues, DMW.DocumentKind>((DMW.DocumentKind)value));
  }
  
  private static DMW.MailMerge? GetMailMerge(DXW.Settings openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.MailMerge>();
    if (element != null)
      return DMXW.MailMergeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMailMerge(DXW.Settings openXmlElement, DMW.MailMerge? value, DiffList? diffs, string? objName)
  {
    return DMXW.MailMergeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.MailMerge>(), value, diffs, objName);
  }
  
  private static void SetMailMerge(DXW.Settings openXmlElement, DMW.MailMerge? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.MailMerge>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MailMergeConverter.CreateOpenXmlElement<DXW.MailMerge>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.RevisionView? GetRevisionView(DXW.Settings openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.RevisionView>();
    if (element != null)
      return DMXW.RevisionViewConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRevisionView(DXW.Settings openXmlElement, DMW.RevisionView? value, DiffList? diffs, string? objName)
  {
    return DMXW.RevisionViewConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.RevisionView>(), value, diffs, objName);
  }
  
  private static void SetRevisionView(DXW.Settings openXmlElement, DMW.RevisionView? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.RevisionView>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.RevisionViewConverter.CreateOpenXmlElement<DXW.RevisionView>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetTrackRevisions(DXW.Settings openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.TrackRevisions>());
  }
  
  private static bool CmpTrackRevisions(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.TrackRevisions>(), value, diffs, objName);
  }
  
  private static void SetTrackRevisions(DXW.Settings openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.TrackRevisions>(openXmlElement, value);
  }
  
  private static Boolean? GetDoNotTrackMoves(DXW.Settings openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.DoNotTrackMoves>());
  }
  
  private static bool CmpDoNotTrackMoves(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.DoNotTrackMoves>(), value, diffs, objName);
  }
  
  private static void SetDoNotTrackMoves(DXW.Settings openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.DoNotTrackMoves>(openXmlElement, value);
  }
  
  private static Boolean? GetDoNotTrackFormatting(DXW.Settings openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.DoNotTrackFormatting>());
  }
  
  private static bool CmpDoNotTrackFormatting(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.DoNotTrackFormatting>(), value, diffs, objName);
  }
  
  private static void SetDoNotTrackFormatting(DXW.Settings openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.DoNotTrackFormatting>(openXmlElement, value);
  }
  
  private static DMW.DocumentProtection? GetDocumentProtection(DXW.Settings openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.DocumentProtection>();
    if (element != null)
      return DMXW.DocumentProtectionConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDocumentProtection(DXW.Settings openXmlElement, DMW.DocumentProtection? value, DiffList? diffs, string? objName)
  {
    return DMXW.DocumentProtectionConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.DocumentProtection>(), value, diffs, objName);
  }
  
  private static void SetDocumentProtection(DXW.Settings openXmlElement, DMW.DocumentProtection? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DocumentProtection>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.DocumentProtectionConverter.CreateOpenXmlElement<DXW.DocumentProtection>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetAutoFormatOverride(DXW.Settings openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.AutoFormatOverride>());
  }
  
  private static bool CmpAutoFormatOverride(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.AutoFormatOverride>(), value, diffs, objName);
  }
  
  private static void SetAutoFormatOverride(DXW.Settings openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.AutoFormatOverride>(openXmlElement, value);
  }
  
  private static Int16? GetDefaultTabStop(DXW.Settings openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.DefaultTabStop>()?.Val);
  }
  
  private static bool CmpDefaultTabStop(DXW.Settings openXmlElement, Int16? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.DefaultTabStop>()?.Val, value, diffs, objName, "DefaultTabStop");
  }
  
  private static void SetDefaultTabStop(DXW.Settings openXmlElement, Int16? value)
  {
    SimpleValueConverter.SetValue<DXW.DefaultTabStop,System.Int16>(openXmlElement, value);
  }
  
  private static Boolean? GetAutoHyphenation(DXW.Settings openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.AutoHyphenation>());
  }
  
  private static bool CmpAutoHyphenation(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.AutoHyphenation>(), value, diffs, objName);
  }
  
  private static void SetAutoHyphenation(DXW.Settings openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.AutoHyphenation>(openXmlElement, value);
  }
  
  private static UInt16? GetConsecutiveHyphenLimit(DXW.Settings openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.ConsecutiveHyphenLimit>()?.Val);
  }
  
  private static bool CmpConsecutiveHyphenLimit(DXW.Settings openXmlElement, UInt16? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.ConsecutiveHyphenLimit>()?.Val, value, diffs, objName, "ConsecutiveHyphenLimit");
  }
  
  private static void SetConsecutiveHyphenLimit(DXW.Settings openXmlElement, UInt16? value)
  {
    SimpleValueConverter.SetValue<DXW.ConsecutiveHyphenLimit,System.UInt16>(openXmlElement, value);
  }
  
  private static Int32? GetHyphenationZone(DXW.Settings openXmlElement)
  {
    return Int32ValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.HyphenationZone>()?.Val);
  }
  
  private static bool CmpHyphenationZone(DXW.Settings openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.HyphenationZone>()?.Val, value, diffs, objName, "HyphenationZone");
  }
  
  private static void SetHyphenationZone(DXW.Settings openXmlElement, String? value)
  {
    StringValueConverter.SetValue<DXW.HyphenationZone>(openXmlElement, value);
  }
  
  private static Boolean? GetDoNotHyphenateCaps(DXW.Settings openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.DoNotHyphenateCaps>());
  }
  
  private static bool CmpDoNotHyphenateCaps(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.DoNotHyphenateCaps>(), value, diffs, objName);
  }
  
  private static void SetDoNotHyphenateCaps(DXW.Settings openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.DoNotHyphenateCaps>(openXmlElement, value);
  }
  
  private static Boolean? GetShowEnvelope(DXW.Settings openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.ShowEnvelope>());
  }
  
  private static bool CmpShowEnvelope(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.ShowEnvelope>(), value, diffs, objName);
  }
  
  private static void SetShowEnvelope(DXW.Settings openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.ShowEnvelope>(openXmlElement, value);
  }
  
  private static Int32? GetSummaryLength(DXW.Settings openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.SummaryLength>()?.Val);
  }
  
  private static bool CmpSummaryLength(DXW.Settings openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.SummaryLength>()?.Val, value, diffs, objName, "SummaryLength");
  }
  
  private static void SetSummaryLength(DXW.Settings openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXW.SummaryLength,System.Int32>(openXmlElement, value);
  }
  
  private static String? GetClickAndTypeStyle(DXW.Settings openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.ClickAndTypeStyle>()?.Val);
  }
  
  private static bool CmpClickAndTypeStyle(DXW.Settings openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.ClickAndTypeStyle>()?.Val, value, diffs, objName, "ClickAndTypeStyle");
  }
  
  private static void SetClickAndTypeStyle(DXW.Settings openXmlElement, String? value)
  {
    StringValueConverter.SetValue<DXW.ClickAndTypeStyle>(openXmlElement, value);
  }
  
  private static String? GetDefaultTableStyle(DXW.Settings openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.DefaultTableStyle>()?.Val);
  }
  
  private static bool CmpDefaultTableStyle(DXW.Settings openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.DefaultTableStyle>()?.Val, value, diffs, objName, "DefaultTableStyle");
  }
  
  private static void SetDefaultTableStyle(DXW.Settings openXmlElement, String? value)
  {
    StringValueConverter.SetValue<DXW.DefaultTableStyle>(openXmlElement, value);
  }
  
  private static Boolean? GetEvenAndOddHeaders(DXW.Settings openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.EvenAndOddHeaders>());
  }
  
  private static bool CmpEvenAndOddHeaders(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.EvenAndOddHeaders>(), value, diffs, objName);
  }
  
  private static void SetEvenAndOddHeaders(DXW.Settings openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.EvenAndOddHeaders>(openXmlElement, value);
  }
  
  private static Boolean? GetBookFoldReversePrinting(DXW.Settings openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.BookFoldReversePrinting>());
  }
  
  private static bool CmpBookFoldReversePrinting(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.BookFoldReversePrinting>(), value, diffs, objName);
  }
  
  private static void SetBookFoldReversePrinting(DXW.Settings openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.BookFoldReversePrinting>(openXmlElement, value);
  }
  
  private static Boolean? GetBookFoldPrinting(DXW.Settings openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.BookFoldPrinting>());
  }
  
  private static bool CmpBookFoldPrinting(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.BookFoldPrinting>(), value, diffs, objName);
  }
  
  private static void SetBookFoldPrinting(DXW.Settings openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.BookFoldPrinting>(openXmlElement, value);
  }
  
  private static Int16? GetBookFoldPrintingSheets(DXW.Settings openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.BookFoldPrintingSheets>()?.Val);
  }
  
  private static bool CmpBookFoldPrintingSheets(DXW.Settings openXmlElement, Int16? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.BookFoldPrintingSheets>()?.Val, value, diffs, objName, "BookFoldPrintingSheets");
  }
  
  private static void SetBookFoldPrintingSheets(DXW.Settings openXmlElement, Int16? value)
  {
    SimpleValueConverter.SetValue<DXW.BookFoldPrintingSheets,System.Int16>(openXmlElement, value);
  }
  
  private static Twips? GetDrawingGridHorizontalSpacing(DXW.Settings openXmlElement)
  {
    return Int32ValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.DrawingGridHorizontalSpacing>()?.Val);
  }
  
  private static bool CmpDrawingGridHorizontalSpacing(DXW.Settings openXmlElement, Twips? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.DrawingGridHorizontalSpacing>()?.Val, value, diffs, objName, "DrawingGridHorizontalSpacing");
  }
  
  private static void SetDrawingGridHorizontalSpacing(DXW.Settings openXmlElement, Twips? value)
  {
    StringValueConverter.SetValue<DXW.DrawingGridHorizontalSpacing>(openXmlElement, value);
  }
  
  private static Twips? GetDrawingGridVerticalSpacing(DXW.Settings openXmlElement)
  {
    return Int32ValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.DrawingGridVerticalSpacing>()?.Val);
  }
  
  private static bool CmpDrawingGridVerticalSpacing(DXW.Settings openXmlElement, Twips? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.DrawingGridVerticalSpacing>()?.Val, value, diffs, objName, "DrawingGridVerticalSpacing");
  }
  
  private static void SetDrawingGridVerticalSpacing(DXW.Settings openXmlElement, Twips? value)
  {
    StringValueConverter.SetValue<DXW.DrawingGridVerticalSpacing>(openXmlElement, value);
  }
  
  private static Twips? GetDisplayHorizontalDrawingGrid(DXW.Settings openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.DisplayHorizontalDrawingGrid>()?.Val);
  }
  
  private static bool CmpDisplayHorizontalDrawingGrid(DXW.Settings openXmlElement, Twips? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.DisplayHorizontalDrawingGrid>()?.Val, value, diffs, objName, "DisplayHorizontalDrawingGrid");
  }
  
  private static void SetDisplayHorizontalDrawingGrid(DXW.Settings openXmlElement, Twips? value)
  {
    SimpleValueConverter.SetValue<DXW.DisplayHorizontalDrawingGrid,System.Int32>(openXmlElement, value);
  }
  
  private static Twips? GetDisplayVerticalDrawingGrid(DXW.Settings openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.DisplayVerticalDrawingGrid>()?.Val);
  }
  
  private static bool CmpDisplayVerticalDrawingGrid(DXW.Settings openXmlElement, Twips? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.DisplayVerticalDrawingGrid>()?.Val, value, diffs, objName, "DisplayVerticalDrawingGrid");
  }
  
  private static void SetDisplayVerticalDrawingGrid(DXW.Settings openXmlElement, Twips? value)
  {
    SimpleValueConverter.SetValue<DXW.DisplayVerticalDrawingGrid,System.Int32>(openXmlElement, value);
  }
  
  private static Boolean? GetDoNotUseMarginsForDrawingGridOrigin(DXW.Settings openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.DoNotUseMarginsForDrawingGridOrigin>());
  }
  
  private static bool CmpDoNotUseMarginsForDrawingGridOrigin(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.DoNotUseMarginsForDrawingGridOrigin>(), value, diffs, objName);
  }
  
  private static void SetDoNotUseMarginsForDrawingGridOrigin(DXW.Settings openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.DoNotUseMarginsForDrawingGridOrigin>(openXmlElement, value);
  }
  
  private static Twips? GetDrawingGridHorizontalOrigin(DXW.Settings openXmlElement)
  {
    return Int32ValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.DrawingGridHorizontalOrigin>()?.Val);
  }
  
  private static bool CmpDrawingGridHorizontalOrigin(DXW.Settings openXmlElement, Twips? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.DrawingGridHorizontalOrigin>()?.Val, value, diffs, objName, "DrawingGridHorizontalOrigin");
  }
  
  private static void SetDrawingGridHorizontalOrigin(DXW.Settings openXmlElement, Twips? value)
  {
    StringValueConverter.SetValue<DXW.DrawingGridHorizontalOrigin>(openXmlElement, value);
  }
  
  private static Twips? GetDrawingGridVerticalOrigin(DXW.Settings openXmlElement)
  {
    return Int32ValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.DrawingGridVerticalOrigin>()?.Val);
  }
  
  private static bool CmpDrawingGridVerticalOrigin(DXW.Settings openXmlElement, Twips? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.DrawingGridVerticalOrigin>()?.Val, value, diffs, objName, "DrawingGridVerticalOrigin");
  }
  
  private static void SetDrawingGridVerticalOrigin(DXW.Settings openXmlElement, Twips? value)
  {
    StringValueConverter.SetValue<DXW.DrawingGridVerticalOrigin>(openXmlElement, value);
  }
  
  private static Boolean? GetDoNotShadeFormData(DXW.Settings openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.DoNotShadeFormData>());
  }
  
  private static bool CmpDoNotShadeFormData(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.DoNotShadeFormData>(), value, diffs, objName);
  }
  
  private static void SetDoNotShadeFormData(DXW.Settings openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.DoNotShadeFormData>(openXmlElement, value);
  }
  
  private static Boolean? GetNoPunctuationKerning(DXW.Settings openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.NoPunctuationKerning>());
  }
  
  private static bool CmpNoPunctuationKerning(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.NoPunctuationKerning>(), value, diffs, objName);
  }
  
  private static void SetNoPunctuationKerning(DXW.Settings openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.NoPunctuationKerning>(openXmlElement, value);
  }
  
  private static DMW.CharacterSpacingKind? GetCharacterSpacingControl(DXW.Settings openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.CharacterSpacingValues, DMW.CharacterSpacingKind>(openXmlElement.GetFirstChild<DXW.CharacterSpacingControl>()?.Val?.Value);
  }
  
  private static bool CmpCharacterSpacingControl(DXW.Settings openXmlElement, DMW.CharacterSpacingKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.CharacterSpacingValues, DMW.CharacterSpacingKind>(openXmlElement.GetFirstChild<DXW.CharacterSpacingControl>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetCharacterSpacingControl(DXW.Settings openXmlElement, DMW.CharacterSpacingKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CharacterSpacingControl>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.CharacterSpacingValues, DMW.CharacterSpacingKind>(itemElement, (DMW.CharacterSpacingKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.CharacterSpacingControl, DocumentFormat.OpenXml.Wordprocessing.CharacterSpacingValues, DMW.CharacterSpacingKind>((DMW.CharacterSpacingKind)value));
  }
  
  private static Boolean? GetPrintTwoOnOne(DXW.Settings openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.PrintTwoOnOne>());
  }
  
  private static bool CmpPrintTwoOnOne(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.PrintTwoOnOne>(), value, diffs, objName);
  }
  
  private static void SetPrintTwoOnOne(DXW.Settings openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.PrintTwoOnOne>(openXmlElement, value);
  }
  
  private static Boolean? GetStrictFirstAndLastChars(DXW.Settings openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.StrictFirstAndLastChars>());
  }
  
  private static bool CmpStrictFirstAndLastChars(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.StrictFirstAndLastChars>(), value, diffs, objName);
  }
  
  private static void SetStrictFirstAndLastChars(DXW.Settings openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.StrictFirstAndLastChars>(openXmlElement, value);
  }
  
  private static DMW.NoLineBreaksAfterKinsoku? GetNoLineBreaksAfterKinsoku(DXW.Settings openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.NoLineBreaksAfterKinsoku>();
    if (element != null)
      return DMXW.NoLineBreaksAfterKinsokuConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNoLineBreaksAfterKinsoku(DXW.Settings openXmlElement, DMW.NoLineBreaksAfterKinsoku? value, DiffList? diffs, string? objName)
  {
    return DMXW.NoLineBreaksAfterKinsokuConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.NoLineBreaksAfterKinsoku>(), value, diffs, objName);
  }
  
  private static void SetNoLineBreaksAfterKinsoku(DXW.Settings openXmlElement, DMW.NoLineBreaksAfterKinsoku? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.NoLineBreaksAfterKinsoku>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.NoLineBreaksAfterKinsokuConverter.CreateOpenXmlElement<DXW.NoLineBreaksAfterKinsoku>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.NoLineBreaksBeforeKinsoku? GetNoLineBreaksBeforeKinsoku(DXW.Settings openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.NoLineBreaksBeforeKinsoku>();
    if (element != null)
      return DMXW.NoLineBreaksBeforeKinsokuConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNoLineBreaksBeforeKinsoku(DXW.Settings openXmlElement, DMW.NoLineBreaksBeforeKinsoku? value, DiffList? diffs, string? objName)
  {
    return DMXW.NoLineBreaksBeforeKinsokuConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.NoLineBreaksBeforeKinsoku>(), value, diffs, objName);
  }
  
  private static void SetNoLineBreaksBeforeKinsoku(DXW.Settings openXmlElement, DMW.NoLineBreaksBeforeKinsoku? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.NoLineBreaksBeforeKinsoku>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.NoLineBreaksBeforeKinsokuConverter.CreateOpenXmlElement<DXW.NoLineBreaksBeforeKinsoku>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetSavePreviewPicture(DXW.Settings openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.SavePreviewPicture>());
  }
  
  private static bool CmpSavePreviewPicture(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.SavePreviewPicture>(), value, diffs, objName);
  }
  
  private static void SetSavePreviewPicture(DXW.Settings openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.SavePreviewPicture>(openXmlElement, value);
  }
  
  private static Boolean? GetDoNotValidateAgainstSchema(DXW.Settings openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.DoNotValidateAgainstSchema>());
  }
  
  private static bool CmpDoNotValidateAgainstSchema(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.DoNotValidateAgainstSchema>(), value, diffs, objName);
  }
  
  private static void SetDoNotValidateAgainstSchema(DXW.Settings openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.DoNotValidateAgainstSchema>(openXmlElement, value);
  }
  
  private static Boolean? GetSaveInvalidXml(DXW.Settings openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.SaveInvalidXml>());
  }
  
  private static bool CmpSaveInvalidXml(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.SaveInvalidXml>(), value, diffs, objName);
  }
  
  private static void SetSaveInvalidXml(DXW.Settings openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.SaveInvalidXml>(openXmlElement, value);
  }
  
  private static Boolean? GetIgnoreMixedContent(DXW.Settings openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.IgnoreMixedContent>());
  }
  
  private static bool CmpIgnoreMixedContent(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.IgnoreMixedContent>(), value, diffs, objName);
  }
  
  private static void SetIgnoreMixedContent(DXW.Settings openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.IgnoreMixedContent>(openXmlElement, value);
  }
  
  private static Boolean? GetAlwaysShowPlaceholderText(DXW.Settings openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.AlwaysShowPlaceholderText>());
  }
  
  private static bool CmpAlwaysShowPlaceholderText(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.AlwaysShowPlaceholderText>(), value, diffs, objName);
  }
  
  private static void SetAlwaysShowPlaceholderText(DXW.Settings openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.AlwaysShowPlaceholderText>(openXmlElement, value);
  }
  
  private static Boolean? GetDoNotDemarcateInvalidXml(DXW.Settings openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.DoNotDemarcateInvalidXml>());
  }
  
  private static bool CmpDoNotDemarcateInvalidXml(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.DoNotDemarcateInvalidXml>(), value, diffs, objName);
  }
  
  private static void SetDoNotDemarcateInvalidXml(DXW.Settings openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.DoNotDemarcateInvalidXml>(openXmlElement, value);
  }
  
  private static Boolean? GetSaveXmlDataOnly(DXW.Settings openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.SaveXmlDataOnly>());
  }
  
  private static bool CmpSaveXmlDataOnly(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.SaveXmlDataOnly>(), value, diffs, objName);
  }
  
  private static void SetSaveXmlDataOnly(DXW.Settings openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.SaveXmlDataOnly>(openXmlElement, value);
  }
  
  private static Boolean? GetUseXsltWhenSaving(DXW.Settings openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.UseXsltWhenSaving>());
  }
  
  private static bool CmpUseXsltWhenSaving(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.UseXsltWhenSaving>(), value, diffs, objName);
  }
  
  private static void SetUseXsltWhenSaving(DXW.Settings openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.UseXsltWhenSaving>(openXmlElement, value);
  }
  
  private static DMW.SaveThroughXslt? GetSaveThroughXslt(DXW.Settings openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.SaveThroughXslt>();
    if (element != null)
      return DMXW.SaveThroughXsltConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSaveThroughXslt(DXW.Settings openXmlElement, DMW.SaveThroughXslt? value, DiffList? diffs, string? objName)
  {
    return DMXW.SaveThroughXsltConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.SaveThroughXslt>(), value, diffs, objName);
  }
  
  private static void SetSaveThroughXslt(DXW.Settings openXmlElement, DMW.SaveThroughXslt? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SaveThroughXslt>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.SaveThroughXsltConverter.CreateOpenXmlElement<DXW.SaveThroughXslt>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetShowXmlTags(DXW.Settings openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.ShowXmlTags>());
  }
  
  private static bool CmpShowXmlTags(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.ShowXmlTags>(), value, diffs, objName);
  }
  
  private static void SetShowXmlTags(DXW.Settings openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.ShowXmlTags>(openXmlElement, value);
  }
  
  private static Boolean? GetAlwaysMergeEmptyNamespace(DXW.Settings openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.AlwaysMergeEmptyNamespace>());
  }
  
  private static bool CmpAlwaysMergeEmptyNamespace(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.AlwaysMergeEmptyNamespace>(), value, diffs, objName);
  }
  
  private static void SetAlwaysMergeEmptyNamespace(DXW.Settings openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.AlwaysMergeEmptyNamespace>(openXmlElement, value);
  }
  
  private static Boolean? GetUpdateFieldsOnOpen(DXW.Settings openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.UpdateFieldsOnOpen>());
  }
  
  private static bool CmpUpdateFieldsOnOpen(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.UpdateFieldsOnOpen>(), value, diffs, objName);
  }
  
  private static void SetUpdateFieldsOnOpen(DXW.Settings openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.UpdateFieldsOnOpen>(openXmlElement, value);
  }
  
  private static DMW.HeaderShapeDefaults? GetHeaderShapeDefaults(DXW.Settings openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.HeaderShapeDefaults>();
    if (element != null)
      return DMXW.HeaderShapeDefaultsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHeaderShapeDefaults(DXW.Settings openXmlElement, DMW.HeaderShapeDefaults? value, DiffList? diffs, string? objName)
  {
    return DMXW.HeaderShapeDefaultsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.HeaderShapeDefaults>(), value, diffs, objName);
  }
  
  private static void SetHeaderShapeDefaults(DXW.Settings openXmlElement, DMW.HeaderShapeDefaults? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.HeaderShapeDefaults>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.HeaderShapeDefaultsConverter.CreateOpenXmlElement<DXW.HeaderShapeDefaults>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.FootnoteDocumentWideProperties? GetFootnoteDocumentWideProperties(DXW.Settings openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.FootnoteDocumentWideProperties>();
    if (element != null)
      return DMXW.FootnoteDocumentWidePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFootnoteDocumentWideProperties(DXW.Settings openXmlElement, DMW.FootnoteDocumentWideProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.FootnoteDocumentWidePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.FootnoteDocumentWideProperties>(), value, diffs, objName);
  }
  
  private static void SetFootnoteDocumentWideProperties(DXW.Settings openXmlElement, DMW.FootnoteDocumentWideProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.FootnoteDocumentWideProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.FootnoteDocumentWidePropertiesConverter.CreateOpenXmlElement<DXW.FootnoteDocumentWideProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.EndnoteDocumentWideProperties? GetEndnoteDocumentWideProperties(DXW.Settings openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.EndnoteDocumentWideProperties>();
    if (element != null)
      return DMXW.EndnoteDocumentWidePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEndnoteDocumentWideProperties(DXW.Settings openXmlElement, DMW.EndnoteDocumentWideProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.EndnoteDocumentWidePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.EndnoteDocumentWideProperties>(), value, diffs, objName);
  }
  
  private static void SetEndnoteDocumentWideProperties(DXW.Settings openXmlElement, DMW.EndnoteDocumentWideProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.EndnoteDocumentWideProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.EndnoteDocumentWidePropertiesConverter.CreateOpenXmlElement<DXW.EndnoteDocumentWideProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.Compatibility? GetCompatibility(DXW.Settings openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Compatibility>();
    if (element != null)
      return DMXW.CompatibilityConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCompatibility(DXW.Settings openXmlElement, DMW.Compatibility? value, DiffList? diffs, string? objName)
  {
    return DMXW.CompatibilityConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Compatibility>(), value, diffs, objName);
  }
  
  private static void SetCompatibility(DXW.Settings openXmlElement, DMW.Compatibility? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Compatibility>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.CompatibilityConverter.CreateOpenXmlElement<DXW.Compatibility>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.DocumentVariables? GetDocumentVariables(DXW.Settings openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.DocumentVariables>();
    if (element != null)
      return DMXW.DocumentVariablesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDocumentVariables(DXW.Settings openXmlElement, DMW.DocumentVariables? value, DiffList? diffs, string? objName)
  {
    return DMXW.DocumentVariablesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.DocumentVariables>(), value, diffs, objName);
  }
  
  private static void SetDocumentVariables(DXW.Settings openXmlElement, DMW.DocumentVariables? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DocumentVariables>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.DocumentVariablesConverter.CreateOpenXmlElement<DXW.DocumentVariables>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.Rsids? GetRsids(DXW.Settings openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Rsids>();
    if (element != null)
      return DMXW.RsidsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRsids(DXW.Settings openXmlElement, DMW.Rsids? value, DiffList? diffs, string? objName)
  {
    return DMXW.RsidsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Rsids>(), value, diffs, objName);
  }
  
  private static void SetRsids(DXW.Settings openXmlElement, DMW.Rsids? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Rsids>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.RsidsConverter.CreateOpenXmlElement<DXW.Rsids>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMM.MathProperties? GetMathProperties(DXW.Settings openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.MathProperties>();
    if (element != null)
      return DMXM.MathPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMathProperties(DXW.Settings openXmlElement, DMM.MathProperties? value, DiffList? diffs, string? objName)
  {
    return DMXM.MathPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.MathProperties>(), value, diffs, objName);
  }
  
  private static void SetMathProperties(DXW.Settings openXmlElement, DMM.MathProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.MathProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.MathPropertiesConverter.CreateOpenXmlElement<DXM.MathProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetUICompatibleWith97To2003(DXW.Settings openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.UICompatibleWith97To2003>());
  }
  
  private static bool CmpUICompatibleWith97To2003(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.UICompatibleWith97To2003>(), value, diffs, objName);
  }
  
  private static void SetUICompatibleWith97To2003(DXW.Settings openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.UICompatibleWith97To2003>(openXmlElement, value);
  }
  
  private static Collection<String>? GetAttachedSchemas(DXW.Settings openXmlElement)
  {
    var collection = new Collection<String>();
    foreach (var item in openXmlElement.Elements<DXW.AttachedSchema>())
    {
      var newItem = StringValueConverter.GetValue(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpAttachedSchemas(DXW.Settings openXmlElement, Collection<String>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXW.AttachedSchema>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!StringValueConverter.CmpValue(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetAttachedSchemas(DXW.Settings openXmlElement, Collection<String>? value)
  {
    openXmlElement.RemoveAllChildren<DXW.AttachedSchema>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = StringValueConverter.CreateOpenXmlElement<DXW.AttachedSchema>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DMW.Languages? GetThemeFontLanguages(DXW.Settings openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.ThemeFontLanguages>();
    if (element != null)
      return DMXW.LanguageTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpThemeFontLanguages(DXW.Settings openXmlElement, DMW.Languages? value, DiffList? diffs, string? objName)
  {
    return DMXW.LanguageTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.ThemeFontLanguages>(), value, diffs, objName);
  }
  
  private static void SetThemeFontLanguages(DXW.Settings openXmlElement, DMW.Languages? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.ThemeFontLanguages>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.LanguageTypeConverter.CreateOpenXmlElement<DXW.ThemeFontLanguages>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.ColorSchemeMapping? GetColorSchemeMapping(DXW.Settings openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.ColorSchemeMapping>();
    if (element != null)
      return DMXW.ColorSchemeMappingConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpColorSchemeMapping(DXW.Settings openXmlElement, DMW.ColorSchemeMapping? value, DiffList? diffs, string? objName)
  {
    return DMXW.ColorSchemeMappingConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.ColorSchemeMapping>(), value, diffs, objName);
  }
  
  private static void SetColorSchemeMapping(DXW.Settings openXmlElement, DMW.ColorSchemeMapping? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.ColorSchemeMapping>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.ColorSchemeMappingConverter.CreateOpenXmlElement<DXW.ColorSchemeMapping>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetDoNotIncludeSubdocsInStats(DXW.Settings openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.DoNotIncludeSubdocsInStats>());
  }
  
  private static bool CmpDoNotIncludeSubdocsInStats(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.DoNotIncludeSubdocsInStats>(), value, diffs, objName);
  }
  
  private static void SetDoNotIncludeSubdocsInStats(DXW.Settings openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.DoNotIncludeSubdocsInStats>(openXmlElement, value);
  }
  
  private static Boolean? GetDoNotAutoCompressPictures(DXW.Settings openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.DoNotAutoCompressPictures>());
  }
  
  private static bool CmpDoNotAutoCompressPictures(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.DoNotAutoCompressPictures>(), value, diffs, objName);
  }
  
  private static void SetDoNotAutoCompressPictures(DXW.Settings openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.DoNotAutoCompressPictures>(openXmlElement, value);
  }
  
  private static Boolean? GetForceUpgrade(DXW.Settings openXmlElement)
  {
    var element = openXmlElement.GetFirstChild<DXW.ForceUpgrade>();
    return (element != null) ? true : null;
  }
  
  private static bool CmpForceUpgrade(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var element = openXmlElement.GetFirstChild<DXW.ForceUpgrade>();
    bool? val = (element != null) ? true : null;
    if (val == value) return true;
    diffs?.Add(objName, "DXW.ForceUpgrade", val, value);
    return false;
  }
  
  private static void SetForceUpgrade(DXW.Settings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.ForceUpgrade>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.ForceUpgrade();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.Captions? GetCaptions(DXW.Settings openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Captions>();
    if (element != null)
      return DMXW.CaptionsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCaptions(DXW.Settings openXmlElement, DMW.Captions? value, DiffList? diffs, string? objName)
  {
    return DMXW.CaptionsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Captions>(), value, diffs, objName);
  }
  
  private static void SetCaptions(DXW.Settings openXmlElement, DMW.Captions? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Captions>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.CaptionsConverter.CreateOpenXmlElement<DXW.Captions>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.ReadModeInkLockDown? GetReadModeInkLockDown(DXW.Settings openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.ReadModeInkLockDown>();
    if (element != null)
      return DMXW.ReadModeInkLockDownConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpReadModeInkLockDown(DXW.Settings openXmlElement, DMW.ReadModeInkLockDown? value, DiffList? diffs, string? objName)
  {
    return DMXW.ReadModeInkLockDownConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.ReadModeInkLockDown>(), value, diffs, objName);
  }
  
  private static void SetReadModeInkLockDown(DXW.Settings openXmlElement, DMW.ReadModeInkLockDown? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.ReadModeInkLockDown>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.ReadModeInkLockDownConverter.CreateOpenXmlElement<DXW.ReadModeInkLockDown>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMCustXml.SchemaLibrary? GetSchemaLibrary(DXW.Settings openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXCustXmlSchRefs.SchemaLibrary>();
    if (element != null)
      return DMXCustXml.SchemaLibraryConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSchemaLibrary(DXW.Settings openXmlElement, DMCustXml.SchemaLibrary? value, DiffList? diffs, string? objName)
  {
    return DMXCustXml.SchemaLibraryConverter.CompareModelElement(openXmlElement.GetFirstChild<DXCustXmlSchRefs.SchemaLibrary>(), value, diffs, objName);
  }
  
  private static void SetSchemaLibrary(DXW.Settings openXmlElement, DMCustXml.SchemaLibrary? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXCustXmlSchRefs.SchemaLibrary>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXCustXml.SchemaLibraryConverter.CreateOpenXmlElement<DXCustXmlSchRefs.SchemaLibrary>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.ShapeDefaults? GetShapeDefaults(DXW.Settings openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.ShapeDefaults>();
    if (element != null)
      return DMXW.ShapeDefaultsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeDefaults(DXW.Settings openXmlElement, DMW.ShapeDefaults? value, DiffList? diffs, string? objName)
  {
    return DMXW.ShapeDefaultsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.ShapeDefaults>(), value, diffs, objName);
  }
  
  private static void SetShapeDefaults(DXW.Settings openXmlElement, DMW.ShapeDefaults? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.ShapeDefaults>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.ShapeDefaultsConverter.CreateOpenXmlElement<DXW.ShapeDefaults>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static String? GetDecimalSymbol(DXW.Settings openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.DecimalSymbol>()?.Val?.Value;
  }
  
  private static bool CmpDecimalSymbol(DXW.Settings openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DecimalSymbol>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DecimalSymbol", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetDecimalSymbol(DXW.Settings openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DecimalSymbol>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.DecimalSymbol { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static String? GetListSeparator(DXW.Settings openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.ListSeparator>()?.Val?.Value;
  }
  
  private static bool CmpListSeparator(DXW.Settings openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.ListSeparator>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "ListSeparator", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetListSeparator(DXW.Settings openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.ListSeparator>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.ListSeparator { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.HexInt? GetDocumentId(DXW.Settings openXmlElement)
  {
    return HexIntConverter.GetValue(openXmlElement?.GetFirstChild<DXO2010W.DocumentId>()?.Val);
  }
  
  private static bool CmpDocumentId(DXW.Settings openXmlElement, DM.HexInt? value, DiffList? diffs, string? objName)
  {
    return HexIntConverter.CmpValue(openXmlElement?.GetFirstChild<DXO2010W.DocumentId>()?.Val, value, diffs, objName, "DocumentId");
  }
  
  private static void SetDocumentId(DXW.Settings openXmlElement, DM.HexInt? value)
  {
    HexIntConverter.SetValue<DXO2010W.DocumentId>(openXmlElement, value);
  }
  
  private static bool? GetDiscardImageEditingData(DXW.Settings openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXO2010W.DiscardImageEditingData>()?.Val?.Value);
  }
  
  private static bool CmpDiscardImageEditingData(DXW.Settings openXmlElement, bool? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXO2010W.DiscardImageEditingData>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetDiscardImageEditingData(DXW.Settings openXmlElement, bool? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.DiscardImageEditingData>();
    if (itemElement != null)
    {
      if (value != null)
        BooleanValueConverter.UpdateOpenXmlElement(itemElement, (bool)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(BooleanValueConverter.CreateOpenXmlElement<DXO2010W.DiscardImageEditingData>((bool)value));
  }
  
  private static Int32? GetDefaultImageDpi(DXW.Settings openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXO2010W.DefaultImageDpi>()?.Val);
  }
  
  private static bool CmpDefaultImageDpi(DXW.Settings openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXO2010W.DefaultImageDpi>()?.Val, value, diffs, objName, "DefaultImageDpi");
  }
  
  private static void SetDefaultImageDpi(DXW.Settings openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXO2010W.DefaultImageDpi,System.Int32>(openXmlElement, value);
  }
  
  private static bool? GetConflictMode(DXW.Settings openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXO2010W.ConflictMode>()?.Val?.Value);
  }
  
  private static bool CmpConflictMode(DXW.Settings openXmlElement, bool? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXO2010W.ConflictMode>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetConflictMode(DXW.Settings openXmlElement, bool? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.ConflictMode>();
    if (itemElement != null)
    {
      if (value != null)
        BooleanValueConverter.UpdateOpenXmlElement<DXO2010W.ConflictMode>(itemElement, (bool)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(BooleanValueConverter.CreateOpenXmlElement<DXO2010W.ConflictMode>((bool)value));
  }
  
  private static Boolean? GetChartTrackingRefBased(DXW.Settings openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXO2013W.ChartTrackingRefBased>() != null;
  }
  
  private static bool CmpChartTrackingRefBased(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXO2013W.ChartTrackingRefBased>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXO2013W.ChartTrackingRefBased", val, value);
    return false;
  }
  
  private static void SetChartTrackingRefBased(DXW.Settings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO2013W.ChartTrackingRefBased>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO2013W.ChartTrackingRefBased();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Guid? GetPersistentDocumentId(DXW.Settings openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013W.PersistentDocumentId>();
    if (itemElement?.Val?.Value != null)
      return Guid.Parse(itemElement.Val.Value);
    return null;
  }
  
  private static bool CmpPersistentDocumentId(DXW.Settings openXmlElement, Guid? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013W.PersistentDocumentId>();
    if (itemElement?.Val?.Value != null)
    {
      var val = Guid.Parse(itemElement.Val.Value);
      if (val == value) return true;
    }
    if (itemElement == null && itemElement?.Val?.Value == null && value == null) return true;
    diffs?.Add(objName, "PersistentDocumentId", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetPersistentDocumentId(DXW.Settings openXmlElement, Guid? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013W.PersistentDocumentId>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXO2013W.PersistentDocumentId{ Val = ((Guid)value).ToString("B") };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.DocumentSettings? CreateModelElement(DXW.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.DocumentSettings();
      value.WriteProtection = GetWriteProtection(openXmlElement);
      value.View = GetView(openXmlElement);
      value.Zoom = GetZoom(openXmlElement);
      value.RemovePersonalInformation = GetRemovePersonalInformation(openXmlElement);
      value.RemoveDateAndTime = GetRemoveDateAndTime(openXmlElement);
      value.DoNotDisplayPageBoundaries = GetDoNotDisplayPageBoundaries(openXmlElement);
      value.DisplayBackgroundShape = GetDisplayBackgroundShape(openXmlElement);
      value.PrintPostScriptOverText = GetPrintPostScriptOverText(openXmlElement);
      value.PrintFractionalCharacterWidth = GetPrintFractionalCharacterWidth(openXmlElement);
      value.PrintFormsData = GetPrintFormsData(openXmlElement);
      value.EmbedTrueTypeFonts = GetEmbedTrueTypeFonts(openXmlElement);
      value.EmbedSystemFonts = GetEmbedSystemFonts(openXmlElement);
      value.SaveSubsetFonts = GetSaveSubsetFonts(openXmlElement);
      value.SaveFormsData = GetSaveFormsData(openXmlElement);
      value.MirrorMargins = GetMirrorMargins(openXmlElement);
      value.AlignBorderAndEdges = GetAlignBorderAndEdges(openXmlElement);
      value.BordersDoNotSurroundHeader = GetBordersDoNotSurroundHeader(openXmlElement);
      value.BordersDoNotSurroundFooter = GetBordersDoNotSurroundFooter(openXmlElement);
      value.GutterAtTop = GetGutterAtTop(openXmlElement);
      value.HideSpellingErrors = GetHideSpellingErrors(openXmlElement);
      value.HideGrammaticalErrors = GetHideGrammaticalErrors(openXmlElement);
      value.ActiveWritingStyles = GetActiveWritingStyles(openXmlElement);
      value.ProofState = GetProofState(openXmlElement);
      value.FormsDesign = GetFormsDesign(openXmlElement);
      value.AttachedTemplate = GetAttachedTemplate(openXmlElement);
      value.LinkStyles = GetLinkStyles(openXmlElement);
      value.StylePaneFormatFilter = GetStylePaneFormatFilter(openXmlElement);
      value.StylePaneSortMethods = GetStylePaneSortMethods(openXmlElement);
      value.DocumentType = GetDocumentType(openXmlElement);
      value.MailMerge = GetMailMerge(openXmlElement);
      value.RevisionView = GetRevisionView(openXmlElement);
      value.TrackRevisions = GetTrackRevisions(openXmlElement);
      value.DoNotTrackMoves = GetDoNotTrackMoves(openXmlElement);
      value.DoNotTrackFormatting = GetDoNotTrackFormatting(openXmlElement);
      value.DocumentProtection = GetDocumentProtection(openXmlElement);
      value.AutoFormatOverride = GetAutoFormatOverride(openXmlElement);
      value.DefaultTabStop = GetDefaultTabStop(openXmlElement);
      value.AutoHyphenation = GetAutoHyphenation(openXmlElement);
      value.ConsecutiveHyphenLimit = GetConsecutiveHyphenLimit(openXmlElement);
      value.HyphenationZone = GetHyphenationZone(openXmlElement);
      value.DoNotHyphenateCaps = GetDoNotHyphenateCaps(openXmlElement);
      value.ShowEnvelope = GetShowEnvelope(openXmlElement);
      value.SummaryLength = GetSummaryLength(openXmlElement);
      value.ClickAndTypeStyle = GetClickAndTypeStyle(openXmlElement);
      value.DefaultTableStyle = GetDefaultTableStyle(openXmlElement);
      value.EvenAndOddHeaders = GetEvenAndOddHeaders(openXmlElement);
      value.BookFoldReversePrinting = GetBookFoldReversePrinting(openXmlElement);
      value.BookFoldPrinting = GetBookFoldPrinting(openXmlElement);
      value.BookFoldPrintingSheets = GetBookFoldPrintingSheets(openXmlElement);
      value.DrawingGridHorizontalSpacing = GetDrawingGridHorizontalSpacing(openXmlElement);
      value.DrawingGridVerticalSpacing = GetDrawingGridVerticalSpacing(openXmlElement);
      value.DisplayHorizontalDrawingGrid = GetDisplayHorizontalDrawingGrid(openXmlElement);
      value.DisplayVerticalDrawingGrid = GetDisplayVerticalDrawingGrid(openXmlElement);
      value.DoNotUseMarginsForDrawingGridOrigin = GetDoNotUseMarginsForDrawingGridOrigin(openXmlElement);
      value.DrawingGridHorizontalOrigin = GetDrawingGridHorizontalOrigin(openXmlElement);
      value.DrawingGridVerticalOrigin = GetDrawingGridVerticalOrigin(openXmlElement);
      value.DoNotShadeFormData = GetDoNotShadeFormData(openXmlElement);
      value.NoPunctuationKerning = GetNoPunctuationKerning(openXmlElement);
      value.CharacterSpacingControl = GetCharacterSpacingControl(openXmlElement);
      value.PrintTwoOnOne = GetPrintTwoOnOne(openXmlElement);
      value.StrictFirstAndLastChars = GetStrictFirstAndLastChars(openXmlElement);
      value.NoLineBreaksAfterKinsoku = GetNoLineBreaksAfterKinsoku(openXmlElement);
      value.NoLineBreaksBeforeKinsoku = GetNoLineBreaksBeforeKinsoku(openXmlElement);
      value.SavePreviewPicture = GetSavePreviewPicture(openXmlElement);
      value.DoNotValidateAgainstSchema = GetDoNotValidateAgainstSchema(openXmlElement);
      value.SaveInvalidXml = GetSaveInvalidXml(openXmlElement);
      value.IgnoreMixedContent = GetIgnoreMixedContent(openXmlElement);
      value.AlwaysShowPlaceholderText = GetAlwaysShowPlaceholderText(openXmlElement);
      value.DoNotDemarcateInvalidXml = GetDoNotDemarcateInvalidXml(openXmlElement);
      value.SaveXmlDataOnly = GetSaveXmlDataOnly(openXmlElement);
      value.UseXsltWhenSaving = GetUseXsltWhenSaving(openXmlElement);
      value.SaveThroughXslt = GetSaveThroughXslt(openXmlElement);
      value.ShowXmlTags = GetShowXmlTags(openXmlElement);
      value.AlwaysMergeEmptyNamespace = GetAlwaysMergeEmptyNamespace(openXmlElement);
      value.UpdateFieldsOnOpen = GetUpdateFieldsOnOpen(openXmlElement);
      value.HeaderShapeDefaults = GetHeaderShapeDefaults(openXmlElement);
      value.FootnoteDocumentWideProperties = GetFootnoteDocumentWideProperties(openXmlElement);
      value.EndnoteDocumentWideProperties = GetEndnoteDocumentWideProperties(openXmlElement);
      value.Compatibility = GetCompatibility(openXmlElement);
      value.DocumentVariables = GetDocumentVariables(openXmlElement);
      value.Rsids = GetRsids(openXmlElement);
      value.MathProperties = GetMathProperties(openXmlElement);
      value.UICompatibleWith97To2003 = GetUICompatibleWith97To2003(openXmlElement);
      value.AttachedSchemas = GetAttachedSchemas(openXmlElement);
      value.ThemeFontLanguages = GetThemeFontLanguages(openXmlElement);
      value.ColorSchemeMapping = GetColorSchemeMapping(openXmlElement);
      value.DoNotIncludeSubdocsInStats = GetDoNotIncludeSubdocsInStats(openXmlElement);
      value.DoNotAutoCompressPictures = GetDoNotAutoCompressPictures(openXmlElement);
      value.ForceUpgrade = GetForceUpgrade(openXmlElement);
      value.Captions = GetCaptions(openXmlElement);
      value.ReadModeInkLockDown = GetReadModeInkLockDown(openXmlElement);
      value.SchemaLibrary = GetSchemaLibrary(openXmlElement);
      value.ShapeDefaults = GetShapeDefaults(openXmlElement);
      value.DecimalSymbol = GetDecimalSymbol(openXmlElement);
      value.ListSeparator = GetListSeparator(openXmlElement);
      value.DocumentId = GetDocumentId(openXmlElement);
      value.DiscardImageEditingData = GetDiscardImageEditingData(openXmlElement);
      value.DefaultImageDpi = GetDefaultImageDpi(openXmlElement);
      value.ConflictMode = GetConflictMode(openXmlElement);
      value.ChartTrackingRefBased = GetChartTrackingRefBased(openXmlElement);
      value.PersistentDocumentId = GetPersistentDocumentId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.Settings? openXmlElement, DM.DocumentSettings? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpWriteProtection(openXmlElement, value.WriteProtection, diffs, objName))
        ok = false;
      if (!CmpView(openXmlElement, value.View, diffs, objName))
        ok = false;
      if (!CmpZoom(openXmlElement, value.Zoom, diffs, objName))
        ok = false;
      if (!CmpRemovePersonalInformation(openXmlElement, value.RemovePersonalInformation, diffs, objName))
        ok = false;
      if (!CmpRemoveDateAndTime(openXmlElement, value.RemoveDateAndTime, diffs, objName))
        ok = false;
      if (!CmpDoNotDisplayPageBoundaries(openXmlElement, value.DoNotDisplayPageBoundaries, diffs, objName))
        ok = false;
      if (!CmpDisplayBackgroundShape(openXmlElement, value.DisplayBackgroundShape, diffs, objName))
        ok = false;
      if (!CmpPrintPostScriptOverText(openXmlElement, value.PrintPostScriptOverText, diffs, objName))
        ok = false;
      if (!CmpPrintFractionalCharacterWidth(openXmlElement, value.PrintFractionalCharacterWidth, diffs, objName))
        ok = false;
      if (!CmpPrintFormsData(openXmlElement, value.PrintFormsData, diffs, objName))
        ok = false;
      if (!CmpEmbedTrueTypeFonts(openXmlElement, value.EmbedTrueTypeFonts, diffs, objName))
        ok = false;
      if (!CmpEmbedSystemFonts(openXmlElement, value.EmbedSystemFonts, diffs, objName))
        ok = false;
      if (!CmpSaveSubsetFonts(openXmlElement, value.SaveSubsetFonts, diffs, objName))
        ok = false;
      if (!CmpSaveFormsData(openXmlElement, value.SaveFormsData, diffs, objName))
        ok = false;
      if (!CmpMirrorMargins(openXmlElement, value.MirrorMargins, diffs, objName))
        ok = false;
      if (!CmpAlignBorderAndEdges(openXmlElement, value.AlignBorderAndEdges, diffs, objName))
        ok = false;
      if (!CmpBordersDoNotSurroundHeader(openXmlElement, value.BordersDoNotSurroundHeader, diffs, objName))
        ok = false;
      if (!CmpBordersDoNotSurroundFooter(openXmlElement, value.BordersDoNotSurroundFooter, diffs, objName))
        ok = false;
      if (!CmpGutterAtTop(openXmlElement, value.GutterAtTop, diffs, objName))
        ok = false;
      if (!CmpHideSpellingErrors(openXmlElement, value.HideSpellingErrors, diffs, objName))
        ok = false;
      if (!CmpHideGrammaticalErrors(openXmlElement, value.HideGrammaticalErrors, diffs, objName))
        ok = false;
      if (!CmpActiveWritingStyles(openXmlElement, value.ActiveWritingStyles, diffs, objName))
        ok = false;
      if (!CmpProofState(openXmlElement, value.ProofState, diffs, objName))
        ok = false;
      if (!CmpFormsDesign(openXmlElement, value.FormsDesign, diffs, objName))
        ok = false;
      if (!CmpAttachedTemplate(openXmlElement, value.AttachedTemplate, diffs, objName))
        ok = false;
      if (!CmpLinkStyles(openXmlElement, value.LinkStyles, diffs, objName))
        ok = false;
      if (!CmpStylePaneFormatFilter(openXmlElement, value.StylePaneFormatFilter, diffs, objName))
        ok = false;
      if (!CmpStylePaneSortMethods(openXmlElement, value.StylePaneSortMethods, diffs, objName))
        ok = false;
      if (!CmpDocumentType(openXmlElement, value.DocumentType, diffs, objName))
        ok = false;
      if (!CmpMailMerge(openXmlElement, value.MailMerge, diffs, objName))
        ok = false;
      if (!CmpRevisionView(openXmlElement, value.RevisionView, diffs, objName))
        ok = false;
      if (!CmpTrackRevisions(openXmlElement, value.TrackRevisions, diffs, objName))
        ok = false;
      if (!CmpDoNotTrackMoves(openXmlElement, value.DoNotTrackMoves, diffs, objName))
        ok = false;
      if (!CmpDoNotTrackFormatting(openXmlElement, value.DoNotTrackFormatting, diffs, objName))
        ok = false;
      if (!CmpDocumentProtection(openXmlElement, value.DocumentProtection, diffs, objName))
        ok = false;
      if (!CmpAutoFormatOverride(openXmlElement, value.AutoFormatOverride, diffs, objName))
        ok = false;
      if (!CmpDefaultTabStop(openXmlElement, value.DefaultTabStop, diffs, objName))
        ok = false;
      if (!CmpAutoHyphenation(openXmlElement, value.AutoHyphenation, diffs, objName))
        ok = false;
      if (!CmpConsecutiveHyphenLimit(openXmlElement, value.ConsecutiveHyphenLimit, diffs, objName))
        ok = false;
      if (!CmpHyphenationZone(openXmlElement, value.HyphenationZone, diffs, objName))
        ok = false;
      if (!CmpDoNotHyphenateCaps(openXmlElement, value.DoNotHyphenateCaps, diffs, objName))
        ok = false;
      if (!CmpShowEnvelope(openXmlElement, value.ShowEnvelope, diffs, objName))
        ok = false;
      if (!CmpSummaryLength(openXmlElement, value.SummaryLength, diffs, objName))
        ok = false;
      if (!CmpClickAndTypeStyle(openXmlElement, value.ClickAndTypeStyle, diffs, objName))
        ok = false;
      if (!CmpDefaultTableStyle(openXmlElement, value.DefaultTableStyle, diffs, objName))
        ok = false;
      if (!CmpEvenAndOddHeaders(openXmlElement, value.EvenAndOddHeaders, diffs, objName))
        ok = false;
      if (!CmpBookFoldReversePrinting(openXmlElement, value.BookFoldReversePrinting, diffs, objName))
        ok = false;
      if (!CmpBookFoldPrinting(openXmlElement, value.BookFoldPrinting, diffs, objName))
        ok = false;
      if (!CmpBookFoldPrintingSheets(openXmlElement, value.BookFoldPrintingSheets, diffs, objName))
        ok = false;
      if (!CmpDrawingGridHorizontalSpacing(openXmlElement, value.DrawingGridHorizontalSpacing, diffs, objName))
        ok = false;
      if (!CmpDrawingGridVerticalSpacing(openXmlElement, value.DrawingGridVerticalSpacing, diffs, objName))
        ok = false;
      if (!CmpDisplayHorizontalDrawingGrid(openXmlElement, value.DisplayHorizontalDrawingGrid, diffs, objName))
        ok = false;
      if (!CmpDisplayVerticalDrawingGrid(openXmlElement, value.DisplayVerticalDrawingGrid, diffs, objName))
        ok = false;
      if (!CmpDoNotUseMarginsForDrawingGridOrigin(openXmlElement, value.DoNotUseMarginsForDrawingGridOrigin, diffs, objName))
        ok = false;
      if (!CmpDrawingGridHorizontalOrigin(openXmlElement, value.DrawingGridHorizontalOrigin, diffs, objName))
        ok = false;
      if (!CmpDrawingGridVerticalOrigin(openXmlElement, value.DrawingGridVerticalOrigin, diffs, objName))
        ok = false;
      if (!CmpDoNotShadeFormData(openXmlElement, value.DoNotShadeFormData, diffs, objName))
        ok = false;
      if (!CmpNoPunctuationKerning(openXmlElement, value.NoPunctuationKerning, diffs, objName))
        ok = false;
      if (!CmpCharacterSpacingControl(openXmlElement, value.CharacterSpacingControl, diffs, objName))
        ok = false;
      if (!CmpPrintTwoOnOne(openXmlElement, value.PrintTwoOnOne, diffs, objName))
        ok = false;
      if (!CmpStrictFirstAndLastChars(openXmlElement, value.StrictFirstAndLastChars, diffs, objName))
        ok = false;
      if (!CmpNoLineBreaksAfterKinsoku(openXmlElement, value.NoLineBreaksAfterKinsoku, diffs, objName))
        ok = false;
      if (!CmpNoLineBreaksBeforeKinsoku(openXmlElement, value.NoLineBreaksBeforeKinsoku, diffs, objName))
        ok = false;
      if (!CmpSavePreviewPicture(openXmlElement, value.SavePreviewPicture, diffs, objName))
        ok = false;
      if (!CmpDoNotValidateAgainstSchema(openXmlElement, value.DoNotValidateAgainstSchema, diffs, objName))
        ok = false;
      if (!CmpSaveInvalidXml(openXmlElement, value.SaveInvalidXml, diffs, objName))
        ok = false;
      if (!CmpIgnoreMixedContent(openXmlElement, value.IgnoreMixedContent, diffs, objName))
        ok = false;
      if (!CmpAlwaysShowPlaceholderText(openXmlElement, value.AlwaysShowPlaceholderText, diffs, objName))
        ok = false;
      if (!CmpDoNotDemarcateInvalidXml(openXmlElement, value.DoNotDemarcateInvalidXml, diffs, objName))
        ok = false;
      if (!CmpSaveXmlDataOnly(openXmlElement, value.SaveXmlDataOnly, diffs, objName))
        ok = false;
      if (!CmpUseXsltWhenSaving(openXmlElement, value.UseXsltWhenSaving, diffs, objName))
        ok = false;
      if (!CmpSaveThroughXslt(openXmlElement, value.SaveThroughXslt, diffs, objName))
        ok = false;
      if (!CmpShowXmlTags(openXmlElement, value.ShowXmlTags, diffs, objName))
        ok = false;
      if (!CmpAlwaysMergeEmptyNamespace(openXmlElement, value.AlwaysMergeEmptyNamespace, diffs, objName))
        ok = false;
      if (!CmpUpdateFieldsOnOpen(openXmlElement, value.UpdateFieldsOnOpen, diffs, objName))
        ok = false;
      if (!CmpHeaderShapeDefaults(openXmlElement, value.HeaderShapeDefaults, diffs, objName))
        ok = false;
      if (!CmpFootnoteDocumentWideProperties(openXmlElement, value.FootnoteDocumentWideProperties, diffs, objName))
        ok = false;
      if (!CmpEndnoteDocumentWideProperties(openXmlElement, value.EndnoteDocumentWideProperties, diffs, objName))
        ok = false;
      if (!CmpCompatibility(openXmlElement, value.Compatibility, diffs, objName))
        ok = false;
      if (!CmpDocumentVariables(openXmlElement, value.DocumentVariables, diffs, objName))
        ok = false;
      if (!CmpRsids(openXmlElement, value.Rsids, diffs, objName))
        ok = false;
      if (!CmpMathProperties(openXmlElement, value.MathProperties, diffs, objName))
        ok = false;
      if (!CmpUICompatibleWith97To2003(openXmlElement, value.UICompatibleWith97To2003, diffs, objName))
        ok = false;
      if (!CmpAttachedSchemas(openXmlElement, value.AttachedSchemas, diffs, objName))
        ok = false;
      if (!CmpThemeFontLanguages(openXmlElement, value.ThemeFontLanguages, diffs, objName))
        ok = false;
      if (!CmpColorSchemeMapping(openXmlElement, value.ColorSchemeMapping, diffs, objName))
        ok = false;
      if (!CmpDoNotIncludeSubdocsInStats(openXmlElement, value.DoNotIncludeSubdocsInStats, diffs, objName))
        ok = false;
      if (!CmpDoNotAutoCompressPictures(openXmlElement, value.DoNotAutoCompressPictures, diffs, objName))
        ok = false;
      if (!CmpForceUpgrade(openXmlElement, value.ForceUpgrade, diffs, objName))
        ok = false;
      if (!CmpCaptions(openXmlElement, value.Captions, diffs, objName))
        ok = false;
      if (!CmpReadModeInkLockDown(openXmlElement, value.ReadModeInkLockDown, diffs, objName))
        ok = false;
      if (!CmpSchemaLibrary(openXmlElement, value.SchemaLibrary, diffs, objName))
        ok = false;
      if (!CmpShapeDefaults(openXmlElement, value.ShapeDefaults, diffs, objName))
        ok = false;
      if (!CmpDecimalSymbol(openXmlElement, value.DecimalSymbol, diffs, objName))
        ok = false;
      if (!CmpListSeparator(openXmlElement, value.ListSeparator, diffs, objName))
        ok = false;
      if (!CmpDocumentId(openXmlElement, value.DocumentId, diffs, objName))
        ok = false;
      if (!CmpDiscardImageEditingData(openXmlElement, value.DiscardImageEditingData, diffs, objName))
        ok = false;
      if (!CmpDefaultImageDpi(openXmlElement, value.DefaultImageDpi, diffs, objName))
        ok = false;
      if (!CmpConflictMode(openXmlElement, value.ConflictMode, diffs, objName))
        ok = false;
      if (!CmpChartTrackingRefBased(openXmlElement, value.ChartTrackingRefBased, diffs, objName))
        ok = false;
      if (!CmpPersistentDocumentId(openXmlElement, value.PersistentDocumentId, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DM.DocumentSettings value)
    where OpenXmlElementType: DXW.Settings, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.Settings openXmlElement, DM.DocumentSettings value)
  {
    SetWriteProtection(openXmlElement, value?.WriteProtection);
    SetView(openXmlElement, value?.View);
    SetZoom(openXmlElement, value?.Zoom);
    SetRemovePersonalInformation(openXmlElement, value?.RemovePersonalInformation);
    SetRemoveDateAndTime(openXmlElement, value?.RemoveDateAndTime);
    SetDoNotDisplayPageBoundaries(openXmlElement, value?.DoNotDisplayPageBoundaries);
    SetDisplayBackgroundShape(openXmlElement, value?.DisplayBackgroundShape);
    SetPrintPostScriptOverText(openXmlElement, value?.PrintPostScriptOverText);
    SetPrintFractionalCharacterWidth(openXmlElement, value?.PrintFractionalCharacterWidth);
    SetPrintFormsData(openXmlElement, value?.PrintFormsData);
    SetEmbedTrueTypeFonts(openXmlElement, value?.EmbedTrueTypeFonts);
    SetEmbedSystemFonts(openXmlElement, value?.EmbedSystemFonts);
    SetSaveSubsetFonts(openXmlElement, value?.SaveSubsetFonts);
    SetSaveFormsData(openXmlElement, value?.SaveFormsData);
    SetMirrorMargins(openXmlElement, value?.MirrorMargins);
    SetAlignBorderAndEdges(openXmlElement, value?.AlignBorderAndEdges);
    SetBordersDoNotSurroundHeader(openXmlElement, value?.BordersDoNotSurroundHeader);
    SetBordersDoNotSurroundFooter(openXmlElement, value?.BordersDoNotSurroundFooter);
    SetGutterAtTop(openXmlElement, value?.GutterAtTop);
    SetHideSpellingErrors(openXmlElement, value?.HideSpellingErrors);
    SetHideGrammaticalErrors(openXmlElement, value?.HideGrammaticalErrors);
    SetActiveWritingStyles(openXmlElement, value?.ActiveWritingStyles);
    SetProofState(openXmlElement, value?.ProofState);
    SetFormsDesign(openXmlElement, value?.FormsDesign);
    SetAttachedTemplate(openXmlElement, value?.AttachedTemplate);
    SetLinkStyles(openXmlElement, value?.LinkStyles);
    SetStylePaneFormatFilter(openXmlElement, value?.StylePaneFormatFilter);
    SetStylePaneSortMethods(openXmlElement, value?.StylePaneSortMethods);
    SetDocumentType(openXmlElement, value?.DocumentType);
    SetMailMerge(openXmlElement, value?.MailMerge);
    SetRevisionView(openXmlElement, value?.RevisionView);
    SetTrackRevisions(openXmlElement, value?.TrackRevisions);
    SetDoNotTrackMoves(openXmlElement, value?.DoNotTrackMoves);
    SetDoNotTrackFormatting(openXmlElement, value?.DoNotTrackFormatting);
    SetDocumentProtection(openXmlElement, value?.DocumentProtection);
    SetAutoFormatOverride(openXmlElement, value?.AutoFormatOverride);
    SetDefaultTabStop(openXmlElement, value?.DefaultTabStop);
    SetAutoHyphenation(openXmlElement, value?.AutoHyphenation);
    SetConsecutiveHyphenLimit(openXmlElement, value?.ConsecutiveHyphenLimit);
    SetHyphenationZone(openXmlElement, value?.HyphenationZone);
    SetDoNotHyphenateCaps(openXmlElement, value?.DoNotHyphenateCaps);
    SetShowEnvelope(openXmlElement, value?.ShowEnvelope);
    SetSummaryLength(openXmlElement, value?.SummaryLength);
    SetClickAndTypeStyle(openXmlElement, value?.ClickAndTypeStyle);
    SetDefaultTableStyle(openXmlElement, value?.DefaultTableStyle);
    SetEvenAndOddHeaders(openXmlElement, value?.EvenAndOddHeaders);
    SetBookFoldReversePrinting(openXmlElement, value?.BookFoldReversePrinting);
    SetBookFoldPrinting(openXmlElement, value?.BookFoldPrinting);
    SetBookFoldPrintingSheets(openXmlElement, value?.BookFoldPrintingSheets);
    SetDrawingGridHorizontalSpacing(openXmlElement, value?.DrawingGridHorizontalSpacing);
    SetDrawingGridVerticalSpacing(openXmlElement, value?.DrawingGridVerticalSpacing);
    SetDisplayHorizontalDrawingGrid(openXmlElement, value?.DisplayHorizontalDrawingGrid);
    SetDisplayVerticalDrawingGrid(openXmlElement, value?.DisplayVerticalDrawingGrid);
    SetDoNotUseMarginsForDrawingGridOrigin(openXmlElement, value?.DoNotUseMarginsForDrawingGridOrigin);
    SetDrawingGridHorizontalOrigin(openXmlElement, value?.DrawingGridHorizontalOrigin);
    SetDrawingGridVerticalOrigin(openXmlElement, value?.DrawingGridVerticalOrigin);
    SetDoNotShadeFormData(openXmlElement, value?.DoNotShadeFormData);
    SetNoPunctuationKerning(openXmlElement, value?.NoPunctuationKerning);
    SetCharacterSpacingControl(openXmlElement, value?.CharacterSpacingControl);
    SetPrintTwoOnOne(openXmlElement, value?.PrintTwoOnOne);
    SetStrictFirstAndLastChars(openXmlElement, value?.StrictFirstAndLastChars);
    SetNoLineBreaksAfterKinsoku(openXmlElement, value?.NoLineBreaksAfterKinsoku);
    SetNoLineBreaksBeforeKinsoku(openXmlElement, value?.NoLineBreaksBeforeKinsoku);
    SetSavePreviewPicture(openXmlElement, value?.SavePreviewPicture);
    SetDoNotValidateAgainstSchema(openXmlElement, value?.DoNotValidateAgainstSchema);
    SetSaveInvalidXml(openXmlElement, value?.SaveInvalidXml);
    SetIgnoreMixedContent(openXmlElement, value?.IgnoreMixedContent);
    SetAlwaysShowPlaceholderText(openXmlElement, value?.AlwaysShowPlaceholderText);
    SetDoNotDemarcateInvalidXml(openXmlElement, value?.DoNotDemarcateInvalidXml);
    SetSaveXmlDataOnly(openXmlElement, value?.SaveXmlDataOnly);
    SetUseXsltWhenSaving(openXmlElement, value?.UseXsltWhenSaving);
    SetSaveThroughXslt(openXmlElement, value?.SaveThroughXslt);
    SetShowXmlTags(openXmlElement, value?.ShowXmlTags);
    SetAlwaysMergeEmptyNamespace(openXmlElement, value?.AlwaysMergeEmptyNamespace);
    SetUpdateFieldsOnOpen(openXmlElement, value?.UpdateFieldsOnOpen);
    SetHeaderShapeDefaults(openXmlElement, value?.HeaderShapeDefaults);
    SetFootnoteDocumentWideProperties(openXmlElement, value?.FootnoteDocumentWideProperties);
    SetEndnoteDocumentWideProperties(openXmlElement, value?.EndnoteDocumentWideProperties);
    SetCompatibility(openXmlElement, value?.Compatibility);
    SetDocumentVariables(openXmlElement, value?.DocumentVariables);
    SetRsids(openXmlElement, value?.Rsids);
    SetMathProperties(openXmlElement, value?.MathProperties);
    SetUICompatibleWith97To2003(openXmlElement, value?.UICompatibleWith97To2003);
    SetAttachedSchemas(openXmlElement, value?.AttachedSchemas);
    SetThemeFontLanguages(openXmlElement, value?.ThemeFontLanguages);
    SetColorSchemeMapping(openXmlElement, value?.ColorSchemeMapping);
    SetDoNotIncludeSubdocsInStats(openXmlElement, value?.DoNotIncludeSubdocsInStats);
    SetDoNotAutoCompressPictures(openXmlElement, value?.DoNotAutoCompressPictures);
    SetForceUpgrade(openXmlElement, value?.ForceUpgrade);
    SetCaptions(openXmlElement, value?.Captions);
    SetReadModeInkLockDown(openXmlElement, value?.ReadModeInkLockDown);
    SetSchemaLibrary(openXmlElement, value?.SchemaLibrary);
    SetShapeDefaults(openXmlElement, value?.ShapeDefaults);
    SetDecimalSymbol(openXmlElement, value?.DecimalSymbol);
    SetListSeparator(openXmlElement, value?.ListSeparator);
    SetDocumentId(openXmlElement, value?.DocumentId);
    SetDiscardImageEditingData(openXmlElement, value?.DiscardImageEditingData);
    SetDefaultImageDpi(openXmlElement, value?.DefaultImageDpi);
    SetConflictMode(openXmlElement, value?.ConflictMode);
    SetChartTrackingRefBased(openXmlElement, value?.ChartTrackingRefBased);
    SetPersistentDocumentId(openXmlElement, value?.PersistentDocumentId);
  }
}

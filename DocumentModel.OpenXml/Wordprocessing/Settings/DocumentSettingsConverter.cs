using DocumentModel.Wordprocessing;

namespace DocumentModel.OpenXml;

/// <summary>
/// <see cref="DocumentSettings"/> class from/to OpenXml converter.
/// </summary>
public static class DocumentSettingsConverter
{
  #region Write Protection conversion.  
  private static DMW.WriteProtection? GetWriteProtection(DXW.Settings openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.WriteProtection>();
    if (element is not null)
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
    if (itemElement is not null)
      itemElement.Remove();
    if (value is not null)
    {
      itemElement = DMXW.WriteProtectionConverter.CreateOpenXmlElement<DXW.WriteProtection>(value);
      if (itemElement is not null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region Document View Setting conversion.  
  private static DMW.ViewKind? GetView(DXW.Settings openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.ViewValues, DMW.ViewKind>(openXmlElement.GetFirstChild<DXW.View>()?.Val?.Value);
  }

  private static bool CmpView(DXW.Settings openXmlElement, DMW.ViewKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DXW.ViewValues, DMW.ViewKind>(openXmlElement.GetFirstChild<DXW.View>()?.Val?.Value, value, diffs, objName);
  }

  private static void SetView(DXW.Settings openXmlElement, DMW.ViewKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.View>();
    if (itemElement is not null)
    {
      if (value is not null)
        EnumValueConverter.UpdateOpenXmlElement<DXW.ViewValues, DMW.ViewKind>(itemElement, (DMW.ViewKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value is not null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXW.View, DXW.ViewValues, DMW.ViewKind>((DMW.ViewKind)value));
  }
  #endregion

  #region Magnification Setting conversion.  
  private static DMW.Zoom? GetZoom(DXW.Settings openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Zoom>();
    if (element is not null)
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
    if (itemElement is not null)
      itemElement.Remove();
    if (value is not null)
    {
      itemElement = DMXW.ZoomConverter.CreateOpenXmlElement<DXW.Zoom>(value);
      if (itemElement is not null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region Remove Personal Information from Document Properties conversion.  
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
  #endregion

  #region Remove Date and Time from Annotations conversion.  
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
  #endregion

  #region Do Not Display Visual Boundary For Header/Footer or Between Pages conversion.  
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
  #endregion

  #region Display Background Objects When Displaying Document conversion.  
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
  #endregion

  #region Print PostScript Codes With Document Text conversion.  
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
  #endregion

  #region Print Fractional Character Widths conversion.  
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
  #endregion

  #region Only Print Form Field Content conversion.  
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
  #endregion

  #region Embed TrueType Fonts conversion.  
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
  #endregion

  #region Embed Common System Fonts conversion.  
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
  #endregion

  #region Subset Fonts When Embedding conversion.  
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
  #endregion

  #region Only Save Form Field Content conversion.  
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
  #endregion

  #region Mirror Page Margins conversion.  
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
  #endregion

  #region Align Paragraph and Table Borders with Page Border conversion.  
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
  #endregion

  #region Page Border Excludes Header conversion.  
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
  #endregion

  #region Page Border Excludes Footer conversion.  
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
  #endregion

  #region Position Gutter At Top of Page conversion.  
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
  #endregion

  #region Do Not Display Visual Indication of Spelling Errors conversion.  
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
  #endregion

  #region Do Not Display Visual Indication of Grammatical Errors conversion.  
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
  #endregion

  #region ActiveWritingStyles conversion.
  private static Collection<DMW.ActiveWritingStyle>? GetActiveWritingStyles(DXW.Settings openXmlElement)
  {
    var collection = new Collection<DMW.ActiveWritingStyle>();
    foreach (var item in openXmlElement.Elements<DXW.ActiveWritingStyle>())
    {
      var newItem = DMXW.ActiveWritingStyleConverter.CreateModelElement(item);
      if (newItem is not null)
        collection.Add(newItem);
    }
    if (collection.Count > 0)
      return collection;
    return null;
  }

  private static bool CmpActiveWritingStyles(DXW.Settings openXmlElement, Collection<DMW.ActiveWritingStyle>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXW.ActiveWritingStyle>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value is not null)
    {
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().Name + ".Count", origElementsCount, modelElementsCount);
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
    if (value is not null)
    {
      foreach (var item in value)
      {
        var newItem = DMXW.ActiveWritingStyleConverter.CreateOpenXmlElement<DXW.ActiveWritingStyle>(item);
        if (newItem is not null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  #endregion

  #region ProofState conversion.
  private static DMW.ProofState? GetProofState(DXW.Settings openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.ProofState>();
    if (element is not null)
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
    if (itemElement is not null)
      itemElement.Remove();
    if (value is not null)
    {
      itemElement = DMXW.ProofStateConverter.CreateOpenXmlElement<DXW.ProofState>(value);
      if (itemElement is not null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region FormsDesign conversion.
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
  #endregion

  #region AttachedTemplate conversion.
  private static DMW.AttachedTemplate? GetAttachedTemplate(DXW.Settings openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.AttachedTemplate>();
    if (element is not null)
    {
      return DMXW.AttachedTemplateConverter.CreateModelElement(element, openXmlElement);
    }
    return null;
  }

  private static bool CmpAttachedTemplate(DXW.Settings openXmlElement, DMW.AttachedTemplate? value, DiffList? diffs, string? objName)
  {
    return DMXW.RelationshipTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.AttachedTemplate>(), value, diffs, objName);
  }

  private static void SetAttachedTemplate(DXW.Settings openXmlElement, DMW.AttachedTemplate? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.AttachedTemplate>();
    if (itemElement is not null)
      itemElement.Remove();
    if (value is not null)
    {
      itemElement = DMXW.AttachedTemplateConverter.CreateOpenXmlElement(value, openXmlElement);
      if (itemElement is not null)
      {
        openXmlElement.AppendChild(itemElement);
      }
    }
  }
  #endregion

  #region LinkStyles conversion.
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
  #endregion

  #region StylePaneFormatFilter conversion.
  private static DMW.StylePaneFormatFilter? GetStylePaneFormatFilter(DXW.Settings openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.StylePaneFormatFilter>();
    if (element is not null)
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
    if (itemElement is not null)
      itemElement.Remove();
    if (value is not null)
    {
      itemElement = DMXW.StylePaneFormatFilterConverter.CreateOpenXmlElement<DXW.StylePaneFormatFilter>(value);
      if (itemElement is not null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region StylePaneSortMehtods conversion.
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
  #endregion

  #region DocumentType conversion.
  private static DMW.DocumentKind? GetDocumentType(DXW.Settings openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.DocumentTypeValues, DMW.DocumentKind>(openXmlElement.GetFirstChild<DXW.DocumentType>()?.Val?.Value);
  }

  private static bool CmpDocumentType(DXW.Settings openXmlElement, DMW.DocumentKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DXW.DocumentTypeValues, DMW.DocumentKind>(openXmlElement.GetFirstChild<DXW.DocumentType>()?.Val?.Value, value, diffs, objName);
  }

  private static void SetDocumentType(DXW.Settings openXmlElement, DMW.DocumentKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DocumentType>();
    if (itemElement is not null)
    {
      if (value is not null)
        EnumValueConverter.UpdateOpenXmlElement<DXW.DocumentTypeValues, DMW.DocumentKind>(itemElement, (DMW.DocumentKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value is not null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXW.DocumentType, DXW.DocumentTypeValues, DMW.DocumentKind>((DMW.DocumentKind)value));
  }
  #endregion

  #region MailMerge conversion.
  private static DMW.MailMerge? GetMailMerge(DXW.Settings openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.MailMerge>();
    if (element is not null)
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
    if (itemElement is not null)
      itemElement.Remove();
    if (value is not null)
    {
      itemElement = DMXW.MailMergeConverter.CreateOpenXmlElement<DXW.MailMerge>(value);
      if (itemElement is not null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region RevisionView conversion.
  private static DMW.RevisionView? GetRevisionView(DXW.Settings openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.RevisionView>();
    if (element is not null)
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
    if (itemElement is not null)
      itemElement.Remove();
    if (value is not null)
    {
      itemElement = DMXW.RevisionViewConverter.CreateOpenXmlElement<DXW.RevisionView>(value);
      if (itemElement is not null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region TrackRevisions conversion.
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
  #endregion

  #region DoNotTrackMoves conversion.
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
  #endregion

  #region DoNotTrackFormatting conversion.
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
  #endregion

  #region DocumentProtection conversion.
  private static DMW.DocumentProtection? GetDocumentProtection(DXW.Settings openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.DocumentProtection>();
    if (element is not null)
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
    if (itemElement is not null)
      itemElement.Remove();
    if (value is not null)
    {
      itemElement = DMXW.DocumentProtectionConverter.CreateOpenXmlElement<DXW.DocumentProtection>(value);
      if (itemElement is not null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region AutoFormatOverride conversion.
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
  #endregion

  #region DefaultTabStop conversion.
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
    if (value is not null)
      SimpleValueConverter.SetValue<DXW.DefaultTabStop, Int16>(openXmlElement, (Int16)value);
    else
      SimpleValueConverter.SetNullValue<DXW.DefaultTabStop>(openXmlElement);
  }
  #endregion

  #region AutoHyphenation conversion.
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
  #endregion

  #region ConsecutiveHyphenLimit conversion.
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
    if (value is not null)
      SimpleValueConverter.SetValue<DXW.ConsecutiveHyphenLimit, UInt16>(openXmlElement, (UInt16)value);
    else
      SimpleValueConverter.SetNullValue<DXW.ConsecutiveHyphenLimit>(openXmlElement);
  }
  #endregion

  #region HyphenationZone conversion.
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
  #endregion

  #region DoNotHyphenateCaps conversion.
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
  #endregion

  #region ShowEnvelope conversion.
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
  #endregion

  #region SummaryLength conversion.
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
    if (value is not null)
      SimpleValueConverter.SetValue<DXW.SummaryLength, Int32>(openXmlElement, (Int32)value);
    else
      SimpleValueConverter.SetNullValue<DXW.SummaryLength>(openXmlElement);
  }
  #endregion

  #region ClickAndTypeStyle conversion.
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
  #endregion

  #region DefaultTableStyle conversion.
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
  #endregion

  #region EvenAndOddHeaders conversion.
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
  #endregion

  #region BookFoldReversePrinting conversion.
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
  #endregion

  #region BookFoldPrinting conversion.
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
  #endregion

  #region BookFoldPrintingSheets conversion.
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
    if (value is not null)
      SimpleValueConverter.SetValue<DXW.BookFoldPrintingSheets, Int16>(openXmlElement, (Int16)value);
    SimpleValueConverter.SetNullValue<DXW.BookFoldPrintingSheets>(openXmlElement);
  }
  #endregion

  #region DrawingGridHorizontalSpacing conversion.
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
  #endregion

  #region DrawingGridVerticalSpacing conversion.
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
  #endregion

  #region DisplayHorizontalDrawingGrid conversion.
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
    if (value is not null)
      SimpleValueConverter.SetValue<DXW.DisplayHorizontalDrawingGrid, Int32>(openXmlElement, (Int32)value);
    else
      SimpleValueConverter.SetNullValue<DXW.DisplayHorizontalDrawingGrid>(openXmlElement);
  }
  #endregion

  #region DisplayVerticalDrawingGrid conversion.
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
    if (value is not null)
      SimpleValueConverter.SetValue<DXW.DisplayVerticalDrawingGrid, Int32>(openXmlElement, (Int32)value);
    else
      SimpleValueConverter.SetNullValue<DXW.DisplayVerticalDrawingGrid>(openXmlElement);
  }
  #endregion

  #region DoNotUseMarginsForDrawingGridOrigin conversion.
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
  #endregion

  #region DrawingGridHorizontalOrigin conversion.
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
  #endregion

  #region DrawingGridVerticalOrigin conversion.
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
  #endregion

  #region DoNotShadeFormData conversion.
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
  #endregion

  #region NoPunctuationKerning conversion.
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
  #endregion

  #region CharacterSpacingControl conversion.
  private static DMW.CharacterSpacingKind? GetCharacterSpacingControl(DXW.Settings openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.CharacterSpacingValues, DMW.CharacterSpacingKind>(openXmlElement.GetFirstChild<DXW.CharacterSpacingControl>()?.Val?.Value);
  }

  private static bool CmpCharacterSpacingControl(DXW.Settings openXmlElement, DMW.CharacterSpacingKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DXW.CharacterSpacingValues, DMW.CharacterSpacingKind>(openXmlElement.GetFirstChild<DXW.CharacterSpacingControl>()?.Val?.Value, value, diffs, objName);
  }

  private static void SetCharacterSpacingControl(DXW.Settings openXmlElement, DMW.CharacterSpacingKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CharacterSpacingControl>();
    if (itemElement is not null)
    {
      if (value is not null)
        EnumValueConverter.UpdateOpenXmlElement<DXW.CharacterSpacingValues, DMW.CharacterSpacingKind>(itemElement, (DMW.CharacterSpacingKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value is not null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXW.CharacterSpacingControl, DXW.CharacterSpacingValues, DMW.CharacterSpacingKind>((DMW.CharacterSpacingKind)value));
  }
  #endregion

  #region PrintTwoOnOne conversion.
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
  #endregion

  #region StrictFirstAndLastChars conversion.
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
  #endregion

  #region NoLineBreaksAfterKinsoku conversion.
  private static DMW.NoLineBreaksAfterKinsoku? GetNoLineBreaksAfterKinsoku(DXW.Settings openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.NoLineBreaksAfterKinsoku>();
    if (element is not null)
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
    if (itemElement is not null)
      itemElement.Remove();
    if (value is not null)
    {
      itemElement = DMXW.NoLineBreaksAfterKinsokuConverter.CreateOpenXmlElement<DXW.NoLineBreaksAfterKinsoku>(value);
      if (itemElement is not null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region NoLineBreaksBeforeKinsoku conversion.
  private static DMW.NoLineBreaksBeforeKinsoku? GetNoLineBreaksBeforeKinsoku(DXW.Settings openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.NoLineBreaksBeforeKinsoku>();
    if (element is not null)
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
    if (itemElement is not null)
      itemElement.Remove();
    if (value is not null)
    {
      itemElement = DMXW.NoLineBreaksBeforeKinsokuConverter.CreateOpenXmlElement<DXW.NoLineBreaksBeforeKinsoku>(value);
      if (itemElement is not null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region SavePreviewPicture conversion.
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
  #endregion

  #region DoNotValidateAgainstSchema conversion.
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
  #endregion

  #region SaveInvalidXml conversion.
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
  #endregion

  #region IgnoreMixedContent conversion.
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
  #endregion

  #region AlwaysShowPlaceholderText conversion.
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
  #endregion

  #region DoNotDemarcateInvalidXml conversion.
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
  #endregion

  #region SaveXmlDataOnly conversion.
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
  #endregion

  #region UseXsltWhenSaving conversion.
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
  #endregion

  #region SaveThroughXslt conversion.
  private static DMW.SaveThroughXslt? GetSaveThroughXslt(DXW.Settings openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.SaveThroughXslt>();
    if (element is not null)
      return DMXW.SaveThroughXsltConverter.CreateModelElement(element, openXmlElement);
    return null;
  }

  private static bool CmpSaveThroughXslt(DXW.Settings openXmlElement, DMW.SaveThroughXslt? value, DiffList? diffs, string? objName)
  {
    return DMXW.SaveThroughXsltConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.SaveThroughXslt>(), value, diffs, objName);
  }

  private static void SetSaveThroughXslt(DXW.Settings openXmlElement, DMW.SaveThroughXslt? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SaveThroughXslt>();
    if (itemElement is not null)
      itemElement.Remove();
    if (value is not null)
    {
      itemElement = DMXW.SaveThroughXsltConverter.CreateOpenXmlElement(value, openXmlElement);
      if (itemElement is not null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region ShowXmlTags conversion.
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
  #endregion

  #region AlwaysMergeEmptyNamespace conversion.
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
  #endregion

  #region UpdateFieldsOnOpen conversion.
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
  #endregion

  #region HeaderShapeDefaults conversion.
  private static DMW.HeaderShapeDefaults? GetHeaderShapeDefaults(DXW.Settings openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.HeaderShapeDefaults>();
    if (element is not null)
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
    if (itemElement is not null)
      itemElement.Remove();
    if (value is not null)
    {
      itemElement = DMXW.HeaderShapeDefaultsConverter.CreateOpenXmlElement<DXW.HeaderShapeDefaults>(value);
      if (itemElement is not null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region FootnoteDocumentWideProperties conversion.
  private static DMW.FootnoteDocumentWideProperties? GetFootnoteDocumentWideProperties(DXW.Settings openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.FootnoteDocumentWideProperties>();
    if (element is not null)
      return DMXW.FootnoteDocumentWidePropertiesConverter.CreateModelElement(element, openXmlElement);
    return null;
  }

  private static bool CmpFootnoteDocumentWideProperties(DXW.Settings openXmlElement, DMW.FootnoteDocumentWideProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.FootnoteDocumentWidePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.FootnoteDocumentWideProperties>(), value, diffs, objName);
  }

  private static void SetFootnoteDocumentWideProperties(DXW.Settings openXmlElement, DMW.FootnoteDocumentWideProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.FootnoteDocumentWideProperties>();
    if (itemElement is not null)
      itemElement.Remove();
    if (value is not null)
    {
      itemElement = DMXW.FootnoteDocumentWidePropertiesConverter.CreateOpenXmlElement(value, openXmlElement);
      if (itemElement is not null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region EndnoteDocumentWideProperties conversion.
  private static DMW.EndnoteDocumentWideProperties? GetEndnoteDocumentWideProperties(DXW.Settings openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.EndnoteDocumentWideProperties>();
    if (element is not null)
    {
      return DMXW.EndnoteDocumentWidePropertiesConverter.CreateModelElement(element, openXmlElement);
    }
    return null;
  }

  private static bool CmpEndnoteDocumentWideProperties(DXW.Settings openXmlElement, DMW.EndnoteDocumentWideProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.EndnoteDocumentWidePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.EndnoteDocumentWideProperties>(), value, diffs, objName);
  }

  private static void SetEndnoteDocumentWideProperties(DXW.Settings openXmlElement, DMW.EndnoteDocumentWideProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.EndnoteDocumentWideProperties>();
    if (itemElement is not null)
      itemElement.Remove();
    if (value is not null)
    {
      itemElement = DMXW.EndnoteDocumentWidePropertiesConverter.CreateOpenXmlElement(value, openXmlElement);
      if (itemElement is not null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region Compatibility conversion.
  private static DMW.Compatibility? GetCompatibility(DXW.Settings openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Compatibility>();
    if (element is not null)
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
    if (itemElement is not null)
      itemElement.Remove();
    if (value is not null)
    {
      itemElement = DMXW.CompatibilityConverter.CreateOpenXmlElement<DXW.Compatibility>(value);
      if (itemElement is not null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region DocumentVariables conversion.
  private static DMW.DocumentVariables? GetDocumentVariables(DXW.Settings openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.DocumentVariables>();
    if (element is not null)
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
    if (itemElement is not null)
      itemElement.Remove();
    if (value is not null)
    {
      itemElement = DMXW.DocumentVariablesConverter.CreateOpenXmlElement<DXW.DocumentVariables>(value);
      if (itemElement is not null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region Rsids conversion.
  private static DMW.Rsids? GetRsids(DXW.Settings openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Rsids>();
    if (element is not null)
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
    if (itemElement is not null)
      itemElement.Remove();
    if (value is not null)
    {
      itemElement = DMXW.RsidsConverter.CreateOpenXmlElement<DXW.Rsids>(value);
      if (itemElement is not null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region MathProperties conversion.
  private static DMM.MathProperties? GetMathProperties(DXW.Settings openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.MathProperties>();
    if (element is not null)
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
    if (itemElement is not null)
      itemElement.Remove();
    if (value is not null)
    {
      itemElement = DMXM.MathPropertiesConverter.CreateOpenXmlElement<DXM.MathProperties>(value);
      if (itemElement is not null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region UICompatibleWith97To2003 conversion.
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
  #endregion

  #region AttachedSchemas conversion.
  private static AttachedSchemas? GetAttachedSchemas(DXW.Settings openXmlElement)
  {
    var collection = new AttachedSchemas();
    foreach (var item in openXmlElement.Elements<DXW.AttachedSchema>())
    {
      var newItem = StringValueConverter.GetValue(item);
      if (newItem is not null)
        collection.Add(new DMCX.Schema { Uri = new Uri(newItem) });
    }
    if (collection.Count > 0)
      return collection;
    return null;
  }

  private static bool CmpAttachedSchemas(DXW.Settings openXmlElement, AttachedSchemas? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXW.AttachedSchema>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value is not null)
    {
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().Name + ".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!StringValueConverter.CmpValue(origItem.Val?.Value, modelItem.Uri?.ToString(), diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }

  private static void SetAttachedSchemas(DXW.Settings openXmlElement, AttachedSchemas? value)
  {
    openXmlElement.RemoveAllChildren<DXW.AttachedSchema>();
    if (value is not null)
    {
      foreach (var item in value)
      {
        if (item.Uri is not null)
        {
          var newItem = StringValueConverter.CreateOpenXmlElement<DXW.AttachedSchema>(item.Uri.ToString() ?? "");
          if (newItem is not null)
            openXmlElement.AppendChild(newItem);
        }
      }
    }
  }
  #endregion

  #region ThemeFontLanguages conversion.
  private static DMW.Languages? GetThemeFontLanguages(DXW.Settings openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.ThemeFontLanguages>();
    if (element is not null)
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
    if (itemElement is not null)
      itemElement.Remove();
    if (value is not null)
    {
      itemElement = DMXW.LanguageTypeConverter.CreateOpenXmlElement<DXW.ThemeFontLanguages>(value);
      if (itemElement is not null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region ColorSchemeMapping conversion.
  private static DMW.ColorSchemeMapping? GetColorSchemeMapping(DXW.Settings openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.ColorSchemeMapping>();
    if (element is not null)
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
    if (itemElement is not null)
      itemElement.Remove();
    if (value is not null)
    {
      itemElement = DMXW.ColorSchemeMappingConverter.CreateOpenXmlElement<DXW.ColorSchemeMapping>(value);
      if (itemElement is not null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region DoNotIncludeSubdocsInStats conversion.
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
  #endregion

  #region DoNotAutoCompressPictures conversion.
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
  #endregion

  #region ForceUpgrade conversion.
  private static Boolean? GetForceUpgrade(DXW.Settings openXmlElement)
  {
    var element = openXmlElement.GetFirstChild<DXW.ForceUpgrade>();
    return (element is not null) ? true : null;
  }

  private static bool CmpForceUpgrade(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var element = openXmlElement.GetFirstChild<DXW.ForceUpgrade>();
    bool? val = (element is not null) ? true : null;
    if (val == value) return true;
    diffs?.Add(objName, "DXW.ForceUpgrade", val, value);
    return false;
  }

  private static void SetForceUpgrade(DXW.Settings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.ForceUpgrade>();
      if (itemElement is not null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.ForceUpgrade();
      openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region Captions conversion.
  private static DMW.Captions? GetCaptions(DXW.Settings openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Captions>();
    if (element is not null)
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
    if (itemElement is not null)
      itemElement.Remove();
    if (value is not null)
    {
      itemElement = DMXW.CaptionsConverter.CreateOpenXmlElement<DXW.Captions>(value);
      if (itemElement is not null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region ReadModeInkLockDown conversion.
  private static DMW.ReadModeInkLockDown? GetReadModeInkLockDown(DXW.Settings openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.ReadModeInkLockDown>();
    if (element is not null)
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
    if (itemElement is not null)
      itemElement.Remove();
    if (value is not null)
    {
      itemElement = DMXW.ReadModeInkLockDownConverter.CreateOpenXmlElement<DXW.ReadModeInkLockDown>(value);
      if (itemElement is not null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region SchemaLibrary conversion.
  private static DMCX.SchemaLibrary? GetSchemaLibrary(DXW.Settings openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXCXSR.SchemaLibrary>();
    if (element is not null)
      return DMXCX.SchemaLibraryConverter.CreateModelElement(element);
    return null;
  }

  private static bool CmpSchemaLibrary(DXW.Settings openXmlElement, DMCX.SchemaLibrary? value, DiffList? diffs, string? objName)
  {
    return DMXCX.SchemaLibraryConverter.CompareModelElement(openXmlElement.GetFirstChild<DXCXSR.SchemaLibrary>(), value, diffs, objName);
  }

  private static void SetSchemaLibrary(DXW.Settings openXmlElement, DMCX.SchemaLibrary? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXCXSR.SchemaLibrary>();
    if (itemElement is not null)
      itemElement.Remove();
    if (value is not null)
    {
      itemElement = DMXCX.SchemaLibraryConverter.CreateOpenXmlElement(value);
      if (itemElement is not null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region ShapeDefaults conversion.
  private static DMW.ShapeDefaults? GetShapeDefaults(DXW.Settings openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.ShapeDefaults>();
    if (element is not null)
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
    if (itemElement is not null)
      itemElement.Remove();
    if (value is not null)
    {
      itemElement = DMXW.ShapeDefaultsConverter.CreateOpenXmlElement<DXW.ShapeDefaults>(value);
      if (itemElement is not null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region DecimalSymbol conversion.
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
    if (itemElement is not null)
      itemElement.Remove();
    if (value is not null)
    {
      itemElement = new DXW.DecimalSymbol { Val = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region ListSeparator conversion.
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
    if (itemElement is not null)
      itemElement.Remove();
    if (value is not null)
    {
      itemElement = new DXW.ListSeparator { Val = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region DocumentId conversion.
  private static DM.HexInt? GetDocumentId(DXW.Settings openXmlElement)
  {
    return HexIntConverter.GetValue(openXmlElement?.GetFirstChild<DXO10W.DocumentId>()?.Val);
  }

  private static bool CmpDocumentId(DXW.Settings openXmlElement, DM.HexInt? value, DiffList? diffs, string? objName)
  {
    return HexIntConverter.CmpValue(openXmlElement?.GetFirstChild<DXO10W.DocumentId>()?.Val, value, diffs, objName, "DocumentId");
  }

  private static void SetDocumentId(DXW.Settings openXmlElement, DM.HexInt? value)
  {
    HexIntConverter.SetValue<DXO10W.DocumentId>(openXmlElement, value);
  }
  #endregion

  #region DiscardImageEditingData conversion.
  private static bool? GetDiscardImageEditingData(DXW.Settings openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXO10W.DiscardImageEditingData>()?.Val?.Value);
  }

  private static bool CmpDiscardImageEditingData(DXW.Settings openXmlElement, bool? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXO10W.DiscardImageEditingData>()?.Val?.Value, value, diffs, objName);
  }

  private static void SetDiscardImageEditingData(DXW.Settings openXmlElement, bool? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10W.DiscardImageEditingData>();
    if (itemElement is not null)
    {
      if (value is not null)
        BooleanValueConverter.UpdateOpenXmlElement(itemElement, (bool)value);
      else
        itemElement.Remove();
    }
    else
    if (value is not null)
      openXmlElement.AppendChild(BooleanValueConverter.CreateWordOpenXmlElement<DXO10W.DiscardImageEditingData>((bool)value));
  }
  #endregion

  #region DefaultImageDpi conversion.
  private static Int32? GetDefaultImageDpi(DXW.Settings openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXO10W.DefaultImageDpi>()?.Val);
  }

  private static bool CmpDefaultImageDpi(DXW.Settings openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXO10W.DefaultImageDpi>()?.Val, value, diffs, objName, "DefaultImageDpi");
  }

  private static void SetDefaultImageDpi(DXW.Settings openXmlElement, Int32? value)
  {
    if (value is not null)
      SimpleValueConverter.SetValue<DXO10W.DefaultImageDpi, Int32>(openXmlElement, (Int32)value);
    else
      SimpleValueConverter.SetNullValue<DXO10W.DefaultImageDpi>(openXmlElement);
  }
  #endregion

  #region ConflictMode conversion.
  private static bool? GetConflictMode(DXW.Settings openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXO10W.ConflictMode>()?.Val?.Value);
  }

  private static bool CmpConflictMode(DXW.Settings openXmlElement, bool? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXO10W.ConflictMode>()?.Val?.Value, value, diffs, objName);
  }

  private static void SetConflictMode(DXW.Settings openXmlElement, bool? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10W.ConflictMode>();
    if (itemElement is not null)
    {
      if (value is not null)
        BooleanValueConverter.UpdateOpenXmlElement<DXO10W.ConflictMode>(itemElement, (bool)value);
      else
        itemElement.Remove();
    }
    else
    if (value is not null)
      openXmlElement.AppendChild(BooleanValueConverter.CreateWordOpenXmlElement<DXO10W.ConflictMode>((bool)value));
  }
  #endregion

  #region ChartTrackingRefBased conversion.
  private static Boolean? GetChartTrackingRefBased(DXW.Settings openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXO13W.ChartTrackingRefBased>());
  }

  private static bool CmpChartTrackingRefBased(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXO13W.ChartTrackingRefBased>(), value, diffs, objName);
  }

  private static void SetChartTrackingRefBased(DXW.Settings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO13W.ChartTrackingRefBased>();
      if (itemElement is not null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO13W.ChartTrackingRefBased();
      openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region PersistentDocumentId conversion.
  private static Guid? GetPersistentDocumentId(DXW.Settings openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO13W.PersistentDocumentId>();
    if (itemElement?.Val?.Value is not null)
      return Guid.Parse(itemElement.Val.Value);
    return null;
  }

  private static bool CmpPersistentDocumentId(DXW.Settings openXmlElement, Guid? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO13W.PersistentDocumentId>();
    if (itemElement?.Val?.Value is not null)
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
    var itemElement = openXmlElement.GetFirstChild<DXO13W.PersistentDocumentId>();
    if (itemElement is not null)
      itemElement.Remove();
    if (value is not null)
    {
      itemElement = new DXO13W.PersistentDocumentId { Val = ((Guid)value).ToString("B") };
      openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region DocumentSettings model conversion.
  public static DocumentModel.DocumentSettings? CreateModelElement(DXW.Settings? openXmlElement)
  {
    if (openXmlElement is not null)
    {
      var model = new DocumentModel.DocumentSettings();
      model.WriteProtection = GetWriteProtection(openXmlElement);
      model.View = GetView(openXmlElement);
      model.Zoom = GetZoom(openXmlElement);
      model.RemovePersonalInformation = GetRemovePersonalInformation(openXmlElement);
      model.RemoveDateAndTime = GetRemoveDateAndTime(openXmlElement);
      model.DoNotDisplayPageBoundaries = GetDoNotDisplayPageBoundaries(openXmlElement);
      model.DisplayBackgroundShape = GetDisplayBackgroundShape(openXmlElement);
      model.PrintPostScriptOverText = GetPrintPostScriptOverText(openXmlElement);
      model.PrintFractionalCharacterWidth = GetPrintFractionalCharacterWidth(openXmlElement);
      model.PrintFormsData = GetPrintFormsData(openXmlElement);
      model.EmbedTrueTypeFonts = GetEmbedTrueTypeFonts(openXmlElement);
      model.EmbedSystemFonts = GetEmbedSystemFonts(openXmlElement);
      model.SaveSubsetFonts = GetSaveSubsetFonts(openXmlElement);
      model.SaveFormsData = GetSaveFormsData(openXmlElement);
      model.MirrorMargins = GetMirrorMargins(openXmlElement);
      model.AlignBorderAndEdges = GetAlignBorderAndEdges(openXmlElement);
      model.BordersDoNotSurroundHeader = GetBordersDoNotSurroundHeader(openXmlElement);
      model.BordersDoNotSurroundFooter = GetBordersDoNotSurroundFooter(openXmlElement);
      model.GutterAtTop = GetGutterAtTop(openXmlElement);
      model.HideSpellingErrors = GetHideSpellingErrors(openXmlElement);
      model.HideGrammaticalErrors = GetHideGrammaticalErrors(openXmlElement);
      model.ActiveWritingStyles = GetActiveWritingStyles(openXmlElement);
      model.ProofState = GetProofState(openXmlElement);
      model.FormsDesign = GetFormsDesign(openXmlElement);
      model.AttachedTemplate = GetAttachedTemplate(openXmlElement);
      model.LinkStyles = GetLinkStyles(openXmlElement);
      model.StylePaneFormatFilter = GetStylePaneFormatFilter(openXmlElement);
      model.StylePaneSortMethods = GetStylePaneSortMethods(openXmlElement);
      model.DocumentType = GetDocumentType(openXmlElement);
      model.MailMerge = GetMailMerge(openXmlElement);
      model.RevisionView = GetRevisionView(openXmlElement);
      model.TrackRevisions = GetTrackRevisions(openXmlElement);
      model.DoNotTrackMoves = GetDoNotTrackMoves(openXmlElement);
      model.DoNotTrackFormatting = GetDoNotTrackFormatting(openXmlElement);
      model.DocumentProtection = GetDocumentProtection(openXmlElement);
      model.AutoFormatOverride = GetAutoFormatOverride(openXmlElement);
      model.DefaultTabStop = GetDefaultTabStop(openXmlElement);
      model.AutoHyphenation = GetAutoHyphenation(openXmlElement);
      model.ConsecutiveHyphenLimit = GetConsecutiveHyphenLimit(openXmlElement);
      model.HyphenationZone = GetHyphenationZone(openXmlElement);
      model.DoNotHyphenateCaps = GetDoNotHyphenateCaps(openXmlElement);
      model.ShowEnvelope = GetShowEnvelope(openXmlElement);
      model.SummaryLength = GetSummaryLength(openXmlElement);
      model.ClickAndTypeStyle = GetClickAndTypeStyle(openXmlElement);
      model.DefaultTableStyle = GetDefaultTableStyle(openXmlElement);
      model.EvenAndOddHeaders = GetEvenAndOddHeaders(openXmlElement);
      model.BookFoldReversePrinting = GetBookFoldReversePrinting(openXmlElement);
      model.BookFoldPrinting = GetBookFoldPrinting(openXmlElement);
      model.BookFoldPrintingSheets = GetBookFoldPrintingSheets(openXmlElement);
      model.DrawingGridHorizontalSpacing = GetDrawingGridHorizontalSpacing(openXmlElement);
      model.DrawingGridVerticalSpacing = GetDrawingGridVerticalSpacing(openXmlElement);
      model.DisplayHorizontalDrawingGrid = GetDisplayHorizontalDrawingGrid(openXmlElement);
      model.DisplayVerticalDrawingGrid = GetDisplayVerticalDrawingGrid(openXmlElement);
      model.DoNotUseMarginsForDrawingGridOrigin = GetDoNotUseMarginsForDrawingGridOrigin(openXmlElement);
      model.DrawingGridHorizontalOrigin = GetDrawingGridHorizontalOrigin(openXmlElement);
      model.DrawingGridVerticalOrigin = GetDrawingGridVerticalOrigin(openXmlElement);
      model.DoNotShadeFormData = GetDoNotShadeFormData(openXmlElement);
      model.NoPunctuationKerning = GetNoPunctuationKerning(openXmlElement);
      model.CharacterSpacingControl = GetCharacterSpacingControl(openXmlElement);
      model.PrintTwoOnOne = GetPrintTwoOnOne(openXmlElement);
      model.StrictFirstAndLastChars = GetStrictFirstAndLastChars(openXmlElement);
      model.NoLineBreaksAfterKinsoku = GetNoLineBreaksAfterKinsoku(openXmlElement);
      model.NoLineBreaksBeforeKinsoku = GetNoLineBreaksBeforeKinsoku(openXmlElement);
      model.SavePreviewPicture = GetSavePreviewPicture(openXmlElement);
      model.DoNotValidateAgainstSchema = GetDoNotValidateAgainstSchema(openXmlElement);
      model.SaveInvalidXml = GetSaveInvalidXml(openXmlElement);
      model.IgnoreMixedContent = GetIgnoreMixedContent(openXmlElement);
      model.AlwaysShowPlaceholderText = GetAlwaysShowPlaceholderText(openXmlElement);
      model.DoNotDemarcateInvalidXml = GetDoNotDemarcateInvalidXml(openXmlElement);
      model.SaveXmlDataOnly = GetSaveXmlDataOnly(openXmlElement);
      model.UseXsltWhenSaving = GetUseXsltWhenSaving(openXmlElement);
      model.SaveThroughXslt = GetSaveThroughXslt(openXmlElement);
      model.ShowXmlTags = GetShowXmlTags(openXmlElement);
      model.AlwaysMergeEmptyNamespace = GetAlwaysMergeEmptyNamespace(openXmlElement);
      model.UpdateFieldsOnOpen = GetUpdateFieldsOnOpen(openXmlElement);
      model.HeaderShapeDefaults = GetHeaderShapeDefaults(openXmlElement);
      model.FootnoteDocumentWideProperties = GetFootnoteDocumentWideProperties(openXmlElement);
      model.EndnoteDocumentWideProperties = GetEndnoteDocumentWideProperties(openXmlElement);
      model.Compatibility = GetCompatibility(openXmlElement);
      model.DocumentVariables = GetDocumentVariables(openXmlElement);
      model.Rsids = GetRsids(openXmlElement);
      model.MathProperties = GetMathProperties(openXmlElement);
      model.UICompatibleWith97To2003 = GetUICompatibleWith97To2003(openXmlElement);
      model.AttachedSchemas = GetAttachedSchemas(openXmlElement);
      model.ThemeFontLanguages = GetThemeFontLanguages(openXmlElement);
      model.ColorSchemeMapping = GetColorSchemeMapping(openXmlElement);
      model.DoNotIncludeSubdocsInStats = GetDoNotIncludeSubdocsInStats(openXmlElement);
      model.DoNotAutoCompressPictures = GetDoNotAutoCompressPictures(openXmlElement);
      model.ForceUpgrade = GetForceUpgrade(openXmlElement);
      model.Captions = GetCaptions(openXmlElement);
      model.ReadModeInkLockDown = GetReadModeInkLockDown(openXmlElement);
      model.SchemaLibrary = GetSchemaLibrary(openXmlElement);
      model.ShapeDefaults = GetShapeDefaults(openXmlElement);
      model.DecimalSymbol = GetDecimalSymbol(openXmlElement);
      model.ListSeparator = GetListSeparator(openXmlElement);
      model.DocumentId = GetDocumentId(openXmlElement);
      model.DiscardImageEditingData = GetDiscardImageEditingData(openXmlElement);
      model.DefaultImageDpi = GetDefaultImageDpi(openXmlElement);
      model.ConflictMode = GetConflictMode(openXmlElement);
      model.ChartTrackingRefBased = GetChartTrackingRefBased(openXmlElement);
      model.PersistentDocumentId = GetPersistentDocumentId(openXmlElement);
      return model;
    }
    return null;
  }

  public static bool CompareModelElement(DXW.Settings? openXmlElement, DM.DocumentSettings? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement is not null && model is not null)
    {
      var ok = true;
      if (!CmpWriteProtection(openXmlElement, model.WriteProtection, diffs, objName))
        ok = false;
      if (!CmpView(openXmlElement, model.View, diffs, objName))
        ok = false;
      if (!CmpZoom(openXmlElement, model.Zoom, diffs, objName))
        ok = false;
      if (!CmpRemovePersonalInformation(openXmlElement, model.RemovePersonalInformation, diffs, objName))
        ok = false;
      if (!CmpRemoveDateAndTime(openXmlElement, model.RemoveDateAndTime, diffs, objName))
        ok = false;
      if (!CmpDoNotDisplayPageBoundaries(openXmlElement, model.DoNotDisplayPageBoundaries, diffs, objName))
        ok = false;
      if (!CmpDisplayBackgroundShape(openXmlElement, model.DisplayBackgroundShape, diffs, objName))
        ok = false;
      if (!CmpPrintPostScriptOverText(openXmlElement, model.PrintPostScriptOverText, diffs, objName))
        ok = false;
      if (!CmpPrintFractionalCharacterWidth(openXmlElement, model.PrintFractionalCharacterWidth, diffs, objName))
        ok = false;
      if (!CmpPrintFormsData(openXmlElement, model.PrintFormsData, diffs, objName))
        ok = false;
      if (!CmpEmbedTrueTypeFonts(openXmlElement, model.EmbedTrueTypeFonts, diffs, objName))
        ok = false;
      if (!CmpEmbedSystemFonts(openXmlElement, model.EmbedSystemFonts, diffs, objName))
        ok = false;
      if (!CmpSaveSubsetFonts(openXmlElement, model.SaveSubsetFonts, diffs, objName))
        ok = false;
      if (!CmpSaveFormsData(openXmlElement, model.SaveFormsData, diffs, objName))
        ok = false;
      if (!CmpMirrorMargins(openXmlElement, model.MirrorMargins, diffs, objName))
        ok = false;
      if (!CmpAlignBorderAndEdges(openXmlElement, model.AlignBorderAndEdges, diffs, objName))
        ok = false;
      if (!CmpBordersDoNotSurroundHeader(openXmlElement, model.BordersDoNotSurroundHeader, diffs, objName))
        ok = false;
      if (!CmpBordersDoNotSurroundFooter(openXmlElement, model.BordersDoNotSurroundFooter, diffs, objName))
        ok = false;
      if (!CmpGutterAtTop(openXmlElement, model.GutterAtTop, diffs, objName))
        ok = false;
      if (!CmpHideSpellingErrors(openXmlElement, model.HideSpellingErrors, diffs, objName))
        ok = false;
      if (!CmpHideGrammaticalErrors(openXmlElement, model.HideGrammaticalErrors, diffs, objName))
        ok = false;
      if (!CmpActiveWritingStyles(openXmlElement, model.ActiveWritingStyles, diffs, objName))
        ok = false;
      if (!CmpProofState(openXmlElement, model.ProofState, diffs, objName))
        ok = false;
      if (!CmpFormsDesign(openXmlElement, model.FormsDesign, diffs, objName))
        ok = false;
      if (!CmpAttachedTemplate(openXmlElement, model.AttachedTemplate, diffs, objName))
        ok = false;
      if (!CmpLinkStyles(openXmlElement, model.LinkStyles, diffs, objName))
        ok = false;
      if (!CmpStylePaneFormatFilter(openXmlElement, model.StylePaneFormatFilter, diffs, objName))
        ok = false;
      if (!CmpStylePaneSortMethods(openXmlElement, model.StylePaneSortMethods, diffs, objName))
        ok = false;
      if (!CmpDocumentType(openXmlElement, model.DocumentType, diffs, objName))
        ok = false;
      if (!CmpMailMerge(openXmlElement, model.MailMerge, diffs, objName))
        ok = false;
      if (!CmpRevisionView(openXmlElement, model.RevisionView, diffs, objName))
        ok = false;
      if (!CmpTrackRevisions(openXmlElement, model.TrackRevisions, diffs, objName))
        ok = false;
      if (!CmpDoNotTrackMoves(openXmlElement, model.DoNotTrackMoves, diffs, objName))
        ok = false;
      if (!CmpDoNotTrackFormatting(openXmlElement, model.DoNotTrackFormatting, diffs, objName))
        ok = false;
      if (!CmpDocumentProtection(openXmlElement, model.DocumentProtection, diffs, objName))
        ok = false;
      if (!CmpAutoFormatOverride(openXmlElement, model.AutoFormatOverride, diffs, objName))
        ok = false;
      if (!CmpDefaultTabStop(openXmlElement, model.DefaultTabStop, diffs, objName))
        ok = false;
      if (!CmpAutoHyphenation(openXmlElement, model.AutoHyphenation, diffs, objName))
        ok = false;
      if (!CmpConsecutiveHyphenLimit(openXmlElement, model.ConsecutiveHyphenLimit, diffs, objName))
        ok = false;
      if (!CmpHyphenationZone(openXmlElement, model.HyphenationZone, diffs, objName))
        ok = false;
      if (!CmpDoNotHyphenateCaps(openXmlElement, model.DoNotHyphenateCaps, diffs, objName))
        ok = false;
      if (!CmpShowEnvelope(openXmlElement, model.ShowEnvelope, diffs, objName))
        ok = false;
      if (!CmpSummaryLength(openXmlElement, model.SummaryLength, diffs, objName))
        ok = false;
      if (!CmpClickAndTypeStyle(openXmlElement, model.ClickAndTypeStyle, diffs, objName))
        ok = false;
      if (!CmpDefaultTableStyle(openXmlElement, model.DefaultTableStyle, diffs, objName))
        ok = false;
      if (!CmpEvenAndOddHeaders(openXmlElement, model.EvenAndOddHeaders, diffs, objName))
        ok = false;
      if (!CmpBookFoldReversePrinting(openXmlElement, model.BookFoldReversePrinting, diffs, objName))
        ok = false;
      if (!CmpBookFoldPrinting(openXmlElement, model.BookFoldPrinting, diffs, objName))
        ok = false;
      if (!CmpBookFoldPrintingSheets(openXmlElement, model.BookFoldPrintingSheets, diffs, objName))
        ok = false;
      if (!CmpDrawingGridHorizontalSpacing(openXmlElement, model.DrawingGridHorizontalSpacing, diffs, objName))
        ok = false;
      if (!CmpDrawingGridVerticalSpacing(openXmlElement, model.DrawingGridVerticalSpacing, diffs, objName))
        ok = false;
      if (!CmpDisplayHorizontalDrawingGrid(openXmlElement, model.DisplayHorizontalDrawingGrid, diffs, objName))
        ok = false;
      if (!CmpDisplayVerticalDrawingGrid(openXmlElement, model.DisplayVerticalDrawingGrid, diffs, objName))
        ok = false;
      if (!CmpDoNotUseMarginsForDrawingGridOrigin(openXmlElement, model.DoNotUseMarginsForDrawingGridOrigin, diffs, objName))
        ok = false;
      if (!CmpDrawingGridHorizontalOrigin(openXmlElement, model.DrawingGridHorizontalOrigin, diffs, objName))
        ok = false;
      if (!CmpDrawingGridVerticalOrigin(openXmlElement, model.DrawingGridVerticalOrigin, diffs, objName))
        ok = false;
      if (!CmpDoNotShadeFormData(openXmlElement, model.DoNotShadeFormData, diffs, objName))
        ok = false;
      if (!CmpNoPunctuationKerning(openXmlElement, model.NoPunctuationKerning, diffs, objName))
        ok = false;
      if (!CmpCharacterSpacingControl(openXmlElement, model.CharacterSpacingControl, diffs, objName))
        ok = false;
      if (!CmpPrintTwoOnOne(openXmlElement, model.PrintTwoOnOne, diffs, objName))
        ok = false;
      if (!CmpStrictFirstAndLastChars(openXmlElement, model.StrictFirstAndLastChars, diffs, objName))
        ok = false;
      if (!CmpNoLineBreaksAfterKinsoku(openXmlElement, model.NoLineBreaksAfterKinsoku, diffs, objName))
        ok = false;
      if (!CmpNoLineBreaksBeforeKinsoku(openXmlElement, model.NoLineBreaksBeforeKinsoku, diffs, objName))
        ok = false;
      if (!CmpSavePreviewPicture(openXmlElement, model.SavePreviewPicture, diffs, objName))
        ok = false;
      if (!CmpDoNotValidateAgainstSchema(openXmlElement, model.DoNotValidateAgainstSchema, diffs, objName))
        ok = false;
      if (!CmpSaveInvalidXml(openXmlElement, model.SaveInvalidXml, diffs, objName))
        ok = false;
      if (!CmpIgnoreMixedContent(openXmlElement, model.IgnoreMixedContent, diffs, objName))
        ok = false;
      if (!CmpAlwaysShowPlaceholderText(openXmlElement, model.AlwaysShowPlaceholderText, diffs, objName))
        ok = false;
      if (!CmpDoNotDemarcateInvalidXml(openXmlElement, model.DoNotDemarcateInvalidXml, diffs, objName))
        ok = false;
      if (!CmpSaveXmlDataOnly(openXmlElement, model.SaveXmlDataOnly, diffs, objName))
        ok = false;
      if (!CmpUseXsltWhenSaving(openXmlElement, model.UseXsltWhenSaving, diffs, objName))
        ok = false;
      if (!CmpSaveThroughXslt(openXmlElement, model.SaveThroughXslt, diffs, objName))
        ok = false;
      if (!CmpShowXmlTags(openXmlElement, model.ShowXmlTags, diffs, objName))
        ok = false;
      if (!CmpAlwaysMergeEmptyNamespace(openXmlElement, model.AlwaysMergeEmptyNamespace, diffs, objName))
        ok = false;
      if (!CmpUpdateFieldsOnOpen(openXmlElement, model.UpdateFieldsOnOpen, diffs, objName))
        ok = false;
      if (!CmpHeaderShapeDefaults(openXmlElement, model.HeaderShapeDefaults, diffs, objName))
        ok = false;
      if (!CmpFootnoteDocumentWideProperties(openXmlElement, model.FootnoteDocumentWideProperties, diffs, objName))
        ok = false;
      if (!CmpEndnoteDocumentWideProperties(openXmlElement, model.EndnoteDocumentWideProperties, diffs, objName))
        ok = false;
      if (!CmpCompatibility(openXmlElement, model.Compatibility, diffs, objName))
        ok = false;
      if (!CmpDocumentVariables(openXmlElement, model.DocumentVariables, diffs, objName))
        ok = false;
      if (!CmpRsids(openXmlElement, model.Rsids, diffs, objName))
        ok = false;
      if (!CmpMathProperties(openXmlElement, model.MathProperties, diffs, objName))
        ok = false;
      if (!CmpUICompatibleWith97To2003(openXmlElement, model.UICompatibleWith97To2003, diffs, objName))
        ok = false;
      if (!CmpAttachedSchemas(openXmlElement, model.AttachedSchemas, diffs, objName))
        ok = false;
      if (!CmpThemeFontLanguages(openXmlElement, model.ThemeFontLanguages, diffs, objName))
        ok = false;
      if (!CmpColorSchemeMapping(openXmlElement, model.ColorSchemeMapping, diffs, objName))
        ok = false;
      if (!CmpDoNotIncludeSubdocsInStats(openXmlElement, model.DoNotIncludeSubdocsInStats, diffs, objName))
        ok = false;
      if (!CmpDoNotAutoCompressPictures(openXmlElement, model.DoNotAutoCompressPictures, diffs, objName))
        ok = false;
      if (!CmpForceUpgrade(openXmlElement, model.ForceUpgrade, diffs, objName))
        ok = false;
      if (!CmpCaptions(openXmlElement, model.Captions, diffs, objName))
        ok = false;
      if (!CmpReadModeInkLockDown(openXmlElement, model.ReadModeInkLockDown, diffs, objName))
        ok = false;
      if (!CmpSchemaLibrary(openXmlElement, model.SchemaLibrary, diffs, objName))
        ok = false;
      if (!CmpShapeDefaults(openXmlElement, model.ShapeDefaults, diffs, objName))
        ok = false;
      if (!CmpDecimalSymbol(openXmlElement, model.DecimalSymbol, diffs, objName))
        ok = false;
      if (!CmpListSeparator(openXmlElement, model.ListSeparator, diffs, objName))
        ok = false;
      if (!CmpDocumentId(openXmlElement, model.DocumentId, diffs, objName))
        ok = false;
      if (!CmpDiscardImageEditingData(openXmlElement, model.DiscardImageEditingData, diffs, objName))
        ok = false;
      if (!CmpDefaultImageDpi(openXmlElement, model.DefaultImageDpi, diffs, objName))
        ok = false;
      if (!CmpConflictMode(openXmlElement, model.ConflictMode, diffs, objName))
        ok = false;
      if (!CmpChartTrackingRefBased(openXmlElement, model.ChartTrackingRefBased, diffs, objName))
        ok = false;
      if (!CmpPersistentDocumentId(openXmlElement, model.PersistentDocumentId, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  public static DXW.Settings CreateOpenXmlElement(DM.DocumentSettings model)
  {
    var openXmlElement = new DXW.Settings();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }

  public static void UpdateOpenXmlElement(DXW.Settings openXmlElement, DM.DocumentSettings model)
  {
    SetWriteProtection(openXmlElement, model.WriteProtection);
    SetView(openXmlElement, model.View);
    SetZoom(openXmlElement, model.Zoom);
    SetRemovePersonalInformation(openXmlElement, model.RemovePersonalInformation);
    SetRemoveDateAndTime(openXmlElement, model.RemoveDateAndTime);
    SetDoNotDisplayPageBoundaries(openXmlElement, model.DoNotDisplayPageBoundaries);
    SetDisplayBackgroundShape(openXmlElement, model.DisplayBackgroundShape);
    SetPrintPostScriptOverText(openXmlElement, model.PrintPostScriptOverText);
    SetPrintFractionalCharacterWidth(openXmlElement, model.PrintFractionalCharacterWidth);
    SetPrintFormsData(openXmlElement, model.PrintFormsData);
    SetEmbedTrueTypeFonts(openXmlElement, model.EmbedTrueTypeFonts);
    SetEmbedSystemFonts(openXmlElement, model.EmbedSystemFonts);
    SetSaveSubsetFonts(openXmlElement, model.SaveSubsetFonts);
    SetSaveFormsData(openXmlElement, model.SaveFormsData);
    SetMirrorMargins(openXmlElement, model.MirrorMargins);
    SetAlignBorderAndEdges(openXmlElement, model.AlignBorderAndEdges);
    SetBordersDoNotSurroundHeader(openXmlElement, model.BordersDoNotSurroundHeader);
    SetBordersDoNotSurroundFooter(openXmlElement, model.BordersDoNotSurroundFooter);
    SetGutterAtTop(openXmlElement, model.GutterAtTop);
    SetHideSpellingErrors(openXmlElement, model.HideSpellingErrors);
    SetHideGrammaticalErrors(openXmlElement, model.HideGrammaticalErrors);
    SetActiveWritingStyles(openXmlElement, model.ActiveWritingStyles);
    SetProofState(openXmlElement, model.ProofState);
    SetFormsDesign(openXmlElement, model.FormsDesign);
    SetAttachedTemplate(openXmlElement, model.AttachedTemplate);
    SetLinkStyles(openXmlElement, model.LinkStyles);
    SetStylePaneFormatFilter(openXmlElement, model.StylePaneFormatFilter);
    SetStylePaneSortMethods(openXmlElement, model.StylePaneSortMethods);
    SetDocumentType(openXmlElement, model.DocumentType);
    SetMailMerge(openXmlElement, model.MailMerge);
    SetRevisionView(openXmlElement, model.RevisionView);
    SetTrackRevisions(openXmlElement, model.TrackRevisions);
    SetDoNotTrackMoves(openXmlElement, model.DoNotTrackMoves);
    SetDoNotTrackFormatting(openXmlElement, model.DoNotTrackFormatting);
    SetDocumentProtection(openXmlElement, model.DocumentProtection);
    SetAutoFormatOverride(openXmlElement, model.AutoFormatOverride);
    SetDefaultTabStop(openXmlElement, model.DefaultTabStop);
    SetAutoHyphenation(openXmlElement, model.AutoHyphenation);
    SetConsecutiveHyphenLimit(openXmlElement, model.ConsecutiveHyphenLimit);
    SetHyphenationZone(openXmlElement, model.HyphenationZone);
    SetDoNotHyphenateCaps(openXmlElement, model.DoNotHyphenateCaps);
    SetShowEnvelope(openXmlElement, model.ShowEnvelope);
    SetSummaryLength(openXmlElement, model.SummaryLength);
    SetClickAndTypeStyle(openXmlElement, model.ClickAndTypeStyle);
    SetDefaultTableStyle(openXmlElement, model.DefaultTableStyle);
    SetEvenAndOddHeaders(openXmlElement, model.EvenAndOddHeaders);
    SetBookFoldReversePrinting(openXmlElement, model.BookFoldReversePrinting);
    SetBookFoldPrinting(openXmlElement, model.BookFoldPrinting);
    SetBookFoldPrintingSheets(openXmlElement, model.BookFoldPrintingSheets);
    SetDrawingGridHorizontalSpacing(openXmlElement, model.DrawingGridHorizontalSpacing);
    SetDrawingGridVerticalSpacing(openXmlElement, model.DrawingGridVerticalSpacing);
    SetDisplayHorizontalDrawingGrid(openXmlElement, model.DisplayHorizontalDrawingGrid);
    SetDisplayVerticalDrawingGrid(openXmlElement, model.DisplayVerticalDrawingGrid);
    SetDoNotUseMarginsForDrawingGridOrigin(openXmlElement, model.DoNotUseMarginsForDrawingGridOrigin);
    SetDrawingGridHorizontalOrigin(openXmlElement, model.DrawingGridHorizontalOrigin);
    SetDrawingGridVerticalOrigin(openXmlElement, model.DrawingGridVerticalOrigin);
    SetDoNotShadeFormData(openXmlElement, model.DoNotShadeFormData);
    SetNoPunctuationKerning(openXmlElement, model.NoPunctuationKerning);
    SetCharacterSpacingControl(openXmlElement, model.CharacterSpacingControl);
    SetPrintTwoOnOne(openXmlElement, model.PrintTwoOnOne);
    SetStrictFirstAndLastChars(openXmlElement, model.StrictFirstAndLastChars);
    SetNoLineBreaksAfterKinsoku(openXmlElement, model.NoLineBreaksAfterKinsoku);
    SetNoLineBreaksBeforeKinsoku(openXmlElement, model.NoLineBreaksBeforeKinsoku);
    SetSavePreviewPicture(openXmlElement, model.SavePreviewPicture);
    SetDoNotValidateAgainstSchema(openXmlElement, model.DoNotValidateAgainstSchema);
    SetSaveInvalidXml(openXmlElement, model.SaveInvalidXml);
    SetIgnoreMixedContent(openXmlElement, model.IgnoreMixedContent);
    SetAlwaysShowPlaceholderText(openXmlElement, model.AlwaysShowPlaceholderText);
    SetDoNotDemarcateInvalidXml(openXmlElement, model.DoNotDemarcateInvalidXml);
    SetSaveXmlDataOnly(openXmlElement, model.SaveXmlDataOnly);
    SetUseXsltWhenSaving(openXmlElement, model.UseXsltWhenSaving);
    SetSaveThroughXslt(openXmlElement, model.SaveThroughXslt);
    SetShowXmlTags(openXmlElement, model.ShowXmlTags);
    SetAlwaysMergeEmptyNamespace(openXmlElement, model.AlwaysMergeEmptyNamespace);
    SetUpdateFieldsOnOpen(openXmlElement, model.UpdateFieldsOnOpen);
    SetHeaderShapeDefaults(openXmlElement, model.HeaderShapeDefaults);
    SetFootnoteDocumentWideProperties(openXmlElement, model.FootnoteDocumentWideProperties);
    SetEndnoteDocumentWideProperties(openXmlElement, model.EndnoteDocumentWideProperties);
    SetCompatibility(openXmlElement, model.Compatibility);
    SetDocumentVariables(openXmlElement, model.DocumentVariables);
    SetRsids(openXmlElement, model.Rsids);
    SetMathProperties(openXmlElement, model.MathProperties);
    SetUICompatibleWith97To2003(openXmlElement, model.UICompatibleWith97To2003);
    SetAttachedSchemas(openXmlElement, model.AttachedSchemas);
    SetThemeFontLanguages(openXmlElement, model.ThemeFontLanguages);
    SetColorSchemeMapping(openXmlElement, model.ColorSchemeMapping);
    SetDoNotIncludeSubdocsInStats(openXmlElement, model.DoNotIncludeSubdocsInStats);
    SetDoNotAutoCompressPictures(openXmlElement, model.DoNotAutoCompressPictures);
    SetForceUpgrade(openXmlElement, model.ForceUpgrade);
    SetCaptions(openXmlElement, model.Captions);
    SetReadModeInkLockDown(openXmlElement, model.ReadModeInkLockDown);
    SetSchemaLibrary(openXmlElement, model.SchemaLibrary);
    SetShapeDefaults(openXmlElement, model.ShapeDefaults);
    SetDecimalSymbol(openXmlElement, model.DecimalSymbol);
    SetListSeparator(openXmlElement, model.ListSeparator);
    SetDocumentId(openXmlElement, model.DocumentId);
    SetDiscardImageEditingData(openXmlElement, model.DiscardImageEditingData);
    SetDefaultImageDpi(openXmlElement, model.DefaultImageDpi);
    SetConflictMode(openXmlElement, model.ConflictMode);
    SetChartTrackingRefBased(openXmlElement, model.ChartTrackingRefBased);
    SetPersistentDocumentId(openXmlElement, model.PersistentDocumentId);
  }
  #endregion

}

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Document Settings.
/// </summary>
public static class SettingsConverter
{
  /// <summary>
  /// Write Protection.
  /// </summary>
  private static DMW.WriteProtection? GetWriteProtection(DXW.Settings openXmlElement)
  {
    return DMXW.WriteProtectionConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.WriteProtection>());
  }
  
  private static bool CmpWriteProtection(DXW.Settings openXmlElement, DMW.WriteProtection? value, DiffList? diffs, string? objName)
  {
    return DMXW.WriteProtectionConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.WriteProtection>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.ViewValues, DMW.ViewKind>(openXmlElement.GetFirstChild<DXW.View>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetView(DXW.Settings openXmlElement, DMW.ViewKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.View>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.View, DocumentFormat.OpenXml.Wordprocessing.ViewValues, DMW.ViewKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Magnification Setting.
  /// </summary>
  private static DMW.Zoom? GetZoom(DXW.Settings openXmlElement)
  {
    return DMXW.ZoomConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.Zoom>());
  }
  
  private static bool CmpZoom(DXW.Settings openXmlElement, DMW.Zoom? value, DiffList? diffs, string? objName)
  {
    return DMXW.ZoomConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Zoom>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return openXmlElement.GetFirstChild<DXW.RemovePersonalInformation>()?.Val?.Value;
  }
  
  private static bool CmpRemovePersonalInformation(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.RemovePersonalInformation>()?.Val?.Value == value;
  }
  
  private static void SetRemovePersonalInformation(DXW.Settings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.RemovePersonalInformation>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.RemovePersonalInformation();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Remove Date and Time from Annotations.
  /// </summary>
  private static Boolean? GetRemoveDateAndTime(DXW.Settings openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.RemoveDateAndTime>()?.Val?.Value;
  }
  
  private static bool CmpRemoveDateAndTime(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.RemoveDateAndTime>()?.Val?.Value == value;
  }
  
  private static void SetRemoveDateAndTime(DXW.Settings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.RemoveDateAndTime>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.RemoveDateAndTime();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Do Not Display Visual Boundary For Header/Footer or Between Pages.
  /// </summary>
  private static Boolean? GetDoNotDisplayPageBoundaries(DXW.Settings openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.DoNotDisplayPageBoundaries>()?.Val?.Value;
  }
  
  private static bool CmpDoNotDisplayPageBoundaries(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.DoNotDisplayPageBoundaries>()?.Val?.Value == value;
  }
  
  private static void SetDoNotDisplayPageBoundaries(DXW.Settings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.DoNotDisplayPageBoundaries>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.DoNotDisplayPageBoundaries();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Display Background Objects When Displaying Document.
  /// </summary>
  private static Boolean? GetDisplayBackgroundShape(DXW.Settings openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.DisplayBackgroundShape>()?.Val?.Value;
  }
  
  private static bool CmpDisplayBackgroundShape(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.DisplayBackgroundShape>()?.Val?.Value == value;
  }
  
  private static void SetDisplayBackgroundShape(DXW.Settings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.DisplayBackgroundShape>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.DisplayBackgroundShape();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Print PostScript Codes With Document Text.
  /// </summary>
  private static Boolean? GetPrintPostScriptOverText(DXW.Settings openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.PrintPostScriptOverText>()?.Val?.Value;
  }
  
  private static bool CmpPrintPostScriptOverText(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.PrintPostScriptOverText>()?.Val?.Value == value;
  }
  
  private static void SetPrintPostScriptOverText(DXW.Settings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.PrintPostScriptOverText>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.PrintPostScriptOverText();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Print Fractional Character Widths.
  /// </summary>
  private static Boolean? GetPrintFractionalCharacterWidth(DXW.Settings openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.PrintFractionalCharacterWidth>()?.Val?.Value;
  }
  
  private static bool CmpPrintFractionalCharacterWidth(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.PrintFractionalCharacterWidth>()?.Val?.Value == value;
  }
  
  private static void SetPrintFractionalCharacterWidth(DXW.Settings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.PrintFractionalCharacterWidth>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.PrintFractionalCharacterWidth();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Only Print Form Field Content.
  /// </summary>
  private static Boolean? GetPrintFormsData(DXW.Settings openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.PrintFormsData>()?.Val?.Value;
  }
  
  private static bool CmpPrintFormsData(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.PrintFormsData>()?.Val?.Value == value;
  }
  
  private static void SetPrintFormsData(DXW.Settings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.PrintFormsData>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.PrintFormsData();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Embed TrueType Fonts.
  /// </summary>
  private static Boolean? GetEmbedTrueTypeFonts(DXW.Settings openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.EmbedTrueTypeFonts>()?.Val?.Value;
  }
  
  private static bool CmpEmbedTrueTypeFonts(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.EmbedTrueTypeFonts>()?.Val?.Value == value;
  }
  
  private static void SetEmbedTrueTypeFonts(DXW.Settings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.EmbedTrueTypeFonts>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.EmbedTrueTypeFonts();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Embed Common System Fonts.
  /// </summary>
  private static Boolean? GetEmbedSystemFonts(DXW.Settings openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.EmbedSystemFonts>()?.Val?.Value;
  }
  
  private static bool CmpEmbedSystemFonts(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.EmbedSystemFonts>()?.Val?.Value == value;
  }
  
  private static void SetEmbedSystemFonts(DXW.Settings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.EmbedSystemFonts>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.EmbedSystemFonts();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Subset Fonts When Embedding.
  /// </summary>
  private static Boolean? GetSaveSubsetFonts(DXW.Settings openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.SaveSubsetFonts>()?.Val?.Value;
  }
  
  private static bool CmpSaveSubsetFonts(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.SaveSubsetFonts>()?.Val?.Value == value;
  }
  
  private static void SetSaveSubsetFonts(DXW.Settings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.SaveSubsetFonts>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.SaveSubsetFonts();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Only Save Form Field Content.
  /// </summary>
  private static Boolean? GetSaveFormsData(DXW.Settings openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.SaveFormsData>()?.Val?.Value;
  }
  
  private static bool CmpSaveFormsData(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.SaveFormsData>()?.Val?.Value == value;
  }
  
  private static void SetSaveFormsData(DXW.Settings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.SaveFormsData>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.SaveFormsData();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Mirror Page Margins.
  /// </summary>
  private static Boolean? GetMirrorMargins(DXW.Settings openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.MirrorMargins>()?.Val?.Value;
  }
  
  private static bool CmpMirrorMargins(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.MirrorMargins>()?.Val?.Value == value;
  }
  
  private static void SetMirrorMargins(DXW.Settings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.MirrorMargins>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.MirrorMargins();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Align Paragraph and Table Borders with Page Border.
  /// </summary>
  private static Boolean? GetAlignBorderAndEdges(DXW.Settings openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.AlignBorderAndEdges>()?.Val?.Value;
  }
  
  private static bool CmpAlignBorderAndEdges(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.AlignBorderAndEdges>()?.Val?.Value == value;
  }
  
  private static void SetAlignBorderAndEdges(DXW.Settings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.AlignBorderAndEdges>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.AlignBorderAndEdges();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Page Border Excludes Header.
  /// </summary>
  private static Boolean? GetBordersDoNotSurroundHeader(DXW.Settings openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.BordersDoNotSurroundHeader>()?.Val?.Value;
  }
  
  private static bool CmpBordersDoNotSurroundHeader(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.BordersDoNotSurroundHeader>()?.Val?.Value == value;
  }
  
  private static void SetBordersDoNotSurroundHeader(DXW.Settings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.BordersDoNotSurroundHeader>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.BordersDoNotSurroundHeader();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Page Border Excludes Footer.
  /// </summary>
  private static Boolean? GetBordersDoNotSurroundFooter(DXW.Settings openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.BordersDoNotSurroundFooter>()?.Val?.Value;
  }
  
  private static bool CmpBordersDoNotSurroundFooter(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.BordersDoNotSurroundFooter>()?.Val?.Value == value;
  }
  
  private static void SetBordersDoNotSurroundFooter(DXW.Settings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.BordersDoNotSurroundFooter>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.BordersDoNotSurroundFooter();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Position Gutter At Top of Page.
  /// </summary>
  private static Boolean? GetGutterAtTop(DXW.Settings openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.GutterAtTop>()?.Val?.Value;
  }
  
  private static bool CmpGutterAtTop(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.GutterAtTop>()?.Val?.Value == value;
  }
  
  private static void SetGutterAtTop(DXW.Settings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.GutterAtTop>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.GutterAtTop();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Do Not Display Visual Indication of Spelling Errors.
  /// </summary>
  private static Boolean? GetHideSpellingErrors(DXW.Settings openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.HideSpellingErrors>()?.Val?.Value;
  }
  
  private static bool CmpHideSpellingErrors(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.HideSpellingErrors>()?.Val?.Value == value;
  }
  
  private static void SetHideSpellingErrors(DXW.Settings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.HideSpellingErrors>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.HideSpellingErrors();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Do Not Display Visual Indication of Grammatical Errors.
  /// </summary>
  private static Boolean? GetHideGrammaticalErrors(DXW.Settings openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.HideGrammaticalErrors>()?.Val?.Value;
  }
  
  private static bool CmpHideGrammaticalErrors(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.HideGrammaticalErrors>()?.Val?.Value == value;
  }
  
  private static void SetHideGrammaticalErrors(DXW.Settings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.HideGrammaticalErrors>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.HideGrammaticalErrors();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Collection<DMW.ActiveWritingStyle> GetActiveWritingStyles(DXW.Settings openXmlElement)
  {
    var collection = new Collection<DMW.ActiveWritingStyle>();
    foreach (var item in openXmlElement.Elements<DXW.ActiveWritingStyle>())
    {
      var newItem = DMXW.ActiveWritingStyleConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpActiveWritingStyles(DXW.Settings openXmlElement, Collection<DMW.ActiveWritingStyle>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXW.ActiveWritingStyle>();
      var origElementsCount = origElements.Count();
      var modelElementsCount = value.Count();
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
    if (openXmlElement == null && value == null) return true;
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
    return DMXW.ProofStateConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.ProofState>());
  }
  
  private static bool CmpProofState(DXW.Settings openXmlElement, DMW.ProofState? value, DiffList? diffs, string? objName)
  {
    return DMXW.ProofStateConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.ProofState>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return openXmlElement.GetFirstChild<DXW.FormsDesign>()?.Val?.Value;
  }
  
  private static bool CmpFormsDesign(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.FormsDesign>()?.Val?.Value == value;
  }
  
  private static void SetFormsDesign(DXW.Settings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.FormsDesign>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.FormsDesign();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.RelationshipType? GetAttachedTemplate(DXW.Settings openXmlElement)
  {
    return DMXW.RelationshipTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.AttachedTemplate>());
  }
  
  private static bool CmpAttachedTemplate(DXW.Settings openXmlElement, DMW.RelationshipType? value, DiffList? diffs, string? objName)
  {
    return DMXW.RelationshipTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.AttachedTemplate>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return openXmlElement.GetFirstChild<DXW.LinkStyles>()?.Val?.Value;
  }
  
  private static bool CmpLinkStyles(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.LinkStyles>()?.Val?.Value == value;
  }
  
  private static void SetLinkStyles(DXW.Settings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.LinkStyles>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.LinkStyles();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.StylePaneFormatFilter? GetStylePaneFormatFilter(DXW.Settings openXmlElement)
  {
    return DMXW.StylePaneFormatFilterConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.StylePaneFormatFilter>());
  }
  
  private static bool CmpStylePaneFormatFilter(DXW.Settings openXmlElement, DMW.StylePaneFormatFilter? value, DiffList? diffs, string? objName)
  {
    return DMXW.StylePaneFormatFilterConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.StylePaneFormatFilter>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
      return openXmlElement?.GetFirstChild<DXW.StylePaneSortMethods>()?.Val?.Value;
  }
  
  private static bool CmpStylePaneSortMethods(DXW.Settings openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXW.StylePaneSortMethods>()?.Val?.Value == value;
  }
  
  private static void SetStylePaneSortMethods(DXW.Settings openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.StylePaneSortMethods>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.StylePaneSortMethods { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.DocumentKind? GetDocumentType(DXW.Settings openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.DocumentTypeValues, DMW.DocumentKind>(openXmlElement.GetFirstChild<DXW.DocumentType>()?.Val?.Value);
  }
  
  private static bool CmpDocumentType(DXW.Settings openXmlElement, DMW.DocumentKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.DocumentTypeValues, DMW.DocumentKind>(openXmlElement.GetFirstChild<DXW.DocumentType>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDocumentType(DXW.Settings openXmlElement, DMW.DocumentKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DocumentType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.DocumentType, DocumentFormat.OpenXml.Wordprocessing.DocumentTypeValues, DMW.DocumentKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.MailMerge? GetMailMerge(DXW.Settings openXmlElement)
  {
    return DMXW.MailMergeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.MailMerge>());
  }
  
  private static bool CmpMailMerge(DXW.Settings openXmlElement, DMW.MailMerge? value, DiffList? diffs, string? objName)
  {
    return DMXW.MailMergeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.MailMerge>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXW.RevisionViewConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.RevisionView>());
  }
  
  private static bool CmpRevisionView(DXW.Settings openXmlElement, DMW.RevisionView? value, DiffList? diffs, string? objName)
  {
    return DMXW.RevisionViewConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.RevisionView>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return openXmlElement.GetFirstChild<DXW.TrackRevisions>()?.Val?.Value;
  }
  
  private static bool CmpTrackRevisions(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.TrackRevisions>()?.Val?.Value == value;
  }
  
  private static void SetTrackRevisions(DXW.Settings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.TrackRevisions>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.TrackRevisions();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetDoNotTrackMoves(DXW.Settings openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.DoNotTrackMoves>()?.Val?.Value;
  }
  
  private static bool CmpDoNotTrackMoves(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.DoNotTrackMoves>()?.Val?.Value == value;
  }
  
  private static void SetDoNotTrackMoves(DXW.Settings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.DoNotTrackMoves>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.DoNotTrackMoves();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetDoNotTrackFormatting(DXW.Settings openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.DoNotTrackFormatting>()?.Val?.Value;
  }
  
  private static bool CmpDoNotTrackFormatting(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.DoNotTrackFormatting>()?.Val?.Value == value;
  }
  
  private static void SetDoNotTrackFormatting(DXW.Settings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.DoNotTrackFormatting>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.DoNotTrackFormatting();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.DocumentProtection? GetDocumentProtection(DXW.Settings openXmlElement)
  {
    return DMXW.DocumentProtectionConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.DocumentProtection>());
  }
  
  private static bool CmpDocumentProtection(DXW.Settings openXmlElement, DMW.DocumentProtection? value, DiffList? diffs, string? objName)
  {
    return DMXW.DocumentProtectionConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.DocumentProtection>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return openXmlElement.GetFirstChild<DXW.AutoFormatOverride>()?.Val?.Value;
  }
  
  private static bool CmpAutoFormatOverride(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.AutoFormatOverride>()?.Val?.Value == value;
  }
  
  private static void SetAutoFormatOverride(DXW.Settings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.AutoFormatOverride>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.AutoFormatOverride();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int16? GetDefaultTabStop(DXW.Settings openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXW.DefaultTabStop>()?.Val?.Value;
  }
  
  private static bool CmpDefaultTabStop(DXW.Settings openXmlElement, Int16? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.DefaultTabStop>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXW.DefaultTabStop", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetDefaultTabStop(DXW.Settings openXmlElement, Int16? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DefaultTabStop>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.DefaultTabStop{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetAutoHyphenation(DXW.Settings openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.AutoHyphenation>()?.Val?.Value;
  }
  
  private static bool CmpAutoHyphenation(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.AutoHyphenation>()?.Val?.Value == value;
  }
  
  private static void SetAutoHyphenation(DXW.Settings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.AutoHyphenation>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.AutoHyphenation();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static UInt16? GetConsecutiveHyphenLimit(DXW.Settings openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXW.ConsecutiveHyphenLimit>()?.Val?.Value;
  }
  
  private static bool CmpConsecutiveHyphenLimit(DXW.Settings openXmlElement, UInt16? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.ConsecutiveHyphenLimit>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXW.ConsecutiveHyphenLimit", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetConsecutiveHyphenLimit(DXW.Settings openXmlElement, UInt16? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.ConsecutiveHyphenLimit>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.ConsecutiveHyphenLimit{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static String? GetHyphenationZone(DXW.Settings openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXW.HyphenationZone>()?.Val?.Value;
  }
  
  private static bool CmpHyphenationZone(DXW.Settings openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXW.HyphenationZone>()?.Val?.Value == value;
  }
  
  private static void SetHyphenationZone(DXW.Settings openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.HyphenationZone>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.HyphenationZone { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetDoNotHyphenateCaps(DXW.Settings openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.DoNotHyphenateCaps>()?.Val?.Value;
  }
  
  private static bool CmpDoNotHyphenateCaps(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.DoNotHyphenateCaps>()?.Val?.Value == value;
  }
  
  private static void SetDoNotHyphenateCaps(DXW.Settings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.DoNotHyphenateCaps>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.DoNotHyphenateCaps();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetShowEnvelope(DXW.Settings openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.ShowEnvelope>()?.Val?.Value;
  }
  
  private static bool CmpShowEnvelope(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.ShowEnvelope>()?.Val?.Value == value;
  }
  
  private static void SetShowEnvelope(DXW.Settings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.ShowEnvelope>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.ShowEnvelope();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetSummaryLength(DXW.Settings openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXW.SummaryLength>()?.Val?.Value;
  }
  
  private static bool CmpSummaryLength(DXW.Settings openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.SummaryLength>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXW.SummaryLength", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetSummaryLength(DXW.Settings openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SummaryLength>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.SummaryLength{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static String? GetClickAndTypeStyle(DXW.Settings openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXW.ClickAndTypeStyle>()?.Val?.Value;
  }
  
  private static bool CmpClickAndTypeStyle(DXW.Settings openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXW.ClickAndTypeStyle>()?.Val?.Value == value;
  }
  
  private static void SetClickAndTypeStyle(DXW.Settings openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.ClickAndTypeStyle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.ClickAndTypeStyle { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static String? GetDefaultTableStyle(DXW.Settings openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXW.DefaultTableStyle>()?.Val?.Value;
  }
  
  private static bool CmpDefaultTableStyle(DXW.Settings openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXW.DefaultTableStyle>()?.Val?.Value == value;
  }
  
  private static void SetDefaultTableStyle(DXW.Settings openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DefaultTableStyle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.DefaultTableStyle { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetEvenAndOddHeaders(DXW.Settings openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.EvenAndOddHeaders>()?.Val?.Value;
  }
  
  private static bool CmpEvenAndOddHeaders(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.EvenAndOddHeaders>()?.Val?.Value == value;
  }
  
  private static void SetEvenAndOddHeaders(DXW.Settings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.EvenAndOddHeaders>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.EvenAndOddHeaders();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetBookFoldReversePrinting(DXW.Settings openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.BookFoldReversePrinting>()?.Val?.Value;
  }
  
  private static bool CmpBookFoldReversePrinting(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.BookFoldReversePrinting>()?.Val?.Value == value;
  }
  
  private static void SetBookFoldReversePrinting(DXW.Settings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.BookFoldReversePrinting>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.BookFoldReversePrinting();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetBookFoldPrinting(DXW.Settings openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.BookFoldPrinting>()?.Val?.Value;
  }
  
  private static bool CmpBookFoldPrinting(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.BookFoldPrinting>()?.Val?.Value == value;
  }
  
  private static void SetBookFoldPrinting(DXW.Settings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.BookFoldPrinting>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.BookFoldPrinting();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int16? GetBookFoldPrintingSheets(DXW.Settings openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXW.BookFoldPrintingSheets>()?.Val?.Value;
  }
  
  private static bool CmpBookFoldPrintingSheets(DXW.Settings openXmlElement, Int16? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.BookFoldPrintingSheets>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXW.BookFoldPrintingSheets", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetBookFoldPrintingSheets(DXW.Settings openXmlElement, Int16? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.BookFoldPrintingSheets>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.BookFoldPrintingSheets{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static String? GetDrawingGridHorizontalSpacing(DXW.Settings openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXW.DrawingGridHorizontalSpacing>()?.Val?.Value;
  }
  
  private static bool CmpDrawingGridHorizontalSpacing(DXW.Settings openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXW.DrawingGridHorizontalSpacing>()?.Val?.Value == value;
  }
  
  private static void SetDrawingGridHorizontalSpacing(DXW.Settings openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DrawingGridHorizontalSpacing>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.DrawingGridHorizontalSpacing { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static String? GetDrawingGridVerticalSpacing(DXW.Settings openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXW.DrawingGridVerticalSpacing>()?.Val?.Value;
  }
  
  private static bool CmpDrawingGridVerticalSpacing(DXW.Settings openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXW.DrawingGridVerticalSpacing>()?.Val?.Value == value;
  }
  
  private static void SetDrawingGridVerticalSpacing(DXW.Settings openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DrawingGridVerticalSpacing>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.DrawingGridVerticalSpacing { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetDisplayHorizontalDrawingGrid(DXW.Settings openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXW.DisplayHorizontalDrawingGrid>()?.Val?.Value;
  }
  
  private static bool CmpDisplayHorizontalDrawingGrid(DXW.Settings openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.DisplayHorizontalDrawingGrid>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXW.DisplayHorizontalDrawingGrid", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetDisplayHorizontalDrawingGrid(DXW.Settings openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DisplayHorizontalDrawingGrid>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.DisplayHorizontalDrawingGrid{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetDisplayVerticalDrawingGrid(DXW.Settings openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXW.DisplayVerticalDrawingGrid>()?.Val?.Value;
  }
  
  private static bool CmpDisplayVerticalDrawingGrid(DXW.Settings openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.DisplayVerticalDrawingGrid>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXW.DisplayVerticalDrawingGrid", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetDisplayVerticalDrawingGrid(DXW.Settings openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DisplayVerticalDrawingGrid>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.DisplayVerticalDrawingGrid{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetDoNotUseMarginsForDrawingGridOrigin(DXW.Settings openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.DoNotUseMarginsForDrawingGridOrigin>()?.Val?.Value;
  }
  
  private static bool CmpDoNotUseMarginsForDrawingGridOrigin(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.DoNotUseMarginsForDrawingGridOrigin>()?.Val?.Value == value;
  }
  
  private static void SetDoNotUseMarginsForDrawingGridOrigin(DXW.Settings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.DoNotUseMarginsForDrawingGridOrigin>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.DoNotUseMarginsForDrawingGridOrigin();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static String? GetDrawingGridHorizontalOrigin(DXW.Settings openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXW.DrawingGridHorizontalOrigin>()?.Val?.Value;
  }
  
  private static bool CmpDrawingGridHorizontalOrigin(DXW.Settings openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXW.DrawingGridHorizontalOrigin>()?.Val?.Value == value;
  }
  
  private static void SetDrawingGridHorizontalOrigin(DXW.Settings openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DrawingGridHorizontalOrigin>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.DrawingGridHorizontalOrigin { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static String? GetDrawingGridVerticalOrigin(DXW.Settings openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXW.DrawingGridVerticalOrigin>()?.Val?.Value;
  }
  
  private static bool CmpDrawingGridVerticalOrigin(DXW.Settings openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXW.DrawingGridVerticalOrigin>()?.Val?.Value == value;
  }
  
  private static void SetDrawingGridVerticalOrigin(DXW.Settings openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DrawingGridVerticalOrigin>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.DrawingGridVerticalOrigin { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetDoNotShadeFormData(DXW.Settings openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.DoNotShadeFormData>()?.Val?.Value;
  }
  
  private static bool CmpDoNotShadeFormData(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.DoNotShadeFormData>()?.Val?.Value == value;
  }
  
  private static void SetDoNotShadeFormData(DXW.Settings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.DoNotShadeFormData>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.DoNotShadeFormData();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetNoPunctuationKerning(DXW.Settings openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.NoPunctuationKerning>()?.Val?.Value;
  }
  
  private static bool CmpNoPunctuationKerning(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.NoPunctuationKerning>()?.Val?.Value == value;
  }
  
  private static void SetNoPunctuationKerning(DXW.Settings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.NoPunctuationKerning>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.NoPunctuationKerning();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.CharacterSpacingKind? GetCharacterSpacingControl(DXW.Settings openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.CharacterSpacingValues, DMW.CharacterSpacingKind>(openXmlElement.GetFirstChild<DXW.CharacterSpacingControl>()?.Val?.Value);
  }
  
  private static bool CmpCharacterSpacingControl(DXW.Settings openXmlElement, DMW.CharacterSpacingKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.CharacterSpacingValues, DMW.CharacterSpacingKind>(openXmlElement.GetFirstChild<DXW.CharacterSpacingControl>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCharacterSpacingControl(DXW.Settings openXmlElement, DMW.CharacterSpacingKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CharacterSpacingControl>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.CharacterSpacingControl, DocumentFormat.OpenXml.Wordprocessing.CharacterSpacingValues, DMW.CharacterSpacingKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetPrintTwoOnOne(DXW.Settings openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.PrintTwoOnOne>()?.Val?.Value;
  }
  
  private static bool CmpPrintTwoOnOne(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.PrintTwoOnOne>()?.Val?.Value == value;
  }
  
  private static void SetPrintTwoOnOne(DXW.Settings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.PrintTwoOnOne>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.PrintTwoOnOne();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetStrictFirstAndLastChars(DXW.Settings openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.StrictFirstAndLastChars>()?.Val?.Value;
  }
  
  private static bool CmpStrictFirstAndLastChars(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.StrictFirstAndLastChars>()?.Val?.Value == value;
  }
  
  private static void SetStrictFirstAndLastChars(DXW.Settings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.StrictFirstAndLastChars>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.StrictFirstAndLastChars();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.NoLineBreaksAfterKinsoku? GetNoLineBreaksAfterKinsoku(DXW.Settings openXmlElement)
  {
    return DMXW.NoLineBreaksAfterKinsokuConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.NoLineBreaksAfterKinsoku>());
  }
  
  private static bool CmpNoLineBreaksAfterKinsoku(DXW.Settings openXmlElement, DMW.NoLineBreaksAfterKinsoku? value, DiffList? diffs, string? objName)
  {
    return DMXW.NoLineBreaksAfterKinsokuConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.NoLineBreaksAfterKinsoku>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXW.NoLineBreaksBeforeKinsokuConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.NoLineBreaksBeforeKinsoku>());
  }
  
  private static bool CmpNoLineBreaksBeforeKinsoku(DXW.Settings openXmlElement, DMW.NoLineBreaksBeforeKinsoku? value, DiffList? diffs, string? objName)
  {
    return DMXW.NoLineBreaksBeforeKinsokuConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.NoLineBreaksBeforeKinsoku>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return openXmlElement.GetFirstChild<DXW.SavePreviewPicture>()?.Val?.Value;
  }
  
  private static bool CmpSavePreviewPicture(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.SavePreviewPicture>()?.Val?.Value == value;
  }
  
  private static void SetSavePreviewPicture(DXW.Settings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.SavePreviewPicture>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.SavePreviewPicture();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetDoNotValidateAgainstSchema(DXW.Settings openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.DoNotValidateAgainstSchema>()?.Val?.Value;
  }
  
  private static bool CmpDoNotValidateAgainstSchema(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.DoNotValidateAgainstSchema>()?.Val?.Value == value;
  }
  
  private static void SetDoNotValidateAgainstSchema(DXW.Settings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.DoNotValidateAgainstSchema>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.DoNotValidateAgainstSchema();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetSaveInvalidXml(DXW.Settings openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.SaveInvalidXml>()?.Val?.Value;
  }
  
  private static bool CmpSaveInvalidXml(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.SaveInvalidXml>()?.Val?.Value == value;
  }
  
  private static void SetSaveInvalidXml(DXW.Settings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.SaveInvalidXml>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.SaveInvalidXml();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetIgnoreMixedContent(DXW.Settings openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.IgnoreMixedContent>()?.Val?.Value;
  }
  
  private static bool CmpIgnoreMixedContent(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.IgnoreMixedContent>()?.Val?.Value == value;
  }
  
  private static void SetIgnoreMixedContent(DXW.Settings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.IgnoreMixedContent>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.IgnoreMixedContent();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetAlwaysShowPlaceholderText(DXW.Settings openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.AlwaysShowPlaceholderText>()?.Val?.Value;
  }
  
  private static bool CmpAlwaysShowPlaceholderText(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.AlwaysShowPlaceholderText>()?.Val?.Value == value;
  }
  
  private static void SetAlwaysShowPlaceholderText(DXW.Settings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.AlwaysShowPlaceholderText>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.AlwaysShowPlaceholderText();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetDoNotDemarcateInvalidXml(DXW.Settings openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.DoNotDemarcateInvalidXml>()?.Val?.Value;
  }
  
  private static bool CmpDoNotDemarcateInvalidXml(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.DoNotDemarcateInvalidXml>()?.Val?.Value == value;
  }
  
  private static void SetDoNotDemarcateInvalidXml(DXW.Settings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.DoNotDemarcateInvalidXml>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.DoNotDemarcateInvalidXml();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetSaveXmlDataOnly(DXW.Settings openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.SaveXmlDataOnly>()?.Val?.Value;
  }
  
  private static bool CmpSaveXmlDataOnly(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.SaveXmlDataOnly>()?.Val?.Value == value;
  }
  
  private static void SetSaveXmlDataOnly(DXW.Settings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.SaveXmlDataOnly>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.SaveXmlDataOnly();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetUseXsltWhenSaving(DXW.Settings openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.UseXsltWhenSaving>()?.Val?.Value;
  }
  
  private static bool CmpUseXsltWhenSaving(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.UseXsltWhenSaving>()?.Val?.Value == value;
  }
  
  private static void SetUseXsltWhenSaving(DXW.Settings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.UseXsltWhenSaving>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.UseXsltWhenSaving();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.SaveThroughXslt? GetSaveThroughXslt(DXW.Settings openXmlElement)
  {
    return DMXW.SaveThroughXsltConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.SaveThroughXslt>());
  }
  
  private static bool CmpSaveThroughXslt(DXW.Settings openXmlElement, DMW.SaveThroughXslt? value, DiffList? diffs, string? objName)
  {
    return DMXW.SaveThroughXsltConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.SaveThroughXslt>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return openXmlElement.GetFirstChild<DXW.ShowXmlTags>()?.Val?.Value;
  }
  
  private static bool CmpShowXmlTags(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.ShowXmlTags>()?.Val?.Value == value;
  }
  
  private static void SetShowXmlTags(DXW.Settings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.ShowXmlTags>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.ShowXmlTags();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetAlwaysMergeEmptyNamespace(DXW.Settings openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.AlwaysMergeEmptyNamespace>()?.Val?.Value;
  }
  
  private static bool CmpAlwaysMergeEmptyNamespace(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.AlwaysMergeEmptyNamespace>()?.Val?.Value == value;
  }
  
  private static void SetAlwaysMergeEmptyNamespace(DXW.Settings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.AlwaysMergeEmptyNamespace>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.AlwaysMergeEmptyNamespace();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetUpdateFieldsOnOpen(DXW.Settings openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.UpdateFieldsOnOpen>()?.Val?.Value;
  }
  
  private static bool CmpUpdateFieldsOnOpen(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.UpdateFieldsOnOpen>()?.Val?.Value == value;
  }
  
  private static void SetUpdateFieldsOnOpen(DXW.Settings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.UpdateFieldsOnOpen>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.UpdateFieldsOnOpen();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.HeaderShapeDefaults? GetHeaderShapeDefaults(DXW.Settings openXmlElement)
  {
    return DMXW.HeaderShapeDefaultsConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.HeaderShapeDefaults>());
  }
  
  private static bool CmpHeaderShapeDefaults(DXW.Settings openXmlElement, DMW.HeaderShapeDefaults? value, DiffList? diffs, string? objName)
  {
    return DMXW.HeaderShapeDefaultsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.HeaderShapeDefaults>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXW.FootnoteDocumentWidePropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.FootnoteDocumentWideProperties>());
  }
  
  private static bool CmpFootnoteDocumentWideProperties(DXW.Settings openXmlElement, DMW.FootnoteDocumentWideProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.FootnoteDocumentWidePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.FootnoteDocumentWideProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXW.EndnoteDocumentWidePropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.EndnoteDocumentWideProperties>());
  }
  
  private static bool CmpEndnoteDocumentWideProperties(DXW.Settings openXmlElement, DMW.EndnoteDocumentWideProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.EndnoteDocumentWidePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.EndnoteDocumentWideProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXW.CompatibilityConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.Compatibility>());
  }
  
  private static bool CmpCompatibility(DXW.Settings openXmlElement, DMW.Compatibility? value, DiffList? diffs, string? objName)
  {
    return DMXW.CompatibilityConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Compatibility>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXW.DocumentVariablesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.DocumentVariables>());
  }
  
  private static bool CmpDocumentVariables(DXW.Settings openXmlElement, DMW.DocumentVariables? value, DiffList? diffs, string? objName)
  {
    return DMXW.DocumentVariablesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.DocumentVariables>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXW.RsidsConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.Rsids>());
  }
  
  private static bool CmpRsids(DXW.Settings openXmlElement, DMW.Rsids? value, DiffList? diffs, string? objName)
  {
    return DMXW.RsidsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Rsids>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  private static DMMath.MathProperties? GetMathProperties(DXW.Settings openXmlElement)
  {
    return DMXMath.MathPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.MathProperties>());
  }
  
  private static bool CmpMathProperties(DXW.Settings openXmlElement, DMMath.MathProperties? value, DiffList? diffs, string? objName)
  {
    return DMXMath.MathPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.MathProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMathProperties(DXW.Settings openXmlElement, DMMath.MathProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.MathProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.MathPropertiesConverter.CreateOpenXmlElement<DXMath.MathProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetUICompatibleWith97To2003(DXW.Settings openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.UICompatibleWith97To2003>()?.Val?.Value;
  }
  
  private static bool CmpUICompatibleWith97To2003(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.UICompatibleWith97To2003>()?.Val?.Value == value;
  }
  
  private static void SetUICompatibleWith97To2003(DXW.Settings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.UICompatibleWith97To2003>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.UICompatibleWith97To2003();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Collection<String> GetAttachedSchemas(DXW.Settings openXmlElement)
  {
    var collection = new Collection<String>();
    foreach (var item in openXmlElement.Elements<DXW.AttachedSchema>())
    {
      var newItem = StringValueConverter.GetValue(item);
      if (newItem != null)
        collection.Add((string)newItem);
    }
    return collection;
  }
  
  private static bool CmpAttachedSchemas(DXW.Settings openXmlElement, Collection<String>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXW.AttachedSchema>();
      var origElementsCount = origElements.Count();
      var modelElementsCount = value.Count();
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
    if (openXmlElement == null && value == null) return true;
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
  
  private static DMW.LanguageType? GetThemeFontLanguages(DXW.Settings openXmlElement)
  {
    return DMXW.LanguageTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.ThemeFontLanguages>());
  }
  
  private static bool CmpThemeFontLanguages(DXW.Settings openXmlElement, DMW.LanguageType? value, DiffList? diffs, string? objName)
  {
    return DMXW.LanguageTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.ThemeFontLanguages>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetThemeFontLanguages(DXW.Settings openXmlElement, DMW.LanguageType? value)
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
    return DMXW.ColorSchemeMappingConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.ColorSchemeMapping>());
  }
  
  private static bool CmpColorSchemeMapping(DXW.Settings openXmlElement, DMW.ColorSchemeMapping? value, DiffList? diffs, string? objName)
  {
    return DMXW.ColorSchemeMappingConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.ColorSchemeMapping>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return openXmlElement.GetFirstChild<DXW.DoNotIncludeSubdocsInStats>()?.Val?.Value;
  }
  
  private static bool CmpDoNotIncludeSubdocsInStats(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.DoNotIncludeSubdocsInStats>()?.Val?.Value == value;
  }
  
  private static void SetDoNotIncludeSubdocsInStats(DXW.Settings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.DoNotIncludeSubdocsInStats>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.DoNotIncludeSubdocsInStats();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetDoNotAutoCompressPictures(DXW.Settings openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.DoNotAutoCompressPictures>()?.Val?.Value;
  }
  
  private static bool CmpDoNotAutoCompressPictures(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.DoNotAutoCompressPictures>()?.Val?.Value == value;
  }
  
  private static void SetDoNotAutoCompressPictures(DXW.Settings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.DoNotAutoCompressPictures>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.DoNotAutoCompressPictures();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetForceUpgrade(DXW.Settings openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.ForceUpgrade>() != null;
  }
  
  private static bool CmpForceUpgrade(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.ForceUpgrade>() != null == value;
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
    return DMXW.CaptionsConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.Captions>());
  }
  
  private static bool CmpCaptions(DXW.Settings openXmlElement, DMW.Captions? value, DiffList? diffs, string? objName)
  {
    return DMXW.CaptionsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Captions>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXW.ReadModeInkLockDownConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.ReadModeInkLockDown>());
  }
  
  private static bool CmpReadModeInkLockDown(DXW.Settings openXmlElement, DMW.ReadModeInkLockDown? value, DiffList? diffs, string? objName)
  {
    return DMXW.ReadModeInkLockDownConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.ReadModeInkLockDown>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXCustXml.SchemaLibraryConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXCustXmlSchRefs.SchemaLibrary>());
  }
  
  private static bool CmpSchemaLibrary(DXW.Settings openXmlElement, DMCustXml.SchemaLibrary? value, DiffList? diffs, string? objName)
  {
    return DMXCustXml.SchemaLibraryConverter.CompareModelElement(openXmlElement.GetFirstChild<DXCustXmlSchRefs.SchemaLibrary>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXW.ShapeDefaultsConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.ShapeDefaults>());
  }
  
  private static bool CmpShapeDefaults(DXW.Settings openXmlElement, DMW.ShapeDefaults? value, DiffList? diffs, string? objName)
  {
    return DMXW.ShapeDefaultsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.ShapeDefaults>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  private static Byte[]? GetDocumentId(DXW.Settings openXmlElement)
  {
    return DMX.HexBinaryConverter.GetValue(openXmlElement?.GetFirstChild<DXO2010W.DocumentId>());
  }
  
  private static bool CmpDocumentId(DXW.Settings openXmlElement, Byte[]? value, DiffList? diffs, string? objName)
  {
    return DMX.HexBinaryConverter.CmpValue(openXmlElement.GetFirstChild<DXO2010W.DocumentId>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDocumentId(DXW.Settings openXmlElement, Byte[]? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.DocumentId>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.HexBinaryConverter.CreateOpenXmlElement<DXO2010W.DocumentId>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.OnOffKind? GetDiscardImageEditingData(DXW.Settings openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.OnOffValues, DMW.OnOffKind>(openXmlElement.GetFirstChild<DXO2010W.DiscardImageEditingData>()?.Val?.Value);
  }
  
  private static bool CmpDiscardImageEditingData(DXW.Settings openXmlElement, DMW.OnOffKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.Word.OnOffValues, DMW.OnOffKind>(openXmlElement.GetFirstChild<DXO2010W.DiscardImageEditingData>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDiscardImageEditingData(DXW.Settings openXmlElement, DMW.OnOffKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.DiscardImageEditingData>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXO2010W.DiscardImageEditingData, DocumentFormat.OpenXml.Office2010.Word.OnOffValues, DMW.OnOffKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetDefaultImageDpi(DXW.Settings openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXO2010W.DefaultImageDpi>()?.Val?.Value;
  }
  
  private static bool CmpDefaultImageDpi(DXW.Settings openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010W.DefaultImageDpi>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXO2010W.DefaultImageDpi", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetDefaultImageDpi(DXW.Settings openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.DefaultImageDpi>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXO2010W.DefaultImageDpi{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.OnOffKind? GetConflictMode(DXW.Settings openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.OnOffValues, DMW.OnOffKind>(openXmlElement.GetFirstChild<DXO2010W.ConflictMode>()?.Val?.Value);
  }
  
  private static bool CmpConflictMode(DXW.Settings openXmlElement, DMW.OnOffKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.Word.OnOffValues, DMW.OnOffKind>(openXmlElement.GetFirstChild<DXO2010W.ConflictMode>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetConflictMode(DXW.Settings openXmlElement, DMW.OnOffKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.ConflictMode>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXO2010W.ConflictMode, DocumentFormat.OpenXml.Office2010.Word.OnOffValues, DMW.OnOffKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetChartTrackingRefBased(DXW.Settings openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXO2013W.ChartTrackingRefBased>() != null;
  }
  
  private static bool CmpChartTrackingRefBased(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXO2013W.ChartTrackingRefBased>() != null == value;
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
  
  private static String? GetPersistentDocumentId(DXW.Settings openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXO2013W.PersistentDocumentId>()?.Val?.Value;
  }
  
  private static bool CmpPersistentDocumentId(DXW.Settings openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXO2013W.PersistentDocumentId>()?.Val?.Value == value;
  }
  
  private static void SetPersistentDocumentId(DXW.Settings openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013W.PersistentDocumentId>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXO2013W.PersistentDocumentId { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.Settings? CreateModelElement(DXW.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Settings();
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
  
  public static bool CompareModelElement(DXW.Settings? openXmlElement, DMW.Settings? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.Settings? value)
    where OpenXmlElementType: DXW.Settings, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
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
      return openXmlElement;
    }
    return default;
  }
}

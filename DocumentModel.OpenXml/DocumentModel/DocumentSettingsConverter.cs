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
    var element = openXmlElement?.GetFirstChild<DXW.Zoom>();
    if (element != null)
      return DMXW.ZoomConverter.CreateModelElement(element);
    return null;
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
    var element = openXmlElement.GetFirstChild<DXW.RemovePersonalInformation>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpRemovePersonalInformation(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetRemovePersonalInformation(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.RemovePersonalInformation", val, value);
    return false;
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
    var element = openXmlElement.GetFirstChild<DXW.RemoveDateAndTime>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpRemoveDateAndTime(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetRemoveDateAndTime(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.RemoveDateAndTime", val, value);
    return false;
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
    var element = openXmlElement.GetFirstChild<DXW.DoNotDisplayPageBoundaries>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpDoNotDisplayPageBoundaries(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetDoNotDisplayPageBoundaries(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.DoNotDisplayPageBoundaries", val, value);
    return false;
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
    var element = openXmlElement.GetFirstChild<DXW.DisplayBackgroundShape>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpDisplayBackgroundShape(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetDisplayBackgroundShape(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.DisplayBackgroundShape", val, value);
    return false;
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
    var element = openXmlElement.GetFirstChild<DXW.PrintPostScriptOverText>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpPrintPostScriptOverText(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetPrintPostScriptOverText(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.PrintPostScriptOverText", val, value);
    return false;
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
    var element = openXmlElement.GetFirstChild<DXW.PrintFractionalCharacterWidth>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpPrintFractionalCharacterWidth(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetPrintFractionalCharacterWidth(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.PrintFractionalCharacterWidth", val, value);
    return false;
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
    var element = openXmlElement.GetFirstChild<DXW.PrintFormsData>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpPrintFormsData(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetPrintFormsData(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.PrintFormsData", val, value);
    return false;
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
    var element = openXmlElement.GetFirstChild<DXW.EmbedTrueTypeFonts>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpEmbedTrueTypeFonts(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetEmbedTrueTypeFonts(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.EmbedTrueTypeFonts", val, value);
    return false;
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
    var element = openXmlElement.GetFirstChild<DXW.EmbedSystemFonts>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpEmbedSystemFonts(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetEmbedSystemFonts(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.EmbedSystemFonts", val, value);
    return false;
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
    var element = openXmlElement.GetFirstChild<DXW.SaveSubsetFonts>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpSaveSubsetFonts(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetSaveSubsetFonts(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.SaveSubsetFonts", val, value);
    return false;
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
    var element = openXmlElement.GetFirstChild<DXW.SaveFormsData>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpSaveFormsData(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetSaveFormsData(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.SaveFormsData", val, value);
    return false;
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
    var element = openXmlElement.GetFirstChild<DXW.MirrorMargins>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpMirrorMargins(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetMirrorMargins(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.MirrorMargins", val, value);
    return false;
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
    var element = openXmlElement.GetFirstChild<DXW.AlignBorderAndEdges>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpAlignBorderAndEdges(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetAlignBorderAndEdges(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.AlignBorderAndEdges", val, value);
    return false;
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
    var element = openXmlElement.GetFirstChild<DXW.BordersDoNotSurroundHeader>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpBordersDoNotSurroundHeader(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetBordersDoNotSurroundHeader(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.BordersDoNotSurroundHeader", val, value);
    return false;
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
    var element = openXmlElement.GetFirstChild<DXW.BordersDoNotSurroundFooter>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpBordersDoNotSurroundFooter(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetBordersDoNotSurroundFooter(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.BordersDoNotSurroundFooter", val, value);
    return false;
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
    var element = openXmlElement.GetFirstChild<DXW.GutterAtTop>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpGutterAtTop(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetGutterAtTop(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.GutterAtTop", val, value);
    return false;
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
    var element = openXmlElement.GetFirstChild<DXW.HideSpellingErrors>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpHideSpellingErrors(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetHideSpellingErrors(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.HideSpellingErrors", val, value);
    return false;
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
    var element = openXmlElement.GetFirstChild<DXW.HideGrammaticalErrors>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpHideGrammaticalErrors(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetHideGrammaticalErrors(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.HideGrammaticalErrors", val, value);
    return false;
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
    var element = openXmlElement?.GetFirstChild<DXW.ProofState>();
    if (element != null)
      return DMXW.ProofStateConverter.CreateModelElement(element);
    return null;
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
    var element = openXmlElement.GetFirstChild<DXW.FormsDesign>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpFormsDesign(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetFormsDesign(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.FormsDesign", val, value);
    return false;
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
    var element = openXmlElement?.GetFirstChild<DXW.AttachedTemplate>();
    if (element != null)
      return DMXW.RelationshipTypeConverter.CreateModelElement(element);
    return null;
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
    var element = openXmlElement.GetFirstChild<DXW.LinkStyles>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpLinkStyles(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetLinkStyles(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.LinkStyles", val, value);
    return false;
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
    var element = openXmlElement?.GetFirstChild<DXW.StylePaneFormatFilter>();
    if (element != null)
      return DMXW.StylePaneFormatFilterConverter.CreateModelElement(element);
    return null;
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
    var element = openXmlElement?.GetFirstChild<DXW.MailMerge>();
    if (element != null)
      return DMXW.MailMergeConverter.CreateModelElement(element);
    return null;
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
    var element = openXmlElement?.GetFirstChild<DXW.RevisionView>();
    if (element != null)
      return DMXW.RevisionViewConverter.CreateModelElement(element);
    return null;
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
    var element = openXmlElement.GetFirstChild<DXW.TrackRevisions>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpTrackRevisions(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetTrackRevisions(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.TrackRevisions", val, value);
    return false;
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
    var element = openXmlElement.GetFirstChild<DXW.DoNotTrackMoves>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpDoNotTrackMoves(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetDoNotTrackMoves(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.DoNotTrackMoves", val, value);
    return false;
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
    var element = openXmlElement.GetFirstChild<DXW.DoNotTrackFormatting>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpDoNotTrackFormatting(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetDoNotTrackFormatting(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.DoNotTrackFormatting", val, value);
    return false;
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
    var element = openXmlElement?.GetFirstChild<DXW.DocumentProtection>();
    if (element != null)
      return DMXW.DocumentProtectionConverter.CreateModelElement(element);
    return null;
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
    var element = openXmlElement.GetFirstChild<DXW.AutoFormatOverride>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpAutoFormatOverride(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetAutoFormatOverride(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.AutoFormatOverride", val, value);
    return false;
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
    var element = openXmlElement.GetFirstChild<DXW.AutoHyphenation>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpAutoHyphenation(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetAutoHyphenation(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.AutoHyphenation", val, value);
    return false;
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
    var element = openXmlElement.GetFirstChild<DXW.DoNotHyphenateCaps>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpDoNotHyphenateCaps(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetDoNotHyphenateCaps(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.DoNotHyphenateCaps", val, value);
    return false;
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
    var element = openXmlElement.GetFirstChild<DXW.ShowEnvelope>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpShowEnvelope(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetShowEnvelope(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.ShowEnvelope", val, value);
    return false;
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
    var element = openXmlElement.GetFirstChild<DXW.EvenAndOddHeaders>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpEvenAndOddHeaders(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetEvenAndOddHeaders(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.EvenAndOddHeaders", val, value);
    return false;
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
    var element = openXmlElement.GetFirstChild<DXW.BookFoldReversePrinting>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpBookFoldReversePrinting(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetBookFoldReversePrinting(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.BookFoldReversePrinting", val, value);
    return false;
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
    var element = openXmlElement.GetFirstChild<DXW.BookFoldPrinting>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpBookFoldPrinting(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetBookFoldPrinting(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.BookFoldPrinting", val, value);
    return false;
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
    var element = openXmlElement.GetFirstChild<DXW.DoNotUseMarginsForDrawingGridOrigin>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpDoNotUseMarginsForDrawingGridOrigin(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetDoNotUseMarginsForDrawingGridOrigin(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.DoNotUseMarginsForDrawingGridOrigin", val, value);
    return false;
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
    var element = openXmlElement.GetFirstChild<DXW.DoNotShadeFormData>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpDoNotShadeFormData(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetDoNotShadeFormData(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.DoNotShadeFormData", val, value);
    return false;
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
    var element = openXmlElement.GetFirstChild<DXW.NoPunctuationKerning>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpNoPunctuationKerning(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetNoPunctuationKerning(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.NoPunctuationKerning", val, value);
    return false;
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
    var element = openXmlElement.GetFirstChild<DXW.PrintTwoOnOne>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpPrintTwoOnOne(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetPrintTwoOnOne(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.PrintTwoOnOne", val, value);
    return false;
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
    var element = openXmlElement.GetFirstChild<DXW.StrictFirstAndLastChars>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpStrictFirstAndLastChars(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetStrictFirstAndLastChars(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.StrictFirstAndLastChars", val, value);
    return false;
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
    var element = openXmlElement?.GetFirstChild<DXW.NoLineBreaksAfterKinsoku>();
    if (element != null)
      return DMXW.NoLineBreaksAfterKinsokuConverter.CreateModelElement(element);
    return null;
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
    var element = openXmlElement?.GetFirstChild<DXW.NoLineBreaksBeforeKinsoku>();
    if (element != null)
      return DMXW.NoLineBreaksBeforeKinsokuConverter.CreateModelElement(element);
    return null;
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
    var element = openXmlElement.GetFirstChild<DXW.SavePreviewPicture>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpSavePreviewPicture(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetSavePreviewPicture(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.SavePreviewPicture", val, value);
    return false;
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
    var element = openXmlElement.GetFirstChild<DXW.DoNotValidateAgainstSchema>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpDoNotValidateAgainstSchema(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetDoNotValidateAgainstSchema(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.DoNotValidateAgainstSchema", val, value);
    return false;
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
    var element = openXmlElement.GetFirstChild<DXW.SaveInvalidXml>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpSaveInvalidXml(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetSaveInvalidXml(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.SaveInvalidXml", val, value);
    return false;
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
    var element = openXmlElement.GetFirstChild<DXW.IgnoreMixedContent>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpIgnoreMixedContent(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetIgnoreMixedContent(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.IgnoreMixedContent", val, value);
    return false;
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
    var element = openXmlElement.GetFirstChild<DXW.AlwaysShowPlaceholderText>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpAlwaysShowPlaceholderText(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetAlwaysShowPlaceholderText(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.AlwaysShowPlaceholderText", val, value);
    return false;
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
    var element = openXmlElement.GetFirstChild<DXW.DoNotDemarcateInvalidXml>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpDoNotDemarcateInvalidXml(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetDoNotDemarcateInvalidXml(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.DoNotDemarcateInvalidXml", val, value);
    return false;
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
    var element = openXmlElement.GetFirstChild<DXW.SaveXmlDataOnly>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpSaveXmlDataOnly(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetSaveXmlDataOnly(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.SaveXmlDataOnly", val, value);
    return false;
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
    var element = openXmlElement.GetFirstChild<DXW.UseXsltWhenSaving>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpUseXsltWhenSaving(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetUseXsltWhenSaving(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.UseXsltWhenSaving", val, value);
    return false;
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
    var element = openXmlElement?.GetFirstChild<DXW.SaveThroughXslt>();
    if (element != null)
      return DMXW.SaveThroughXsltConverter.CreateModelElement(element);
    return null;
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
    var element = openXmlElement.GetFirstChild<DXW.ShowXmlTags>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpShowXmlTags(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetShowXmlTags(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.ShowXmlTags", val, value);
    return false;
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
    var element = openXmlElement.GetFirstChild<DXW.AlwaysMergeEmptyNamespace>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpAlwaysMergeEmptyNamespace(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetAlwaysMergeEmptyNamespace(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.AlwaysMergeEmptyNamespace", val, value);
    return false;
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
    var element = openXmlElement.GetFirstChild<DXW.UpdateFieldsOnOpen>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpUpdateFieldsOnOpen(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetUpdateFieldsOnOpen(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.UpdateFieldsOnOpen", val, value);
    return false;
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
    var element = openXmlElement?.GetFirstChild<DXW.HeaderShapeDefaults>();
    if (element != null)
      return DMXW.HeaderShapeDefaultsConverter.CreateModelElement(element);
    return null;
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
    var element = openXmlElement?.GetFirstChild<DXW.FootnoteDocumentWideProperties>();
    if (element != null)
      return DMXW.FootnoteDocumentWidePropertiesConverter.CreateModelElement(element);
    return null;
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
    var element = openXmlElement?.GetFirstChild<DXW.EndnoteDocumentWideProperties>();
    if (element != null)
      return DMXW.EndnoteDocumentWidePropertiesConverter.CreateModelElement(element);
    return null;
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
    var element = openXmlElement?.GetFirstChild<DXW.Compatibility>();
    if (element != null)
      return DMXW.CompatibilityConverter.CreateModelElement(element);
    return null;
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
    var element = openXmlElement?.GetFirstChild<DXW.DocumentVariables>();
    if (element != null)
      return DMXW.DocumentVariablesConverter.CreateModelElement(element);
    return null;
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
    var element = openXmlElement?.GetFirstChild<DXW.Rsids>();
    if (element != null)
      return DMXW.RsidsConverter.CreateModelElement(element);
    return null;
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
    var element = openXmlElement?.GetFirstChild<DXMath.MathProperties>();
    if (element != null)
      return DMXMath.MathPropertiesConverter.CreateModelElement(element);
    return null;
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
    var element = openXmlElement.GetFirstChild<DXW.UICompatibleWith97To2003>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpUICompatibleWith97To2003(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetUICompatibleWith97To2003(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.UICompatibleWith97To2003", val, value);
    return false;
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
  
  private static Collection<String>? GetAttachedSchemas(DXW.Settings openXmlElement)
  {
    var collection = new Collection<String>();
    foreach (var item in openXmlElement.Elements<DXW.AttachedSchema>())
    {
      var newItem = StringValueConverter.GetValue(item);
      if (newItem != null)
        collection.Add((string)newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
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
    var element = openXmlElement?.GetFirstChild<DXW.ThemeFontLanguages>();
    if (element != null)
      return DMXW.LanguageTypeConverter.CreateModelElement(element);
    return null;
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
    var element = openXmlElement?.GetFirstChild<DXW.ColorSchemeMapping>();
    if (element != null)
      return DMXW.ColorSchemeMappingConverter.CreateModelElement(element);
    return null;
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
    var element = openXmlElement.GetFirstChild<DXW.DoNotIncludeSubdocsInStats>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpDoNotIncludeSubdocsInStats(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetDoNotIncludeSubdocsInStats(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.DoNotIncludeSubdocsInStats", val, value);
    return false;
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
    var element = openXmlElement.GetFirstChild<DXW.DoNotAutoCompressPictures>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpDoNotAutoCompressPictures(DXW.Settings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetDoNotAutoCompressPictures(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.DoNotAutoCompressPictures", val, value);
    return false;
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
    var val = openXmlElement.GetFirstChild<DXW.ForceUpgrade>() != null;
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
    var element = openXmlElement?.GetFirstChild<DXW.ReadModeInkLockDown>();
    if (element != null)
      return DMXW.ReadModeInkLockDownConverter.CreateModelElement(element);
    return null;
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
    var element = openXmlElement?.GetFirstChild<DXCustXmlSchRefs.SchemaLibrary>();
    if (element != null)
      return DMXCustXml.SchemaLibraryConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSchemaLibrary(DXW.Settings openXmlElement, DMCustXml.SchemaLibrary? value, DiffList? diffs, string? objName)
  {
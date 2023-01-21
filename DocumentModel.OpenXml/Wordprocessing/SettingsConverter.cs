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
    var itemElement = openXmlElement?.GetFirstChild<DXW.WriteProtection>();
    if (itemElement != null)
      return DMXW.WriteProtectionConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.View>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ViewValues, DMW.ViewKind>(itemElement.Val.Value);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.Zoom>();
    if (itemElement != null)
      return DMXW.ZoomConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.RemovePersonalInformation>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.RemoveDateAndTime>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.DoNotDisplayPageBoundaries>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.DisplayBackgroundShape>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.PrintPostScriptOverText>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.PrintFractionalCharacterWidth>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.PrintFormsData>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.EmbedTrueTypeFonts>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.EmbedSystemFonts>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.SaveSubsetFonts>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.SaveFormsData>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.MirrorMargins>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.AlignBorderAndEdges>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.BordersDoNotSurroundHeader>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.BordersDoNotSurroundFooter>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.GutterAtTop>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.HideSpellingErrors>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.HideGrammaticalErrors>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.ProofState>();
    if (itemElement != null)
      return DMXW.ProofStateConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.FormsDesign>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.AttachedTemplate>();
    if (itemElement != null)
      return DMXW.RelationshipTypeConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.LinkStyles>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.StylePaneFormatFilter>();
    if (itemElement != null)
      return DMXW.StylePaneFormatFilterConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.StylePaneSortMethods>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.DocumentType>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.DocumentTypeValues, DMW.DocumentKind>(itemElement.Val.Value);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.MailMerge>();
    if (itemElement != null)
      return DMXW.MailMergeConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.RevisionView>();
    if (itemElement != null)
      return DMXW.RevisionViewConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.TrackRevisions>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.DoNotTrackMoves>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.DoNotTrackFormatting>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.DocumentProtection>();
    if (itemElement != null)
      return DMXW.DocumentProtectionConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.AutoFormatOverride>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.DefaultTabStop>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.AutoHyphenation>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.ConsecutiveHyphenLimit>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.HyphenationZone>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.DoNotHyphenateCaps>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.ShowEnvelope>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.SummaryLength>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.ClickAndTypeStyle>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.DefaultTableStyle>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.EvenAndOddHeaders>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.BookFoldReversePrinting>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.BookFoldPrinting>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.BookFoldPrintingSheets>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.DrawingGridHorizontalSpacing>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.DrawingGridVerticalSpacing>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.DisplayHorizontalDrawingGrid>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.DisplayVerticalDrawingGrid>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.DoNotUseMarginsForDrawingGridOrigin>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.DrawingGridHorizontalOrigin>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.DrawingGridVerticalOrigin>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.DoNotShadeFormData>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.NoPunctuationKerning>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.CharacterSpacingControl>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.CharacterSpacingValues, DMW.CharacterSpacingKind>(itemElement.Val.Value);
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.PrintTwoOnOne>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.StrictFirstAndLastChars>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.NoLineBreaksAfterKinsoku>();
    if (itemElement != null)
      return DMXW.NoLineBreaksAfterKinsokuConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.NoLineBreaksBeforeKinsoku>();
    if (itemElement != null)
      return DMXW.NoLineBreaksBeforeKinsokuConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.SavePreviewPicture>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.DoNotValidateAgainstSchema>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.SaveInvalidXml>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.IgnoreMixedContent>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.AlwaysShowPlaceholderText>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.DoNotDemarcateInvalidXml>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.SaveXmlDataOnly>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.UseXsltWhenSaving>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.SaveThroughXslt>();
    if (itemElement != null)
      return DMXW.SaveThroughXsltConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.ShowXmlTags>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.AlwaysMergeEmptyNamespace>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.UpdateFieldsOnOpen>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.HeaderShapeDefaults>();
    if (itemElement != null)
      return DMXW.HeaderShapeDefaultsConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.FootnoteDocumentWideProperties>();
    if (itemElement != null)
      return DMXW.FootnoteDocumentWidePropertiesConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.EndnoteDocumentWideProperties>();
    if (itemElement != null)
      return DMXW.EndnoteDocumentWidePropertiesConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.Compatibility>();
    if (itemElement != null)
      return DMXW.CompatibilityConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.DocumentVariables>();
    if (itemElement != null)
      return DMXW.DocumentVariablesConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.Rsids>();
    if (itemElement != null)
      return DMXW.RsidsConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.MathProperties>();
    if (itemElement != null)
      return DMXMath.MathPropertiesConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.UICompatibleWith97To2003>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.ThemeFontLanguages>();
    if (itemElement != null)
      return DMXW.LanguageTypeConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.ColorSchemeMapping>();
    if (itemElement != null)
      return DMXW.ColorSchemeMappingConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.DoNotIncludeSubdocsInStats>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.DoNotAutoCompressPictures>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.ForceUpgrade>();
    return itemElement != null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.Captions>();
    if (itemElement != null)
      return DMXW.CaptionsConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.ReadModeInkLockDown>();
    if (itemElement != null)
      return DMXW.ReadModeInkLockDownConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXCustXmlSchRefs.SchemaLibrary>();
    if (itemElement != null)
      return DMXCustXml.SchemaLibraryConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.ShapeDefaults>();
    if (itemElement != null)
      return DMXW.ShapeDefaultsConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.DecimalSymbol>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.ListSeparator>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2010W.DocumentId>();
    if (itemElement != null)
      return DMX.HexBinaryConverter.GetValue(itemElement);
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.DiscardImageEditingData>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.OnOffValues, DMW.OnOffKind>(itemElement.Val.Value);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2010W.DefaultImageDpi>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.ConflictMode>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.OnOffValues, DMW.OnOffKind>(itemElement.Val.Value);
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXO2013W.ChartTrackingRefBased>();
    return itemElement != null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2013W.PersistentDocumentId>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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

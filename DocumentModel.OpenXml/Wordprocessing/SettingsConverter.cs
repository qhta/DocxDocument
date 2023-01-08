namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Document Settings.
/// </summary>
public static class SettingsConverter
{
  /// <summary>
  /// Write Protection.
  /// </summary>
  public static DocumentModel.Wordprocessing.WriteProtection? GetWriteProtection(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetWriteProtection(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, DocumentModel.Wordprocessing.WriteProtection? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Document View Setting.
  /// </summary>
  public static DocumentModel.Wordprocessing.ViewKind? GetView(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.View>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ViewValues, DocumentModel.Wordprocessing.ViewKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetView(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, DocumentModel.Wordprocessing.ViewKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.View>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.View, DocumentFormat.OpenXml.Wordprocessing.ViewValues, DocumentModel.Wordprocessing.ViewKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Magnification Setting.
  /// </summary>
  public static DocumentModel.Wordprocessing.Zoom? GetZoom(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetZoom(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, DocumentModel.Wordprocessing.Zoom? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Remove Personal Information from Document Properties.
  /// </summary>
  public static Boolean? GetRemovePersonalInformation(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetRemovePersonalInformation(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Remove Date and Time from Annotations.
  /// </summary>
  public static Boolean? GetRemoveDateAndTime(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetRemoveDateAndTime(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Do Not Display Visual Boundary For Header/Footer or Between Pages.
  /// </summary>
  public static Boolean? GetDoNotDisplayPageBoundaries(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDoNotDisplayPageBoundaries(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Display Background Objects When Displaying Document.
  /// </summary>
  public static Boolean? GetDisplayBackgroundShape(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDisplayBackgroundShape(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Print PostScript Codes With Document Text.
  /// </summary>
  public static Boolean? GetPrintPostScriptOverText(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetPrintPostScriptOverText(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Print Fractional Character Widths.
  /// </summary>
  public static Boolean? GetPrintFractionalCharacterWidth(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetPrintFractionalCharacterWidth(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Only Print Form Field Content.
  /// </summary>
  public static Boolean? GetPrintFormsData(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetPrintFormsData(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Embed TrueType Fonts.
  /// </summary>
  public static Boolean? GetEmbedTrueTypeFonts(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetEmbedTrueTypeFonts(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Embed Common System Fonts.
  /// </summary>
  public static Boolean? GetEmbedSystemFonts(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetEmbedSystemFonts(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Subset Fonts When Embedding.
  /// </summary>
  public static Boolean? GetSaveSubsetFonts(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSaveSubsetFonts(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Only Save Form Field Content.
  /// </summary>
  public static Boolean? GetSaveFormsData(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSaveFormsData(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Mirror Page Margins.
  /// </summary>
  public static Boolean? GetMirrorMargins(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetMirrorMargins(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Align Paragraph and Table Borders with Page Border.
  /// </summary>
  public static Boolean? GetAlignBorderAndEdges(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAlignBorderAndEdges(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Page Border Excludes Header.
  /// </summary>
  public static Boolean? GetBordersDoNotSurroundHeader(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBordersDoNotSurroundHeader(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Page Border Excludes Footer.
  /// </summary>
  public static Boolean? GetBordersDoNotSurroundFooter(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBordersDoNotSurroundFooter(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Position Gutter At Top of Page.
  /// </summary>
  public static Boolean? GetGutterAtTop(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetGutterAtTop(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Do Not Display Visual Indication of Spelling Errors.
  /// </summary>
  public static Boolean? GetHideSpellingErrors(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetHideSpellingErrors(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Do Not Display Visual Indication of Grammatical Errors.
  /// </summary>
  public static Boolean? GetHideGrammaticalErrors(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetHideGrammaticalErrors(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.ActiveWritingStyle>? GetActiveWritingStyles(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetActiveWritingStyles(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.ActiveWritingStyle>? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.ProofState? GetProofState(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetProofState(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, DocumentModel.Wordprocessing.ProofState? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetFormsDesign(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetFormsDesign(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.RelationshipType? GetAttachedTemplate(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAttachedTemplate(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, DocumentModel.Wordprocessing.RelationshipType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetLinkStyles(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLinkStyles(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.StylePaneFormatFilter? GetStylePaneFormatFilter(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetStylePaneFormatFilter(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, DocumentModel.Wordprocessing.StylePaneFormatFilter? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static String? GetStylePaneSortMethods(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.Wordprocessing.StylePaneSortMethods");
  }
  
  public static void SetStylePaneSortMethods(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.DocumentKind? GetDocumentType(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocumentType>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.DocumentTypeValues, DocumentModel.Wordprocessing.DocumentKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetDocumentType(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, DocumentModel.Wordprocessing.DocumentKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocumentType>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.DocumentType, DocumentFormat.OpenXml.Wordprocessing.DocumentTypeValues, DocumentModel.Wordprocessing.DocumentKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.MailMerge? GetMailMerge(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetMailMerge(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, DocumentModel.Wordprocessing.MailMerge? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.RevisionView? GetRevisionView(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetRevisionView(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, DocumentModel.Wordprocessing.RevisionView? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetTrackRevisions(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTrackRevisions(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetDoNotTrackMoves(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDoNotTrackMoves(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetDoNotTrackFormatting(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDoNotTrackFormatting(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.DocumentProtection? GetDocumentProtection(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDocumentProtection(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, DocumentModel.Wordprocessing.DocumentProtection? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetAutoFormatOverride(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAutoFormatOverride(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Int16? GetDefaultTabStop(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDefaultTabStop(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Int16? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetAutoHyphenation(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAutoHyphenation(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static UInt16? GetConsecutiveHyphenLimit(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetConsecutiveHyphenLimit(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, UInt16? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static String? GetHyphenationZone(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.Wordprocessing.HyphenationZone");
  }
  
  public static void SetHyphenationZone(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetDoNotHyphenateCaps(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDoNotHyphenateCaps(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetShowEnvelope(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetShowEnvelope(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Int32? GetSummaryLength(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSummaryLength(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static String? GetClickAndTypeStyle(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.Wordprocessing.ClickAndTypeStyle");
  }
  
  public static void SetClickAndTypeStyle(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static String? GetDefaultTableStyle(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.Wordprocessing.DefaultTableStyle");
  }
  
  public static void SetDefaultTableStyle(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetEvenAndOddHeaders(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetEvenAndOddHeaders(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetBookFoldReversePrinting(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBookFoldReversePrinting(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetBookFoldPrinting(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBookFoldPrinting(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Int16? GetBookFoldPrintingSheets(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBookFoldPrintingSheets(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Int16? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static String? GetDrawingGridHorizontalSpacing(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.Wordprocessing.DrawingGridHorizontalSpacing");
  }
  
  public static void SetDrawingGridHorizontalSpacing(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static String? GetDrawingGridVerticalSpacing(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.Wordprocessing.DrawingGridVerticalSpacing");
  }
  
  public static void SetDrawingGridVerticalSpacing(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Int32? GetDisplayHorizontalDrawingGrid(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDisplayHorizontalDrawingGrid(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Int32? GetDisplayVerticalDrawingGrid(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDisplayVerticalDrawingGrid(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetDoNotUseMarginsForDrawingGridOrigin(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDoNotUseMarginsForDrawingGridOrigin(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static String? GetDrawingGridHorizontalOrigin(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.Wordprocessing.DrawingGridHorizontalOrigin");
  }
  
  public static void SetDrawingGridHorizontalOrigin(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static String? GetDrawingGridVerticalOrigin(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.Wordprocessing.DrawingGridVerticalOrigin");
  }
  
  public static void SetDrawingGridVerticalOrigin(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetDoNotShadeFormData(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDoNotShadeFormData(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetNoPunctuationKerning(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetNoPunctuationKerning(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.CharacterSpacingKind? GetCharacterSpacingControl(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CharacterSpacingControl>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.CharacterSpacingValues, DocumentModel.Wordprocessing.CharacterSpacingKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetCharacterSpacingControl(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, DocumentModel.Wordprocessing.CharacterSpacingKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CharacterSpacingControl>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.CharacterSpacingControl, DocumentFormat.OpenXml.Wordprocessing.CharacterSpacingValues, DocumentModel.Wordprocessing.CharacterSpacingKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetPrintTwoOnOne(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetPrintTwoOnOne(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetStrictFirstAndLastChars(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetStrictFirstAndLastChars(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.NoLineBreaksAfterKinsoku? GetNoLineBreaksAfterKinsoku(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetNoLineBreaksAfterKinsoku(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, DocumentModel.Wordprocessing.NoLineBreaksAfterKinsoku? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.NoLineBreaksBeforeKinsoku? GetNoLineBreaksBeforeKinsoku(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetNoLineBreaksBeforeKinsoku(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, DocumentModel.Wordprocessing.NoLineBreaksBeforeKinsoku? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetSavePreviewPicture(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSavePreviewPicture(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetDoNotValidateAgainstSchema(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDoNotValidateAgainstSchema(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetSaveInvalidXml(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSaveInvalidXml(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetIgnoreMixedContent(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetIgnoreMixedContent(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetAlwaysShowPlaceholderText(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAlwaysShowPlaceholderText(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetDoNotDemarcateInvalidXml(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDoNotDemarcateInvalidXml(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetSaveXmlDataOnly(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSaveXmlDataOnly(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetUseXsltWhenSaving(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetUseXsltWhenSaving(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.SaveThroughXslt? GetSaveThroughXslt(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSaveThroughXslt(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, DocumentModel.Wordprocessing.SaveThroughXslt? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetShowXmlTags(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetShowXmlTags(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetAlwaysMergeEmptyNamespace(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAlwaysMergeEmptyNamespace(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetUpdateFieldsOnOpen(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetUpdateFieldsOnOpen(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.HeaderShapeDefaults? GetHeaderShapeDefaults(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetHeaderShapeDefaults(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, DocumentModel.Wordprocessing.HeaderShapeDefaults? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.FootnoteDocumentWideProperties? GetFootnoteDocumentWideProperties(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetFootnoteDocumentWideProperties(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, DocumentModel.Wordprocessing.FootnoteDocumentWideProperties? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.EndnoteDocumentWideProperties? GetEndnoteDocumentWideProperties(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetEndnoteDocumentWideProperties(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, DocumentModel.Wordprocessing.EndnoteDocumentWideProperties? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.Compatibility? GetCompatibility(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetCompatibility(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, DocumentModel.Wordprocessing.Compatibility? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.DocumentVariables? GetDocumentVariables(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDocumentVariables(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, DocumentModel.Wordprocessing.DocumentVariables? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.Rsids? GetRsids(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetRsids(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, DocumentModel.Wordprocessing.Rsids? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Math.MathProperties? GetMathProperties(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetMathProperties(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, DocumentModel.Math.MathProperties? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetUICompatibleWith97To2003(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetUICompatibleWith97To2003(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static System.Collections.ObjectModel.Collection<String>? GetAttachedSchemas(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAttachedSchemas(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, System.Collections.ObjectModel.Collection<String>? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.LanguageType? GetThemeFontLanguages(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetThemeFontLanguages(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, DocumentModel.Wordprocessing.LanguageType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.ColorSchemeMapping? GetColorSchemeMapping(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetColorSchemeMapping(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, DocumentModel.Wordprocessing.ColorSchemeMapping? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetDoNotIncludeSubdocsInStats(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDoNotIncludeSubdocsInStats(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetDoNotAutoCompressPictures(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDoNotAutoCompressPictures(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetForceUpgrade(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetForceUpgrade(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.Captions? GetCaptions(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetCaptions(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, DocumentModel.Wordprocessing.Captions? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.ReadModeInkLockDown? GetReadModeInkLockDown(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetReadModeInkLockDown(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, DocumentModel.Wordprocessing.ReadModeInkLockDown? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.CustomXml.SchemaLibrary? GetSchemaLibrary(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSchemaLibrary(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, DocumentModel.CustomXml.SchemaLibrary? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.ShapeDefaults? GetShapeDefaults(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetShapeDefaults(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, DocumentModel.Wordprocessing.ShapeDefaults? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static String? GetDecimalSymbol(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 2 in property declaring Type is DocumentFormat.OpenXml.Wordprocessing.Settings");
  }
  
  public static void SetDecimalSymbol(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static String? GetListSeparator(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 2 in property declaring Type is DocumentFormat.OpenXml.Wordprocessing.Settings");
  }
  
  public static void SetListSeparator(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.HexBinary? GetDocumentId(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDocumentId(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, DocumentModel.HexBinary? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.OnOffKind? GetDiscardImageEditingData(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.DiscardImageEditingData>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.OnOffValues, DocumentModel.Wordprocessing.OnOffKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetDiscardImageEditingData(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, DocumentModel.Wordprocessing.OnOffKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.DiscardImageEditingData>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.DiscardImageEditingData, DocumentFormat.OpenXml.Office2010.Word.OnOffValues, DocumentModel.Wordprocessing.OnOffKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Int32? GetDefaultImageDpi(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDefaultImageDpi(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.OnOffKind? GetConflictMode(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.ConflictMode>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.OnOffValues, DocumentModel.Wordprocessing.OnOffKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetConflictMode(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, DocumentModel.Wordprocessing.OnOffKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.ConflictMode>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.ConflictMode, DocumentFormat.OpenXml.Office2010.Word.OnOffValues, DocumentModel.Wordprocessing.OnOffKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetChartTrackingRefBased(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetChartTrackingRefBased(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static String? GetPersistentDocumentId(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.Office2013.Word.PersistentDocumentId");
  }
  
  public static void SetPersistentDocumentId(DocumentFormat.OpenXml.Wordprocessing.Settings? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}

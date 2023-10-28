namespace DocumentModel;


/// <summary>
///   Document Settings.
/// </summary>
public partial class DocumentSettings
{
  
  /// <summary>
  ///   Write Protection.
  /// </summary>
  public DMW.WriteProtection? WriteProtection { get; set; }
  
  
  /// <summary>
  ///   Document View Setting.
  /// </summary>
  public DMW.ViewKind? View { get; set; }
  
  
  /// <summary>
  ///   Magnification Setting.
  /// </summary>
  public DMW.Zoom? Zoom { get; set; }
  
  
  /// <summary>
  ///   Remove Personal Information from Document Properties.
  /// </summary>
  public DMW.RemovePersonalInformation? RemovePersonalInformation { get; set; }
  
  
  /// <summary>
  ///   Remove Date and Time from Annotations.
  /// </summary>
  public DMW.RemoveDateAndTime? RemoveDateAndTime { get; set; }
  
  
  /// <summary>
  ///   Do Not Display Visual Boundary For Header/Footer or Between Pages.
  /// </summary>
  public DMW.DoNotDisplayPageBoundaries? DoNotDisplayPageBoundaries { get; set; }
  
  
  /// <summary>
  ///   Display Background Objects When Displaying Document.
  /// </summary>
  public DMW.DisplayBackgroundShape? DisplayBackgroundShape { get; set; }
  
  
  /// <summary>
  ///   Print PostScript Codes With Document Text.
  /// </summary>
  public DMW.PrintPostScriptOverText? PrintPostScriptOverText { get; set; }
  
  
  /// <summary>
  ///   Print Fractional Character Widths.
  /// </summary>
  public DMW.PrintFractionalCharacterWidth? PrintFractionalCharacterWidth { get; set; }
  
  
  /// <summary>
  ///   Only Print Form Field Content.
  /// </summary>
  public DMW.PrintFormsData? PrintFormsData { get; set; }
  
  
  /// <summary>
  ///   Embed TrueType Fonts.
  /// </summary>
  public DMW.EmbedTrueTypeFonts? EmbedTrueTypeFonts { get; set; }
  
  
  /// <summary>
  ///   Embed Common System Fonts.
  /// </summary>
  public DMW.EmbedSystemFonts? EmbedSystemFonts { get; set; }
  
  
  /// <summary>
  ///   Subset Fonts When Embedding.
  /// </summary>
  public DMW.SaveSubsetFonts? SaveSubsetFonts { get; set; }
  
  
  /// <summary>
  ///   Only Save Form Field Content.
  /// </summary>
  public DMW.SaveFormsData? SaveFormsData { get; set; }
  
  
  /// <summary>
  ///   Mirror Page Margins.
  /// </summary>
  public DMW.MirrorMargins? MirrorMargins { get; set; }
  
  
  /// <summary>
  ///   Align Paragraph and Table Borders with Page Border.
  /// </summary>
  public DMW.AlignBorderAndEdges? AlignBorderAndEdges { get; set; }
  
  
  /// <summary>
  ///   Page Border Excludes Header.
  /// </summary>
  public DMW.BordersDoNotSurroundHeader? BordersDoNotSurroundHeader { get; set; }
  
  
  /// <summary>
  ///   Page Border Excludes Footer.
  /// </summary>
  public DMW.BordersDoNotSurroundFooter? BordersDoNotSurroundFooter { get; set; }
  
  
  /// <summary>
  ///   Position Gutter At Top of Page.
  /// </summary>
  public DMW.GutterAtTop? GutterAtTop { get; set; }
  
  
  /// <summary>
  ///   Do Not Display Visual Indication of Spelling Errors.
  /// </summary>
  public DMW.HideSpellingErrors? HideSpellingErrors { get; set; }
  
  
  /// <summary>
  ///   Do Not Display Visual Indication of Grammatical Errors.
  /// </summary>
  public DMW.HideGrammaticalErrors? HideGrammaticalErrors { get; set; }
  
  public DMW.ProofState? ProofState { get; set; }
  
  public DMW.FormsDesign? FormsDesign { get; set; }
  
  public DMW.AttachedTemplate? AttachedTemplate { get; set; }
  
  public DMW.LinkStyles? LinkStyles { get; set; }
  
  public DMW.StylePaneFormatFilter? StylePaneFormatFilter { get; set; }
  
  public DMW.DocumentTypeKind? DocumentType { get; set; }
  
  public DMW.MailMerge? MailMerge { get; set; }
  
  public DMW.RevisionView? RevisionView { get; set; }
  
  public DMW.TrackRevisions? TrackRevisions { get; set; }
  
  public DMW.DoNotTrackMoves? DoNotTrackMoves { get; set; }
  
  public DMW.DoNotTrackFormatting? DoNotTrackFormatting { get; set; }
  
  public DMW.DocumentProtection? DocumentProtection { get; set; }
  
  public DMW.AutoFormatOverride? AutoFormatOverride { get; set; }
  
  public DMW.DefaultTabStop? DefaultTabStop { get; set; }
  
  public DMW.AutoHyphenation? AutoHyphenation { get; set; }
  
  public UInt16? ConsecutiveHyphenLimit { get; set; }
  
  public DMW.HyphenationZone? HyphenationZone { get; set; }
  
  public DMW.DoNotHyphenateCaps? DoNotHyphenateCaps { get; set; }
  
  public DMW.ShowEnvelope? ShowEnvelope { get; set; }
  
  public Int32? SummaryLength { get; set; }
  
  public DMW.ClickAndTypeStyle? ClickAndTypeStyle { get; set; }
  
  public DMW.DefaultTableStyle? DefaultTableStyle { get; set; }
  
  public DMW.EvenAndOddHeaders? EvenAndOddHeaders { get; set; }
  
  public DMW.BookFoldReversePrinting? BookFoldReversePrinting { get; set; }
  
  public DMW.BookFoldPrinting? BookFoldPrinting { get; set; }
  
  public DMW.BookFoldPrintingSheets? BookFoldPrintingSheets { get; set; }
  
  public DMW.DrawingGridHorizontalSpacing? DrawingGridHorizontalSpacing { get; set; }
  
  public DMW.DrawingGridVerticalSpacing? DrawingGridVerticalSpacing { get; set; }
  
  public DMW.DisplayHorizontalDrawingGrid? DisplayHorizontalDrawingGrid { get; set; }
  
  public DMW.DisplayVerticalDrawingGrid? DisplayVerticalDrawingGrid { get; set; }
  
  public DMW.DoNotUseMarginsForDrawingGridOrigin? DoNotUseMarginsForDrawingGridOrigin { get; set; }
  
  public DMW.DrawingGridHorizontalOrigin? DrawingGridHorizontalOrigin { get; set; }
  
  public DMW.DrawingGridVerticalOrigin? DrawingGridVerticalOrigin { get; set; }
  
  public DMW.DoNotShadeFormData? DoNotShadeFormData { get; set; }
  
  public DMW.NoPunctuationKerning? NoPunctuationKerning { get; set; }
  
  public DMW.CharacterSpacingKind? CharacterSpacingControl { get; set; }
  
  public DMW.PrintTwoOnOne? PrintTwoOnOne { get; set; }
  
  public DMW.StrictFirstAndLastChars? StrictFirstAndLastChars { get; set; }
  
  public DMW.NoLineBreaksAfterKinsoku? NoLineBreaksAfterKinsoku { get; set; }
  
  public DMW.NoLineBreaksBeforeKinsoku? NoLineBreaksBeforeKinsoku { get; set; }
  
  public DMW.SavePreviewPicture? SavePreviewPicture { get; set; }
  
  public DMW.DoNotValidateAgainstSchema? DoNotValidateAgainstSchema { get; set; }
  
  public DMW.SaveInvalidXml? SaveInvalidXml { get; set; }
  
  public DMW.IgnoreMixedContent? IgnoreMixedContent { get; set; }
  
  public DMW.AlwaysShowPlaceholderText? AlwaysShowPlaceholderText { get; set; }
  
  public DMW.DoNotDemarcateInvalidXml? DoNotDemarcateInvalidXml { get; set; }
  
  public DMW.SaveXmlDataOnly? SaveXmlDataOnly { get; set; }
  
  public DMW.UseXsltWhenSaving? UseXsltWhenSaving { get; set; }
  
  public DMW.SaveThroughXslt? SaveThroughXslt { get; set; }
  
  public DMW.ShowXmlTags? ShowXmlTags { get; set; }
  
  public DMW.AlwaysMergeEmptyNamespace? AlwaysMergeEmptyNamespace { get; set; }
  
  public DMW.UpdateFieldsOnOpen? UpdateFieldsOnOpen { get; set; }
  
  public DMW.HeaderShapeDefaults? HeaderShapeDefaults { get; set; }
  
  public DMW.FootnoteDocumentWideProperties? FootnoteDocumentWideProperties { get; set; }
  
  public DMW.EndnoteDocumentWideProperties? EndnoteDocumentWideProperties { get; set; }
  
  public DMW.Compatibility? Compatibility { get; set; }
  
  public DMW.DocumentVariables? DocumentVariables { get; set; }
  
  public DMW.Rsids? Rsids { get; set; }
  
  public DMM.MathProperties? MathProperties { get; set; }
  
  public DMW.UICompatibleWith97To2003? UICompatibleWith97To2003 { get; set; }
  
  public DMW.ThemeFontLanguages? ThemeFontLanguages { get; set; }
  
  public DMW.ColorSchemeMapping? ColorSchemeMapping { get; set; }
  
  public DMW.DoNotIncludeSubdocsInStats? DoNotIncludeSubdocsInStats { get; set; }
  
  public DMW.DoNotAutoCompressPictures? DoNotAutoCompressPictures { get; set; }
  
  public DMW.ForceUpgrade? ForceUpgrade { get; set; }
  
  public DMW.Captions? Captions { get; set; }
  
  public DMW.ReadModeInkLockDown? ReadModeInkLockDown { get; set; }
  
  public DMCX.SchemaLibrary? SchemaLibrary { get; set; }
  
  public DMW.ShapeDefaults? ShapeDefaults { get; set; }
  
  public DMW.DecimalSymbol? DecimalSymbol { get; set; }
  
  public DMW.ListSeparator? ListSeparator { get; set; }
  
  public DM.HexBinary? DocumentId { get; set; }
  
  public DMW10.DiscardImageEditingData? DiscardImageEditingData { get; set; }
  
  public Int32? DefaultImageDpi { get; set; }
  
  public DMW10.ConflictMode? ConflictMode { get; set; }
  
  public DMW13.ChartTrackingRefBased? ChartTrackingRefBased { get; set; }
  
  public String? PersistentDocumentId { get; set; }
  
}

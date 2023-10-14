namespace DocumentModel;


/// <summary>
///   Document Settings.
/// </summary>
public partial class DocumentSettings
{
  
  /// <summary>
  ///   Write Protection.
  /// </summary>
  public DocumentModel.Wordprocessing.WriteProtection? WriteProtection { get; set; }
  
  
  /// <summary>
  ///   Document View Setting.
  /// </summary>
  public DocumentModel.Wordprocessing.ViewKind? View { get; set; }
  
  
  /// <summary>
  ///   Magnification Setting.
  /// </summary>
  public DocumentModel.Wordprocessing.Zoom? Zoom { get; set; }
  
  
  /// <summary>
  ///   Remove Personal Information from Document Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.RemovePersonalInformation? RemovePersonalInformation { get; set; }
  
  
  /// <summary>
  ///   Remove Date and Time from Annotations.
  /// </summary>
  public DocumentModel.Wordprocessing.RemoveDateAndTime? RemoveDateAndTime { get; set; }
  
  
  /// <summary>
  ///   Do Not Display Visual Boundary For Header/Footer or Between Pages.
  /// </summary>
  public DocumentModel.Wordprocessing.DoNotDisplayPageBoundaries? DoNotDisplayPageBoundaries { get; set; }
  
  
  /// <summary>
  ///   Display Background Objects When Displaying Document.
  /// </summary>
  public DocumentModel.Wordprocessing.DisplayBackgroundShape? DisplayBackgroundShape { get; set; }
  
  
  /// <summary>
  ///   Print PostScript Codes With Document Text.
  /// </summary>
  public DocumentModel.Wordprocessing.PrintPostScriptOverText? PrintPostScriptOverText { get; set; }
  
  
  /// <summary>
  ///   Print Fractional Character Widths.
  /// </summary>
  public DocumentModel.Wordprocessing.PrintFractionalCharacterWidth? PrintFractionalCharacterWidth { get; set; }
  
  
  /// <summary>
  ///   Only Print Form Field Content.
  /// </summary>
  public DocumentModel.Wordprocessing.PrintFormsData? PrintFormsData { get; set; }
  
  
  /// <summary>
  ///   Embed TrueType Fonts.
  /// </summary>
  public DocumentModel.Wordprocessing.EmbedTrueTypeFonts? EmbedTrueTypeFonts { get; set; }
  
  
  /// <summary>
  ///   Embed Common System Fonts.
  /// </summary>
  public DocumentModel.Wordprocessing.EmbedSystemFonts? EmbedSystemFonts { get; set; }
  
  
  /// <summary>
  ///   Subset Fonts When Embedding.
  /// </summary>
  public DocumentModel.Wordprocessing.SaveSubsetFonts? SaveSubsetFonts { get; set; }
  
  
  /// <summary>
  ///   Only Save Form Field Content.
  /// </summary>
  public DocumentModel.Wordprocessing.SaveFormsData? SaveFormsData { get; set; }
  
  
  /// <summary>
  ///   Mirror Page Margins.
  /// </summary>
  public DocumentModel.Wordprocessing.MirrorMargins? MirrorMargins { get; set; }
  
  
  /// <summary>
  ///   Align Paragraph and Table Borders with Page Border.
  /// </summary>
  public DocumentModel.Wordprocessing.AlignBorderAndEdges? AlignBorderAndEdges { get; set; }
  
  
  /// <summary>
  ///   Page Border Excludes Header.
  /// </summary>
  public DocumentModel.Wordprocessing.BordersDoNotSurroundHeader? BordersDoNotSurroundHeader { get; set; }
  
  
  /// <summary>
  ///   Page Border Excludes Footer.
  /// </summary>
  public DocumentModel.Wordprocessing.BordersDoNotSurroundFooter? BordersDoNotSurroundFooter { get; set; }
  
  
  /// <summary>
  ///   Position Gutter At Top of Page.
  /// </summary>
  public DocumentModel.Wordprocessing.GutterAtTop? GutterAtTop { get; set; }
  
  
  /// <summary>
  ///   Do Not Display Visual Indication of Spelling Errors.
  /// </summary>
  public DocumentModel.Wordprocessing.HideSpellingErrors? HideSpellingErrors { get; set; }
  
  
  /// <summary>
  ///   Do Not Display Visual Indication of Grammatical Errors.
  /// </summary>
  public DocumentModel.Wordprocessing.HideGrammaticalErrors? HideGrammaticalErrors { get; set; }
  
  public DocumentModel.Wordprocessing.ProofState? ProofState { get; set; }
  
  public DocumentModel.Wordprocessing.FormsDesign? FormsDesign { get; set; }
  
  public DocumentModel.Wordprocessing.AttachedTemplate? AttachedTemplate { get; set; }
  
  public DocumentModel.Wordprocessing.LinkStyles? LinkStyles { get; set; }
  
  public DocumentModel.Wordprocessing.StylePaneFormatFilter? StylePaneFormatFilter { get; set; }
  
  public DocumentModel.Wordprocessing.DocumentTypeKind? DocumentType { get; set; }
  
  public DocumentModel.Wordprocessing.MailMerge? MailMerge { get; set; }
  
  public DocumentModel.Wordprocessing.RevisionView? RevisionView { get; set; }
  
  public DocumentModel.Wordprocessing.TrackRevisions? TrackRevisions { get; set; }
  
  public DocumentModel.Wordprocessing.DoNotTrackMoves? DoNotTrackMoves { get; set; }
  
  public DocumentModel.Wordprocessing.DoNotTrackFormatting? DoNotTrackFormatting { get; set; }
  
  public DocumentModel.Wordprocessing.DocumentProtection? DocumentProtection { get; set; }
  
  public DocumentModel.Wordprocessing.AutoFormatOverride? AutoFormatOverride { get; set; }
  
  public DocumentModel.Wordprocessing.DefaultTabStop? DefaultTabStop { get; set; }
  
  public DocumentModel.Wordprocessing.AutoHyphenation? AutoHyphenation { get; set; }
  
  public UInt16? ConsecutiveHyphenLimit { get; set; }
  
  public DocumentModel.Wordprocessing.HyphenationZone? HyphenationZone { get; set; }
  
  public DocumentModel.Wordprocessing.DoNotHyphenateCaps? DoNotHyphenateCaps { get; set; }
  
  public DocumentModel.Wordprocessing.ShowEnvelope? ShowEnvelope { get; set; }
  
  public Int32? SummaryLength { get; set; }
  
  public DocumentModel.Wordprocessing.ClickAndTypeStyle? ClickAndTypeStyle { get; set; }
  
  public DocumentModel.Wordprocessing.DefaultTableStyle? DefaultTableStyle { get; set; }
  
  public DocumentModel.Wordprocessing.EvenAndOddHeaders? EvenAndOddHeaders { get; set; }
  
  public DocumentModel.Wordprocessing.BookFoldReversePrinting? BookFoldReversePrinting { get; set; }
  
  public DocumentModel.Wordprocessing.BookFoldPrinting? BookFoldPrinting { get; set; }
  
  public DocumentModel.Wordprocessing.BookFoldPrintingSheets? BookFoldPrintingSheets { get; set; }
  
  public DocumentModel.Wordprocessing.DrawingGridHorizontalSpacing? DrawingGridHorizontalSpacing { get; set; }
  
  public DocumentModel.Wordprocessing.DrawingGridVerticalSpacing? DrawingGridVerticalSpacing { get; set; }
  
  public DocumentModel.Wordprocessing.DisplayHorizontalDrawingGrid? DisplayHorizontalDrawingGrid { get; set; }
  
  public DocumentModel.Wordprocessing.DisplayVerticalDrawingGrid? DisplayVerticalDrawingGrid { get; set; }
  
  public DocumentModel.Wordprocessing.DoNotUseMarginsForDrawingGridOrigin? DoNotUseMarginsForDrawingGridOrigin { get; set; }
  
  public DocumentModel.Wordprocessing.DrawingGridHorizontalOrigin? DrawingGridHorizontalOrigin { get; set; }
  
  public DocumentModel.Wordprocessing.DrawingGridVerticalOrigin? DrawingGridVerticalOrigin { get; set; }
  
  public DocumentModel.Wordprocessing.DoNotShadeFormData? DoNotShadeFormData { get; set; }
  
  public DocumentModel.Wordprocessing.NoPunctuationKerning? NoPunctuationKerning { get; set; }
  
  public DocumentModel.Wordprocessing.CharacterSpacingKind? CharacterSpacingControl { get; set; }
  
  public DocumentModel.Wordprocessing.PrintTwoOnOne? PrintTwoOnOne { get; set; }
  
  public DocumentModel.Wordprocessing.StrictFirstAndLastChars? StrictFirstAndLastChars { get; set; }
  
  public DocumentModel.Wordprocessing.NoLineBreaksAfterKinsoku? NoLineBreaksAfterKinsoku { get; set; }
  
  public DocumentModel.Wordprocessing.NoLineBreaksBeforeKinsoku? NoLineBreaksBeforeKinsoku { get; set; }
  
  public DocumentModel.Wordprocessing.SavePreviewPicture? SavePreviewPicture { get; set; }
  
  public DocumentModel.Wordprocessing.DoNotValidateAgainstSchema? DoNotValidateAgainstSchema { get; set; }
  
  public DocumentModel.Wordprocessing.SaveInvalidXml? SaveInvalidXml { get; set; }
  
  public DocumentModel.Wordprocessing.IgnoreMixedContent? IgnoreMixedContent { get; set; }
  
  public DocumentModel.Wordprocessing.AlwaysShowPlaceholderText? AlwaysShowPlaceholderText { get; set; }
  
  public DocumentModel.Wordprocessing.DoNotDemarcateInvalidXml? DoNotDemarcateInvalidXml { get; set; }
  
  public DocumentModel.Wordprocessing.SaveXmlDataOnly? SaveXmlDataOnly { get; set; }
  
  public DocumentModel.Wordprocessing.UseXsltWhenSaving? UseXsltWhenSaving { get; set; }
  
  public DocumentModel.Wordprocessing.SaveThroughXslt? SaveThroughXslt { get; set; }
  
  public DocumentModel.Wordprocessing.ShowXmlTags? ShowXmlTags { get; set; }
  
  public DocumentModel.Wordprocessing.AlwaysMergeEmptyNamespace? AlwaysMergeEmptyNamespace { get; set; }
  
  public DocumentModel.Wordprocessing.UpdateFieldsOnOpen? UpdateFieldsOnOpen { get; set; }
  
  public DocumentModel.Wordprocessing.HeaderShapeDefaults? HeaderShapeDefaults { get; set; }
  
  public DocumentModel.Wordprocessing.FootnoteDocumentWideProperties? FootnoteDocumentWideProperties { get; set; }
  
  public DocumentModel.Wordprocessing.EndnoteDocumentWideProperties? EndnoteDocumentWideProperties { get; set; }
  
  public DocumentModel.Wordprocessing.Compatibility? Compatibility { get; set; }
  
  public DocumentModel.Wordprocessing.DocumentVariables? DocumentVariables { get; set; }
  
  public DocumentModel.Wordprocessing.Rsids? Rsids { get; set; }
  
  public DocumentModel.Math.MathProperties? MathProperties { get; set; }
  
  public DocumentModel.Wordprocessing.UICompatibleWith97To2003? UICompatibleWith97To2003 { get; set; }
  
  public DocumentModel.Wordprocessing.ThemeFontLanguages? ThemeFontLanguages { get; set; }
  
  public DocumentModel.Wordprocessing.ColorSchemeMapping? ColorSchemeMapping { get; set; }
  
  public DocumentModel.Wordprocessing.DoNotIncludeSubdocsInStats? DoNotIncludeSubdocsInStats { get; set; }
  
  public DocumentModel.Wordprocessing.DoNotAutoCompressPictures? DoNotAutoCompressPictures { get; set; }
  
  public DocumentModel.Wordprocessing.ForceUpgrade? ForceUpgrade { get; set; }
  
  public DocumentModel.Wordprocessing.Captions? Captions { get; set; }
  
  public DocumentModel.Wordprocessing.ReadModeInkLockDown? ReadModeInkLockDown { get; set; }
  
  public DMCX.SchemaLibrary? SchemaLibrary { get; set; }
  
  public DocumentModel.Wordprocessing.ShapeDefaults? ShapeDefaults { get; set; }
  
  public DocumentModel.Wordprocessing.DecimalSymbol? DecimalSymbol { get; set; }
  
  public DocumentModel.Wordprocessing.ListSeparator? ListSeparator { get; set; }
  
  public DM.HexBinary? DocumentId { get; set; }
  
  public DocumentModel.Wordprocessing.DiscardImageEditingData? DiscardImageEditingData { get; set; }
  
  public Int32? DefaultImageDpi { get; set; }
  
  public DocumentModel.Wordprocessing.ConflictMode? ConflictMode { get; set; }
  
  public DocumentModel.Wordprocessing.ChartTrackingRefBased? ChartTrackingRefBased { get; set; }
  
  public String? PersistentDocumentId { get; set; }
  
  public DM.ElementCollection<IModelElement>? Items { get; set; }
  
}

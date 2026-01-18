#pragma warning disable CS0612 // Type or member is obsolete

namespace DocumentModel.Wordprocessing;

public partial class DocumentSettings
{
  public bool ShouldSerializeActiveWritingStyles() => ActiveWritingStyles is not null;

  public bool ShouldSerializeAlignBorderAndEdges() => AlignBorderAndEdges is not null;

  public bool ShouldSerializeAlwaysMergeEmptyNamespace() => AlwaysMergeEmptyNamespace is not null;

  public bool ShouldSerializeAlwaysShowPlaceholderText() => AlwaysShowPlaceholderText is not null;

  public bool ShouldSerializeAttachedSchemas() => AttachedSchemas is not null;

  public bool ShouldSerializeAttachedTemplate() => AttachedTemplate is not null;

  public bool ShouldSerializeAutoFormatOverride() => AutoFormatOverride is not null;

  public bool ShouldSerializeAutoHyphenation() => AutoHyphenation is not null;

  public bool ShouldSerializeBookFoldPrinting() => BookFoldPrinting is not null;

  public bool ShouldSerializeBookFoldPrintingSheets() => BookFoldPrintingSheets is not null;

  public bool ShouldSerializeBookFoldReversePrinting() => BookFoldReversePrinting is not null;

  public bool ShouldSerializeBordersDoNotSurroundFooter() => BordersDoNotSurroundFooter is not null;

  public bool ShouldSerializeBordersDoNotSurroundHeader() => BordersDoNotSurroundHeader is not null;

  public bool ShouldSerializeCaptions() => Captions is not null;

  public bool ShouldSerializeCharacterSpacingControl() => CharacterSpacingControl is not null;

  public bool ShouldSerializeChartTrackingRefBased() => ChartTrackingRefBased is not null;

  public bool ShouldSerializeClickAndTypeStyle() => ClickAndTypeStyle is not null;

  public bool ShouldSerializeColorSchemeMapping() => ColorSchemeMapping is not null;

  public bool ShouldSerializeCompatibility() => Compatibility is not null;

  public bool ShouldSerializeConflictMode() => ConflictMode is not null;

  public bool ShouldSerializeConsecutiveHyphenLimit() => ConsecutiveHyphenLimit is not null;

  public bool ShouldSerializeDecimalSymbol() => DecimalSymbol is not null;

  public bool ShouldSerializeDefaultImageDpi() => DefaultImageDpi is not null;

  public bool ShouldSerializeDefaultTableStyle() => DefaultTableStyle is not null;

  public bool ShouldSerializeDefaultTabStop() => DefaultTabStop is not null;

  public bool ShouldSerializeDiscardImageEditingData() => DiscardImageEditingData is not null;

  public bool ShouldSerializeDisplayBackgroundShape() => DisplayBackgroundShape is not null;

  public bool ShouldSerializeDisplayHorizontalDrawingGrid() => DisplayHorizontalDrawingGrid is not null;

  public bool ShouldSerializeDisplayVerticalDrawingGrid() => DisplayVerticalDrawingGrid is not null;

  public bool ShouldSerializeDocumentId() => DocumentId is not null;

  public bool ShouldSerializeDocumentProtection() => DocumentProtection is not null;

  public bool ShouldSerializeDocumentType() => DocumentType is not null;

  public bool ShouldSerializeDoNotAutoCompressPictures() => DoNotAutoCompressPictures is not null;

  public bool ShouldSerializeDoNotDemarcateInvalidXml() => DoNotDemarcateInvalidXml is not null;

  public bool ShouldSerializeDoNotDisplayPageBoundaries() => DoNotDisplayPageBoundaries is not null;

  public bool ShouldSerializeDoNotHyphenateCaps() => DoNotHyphenateCaps is not null;

  public bool ShouldSerializeDoNotIncludeSubdocsInStats() => DoNotIncludeSubdocsInStats is not null;

  public bool ShouldSerializeDoNotShadeFormData() => DoNotShadeFormData is not null;

  public bool ShouldSerializeDoNotTrackFormatting() => DoNotTrackFormatting is not null;

  public bool ShouldSerializeDoNotTrackMoves() => DoNotTrackMoves is not null;

  public bool ShouldSerializeDoNotUseMarginsForDrawingGridOrigin() => DoNotUseMarginsForDrawingGridOrigin is not null;

  public bool ShouldSerializeDoNotValidateAgainstSchema() => DoNotValidateAgainstSchema is not null;

  public bool ShouldSerializeDrawingGridHorizontalOrigin() => DrawingGridHorizontalOrigin is not null;

  public bool ShouldSerializeDrawingGridHorizontalSpacing() => DrawingGridHorizontalSpacing is not null;

  public bool ShouldSerializeDrawingGridVerticalOrigin() => DrawingGridVerticalOrigin is not null;

  public bool ShouldSerializeDrawingGridVerticalSpacing() => DrawingGridVerticalSpacing is not null;

  public bool ShouldSerializeEmbedSystemFonts() => EmbedSystemFonts is not null;

  public bool ShouldSerializeEmbedTrueTypeFonts() => EmbedTrueTypeFonts is not null;

  public bool ShouldSerializeEndnoteDocumentWideProperties() => EndnoteDocumentWideProperties is not null;

  public bool ShouldSerializeEvenAndOddHeaders() => EvenAndOddHeaders is not null;

  public bool ShouldSerializeFootnoteDocumentWideProperties() => FootnoteDocumentWideProperties is not null;

  public bool ShouldSerializeForceUpgrade() => ForceUpgrade is not null;

  public bool ShouldSerializeFormsDesign() => FormsDesign is not null;

  public bool ShouldSerializeHeaderShapeDefaults() => HeaderShapeDefaults is not null;

  public bool ShouldSerializeHideGrammaticalErrors() => HideGrammaticalErrors is not null;

  public bool ShouldSerializeHideSpellingErrors() => HideSpellingErrors is not null;

  public bool ShouldSerializeHyphenationZone() => HyphenationZone is not null;

  public bool ShouldSerializeIgnoreMixedContent() => IgnoreMixedContent is not null;

  public bool ShouldSerializeLinkStyles() => LinkStyles is not null;

  public bool ShouldSerializeListSeparator() => ListSeparator is not null;

  public bool ShouldSerializeMirrorMargins() => MirrorMargins is not null;

  public bool ShouldSerializeNoLineBreaksAfterKinsoku() => NoLineBreaksAfterKinsoku is not null;

  public bool ShouldSerializeNoLineBreaksBeforeKinsoku() => NoLineBreaksBeforeKinsoku is not null;

  public bool ShouldSerializeNoPunctuationKerning() => NoPunctuationKerning is not null;

  public bool ShouldSerializePersistentDocumentId() => PersistentDocumentId is not null;

  public bool ShouldSerializePrintFormsData() => PrintFormsData is not null;

  public bool ShouldSerializePrintFractionalCharacterWidth() => PrintFractionalCharacterWidth is not null;

  public bool ShouldSerializePrintPostScriptOverText() => PrintPostScriptOverText is not null;

  public bool ShouldSerializePrintTwoOnOne() => PrintTwoOnOne is not null;

  public bool ShouldSerializeProofState() => ProofState is not null;

  public bool ShouldSerializeReadModeInkLockDown() => ReadModeInkLockDown is not null;

  public bool ShouldSerializeRemoveDateAndTime() => RemoveDateAndTime is not null;

  public bool ShouldSerializeRemovePersonalInformation() => RemovePersonalInformation is not null;

  public bool ShouldSerializeRevisionView() => RevisionView is not null;

  public bool ShouldSerializeSaveFormsData() => SaveFormsData is not null;

  public bool ShouldSerializeSaveInvalidXml() => SaveInvalidXml is not null;

  public bool ShouldSerializeSavePreviewPicture() => SavePreviewPicture is not null;

  public bool ShouldSerializeSaveSubsetFonts() => SaveSubsetFonts is not null;

  public bool ShouldSerializeSaveThroughXslt() => SaveThroughXslt is not null;

  public bool ShouldSerializeSaveXmlDataOnly() => SaveXmlDataOnly is not null;

  public bool ShouldSerializeSchemaLibrary() => SchemaLibrary is not null;

  public bool ShouldSerializeShapeDefaults() => ShapeDefaults is not null;

  public bool ShouldSerializeShowEnvelope() => ShowEnvelope is not null;

  public bool ShouldSerializeShowXmlTags() => ShowXmlTags is not null;

  public bool ShouldSerializeStrictFirstAndLastChars() => StrictFirstAndLastChars is not null;

  public bool ShouldSerializeStylePaneFormatFilter() => StylePaneFormatFilter is not null;

  public bool ShouldSerializeStylePaneSortMethods() => StylePaneSortMethods is not null;

  public bool ShouldSerializeSummaryLength() => SummaryLength is not null;

  public bool ShouldSerializeThemeFontLanguages() => ThemeFontLanguages is not null;

  public bool ShouldSerializeTrackRevisions() => TrackRevisions is not null;

  public bool ShouldSerializeUICompatibleWith97To2003() => UICompatibleWith97To2003 is not null;

  public bool ShouldSerializeUpdateFieldsOnOpen() => UpdateFieldsOnOpen is not null;

  public bool ShouldSerializeUseXsltWhenSaving() => UseXsltWhenSaving is not null;

  public bool ShouldSerializeView() => View is not null;

  public bool ShouldSerializeWriteProtection() => WriteProtection is not null;

  public bool ShouldSerializeZoom() => Zoom is not null;

  public bool ShouldSerializeDocumentVariables() => DocumentVariables is not null;

  public bool ShouldSerializeMailMerge() => MailMerge is not null;

  public bool ShouldSerializeMathProperties() => MathProperties is not null;
}
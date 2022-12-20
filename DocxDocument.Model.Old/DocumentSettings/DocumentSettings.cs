using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using DocxDocument.Reader;

using Microsoft.Office.Interop.Word;

using Qhta.OpenXMLTools;

namespace DocxDocument.Model;

public class DocumentSettings : DocxBasedElement<WD.Settings>, IDocumentSettings, IEnumerable<KeyValuePair<string, object?>>
{

  public DocumentSettings(WD.Settings element): base(element)
  {
  }


  #region Automation settings

  /// <summary> 
  /// Do Not Include Content in Text Boxes, Footnotes, and Endnotes in Document Statistics
  ///</summary> 
  public bool? DoNotIncludeSubdocsInStats
  {
    get => DocxElement.ReadOnOffType<WD.DoNotIncludeSubdocsInStats>();
    set => DocxElement.WriteOnOffType<WD.DoNotIncludeSubdocsInStats>(value);
  }

  /// <summary> 
  /// Generate Thumbnail For Document On Save
  ///</summary> 
  public bool? SavePreviewPicture
  {
    get => DocxElement.ReadOnOffType<WD.SavePreviewPicture>();
    set => DocxElement.WriteOnOffType<WD.SavePreviewPicture>(value);
  }

  /// <summary> 
  /// Percentage of Document to Use When Generating Summary
  ///</summary> 
  public Percentage? SummaryLength
  {
    get => DocxElement.ReadPercentage<WD.SummaryLength>();
    set => DocxElement.WritePercentage<WD.SummaryLength>(value);
  }

  #endregion

  #region Change Tracking settings

  /// <summary> 
  /// Track Revisions to Document
  ///</summary> 
  public bool? TrackRevisions
  {
    get => DocxElement.ReadOnOffType<WD.TrackRevisions>();
    set => DocxElement.WriteOnOffType<WD.TrackRevisions>(value);
  }

  /// <summary> 
  /// Do Not Track Formatting Revisions When Tracking Revisions
  ///</summary> 
  public bool? DoNotTrackFormatting
  {
    get => DocxElement.ReadOnOffType<WD.DoNotTrackFormatting>();
    set => DocxElement.WriteOnOffType<WD.DoNotTrackFormatting>(value);
  }

  /// <summary> 
  /// Do Not Use Move Syntax When Tracking Revisions
  ///</summary> 
  public bool? DoNotTrackMoves
  {
    get => DocxElement.ReadOnOffType<WD.DoNotTrackMoves>();
    set => DocxElement.WriteOnOffType<WD.DoNotTrackMoves>(value);
  }

  /// <summary> 
  /// Visibility of Annotation Types
  ///</summary> 
  public RevisionView? RevisionView
  {
    get => DocxElement.ReadEnumFlags<RevisionView, WD.RevisionView>();
    set => DocxElement.WriteEnumFlags<RevisionView, WD.RevisionView>(value);
  }

  #endregion

  #region Character Spacing settings

  /// <summary> 
  /// Character-Level Whitespace Compression
  ///</summary> 
  public DM.CharacterSpacing? CharacterSpacingControl
  {
    get => (DM.CharacterSpacing?)DocxElement.ReadEnum<WD.CharacterSpacingValues, WD.CharacterSpacingControl>();
    set => DocxElement.WriteEnum<WD.CharacterSpacingValues, WD.CharacterSpacingControl>((WD.CharacterSpacingValues?)value);
  }

  /// <summary> 
  /// Never Kern Punctuation Characters
  ///</summary> 
  public bool? NoPunctuationKerning
  {
    get => DocxElement.ReadOnOffType<WD.NoPunctuationKerning>();
    set => DocxElement.WriteOnOffType<WD.NoPunctuationKerning>(value);
  }

  #endregion

  #region Compatibility settings

  /// <summary> 
  /// Compatibility settings
  ///</summary> 
  public ICompatibilitySettings? Compatibility
  {
    get => DocxElement.ReadObject<DM.CompatibilitySettings, WD.Compatibility>();
    set => DocxElement.WriteObject<DM.CompatibilitySettings, WD.Compatibility>(value as CompatibilitySettings);
  }

  /// <summary> 
  /// Upgrade Document on Open to Newest Application Version
  ///</summary> 
  public bool? ForceUpgrade
  {
    get => DocxElement.ReadEmptyAsBool<WD.ForceUpgrade>();
    set => DocxElement.WriteEmptyAdBool<WD.ForceUpgrade>(value);
  }

  #endregion

  #region Custom XML settings

  /// <summary> 
  /// Do Not Mark Custom XML Elements With No Namespace As Invalid
  ///</summary> 
  public bool? AlwaysMergeEmptyNamespace
  {
    get => DocxElement.ReadOnOffType<WD.AlwaysMergeEmptyNamespace>();
    set => DocxElement.WriteOnOffType<WD.AlwaysMergeEmptyNamespace>(value);
  }

  /// <summary> 
  /// Use Custom XML Element Names as Default Placeholder Text
  ///</summary> 
  public bool? AlwaysShowPlaceholderText
  {
    get => DocxElement.ReadOnOffType<WD.AlwaysShowPlaceholderText>();
    set => DocxElement.WriteOnOffType<WD.AlwaysShowPlaceholderText>(value);
  }

  /// <summary> 
  /// Show Visual Indicators for Custom XML Markup Start/End Locations
  ///</summary> 
  public bool? ShowXmlTags
  {
    get => DocxElement.ReadOnOffType<WD.ShowXmlTags>();
    set => DocxElement.WriteOnOffType<WD.ShowXmlTags>(value);
  }

  /// <summary> 
  /// Do Not Show Visual Indicator For Invalid Custom XML Markup
  ///</summary> 
  public bool? DoNotDemarcateInvalidXml
  {
    get => DocxElement.ReadOnOffType<WD.DoNotDemarcateInvalidXml>();
    set => DocxElement.WriteOnOffType<WD.DoNotDemarcateInvalidXml>(value);
  }

  /// <summary> 
  /// Do Not Validate Custom XML Markup Against Schemas
  ///</summary> 
  public bool? DoNotValidateAgainstSchema
  {
    get => DocxElement.ReadOnOffType<WD.DoNotValidateAgainstSchema>();
    set => DocxElement.WriteOnOffType<WD.DoNotValidateAgainstSchema>(value);
  }

  /// <summary> 
  /// Ignore Mixed Content When Validating Custom XML Markup
  ///</summary> 
  public bool? IgnoreMixedContent
  {
    get => DocxElement.ReadOnOffType<WD.IgnoreMixedContent>();
    set => DocxElement.WriteOnOffType<WD.IgnoreMixedContent>(value);
  }

  /// <summary> 
  /// Allow Saving Document As XML File When Custom XML Markup Is Invalid
  ///</summary> 
  public bool? SaveInvalidXml
  {
    get => DocxElement.ReadOnOffType<WD.SaveInvalidXml>();
    set => DocxElement.WriteOnOffType<WD.SaveInvalidXml>(value);
  }

  /// <summary> 
  /// Only Save Custom XML Markup
  ///</summary> 
  public bool? SaveXmlDataOnly
  {
    get => DocxElement.ReadOnOffType<WD.SaveXmlDataOnly>();
    set => DocxElement.WriteOnOffType<WD.SaveXmlDataOnly>(value);
  }

  /// <summary> 
  /// Save Document as XML File through Custom XSL Transform
  ///</summary> 
  public bool? UseXsltWhenSaving
  {
    get => DocxElement.ReadOnOffType<WD.UseXsltWhenSaving>();
    set => DocxElement.WriteOnOffType<WD.UseXsltWhenSaving>(value);
  }

  /// <summary> 
  /// Custom XSL Transform To Use When Saving As XML File
  ///</summary> 
  public ISaveThroughXslt? SaveThroughXslt
  {
    get => DocxElement.ReadObject<DM.SaveThroughXslt, WD.SaveThroughXslt>();
    set => DocxElement.WriteObject<DM.SaveThroughXslt, WD.SaveThroughXslt>(value as SaveThroughXslt);
  }

  /// <summary> 
  /// Attached Custom XML Schema
  ///</summary> 
  public string? AttachedSchema
  {
    get => DocxElement.ReadStringType<WD.AttachedSchema>();
    set => DocxElement.WriteStringType<WD.AttachedSchema>(value);
  }

  /// <summary> 
  /// Embedded Custom XML Schema Supplementary Data
  ///</summary> 
  public ISchemaLibrary? SchemaLibrary
  {
    get => DocxElement.ReadCollection<DM.SchemaLibrary, CX.SchemaLibrary>();
    set => DocxElement.WriteCollection<DM.SchemaLibrary, CX.SchemaLibrary>(value as DM.SchemaLibrary);
  }

  #endregion

  #region DisplayGrid settings

  /// <summary> 
  /// Drawing Grid Horizontal Origin Point
  ///</summary> 
  public Twips? DrawingGridHorizontalOrigin
  {
    get => DocxElement.ReadTwipsMeasureType<WD.DrawingGridHorizontalOrigin>();
    set => DocxElement.WriteTwipsMeasureType<WD.DrawingGridHorizontalOrigin>(value);
  }

  /// <summary> 
  /// Drawing Grid Horizontal Grid Unit Size
  ///</summary> 
  public Twips? DrawingGridHorizontalSpacing
  {
    get => DocxElement.ReadTwipsMeasureType<WD.DrawingGridHorizontalSpacing>();
    set => DocxElement.WriteTwipsMeasureType<WD.DrawingGridHorizontalSpacing>(value);
  }

  /// <summary> 
  /// Drawing Grid Vertical Origin Point
  ///</summary> 
  public Twips? DrawingGridVerticalOrigin
  {
    get => DocxElement.ReadTwipsMeasureType<WD.DrawingGridVerticalOrigin>();
    set => DocxElement.WriteTwipsMeasureType<WD.DrawingGridVerticalOrigin>(value);
  }

  /// <summary> 
  /// Drawing Grid Vertical Grid Unit Size
  ///</summary> 
  public Twips? DrawingGridVerticalSpacing
  {
    get => DocxElement.ReadTwipsMeasureType<WD.DrawingGridVerticalSpacing>();
    set => DocxElement.WriteTwipsMeasureType<WD.DrawingGridVerticalSpacing>(value);
  }

  /// <summary> 
  /// Distance between Horizontal Gridlines
  ///</summary> 
  public int? DisplayHorizontalDrawingGrid
  {
    get => DocxElement.ReadUnsignedInt7Type<WD.DisplayHorizontalDrawingGrid>();
    set => DocxElement.WriteUnsignedInt7Type<WD.DisplayHorizontalDrawingGrid>(value);
  }

  /// <summary> 
  /// Distance between Vertical Gridlines
  ///</summary> 
  public int? DisplayVerticalDrawingGrid
  {
    get => DocxElement.ReadUnsignedInt7Type<WD.DisplayVerticalDrawingGrid>();
    set => DocxElement.WriteUnsignedInt7Type<WD.DisplayVerticalDrawingGrid>(value);
  }

  /// <summary> 
  /// Do Not Use Margins for Drawing Grid Origin
  ///</summary> 
  public bool? DoNotUseMarginsForDrawingGridOrigin
  {
    get => DocxElement.ReadOnOffType<WD.DoNotUseMarginsForDrawingGridOrigin>();
    set => DocxElement.WriteOnOffType<WD.DoNotUseMarginsForDrawingGridOrigin>(value);
  }

  #endregion

  #region Mailing settings

  /// <summary> 
  /// Document Classification
  ///</summary> 
  public DM.MailMergeDocumentType? DocumentType
  {
    get => (DM.MailMergeDocumentType?)DocxElement.ReadEnum<WD.DocumentTypeValues, WD.DocumentType>();
    set => DocxElement.WriteEnum<WD.DocumentTypeValues, WD.DocumentType>((WD.DocumentTypeValues?)value);
  }

  /// <summary> 
  /// Show E-Mail Message Header
  ///</summary> 
  public bool? ShowEnvelope
  {
    get => DocxElement.ReadOnOffType<WD.ShowEnvelope>();
    set => DocxElement.WriteOnOffType<WD.ShowEnvelope>(value);
  }

  /// <summary> 
  /// Mail Merge Settings
  ///</summary> 
  public IMailMergeSettings? MailMerge
  {
    get => DocxElement.ReadObject<DM.MailMergeSettings, WD.MailMerge>();
    set => DocxElement.WriteObject<DM.MailMergeSettings, WD.MailMerge>(value as DM.MailMergeSettings);
  }

  #endregion

  #region Field evaluation

  /// <summary> 
  /// Radix Point for Field Code Evaluation
  ///</summary> 
  public string? DecimalSymbol
  {
    get => DocxElement.ReadStringType<WD.DecimalSymbol>();
    set => DocxElement.WriteStringType<WD.DecimalSymbol>(value);
  }

  /// <summary> 
  /// List Separator for Field Code Evaluation
  ///</summary> 
  public string? ListSeparator
  {
    get => DocxElement.ReadStringType<WD.ListSeparator>();
    set => DocxElement.WriteStringType<WD.ListSeparator>(value);
  }

  /// <summary> 
  /// Automatically Recalculate Fields on Open
  ///</summary> 
  public bool? UpdateFieldsOnOpen
  {
    get => DocxElement.ReadOnOffType<WD.UpdateFieldsOnOpen>();
    set => DocxElement.WriteOnOffType<WD.UpdateFieldsOnOpen>(value);
  }

  #endregion

  #region Forms settings

  /// <summary> 
  /// Do Not Show Visual Indicator For Form Fields
  ///</summary> 
  public bool? DoNotShadeFormData
  {
    get => DocxElement.ReadOnOffType<WD.DoNotShadeFormData>();
    set => DocxElement.WriteOnOffType<WD.DoNotShadeFormData>(value);
  }

  /// <summary> 
  /// Only Save Form Field Content
  ///</summary> 
  public bool? SaveFormsData
  {
    get => DocxElement.ReadOnOffType<WD.SaveFormsData>();
    set => DocxElement.WriteOnOffType<WD.SaveFormsData>(value);
  }

  /// <summary> 
  /// Structured Document Tag Placeholder Text Should be Resaved
  ///</summary> 
  public bool? FormsDesign
  {
    get => DocxElement.ReadOnOffType<WD.FormsDesign>();
    set => DocxElement.WriteOnOffType<WD.FormsDesign>(value);
  }

  #endregion

  #region Embed Fonts settings

  /// <summary> 
  /// Subset Fonts When Embedding
  ///</summary> 
  public bool? SaveSubsetFonts
  {
    get => DocxElement.ReadOnOffType<WD.SaveSubsetFonts>();
    set => DocxElement.WriteOnOffType<WD.SaveSubsetFonts>(value);
  }

  /// <summary> 
  /// Embed Common System Fonts
  ///</summary> 
  public bool? EmbedSystemFonts
  {
    get => DocxElement.ReadOnOffType<WD.EmbedSystemFonts>();
    set => DocxElement.WriteOnOffType<WD.EmbedSystemFonts>(value);
  }

  /// <summary> 
  /// Embed TrueType Fonts
  ///</summary> 
  public bool? EmbedTrueTypeFonts
  {
    get => DocxElement.ReadOnOffType<WD.EmbedTrueTypeFonts>();
    set => DocxElement.WriteOnOffType<WD.EmbedTrueTypeFonts>(value);
  }

  #endregion

  #region Graphics settings

  /// <summary> 
  /// Do Not Automatically Compress Images
  ///</summary> 
  public bool? DoNotAutoCompressPictures
  {
    get => DocxElement.ReadOnOffType<WD.DoNotAutoCompressPictures>();
    set => DocxElement.WriteOnOffType<WD.DoNotAutoCompressPictures>(value);
  }

  /// <summary> 
  /// This setting is ignored by images that have dots per inch (DPI) specified by useLocalDpi .
  /// This setting is also ignored when doNotAutoCompressPictures is set to true.
  ///</summary> 
  public int? DefaultImageDpi
  {
    get => DocxElement.ReadInteger<W14.DefaultImageDpi>();
    set => DocxElement.WriteInteger<W14.DefaultImageDpi>(value);
  }

  /// <summary> 
  /// When true, the cropped-out areas of the images are not to be saved.
  /// Rather, the images saved are the results of applying imgProps on the original images. 
  ///</summary> 
  public bool? DiscardImageEditingData
  {
    get => DocxElement.ReadW14OnOffType<W14.DiscardImageEditingData>();
    set => DocxElement.WriteW14OnOffType<W14.DiscardImageEditingData>(value);
  }

  /// <summary> 
  /// Specifies how the datapoint properties and datalabels in all charts in this document behave.
  /// If true then they follow their reference.
  /// If false then they follow their position in the chart.
  ///</summary> 
  public bool? ChartTrackingRefBased
  {
    get => DocxElement.ReadW15OnOffType<W15.ChartTrackingRefBased>();
    set => DocxElement.WriteW15OnOffType<W15.ChartTrackingRefBased>(value);
  }

  /// <summary> 
  /// Specifies the defaults that are used when creating new shapes.
  ///</summary> 
  public DM.ShapeDefaults? ShapeDefaults
  {
    get => DocxElement.ReadTypedObject<DM.ShapeDefaults, WD.ShapeDefaults, VO.ShapeDefaults>();
    set => DocxElement.WriteTypedObject<DM.ShapeDefaults, WD.ShapeDefaults, VO.ShapeDefaults>(value);
  }
#endregion

#region Hyphenation settings

/// <summary> 
/// Automatically Hyphenate Document Contents When Displayed
///</summary> 
public bool? AutoHyphenation
  {
    get => DocxElement.ReadOnOffType<WD.AutoHyphenation>();
    set => DocxElement.WriteOnOffType<WD.AutoHyphenation>(value);
  }

  /// <summary> 
  /// Do Not Hyphenate Words in ALL CAPITAL LETTERS
  ///</summary> 
  public bool? DoNotHyphenateCaps
  {
    get => DocxElement.ReadOnOffType<WD.DoNotHyphenateCaps>();
    set => DocxElement.WriteOnOffType<WD.DoNotHyphenateCaps>(value);
  }

  /// <summary> 
  /// Maximum Number of Consecutively Hyphenated Lines
  ///</summary> 
  public int? ConsecutiveHyphenLimit
  {
    get => DocxElement.ReadInteger<WD.ConsecutiveHyphenLimit>();
    set => DocxElement.WriteInteger<WD.ConsecutiveHyphenLimit>(value);
  }

  public Twips? HyphenationZone
  {
    get => DocxElement.ReadTwipsMeasureType<WD.HyphenationZone>();
    set => DocxElement.WriteTwipsMeasureType<WD.HyphenationZone>(value);
  }

  #endregion

  #region Kinsoku line breaking settings

  /// <summary> 
  /// Use Strict Kinsoku Rules for Japanese Text
  ///</summary> 
  public bool? StrictFirstAndLastChars
  {
    get => DocxElement.ReadOnOffType<WD.StrictFirstAndLastChars>();
    set => DocxElement.WriteOnOffType<WD.StrictFirstAndLastChars>(value);
  }

  /// <summary> 
  /// Custom Set of Characters Which Cannot End a Line
  ///</summary> 
  public LangText? NoLineBreaksAfter
  {
    get => DocxElement.ReadLangText<WD.NoLineBreaksAfterKinsoku>();
    set => DocxElement.WriteLangText<WD.NoLineBreaksAfterKinsoku>(value);
  }

  /// <summary> 
  /// Custom Set Of Characters Which Cannot Begin A Line
  ///</summary> 
  public LangText? NoLineBreaksBefore
  {
    get => DocxElement.ReadLangText<WD.NoLineBreaksBeforeKinsoku>();
    set => DocxElement.WriteLangText<WD.NoLineBreaksBeforeKinsoku>(value);
  }

  #endregion

  #region Layout settings

  /// <summary> 
  /// Mirror Page Margins
  ///</summary> 
  public bool? MirrorMargins
  {
    get => DocxElement.ReadOnOffType<WD.MirrorMargins>();
    set => DocxElement.WriteOnOffType<WD.MirrorMargins>(value);
  }

  /// <summary> 
  /// Different Even/Odd Page Headers and Footers
  ///</summary> 
  public bool? EvenAndOddHeaders
  {
    get => DocxElement.ReadOnOffType<WD.EvenAndOddHeaders>();
    set => DocxElement.WriteOnOffType<WD.EvenAndOddHeaders>(value);
  }

  /// <summary> 
  /// Page Border Excludes Footer
  ///</summary> 
  public bool? BordersDoNotSurroundFooter
  {
    get => DocxElement.ReadOnOffType<WD.BordersDoNotSurroundFooter>();
    set => DocxElement.WriteOnOffType<WD.BordersDoNotSurroundFooter>(value);
  }

  /// <summary> 
  /// Page Border Excludes Header
  ///</summary> 
  public bool? BordersDoNotSurroundHeader
  {
    get => DocxElement.ReadOnOffType<WD.BordersDoNotSurroundHeader>();
    set => DocxElement.WriteOnOffType<WD.BordersDoNotSurroundHeader>(value);
  }

  /// <summary> 
  /// Align Paragraph and Table Borders with Page Border
  ///</summary> 
  public bool? AlignBorderAndEdges
  {
    get => DocxElement.ReadOnOffType<WD.AlignBorderAndEdges>();
    set => DocxElement.WriteOnOffType<WD.AlignBorderAndEdges>(value);
  }

  /// <summary> 
  /// Display Background Objects When Displaying Document
  ///</summary> 
  public bool? DisplayBackgroundShape
  {
    get => DocxElement.ReadOnOffType<WD.DisplayBackgroundShape>();
    set => DocxElement.WriteOnOffType<WD.DisplayBackgroundShape>(value);
  }

  /// <summary> 
  /// Position Gutter At Top of Page
  ///</summary> 
  public bool? GutterAtTop
  {
    get => DocxElement.ReadOnOffType<WD.GutterAtTop>();
    set => DocxElement.WriteOnOffType<WD.GutterAtTop>(value);
  }

  /// <summary> 
  /// Distance Between Automatic Tab Stops
  ///</summary> 
  public Twips? DefaultTabStop
  {
    get => DocxElement.ReadNonNegativeShortType<WD.DefaultTabStop>();
    set => DocxElement.WriteNonNegativeShortType<WD.DefaultTabStop>(value);
  }

  /// <summary> 
  /// Freeze Document Layout
  ///</summary> 
  public IReadModeInkLockDown? ReadModeInkLockDown
  {
    get => DocxElement.ReadObject<DM.ReadModeInkLockDown, WD.ReadModeInkLockDown>();
    set => DocxElement.WriteObject<DM.ReadModeInkLockDown, WD.ReadModeInkLockDown>(value as DM.ReadModeInkLockDown);
  }

  #endregion

  #region Printing settings

  /// <summary> 
  /// Only Print Form Field Content
  ///</summary> 
  public bool? PrintFormsData
  {
    get => DocxElement.ReadOnOffType<WD.PrintFormsData>();
    set => DocxElement.WriteOnOffType<WD.PrintFormsData>(value);
  }

  /// <summary> 
  /// Print Fractional Character Widths
  ///</summary> 
  public bool? PrintFractionalCharacterWidth
  {
    get => DocxElement.ReadOnOffType<WD.PrintFractionalCharacterWidth>();
    set => DocxElement.WriteOnOffType<WD.PrintFractionalCharacterWidth>(value);
  }

  /// <summary> 
  /// Print PostScript Codes With Document Text
  ///</summary> 
  public bool? PrintPostScriptOverText
  {
    get => DocxElement.ReadOnOffType<WD.PrintPostScriptOverText>();
    set => DocxElement.WriteOnOffType<WD.PrintPostScriptOverText>(value);
  }

  /// <summary> 
  /// Print Two Pages Per Sheet
  ///</summary> 
  public bool? PrintTwoOnOne
  {
    get => DocxElement.ReadOnOffType<WD.PrintTwoOnOne>();
    set => DocxElement.WriteOnOffType<WD.PrintTwoOnOne>(value);
  }

  /// <summary> 
  /// Book Fold Printing
  ///</summary> 
  public bool? BookFoldPrinting
  {
    get => DocxElement.ReadOnOffType<WD.BookFoldPrinting>();
    set => DocxElement.WriteOnOffType<WD.BookFoldPrinting>(value);
  }

  /// <summary> 
  /// Reverse Book Fold Printing
  ///</summary> 
  public bool? BookFoldReversePrinting
  {
    get => DocxElement.ReadOnOffType<WD.BookFoldReversePrinting>();
    set => DocxElement.WriteOnOffType<WD.BookFoldReversePrinting>(value);
  }

  /// <summary> 
  /// Number of Pages Per Booklet
  ///</summary> 
  public int? BookFoldPrintingSheets
  {
    get => DocxElement.ReadNonNegativeShortType<WD.BookFoldPrintingSheets>();
    set => DocxElement.WriteNonNegativeShortType<WD.BookFoldPrintingSheets>(value);
  }

  #endregion

  #region Proofing settings

  /// <summary> 
  /// Grammar Checking Settings
  ///</summary> 
  public IWritingStyle? ActiveWritingStyle
  {
    get => DocxElement.ReadObject<DM.WritingStyle, WD.ActiveWritingStyle>();
    set => DocxElement.WriteObject<DM.WritingStyle, WD.ActiveWritingStyle>(value as DM.WritingStyle);
  }

  /// <summary> 
  /// Do Not Display Visual Indication of Grammatical Errors
  ///</summary> 
  public bool? HideGrammaticalErrors
  {
    get => DocxElement.ReadOnOffType<WD.HideGrammaticalErrors>();
    set => DocxElement.WriteOnOffType<WD.HideGrammaticalErrors>(value);
  }

  /// <summary> 
  /// Do Not Display Visual Indication of Spelling Errors
  ///</summary> 
  public bool? HideSpellingErrors
  {
    get => DocxElement.ReadOnOffType<WD.HideSpellingErrors>();
    set => DocxElement.WriteOnOffType<WD.HideSpellingErrors>(value);
  }


  /// <summary> 
  /// Spelling and Grammatical Checking State
  ///</summary> 
  public DM.ProofState? ProofState
  {
    get => DocxElement.ReadObject<DM.ProofState, WD.ProofState>();
    set => DocxElement.WriteObject<DM.ProofState, WD.ProofState>(value);
  }

  #endregion

  #region Document Protection settings

  /// <summary> 
  /// Document Editing Restrictions
  ///</summary> 
  public IDocumentProtection? DocumentProtection
  {
    get => DocxElement.ReadObject<DM.DocumentProtection, WD.DocumentProtection>();
    set => DocxElement.WriteObject<DM.DocumentProtection, WD.DocumentProtection>(value as DocumentProtection);
  }

  /// <summary> 
  /// Write Protection
  ///</summary> 
  public IWriteProtection? WriteProtection
  {
    get => DocxElement.ReadObject<DM.WriteProtection, WD.WriteProtection>();
    set => DocxElement.WriteObject<DM.WriteProtection, WD.WriteProtection>(value as WriteProtection);
  }

  /// <summary> 
  /// Remove Date and Time from Annotations
  ///</summary> 
  public bool? RemoveDateAndTime
  {
    get => DocxElement.ReadOnOffType<WD.RemoveDateAndTime>();
    set => DocxElement.WriteOnOffType<WD.RemoveDateAndTime>(value);
  }

  /// <summary> 
  /// Remove Personal Information from Document Properties
  ///</summary> 
  public bool? RemovePersonalInformation
  {
    get => DocxElement.ReadOnOffType<WD.RemovePersonalInformation>();
    set => DocxElement.WriteOnOffType<WD.RemovePersonalInformation>(value);
  }

  /// <summary> 
  /// Allow Automatic Formatting to Override Formatting Protection Settings
  ///</summary> 
  public bool? AutoFormatOverride
  {
    get => DocxElement.ReadOnOffType<WD.AutoFormatOverride>();
    set => DocxElement.WriteOnOffType<WD.AutoFormatOverride>(value);
  }

  #endregion

  #region Style and Theme settings

  /// <summary> 
  /// Prevent Replacement of Styles Part
  ///</summary> 
  public bool? StyleLockStylesPart
  {
    get => DocxElement.ReadOnOffType<WD.StyleLockStylesPart>();
    set => DocxElement.WriteOnOffType<WD.StyleLockStylesPart>(value);
  }

  /// <summary> 
  /// Prevent Modification of Themes Part
  ///</summary> 
  public bool? StyleLockThemesPart
  {
    get => DocxElement.ReadOnOffType<WD.StyleLockThemesPart>();
    set => DocxElement.WriteOnOffType<WD.StyleLockThemesPart>(value);
  }

  /// <summary> 
  /// Paragraph Style Applied to Automatically Generated Paragraphs
  ///</summary> 
  public string? ClickAndTypeStyle
  {
    get => DocxElement.ReadString253Type<WD.ClickAndTypeStyle>();
    set => DocxElement.WriteString253Type<WD.ClickAndTypeStyle>(value);
  }

  /// <summary> 
  /// Default Table Style for Newly Inserted Tables
  ///</summary> 
  public string? DefaultTableStyle
  {
    get => DocxElement.ReadString253Type<WD.DefaultTableStyle>();
    set => DocxElement.WriteString253Type<WD.DefaultTableStyle>(value);
  }

  /// <summary> 
  /// Automatically Update Styles From Document Template
  ///</summary> 
  public bool? LinkStyles
  {
    get => DocxElement.ReadOnOffType<WD.LinkStyles>();
    set => DocxElement.WriteOnOffType<WD.LinkStyles>(value);
  }

  /// <summary> 
  /// Attached Document Template
  ///</summary> 
  public Relationship? AttachedTemplate
  {
    get => DocxElement.ReadRelationshipType<WD.AttachedTemplate>();
    set => DocxElement.WriteRelationshipType<WD.AttachedTemplate>(value);
  }

  /// <summary> 
  /// Theme Color Mappings
  ///</summary> 
  public IColorSchemeMapping? ColorSchemeMapping
  {
    get => DocxElement.ReadObject<DM.ColorSchemeMapping, WD.ColorSchemeMapping>();
    set => DocxElement.WriteObject<DM.ColorSchemeMapping, WD.ColorSchemeMapping>((DM.ColorSchemeMapping?)value);
  }

  /// <summary> 
  /// Theme Font Languages
  ///</summary> 
  public IScriptTypeLanguage? ThemeFontLanguages
  {
    get => DocxElement.ReadObject<DM.ScriptTypeLanguage, WD.ThemeFontLanguages>();
    set => DocxElement.WriteObject<DM.ScriptTypeLanguage, WD.ThemeFontLanguages>(value as ScriptTypeLanguage);
  }

  /// <summary> 
  /// Suggested Filtering for List of Document Styles
  ///</summary> 
  public StylePaneFormatFilter? StylePaneFormatFilter
  {
    get => DocxElement.ReadEnumFlags<DM.StylePaneFormatFilter, WD.StylePaneFormatFilter>();
    set => DocxElement.WriteEnumFlags<DM.StylePaneFormatFilter, WD.StylePaneFormatFilter>(value);
  }

  /// <summary> 
  /// Suggested Sorting for List of Document Styles
  ///</summary> 
  public DM.StylePaneSortMethods? StylePaneSortMethods
  {
    get => (DM.StylePaneSortMethods?)DocxElement.ReadEnum<WD.StylePaneSortMethodsValues, WD.StylePaneSortMethods>();
    set => DocxElement.WriteEnum<WD.StylePaneSortMethodsValues, WD.StylePaneSortMethods>((WD.StylePaneSortMethodsValues?)value);
  }

  #endregion

  #region Document View settings

  /// <summary> 
  /// Do Not Display Visual Boundary For Header/Footer or Between Pages
  ///</summary> 
  public bool? DoNotDisplayPageBoundaries
  {
    get => DocxElement.ReadOnOffType<WD.DoNotDisplayPageBoundaries>();
    set => DocxElement.WriteOnOffType<WD.DoNotDisplayPageBoundaries>(value);
  }

  /// <summary> 
  /// Document View Setting
  ///</summary> 
  public DM.DocView? View
  {
    get => (DM.DocView?)DocxElement.ReadEnum<WD.ViewValues, WD.View>();
    set => DocxElement.WriteEnum<WD.ViewValues, WD.View>((WD.ViewValues?)value);
  }

  /// <summary> 
  /// Magnification Setting
  ///</summary> 
  public IZoom? Zoom
  {
    get => DocxElement.ReadObject<DM.Zoom, WD.Zoom>();
    set => DocxElement.WriteObject<DM.Zoom, WD.Zoom>(value as DM.Zoom);
  }

  #endregion

  #region Other settings

  /// <summary> 
  /// Caption Settings
  ///</summary> 
  public ICaptions? Captions
  {
    get => DocxElement.ReadCollection<Captions, WD.Captions>();
    set => DocxElement.WriteCollection<Captions, WD.Captions>(value as DM.Captions);
  }

  /// <summary> 
  /// Document Variables
  ///</summary> 
  public IDocumentVariables? DocumentVariables
  {
    get => DocxElement.ReadObject<DM.DocumentVariables, WD.DocumentVariables>();
    set => DocxElement.WriteObject<DM.DocumentVariables, WD.DocumentVariables>(value as DM.DocumentVariables);
  }


  /// <summary> 
  /// Document-Wide Endnote Properties
  ///</summary> 
  public IEndnoteProperties? EndnoteDocumentWideProperties
  {
    get => DocxElement.ReadObject<DM.EndnoteProperties, WD.EndnoteProperties>();
    set => DocxElement.WriteObject<DM.EndnoteProperties, WD.EndnoteProperties>(value as EndnoteProperties);
  }

  /// <summary> 
  /// Document-Wide Footnote Properties
  ///</summary> 
  public IFootnoteProperties? FootnoteDocumentWideProperties
  {
    get => DocxElement.ReadObject<DM.FootnoteProperties, WD.FootnoteProperties>();
    set => DocxElement.WriteObject<DM.FootnoteProperties, WD.FootnoteProperties>(value as FootnoteProperties);
  }

  /// <summary> 
  /// Math Properties
  ///</summary> 
  public IMathProperties? MathProperties
  {
    get => DocxElement.ReadObject<DM.MathProperties, OM.MathProperties>();
    set => DocxElement.WriteObject<DM.MathProperties, OM.MathProperties>(value as MathProperties);
  }

  #endregion

  public bool IsEmpty()
  {
    foreach (var propInfo in this.GetType().GetProperties())
      if (propInfo.GetCustomAttribute<XmlIgnoreAttribute>() == null && propInfo.GetValue(this, null) != null)
        return false;
    return true;
  }

  [XmlIgnore]
  public int Count => DocxElement.Elements().Count();


  public IEnumerator<KeyValuePair<string, object?>> GetEnumerator()
  {
    foreach (var prop in this.GetType().GetProperties())
    {
      if (prop.CanRead && prop.GetCustomAttribute<XmlIgnoreAttribute>() is null)
      {
        var val = prop.GetValue(this, new object[0]);
        if (val != null)
          yield return new KeyValuePair<string, object?>(prop.Name, val);
      }
    }
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return GetEnumerator();
  }




}
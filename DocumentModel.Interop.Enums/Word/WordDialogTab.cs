namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the active tab when the specified dialog box is displayed.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdworddialogtab?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdWordDialogTab")]
public enum WordDialogTab
{
  /// <summary>
  /// General tab of the Options dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsOptionsTabGeneral")]
  ToolsOptionsTabGeneral = 203,
  /// <summary>
  /// View tab of the Options dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsOptionsTabView")]
  ToolsOptionsTabView = 204,
  /// <summary>
  /// Print tab of the Options dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsOptionsTabPrint")]
  ToolsOptionsTabPrint = 208,
  /// <summary>
  /// Save tab of the Options dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsOptionsTabSave")]
  ToolsOptionsTabSave = 209,
  /// <summary>
  /// Spelling and Grammar tab of the Options dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsOptionsTabProofread")]
  ToolsOptionsTabProofread = 211,
  /// <summary>
  /// User Information tab of the Options dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsOptionsTabUserInfo")]
  ToolsOptionsTabUserInfo = 213,
  /// <summary>
  /// Edit tab of the Options dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsOptionsTabEdit")]
  ToolsOptionsTabEdit = 224,
  /// <summary>
  /// File Locations tab of the Options dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsOptionsTabFileLocations")]
  ToolsOptionsTabFileLocations = 225,
  /// <summary>
  /// Track Changes tab of the Options dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsOptionsTabTrackChanges")]
  ToolsOptionsTabTrackChanges = 386,
  /// <summary>
  /// Compatibility tab of the Options dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsOptionsTabCompatibility")]
  ToolsOptionsTabCompatibility = 525,
  /// <summary>
  /// Asian Typography tab of the Options dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsOptionsTabTypography")]
  ToolsOptionsTabTypography = 739,
  /// <summary>
  /// Hangul Hanja Conversion tab of the Options dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsOptionsTabHangulHanjaConversion")]
  ToolsOptionsTabHangulHanjaConversion = 786,
  /// <summary>
  /// Not supported.
  /// </summary>
  [InteropEnumValue("wdDialogToolsOptionsTabFuzzy")]
  ToolsOptionsTabFuzzy = 790,
  /// <summary>
  /// Complex Scripts tab of the Options dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsOptionsTabBidi")]
  ToolsOptionsTabBidi = 1029,
  /// <summary>
  /// Not supported.
  /// </summary>
  [InteropEnumValue("wdDialogToolsOptionsTabAcetate")]
  ToolsOptionsTabAcetate = 1266,
  /// <summary>
  /// Security tab of the Options dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsOptionsTabSecurity")]
  ToolsOptionsTabSecurity = 1361,
  /// <summary>
  /// Margins tab of the Page Setup dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogFilePageSetupTabMargins")]
  FilePageSetupTabMargins = 150000,
  /// <summary>
  /// Paper tab of the Page Setup dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogFilePageSetupTabPaper")]
  FilePageSetupTabPaper = 150001,
  /// <summary>
  /// Layout tab of the Page Setup dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogFilePageSetupTabLayout")]
  FilePageSetupTabLayout = 150003,
  /// <summary>
  /// Margins tab of the Page Setup dialog box, with Apply To drop-down list active.
  /// </summary>
  [InteropEnumValue("wdDialogFilePageSetupTabCharsLines")]
  FilePageSetupTabCharsLines = 150004,
  /// <summary>
  /// Symbols tab of the Symbol dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogInsertSymbolTabSymbols")]
  InsertSymbolTabSymbols = 200000,
  /// <summary>
  /// Special Characters tab of the Symbol dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogInsertSymbolTabSpecialCharacters")]
  InsertSymbolTabSpecialCharacters = 200001,
  /// <summary>
  /// All Footnotes tab of the Note Options dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogNoteOptionsTabAllFootnotes")]
  NoteOptionsTabAllFootnotes = 300000,
  /// <summary>
  /// All Endnotes tab of the Note Options dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogNoteOptionsTabAllEndnotes")]
  NoteOptionsTabAllEndnotes = 300001,
  /// <summary>
  /// Index tab of the Index and Tables dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogInsertIndexAndTablesTabIndex")]
  InsertIndexAndTablesTabIndex = 400000,
  /// <summary>
  /// Table of Contents tab of the Index and Tables dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogInsertIndexAndTablesTabTableOfContents")]
  InsertIndexAndTablesTabTableOfContents = 400001,
  /// <summary>
  /// Table of Figures tab of the Index and Tables dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogInsertIndexAndTablesTabTableOfFigures")]
  InsertIndexAndTablesTabTableOfFigures = 400002,
  /// <summary>
  /// Table of Authorities tab of the Index and Tables dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogInsertIndexAndTablesTabTableOfAuthorities")]
  InsertIndexAndTablesTabTableOfAuthorities = 400003,
  /// <summary>
  /// Styles tab of the Organizer dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogOrganizerTabStyles")]
  OrganizerTabStyles = 500000,
  /// <summary>
  /// AutoText tab of the Organizer dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogOrganizerTabAutoText")]
  OrganizerTabAutoText = 500001,
  /// <summary>
  /// Command Bars tab of the Organizer dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogOrganizerTabCommandBars")]
  OrganizerTabCommandBars = 500002,
  /// <summary>
  /// Macros tab of the Organizer dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogOrganizerTabMacros")]
  OrganizerTabMacros = 500003,
  /// <summary>
  /// Font tab of the Font dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogFormatFontTabFont")]
  FormatFontTabFont = 600000,
  /// <summary>
  /// Character Spacing tab of the Font dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogFormatFontTabCharacterSpacing")]
  FormatFontTabCharacterSpacing = 600001,
  /// <summary>
  /// Animation tab of the Font dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogFormatFontTabAnimation")]
  FormatFontTabAnimation = 600002,
  /// <summary>
  /// Borders tab of the Borders dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogFormatBordersAndShadingTabBorders")]
  FormatBordersAndShadingTabBorders = 700000,
  /// <summary>
  /// Page Border tab of the Borders dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogFormatBordersAndShadingTabPageBorder")]
  FormatBordersAndShadingTabPageBorder = 700001,
  /// <summary>
  /// Shading tab of the Borders dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogFormatBordersAndShadingTabShading")]
  FormatBordersAndShadingTabShading = 700002,
  /// <summary>
  /// Envelopes tab of the Envelopes and Labels dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsEnvelopesAndLabelsTabEnvelopes")]
  ToolsEnvelopesAndLabelsTabEnvelopes = 800000,
  /// <summary>
  /// Labels tab of the Envelopes and Labels dialog box. wdDialogFormatParagraphTabIndentsAndSpacing 1000000Indents
  /// and Spacing tab of the Paragraph dialog box. wdDialogFormatParagraphTabTextFlow 1000001Line and Page Breaks
  /// tab of the Paragraph dialog box. wdDialogFormatParagraphTabTeisai 1000002Line and Page Breaks tab of the
  /// Paragraph dialog box, with choices appropriate for Asian text. wdDialogFormatDrawingObjectTabColorsAndLines
  /// 1200000Colors and Lines tab of the Format Drawing Object dialog box. wdDialogFormatDrawingObjectTabSize
  /// 1200001Size tab of the Format Drawing Object dialog box. wdDialogFormatDrawingObjectTabPosition
  /// 1200002Position tab of the Format Drawing Object dialog box. wdDialogFormatDrawingObjectTabWrapping
  /// 1200003Wrapping tab of the Format Drawing Object dialog box. wdDialogFormatDrawingObjectTabPicture
  /// 1200004Picture tab of the Format Drawing Object dialog box. wdDialogFormatDrawingObjectTabTextbox
  /// 1200005Textbox tab of the Format Drawing Object dialog box. wdDialogFormatDrawingObjectTabWeb 1200006Web tab
  /// of the Format Drawing Object dialog box. wdDialogFormatDrawingObjectTabHR 1200007Colors and Lines tab of the
  /// Format Drawing Object dialog box. wdDialogToolsAutoCorrectExceptionsTabFirstLetter 1400000First Letter tab of
  /// the AutoCorrect Exceptions dialog box. wdDialogToolsAutoCorrectExceptionsTabInitialCaps 1400001Initial Caps
  /// tab of the AutoCorrect Exceptions dialog box.
  /// wdDialogToolsAutoCorrectExceptionsTabHangulAndAlphabet1400002Hangul and Alphabet tab of the AutoCorrect
  /// Exceptions dialog box. Available only in multi-language versions. wdDialogToolsAutoCorrectExceptionsTabIac
  /// 1400003Other Corrections tab of the AutoCorrect Exceptions dialog box.
  /// wdDialogFormatBulletsAndNumberingTabBulleted 1500000Bulleted tab of the Bullets and Numbering dialog box.
  /// wdDialogFormatBulletsAndNumberingTabNumbered 1500001Numbered tab of the Bullets and Numbering dialog box.
  /// wdDialogFormatBulletsAndNumberingTabOutlineNumbered1500002Outline Numbered tab of the Bullets and Numbering
  /// dialog box. wdDialogLetterWizardTabLetterFormat 1600000Letter Format tab of the Letter Wizard dialog box.
  /// wdDialogLetterWizardTabRecipientInfo 1600001Recipient Info tab of the Letter Wizard dialog box.
  /// wdDialogLetterWizardTabOtherElements 1600002Other Elements tab of the Letter Wizard dialog box.
  /// wdDialogLetterWizardTabSenderInfo 1600003Sender Info tab of the Letter Wizard dialog box.
  /// wdDialogToolsAutoManagerTabAutoCorrect 1700000AutoCorrect tab of the AutoCorrect dialog box.
  /// wdDialogToolsAutoManagerTabAutoFormatAsYouType 1700001Format As You Type tab of the AutoCorrect dialog box.
  /// wdDialogToolsAutoManagerTabAutoText 1700002AutoText tab of the AutoCorrect dialog box.
  /// wdDialogToolsAutoManagerTabAutoFormat 1700003AutoFormat tab of the AutoCorrect dialog box.
  /// wdDialogToolsAutoManagerTabSmartTags 1700004Smart Tags tab of the AutoCorrect dialog box.
  /// wdDialogTablePropertiesTabTable 1800000Table tab of the Table Properties dialog box.
  /// wdDialogTablePropertiesTabRow 1800001Row tab of the Table Properties dialog box.
  /// wdDialogTablePropertiesTabColumn 1800002Column tab of the Table Properties dialog box.
  /// wdDialogTablePropertiesTabCell 1800003Cell tab of the Table Properties dialog box.
  /// wdDialogEmailOptionsTabSignature 1900000E-mail Signature tab of the E- mail Options dialog box.
  /// wdDialogEmailOptionsTabStationary 1900001Personal Stationary tab of the E-mail Options dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsEnvelopesAndLabelsTabLabels")]
  ToolsEnvelopesAndLabelsTabLabels = 800001,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [InteropEnumValue("wdDialogFormatParagraphTabIndentsAndSpacing")]
  FormatParagraphTabIndentsAndSpacing = 1000000,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [InteropEnumValue("wdDialogFormatParagraphTabTextFlow")]
  FormatParagraphTabTextFlow = 1000001,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [InteropEnumValue("wdDialogFormatParagraphTabTeisai")]
  FormatParagraphTabTeisai = 1000002,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [InteropEnumValue("wdDialogFormatDrawingObjectTabColorsAndLines")]
  FormatDrawingObjectTabColorsAndLines = 1200000,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [InteropEnumValue("wdDialogFormatDrawingObjectTabSize")]
  FormatDrawingObjectTabSize = 1200001,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [InteropEnumValue("wdDialogFormatDrawingObjectTabPosition")]
  FormatDrawingObjectTabPosition = 1200002,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [InteropEnumValue("wdDialogFormatDrawingObjectTabWrapping")]
  FormatDrawingObjectTabWrapping = 1200003,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [InteropEnumValue("wdDialogFormatDrawingObjectTabPicture")]
  FormatDrawingObjectTabPicture = 1200004,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [InteropEnumValue("wdDialogFormatDrawingObjectTabTextbox")]
  FormatDrawingObjectTabTextbox = 1200005,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [InteropEnumValue("wdDialogFormatDrawingObjectTabWeb")]
  FormatDrawingObjectTabWeb = 1200006,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [InteropEnumValue("wdDialogFormatDrawingObjectTabHR")]
  FormatDrawingObjectTabHR = 1200007,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [InteropEnumValue("wdDialogToolsAutoCorrectExceptionsTabFirstLetter")]
  ToolsAutoCorrectExceptionsTabFirstLetter = 1400000,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [InteropEnumValue("wdDialogToolsAutoCorrectExceptionsTabInitialCaps")]
  ToolsAutoCorrectExceptionsTabInitialCaps = 1400001,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [InteropEnumValue("wdDialogToolsAutoCorrectExceptionsTabHangulAndAlphabet")]
  ToolsAutoCorrectExceptionsTabHangulAndAlphabet = 1400002,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [InteropEnumValue("wdDialogToolsAutoCorrectExceptionsTabIac")]
  ToolsAutoCorrectExceptionsTabIac = 1400003,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [InteropEnumValue("wdDialogFormatBulletsAndNumberingTabBulleted")]
  FormatBulletsAndNumberingTabBulleted = 1500000,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [InteropEnumValue("wdDialogFormatBulletsAndNumberingTabNumbered")]
  FormatBulletsAndNumberingTabNumbered = 1500001,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [InteropEnumValue("wdDialogFormatBulletsAndNumberingTabOutlineNumbered")]
  FormatBulletsAndNumberingTabOutlineNumbered = 1500002,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [InteropEnumValue("wdDialogLetterWizardTabLetterFormat")]
  LetterWizardTabLetterFormat = 1600000,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [InteropEnumValue("wdDialogLetterWizardTabRecipientInfo")]
  LetterWizardTabRecipientInfo = 1600001,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [InteropEnumValue("wdDialogLetterWizardTabOtherElements")]
  LetterWizardTabOtherElements = 1600002,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [InteropEnumValue("wdDialogLetterWizardTabSenderInfo")]
  LetterWizardTabSenderInfo = 1600003,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [InteropEnumValue("wdDialogToolsAutoManagerTabAutoCorrect")]
  ToolsAutoManagerTabAutoCorrect = 1700000,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [InteropEnumValue("wdDialogToolsAutoManagerTabAutoFormatAsYouType")]
  ToolsAutoManagerTabAutoFormatAsYouType = 1700001,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [InteropEnumValue("wdDialogToolsAutoManagerTabAutoText")]
  ToolsAutoManagerTabAutoText = 1700002,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [InteropEnumValue("wdDialogToolsAutoManagerTabAutoFormat")]
  ToolsAutoManagerTabAutoFormat = 1700003,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [InteropEnumValue("wdDialogToolsAutoManagerTabSmartTags")]
  ToolsAutoManagerTabSmartTags = 1700004,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [InteropEnumValue("wdDialogTablePropertiesTabTable")]
  TablePropertiesTabTable = 1800000,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [InteropEnumValue("wdDialogTablePropertiesTabRow")]
  TablePropertiesTabRow = 1800001,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [InteropEnumValue("wdDialogTablePropertiesTabColumn")]
  TablePropertiesTabColumn = 1800002,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [InteropEnumValue("wdDialogTablePropertiesTabCell")]
  TablePropertiesTabCell = 1800003,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [InteropEnumValue("wdDialogEmailOptionsTabSignature")]
  EmailOptionsTabSignature = 1900000,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [InteropEnumValue("wdDialogEmailOptionsTabStationary")]
  EmailOptionsTabStationary = 1900001,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [InteropEnumValue("wdDialogEmailOptionsTabQuoting")]
  EmailOptionsTabQuoting = 1900002,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [InteropEnumValue("wdDialogWebOptionsGeneral")]
  WebOptionsGeneral = 2000000,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [InteropEnumValue("wdDialogWebOptionsBrowsers")]
  WebOptionsBrowsers = 2000000,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [InteropEnumValue("wdDialogWebOptionsFiles")]
  WebOptionsFiles = 2000001,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [InteropEnumValue("wdDialogWebOptionsPictures")]
  WebOptionsPictures = 2000002,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [InteropEnumValue("wdDialogWebOptionsEncoding")]
  WebOptionsEncoding = 2000003,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [InteropEnumValue("wdDialogWebOptionsFonts")]
  WebOptionsFonts = 2000004,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [InteropEnumValue("wdDialogTemplates")]
  Templates = 2100000,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [InteropEnumValue("wdDialogTemplatesXMLSchema")]
  TemplatesXMLSchema = 2100001,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [InteropEnumValue("wdDialogTemplatesXMLExpansionPacks")]
  TemplatesXMLExpansionPacks = 2100002,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [InteropEnumValue("wdDialogTemplatesLinkedCSS")]
  TemplatesLinkedCSS = 2100003,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [InteropEnumValue("wdDialogStyleManagementTabEdit")]
  StyleManagementTabEdit = 2200000,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [InteropEnumValue("wdDialogStyleManagementTabRecommend")]
  StyleManagementTabRecommend = 2200001,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [InteropEnumValue("wdDialogStyleManagementTabRestrict")]
  StyleManagementTabRestrict = 2200002
}

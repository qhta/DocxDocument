namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the active tab when the specified dialog box is displayed.
/// </summary>
public enum WdWordDialogTab
{
  /// <summary>
  /// General tab of the Options dialog box.
  /// </summary>
  wdDialogToolsOptionsTabGeneral = unchecked((int)203),
  /// <summary>
  /// View tab of the Options dialog box.
  /// </summary>
  wdDialogToolsOptionsTabView = unchecked((int)204),
  /// <summary>
  /// Print tab of the Options dialog box.
  /// </summary>
  wdDialogToolsOptionsTabPrint = unchecked((int)208),
  /// <summary>
  /// Save tab of the Options dialog box.
  /// </summary>
  wdDialogToolsOptionsTabSave = unchecked((int)209),
  /// <summary>
  /// Spelling and Grammar tab of the Options dialog box.
  /// </summary>
  wdDialogToolsOptionsTabProofread = unchecked((int)211),
  /// <summary>
  /// User Information tab of the Options dialog box.
  /// </summary>
  wdDialogToolsOptionsTabUserInfo = unchecked((int)213),
  /// <summary>
  /// Edit tab of the Options dialog box.
  /// [System.Runtime.InteropServices.Guid("5A240536-0B1F-3599-BF96-3FD550690EF3")] public enum WdWordDialogTab ﾉ
  /// Expand table
  /// </summary>
  wdDialogToolsOptionsTabEdit = unchecked((int)224),
  /// <summary>
  /// File Locations tab of the Options dialog box.
  /// </summary>
  wdDialogToolsOptionsTabFileLocations = unchecked((int)225),
  /// <summary>
  /// Track Changes tab of the Options dialog box.
  /// </summary>
  wdDialogToolsOptionsTabTrackChanges = unchecked((int)386),
  /// <summary>
  /// Compatibility tab of the Options dialog box.
  /// </summary>
  wdDialogToolsOptionsTabCompatibility = unchecked((int)525),
  /// <summary>
  /// Asian Typography tab of the Options dialog box.
  /// </summary>
  wdDialogToolsOptionsTabTypography = unchecked((int)739),
  /// <summary>
  /// Hangul Hanja Conversion tab of the Options dialog box.
  /// </summary>
  wdDialogToolsOptionsTabHangulHanjaConversion = unchecked((int)786),
  /// <summary>
  /// Not supported.
  /// </summary>
  wdDialogToolsOptionsTabFuzzy = unchecked((int)790),
  /// <summary>
  /// Complex Scripts tab of the Options dialog box.
  /// </summary>
  wdDialogToolsOptionsTabBidi = unchecked((int)1029),
  /// <summary>
  /// Not supported.
  /// </summary>
  wdDialogToolsOptionsTabAcetate = unchecked((int)1266),
  /// <summary>
  /// Security tab of the Options dialog box.
  /// </summary>
  wdDialogToolsOptionsTabSecurity = unchecked((int)1361),
  /// <summary>
  /// Margins tab of the Page Setup dialog box.
  /// </summary>
  wdDialogFilePageSetupTabMargins = unchecked((int)150000),
  /// <summary>
  /// Paper tab of the Page Setup dialog box.
  /// </summary>
  wdDialogFilePageSetupTabPaper = unchecked((int)150001),
  /// <summary>
  /// Layout tab of the Page Setup dialog box.
  /// </summary>
  wdDialogFilePageSetupTabLayout = unchecked((int)150003),
  /// <summary>
  /// Margins tab of the Page Setup dialog box, with Apply To drop-down list active.
  /// </summary>
  wdDialogFilePageSetupTabCharsLines = unchecked((int)150004),
  /// <summary>
  /// Symbols tab of the Symbol dialog box.
  /// </summary>
  wdDialogInsertSymbolTabSymbols = unchecked((int)200000),
  /// <summary>
  /// Special Characters tab of the Symbol dialog box.
  /// </summary>
  wdDialogInsertSymbolTabSpecialCharacters = unchecked((int)200001),
  /// <summary>
  /// All Footnotes tab of the Note Options dialog box.
  /// </summary>
  wdDialogNoteOptionsTabAllFootnotes = unchecked((int)300000),
  /// <summary>
  /// All Endnotes tab of the Note Options dialog box.
  /// </summary>
  wdDialogNoteOptionsTabAllEndnotes = unchecked((int)300001),
  /// <summary>
  /// Index tab of the Index and Tables dialog box.
  /// </summary>
  wdDialogInsertIndexAndTablesTabIndex = unchecked((int)400000),
  /// <summary>
  /// Table of Contents tab of the Index and Tables dialog box.
  /// </summary>
  wdDialogInsertIndexAndTablesTabTableOfContents = unchecked((int)400001),
  /// <summary>
  /// Table of Figures tab of the Index and Tables dialog box.
  /// </summary>
  wdDialogInsertIndexAndTablesTabTableOfFigures = unchecked((int)400002),
  /// <summary>
  /// Table of Authorities tab of the Index and Tables dialog box.
  /// </summary>
  wdDialogInsertIndexAndTablesTabTableOfAuthorities = unchecked((int)400003),
  /// <summary>
  /// Styles tab of the Organizer dialog box.
  /// </summary>
  wdDialogOrganizerTabStyles = unchecked((int)500000),
  /// <summary>
  /// AutoText tab of the Organizer dialog box.
  /// </summary>
  wdDialogOrganizerTabAutoText = unchecked((int)500001),
  /// <summary>
  /// Command Bars tab of the Organizer dialog box.
  /// </summary>
  wdDialogOrganizerTabCommandBars = unchecked((int)500002),
  /// <summary>
  /// Macros tab of the Organizer dialog box.
  /// </summary>
  wdDialogOrganizerTabMacros = unchecked((int)500003),
  /// <summary>
  /// Font tab of the Font dialog box.
  /// </summary>
  wdDialogFormatFontTabFont = unchecked((int)600000),
  /// <summary>
  /// Character Spacing tab of the Font dialog box.
  /// </summary>
  wdDialogFormatFontTabCharacterSpacing = unchecked((int)600001),
  /// <summary>
  /// Animation tab of the Font dialog box.
  /// </summary>
  wdDialogFormatFontTabAnimation = unchecked((int)600002),
  /// <summary>
  /// Borders tab of the Borders dialog box.
  /// </summary>
  wdDialogFormatBordersAndShadingTabBorders = unchecked((int)700000),
  /// <summary>
  /// Page Border tab of the Borders dialog box.
  /// </summary>
  wdDialogFormatBordersAndShadingTabPageBorder = unchecked((int)700001),
  /// <summary>
  /// Shading tab of the Borders dialog box.
  /// </summary>
  wdDialogFormatBordersAndShadingTabShading = unchecked((int)700002),
  /// <summary>
  /// Envelopes tab of the Envelopes and Labels dialog box.
  /// </summary>
  wdDialogToolsEnvelopesAndLabelsTabEnvelopes = unchecked((int)800000),
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
  wdDialogToolsEnvelopesAndLabelsTabLabels = unchecked((int)800001),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  wdDialogFormatParagraphTabIndentsAndSpacing = unchecked((int)1000000),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  wdDialogFormatParagraphTabTextFlow = unchecked((int)1000001),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  wdDialogFormatParagraphTabTeisai = unchecked((int)1000002),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  wdDialogFormatDrawingObjectTabColorsAndLines = unchecked((int)1200000),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  wdDialogFormatDrawingObjectTabSize = unchecked((int)1200001),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  wdDialogFormatDrawingObjectTabPosition = unchecked((int)1200002),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  wdDialogFormatDrawingObjectTabWrapping = unchecked((int)1200003),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  wdDialogFormatDrawingObjectTabPicture = unchecked((int)1200004),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  wdDialogFormatDrawingObjectTabTextbox = unchecked((int)1200005),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  wdDialogFormatDrawingObjectTabWeb = unchecked((int)1200006),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  wdDialogFormatDrawingObjectTabHR = unchecked((int)1200007),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  wdDialogToolsAutoCorrectExceptionsTabFirstLetter = unchecked((int)1400000),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  wdDialogToolsAutoCorrectExceptionsTabInitialCaps = unchecked((int)1400001),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  wdDialogToolsAutoCorrectExceptionsTabHangulAndAlphabet = unchecked((int)1400002),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  wdDialogToolsAutoCorrectExceptionsTabIac = unchecked((int)1400003),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  wdDialogFormatBulletsAndNumberingTabBulleted = unchecked((int)1500000),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  wdDialogFormatBulletsAndNumberingTabNumbered = unchecked((int)1500001),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  wdDialogFormatBulletsAndNumberingTabOutlineNumbered = unchecked((int)1500002),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  wdDialogLetterWizardTabLetterFormat = unchecked((int)1600000),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  wdDialogLetterWizardTabRecipientInfo = unchecked((int)1600001),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  wdDialogLetterWizardTabOtherElements = unchecked((int)1600002),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  wdDialogLetterWizardTabSenderInfo = unchecked((int)1600003),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  wdDialogToolsAutoManagerTabAutoCorrect = unchecked((int)1700000),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  wdDialogToolsAutoManagerTabAutoFormatAsYouType = unchecked((int)1700001),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  wdDialogToolsAutoManagerTabAutoText = unchecked((int)1700002),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  wdDialogToolsAutoManagerTabAutoFormat = unchecked((int)1700003),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  wdDialogToolsAutoManagerTabSmartTags = unchecked((int)1700004),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  wdDialogTablePropertiesTabTable = unchecked((int)1800000),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  wdDialogTablePropertiesTabRow = unchecked((int)1800001),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  wdDialogTablePropertiesTabColumn = unchecked((int)1800002),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  wdDialogTablePropertiesTabCell = unchecked((int)1800003),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  wdDialogEmailOptionsTabSignature = unchecked((int)1900000),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  wdDialogEmailOptionsTabStationary = unchecked((int)1900001),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  wdDialogEmailOptionsTabQuoting = unchecked((int)1900002),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  wdDialogWebOptionsGeneral = unchecked((int)2000000),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  wdDialogWebOptionsBrowsers = unchecked((int)2000000),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  wdDialogWebOptionsFiles = unchecked((int)2000001),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  wdDialogWebOptionsPictures = unchecked((int)2000002),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  wdDialogWebOptionsEncoding = unchecked((int)2000003),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  wdDialogWebOptionsFonts = unchecked((int)2000004),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  wdDialogTemplates = unchecked((int)2100000),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  wdDialogTemplatesXMLSchema = unchecked((int)2100001),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  wdDialogTemplatesXMLExpansionPacks = unchecked((int)2100002),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  wdDialogTemplatesLinkedCSS = unchecked((int)2100003),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  wdDialogStyleManagementTabEdit = unchecked((int)2200000),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  wdDialogStyleManagementTabRecommend = unchecked((int)2200001),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  wdDialogStyleManagementTabRestrict = unchecked((int)2200002)
}

namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the active tab when the specified dialog box is displayed.
/// </summary>
public enum WdWordDialogTab
{
  /// <summary>
  /// General tab of the Options dialog box.
  /// </summary>
  ToolsOptionsTabGeneral = unchecked((int)203),
  /// <summary>
  /// View tab of the Options dialog box.
  /// </summary>
  ToolsOptionsTabView = unchecked((int)204),
  /// <summary>
  /// Print tab of the Options dialog box.
  /// </summary>
  ToolsOptionsTabPrint = unchecked((int)208),
  /// <summary>
  /// Save tab of the Options dialog box.
  /// </summary>
  ToolsOptionsTabSave = unchecked((int)209),
  /// <summary>
  /// Spelling and Grammar tab of the Options dialog box.
  /// </summary>
  ToolsOptionsTabProofread = unchecked((int)211),
  /// <summary>
  /// User Information tab of the Options dialog box.
  /// </summary>
  ToolsOptionsTabUserInfo = unchecked((int)213),
  /// <summary>
  /// Edit tab of the Options dialog box.
  /// [System.Runtime.InteropServices.Guid("5A240536-0B1F-3599-BF96-3FD550690EF3")] public enum WdWordDialogTab ﾉ
  /// Expand table
  /// </summary>
  ToolsOptionsTabEdit = unchecked((int)224),
  /// <summary>
  /// File Locations tab of the Options dialog box.
  /// </summary>
  ToolsOptionsTabFileLocations = unchecked((int)225),
  /// <summary>
  /// Track Changes tab of the Options dialog box.
  /// </summary>
  ToolsOptionsTabTrackChanges = unchecked((int)386),
  /// <summary>
  /// Compatibility tab of the Options dialog box.
  /// </summary>
  ToolsOptionsTabCompatibility = unchecked((int)525),
  /// <summary>
  /// Asian Typography tab of the Options dialog box.
  /// </summary>
  ToolsOptionsTabTypography = unchecked((int)739),
  /// <summary>
  /// Hangul Hanja Conversion tab of the Options dialog box.
  /// </summary>
  ToolsOptionsTabHangulHanjaConversion = unchecked((int)786),
  /// <summary>
  /// Not supported.
  /// </summary>
  ToolsOptionsTabFuzzy = unchecked((int)790),
  /// <summary>
  /// Complex Scripts tab of the Options dialog box.
  /// </summary>
  ToolsOptionsTabBidi = unchecked((int)1029),
  /// <summary>
  /// Not supported.
  /// </summary>
  ToolsOptionsTabAcetate = unchecked((int)1266),
  /// <summary>
  /// Security tab of the Options dialog box.
  /// </summary>
  ToolsOptionsTabSecurity = unchecked((int)1361),
  /// <summary>
  /// Margins tab of the Page Setup dialog box.
  /// </summary>
  FilePageSetupTabMargins = unchecked((int)150000),
  /// <summary>
  /// Paper tab of the Page Setup dialog box.
  /// </summary>
  FilePageSetupTabPaper = unchecked((int)150001),
  /// <summary>
  /// Layout tab of the Page Setup dialog box.
  /// </summary>
  FilePageSetupTabLayout = unchecked((int)150003),
  /// <summary>
  /// Margins tab of the Page Setup dialog box, with Apply To drop-down list active.
  /// </summary>
  FilePageSetupTabCharsLines = unchecked((int)150004),
  /// <summary>
  /// Symbols tab of the Symbol dialog box.
  /// </summary>
  InsertSymbolTabSymbols = unchecked((int)200000),
  /// <summary>
  /// Special Characters tab of the Symbol dialog box.
  /// </summary>
  InsertSymbolTabSpecialCharacters = unchecked((int)200001),
  /// <summary>
  /// All Footnotes tab of the Note Options dialog box.
  /// </summary>
  NoteOptionsTabAllFootnotes = unchecked((int)300000),
  /// <summary>
  /// All Endnotes tab of the Note Options dialog box.
  /// </summary>
  NoteOptionsTabAllEndnotes = unchecked((int)300001),
  /// <summary>
  /// Index tab of the Index and Tables dialog box.
  /// </summary>
  InsertIndexAndTablesTabIndex = unchecked((int)400000),
  /// <summary>
  /// Table of Contents tab of the Index and Tables dialog box.
  /// </summary>
  InsertIndexAndTablesTabTableOfContents = unchecked((int)400001),
  /// <summary>
  /// Table of Figures tab of the Index and Tables dialog box.
  /// </summary>
  InsertIndexAndTablesTabTableOfFigures = unchecked((int)400002),
  /// <summary>
  /// Table of Authorities tab of the Index and Tables dialog box.
  /// </summary>
  InsertIndexAndTablesTabTableOfAuthorities = unchecked((int)400003),
  /// <summary>
  /// Styles tab of the Organizer dialog box.
  /// </summary>
  OrganizerTabStyles = unchecked((int)500000),
  /// <summary>
  /// AutoText tab of the Organizer dialog box.
  /// </summary>
  OrganizerTabAutoText = unchecked((int)500001),
  /// <summary>
  /// Command Bars tab of the Organizer dialog box.
  /// </summary>
  OrganizerTabCommandBars = unchecked((int)500002),
  /// <summary>
  /// Macros tab of the Organizer dialog box.
  /// </summary>
  OrganizerTabMacros = unchecked((int)500003),
  /// <summary>
  /// Font tab of the Font dialog box.
  /// </summary>
  FormatFontTabFont = unchecked((int)600000),
  /// <summary>
  /// Character Spacing tab of the Font dialog box.
  /// </summary>
  FormatFontTabCharacterSpacing = unchecked((int)600001),
  /// <summary>
  /// Animation tab of the Font dialog box.
  /// </summary>
  FormatFontTabAnimation = unchecked((int)600002),
  /// <summary>
  /// Borders tab of the Borders dialog box.
  /// </summary>
  FormatBordersAndShadingTabBorders = unchecked((int)700000),
  /// <summary>
  /// Page Border tab of the Borders dialog box.
  /// </summary>
  FormatBordersAndShadingTabPageBorder = unchecked((int)700001),
  /// <summary>
  /// Shading tab of the Borders dialog box.
  /// </summary>
  FormatBordersAndShadingTabShading = unchecked((int)700002),
  /// <summary>
  /// Envelopes tab of the Envelopes and Labels dialog box.
  /// </summary>
  ToolsEnvelopesAndLabelsTabEnvelopes = unchecked((int)800000),
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
  ToolsEnvelopesAndLabelsTabLabels = unchecked((int)800001),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  FormatParagraphTabIndentsAndSpacing = unchecked((int)1000000),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  FormatParagraphTabTextFlow = unchecked((int)1000001),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  FormatParagraphTabTeisai = unchecked((int)1000002),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  FormatDrawingObjectTabColorsAndLines = unchecked((int)1200000),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  FormatDrawingObjectTabSize = unchecked((int)1200001),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  FormatDrawingObjectTabPosition = unchecked((int)1200002),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  FormatDrawingObjectTabWrapping = unchecked((int)1200003),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  FormatDrawingObjectTabPicture = unchecked((int)1200004),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  FormatDrawingObjectTabTextbox = unchecked((int)1200005),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  FormatDrawingObjectTabWeb = unchecked((int)1200006),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  FormatDrawingObjectTabHR = unchecked((int)1200007),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  ToolsAutoCorrectExceptionsTabFirstLetter = unchecked((int)1400000),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  ToolsAutoCorrectExceptionsTabInitialCaps = unchecked((int)1400001),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  ToolsAutoCorrectExceptionsTabHangulAndAlphabet = unchecked((int)1400002),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  ToolsAutoCorrectExceptionsTabIac = unchecked((int)1400003),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  FormatBulletsAndNumberingTabBulleted = unchecked((int)1500000),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  FormatBulletsAndNumberingTabNumbered = unchecked((int)1500001),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  FormatBulletsAndNumberingTabOutlineNumbered = unchecked((int)1500002),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  LetterWizardTabLetterFormat = unchecked((int)1600000),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  LetterWizardTabRecipientInfo = unchecked((int)1600001),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  LetterWizardTabOtherElements = unchecked((int)1600002),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  LetterWizardTabSenderInfo = unchecked((int)1600003),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  ToolsAutoManagerTabAutoCorrect = unchecked((int)1700000),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  ToolsAutoManagerTabAutoFormatAsYouType = unchecked((int)1700001),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  ToolsAutoManagerTabAutoText = unchecked((int)1700002),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  ToolsAutoManagerTabAutoFormat = unchecked((int)1700003),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  ToolsAutoManagerTabSmartTags = unchecked((int)1700004),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  TablePropertiesTabTable = unchecked((int)1800000),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  TablePropertiesTabRow = unchecked((int)1800001),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  TablePropertiesTabColumn = unchecked((int)1800002),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  TablePropertiesTabCell = unchecked((int)1800003),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  EmailOptionsTabSignature = unchecked((int)1900000),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  EmailOptionsTabStationary = unchecked((int)1900001),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  EmailOptionsTabQuoting = unchecked((int)1900002),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  WebOptionsGeneral = unchecked((int)2000000),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  WebOptionsBrowsers = unchecked((int)2000000),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  WebOptionsFiles = unchecked((int)2000001),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  WebOptionsPictures = unchecked((int)2000002),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  WebOptionsEncoding = unchecked((int)2000003),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  WebOptionsFonts = unchecked((int)2000004),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  Templates = unchecked((int)2100000),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  TemplatesXMLSchema = unchecked((int)2100001),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  TemplatesXMLExpansionPacks = unchecked((int)2100002),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  TemplatesLinkedCSS = unchecked((int)2100003),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  StyleManagementTabEdit = unchecked((int)2200000),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  StyleManagementTabRecommend = unchecked((int)2200001),
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  StyleManagementTabRestrict = unchecked((int)2200002)
}

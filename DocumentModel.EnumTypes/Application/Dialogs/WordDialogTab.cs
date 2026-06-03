namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the active tab when the specified dialog box is displayed.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdworddialogtab?view=office-pia` for Office interop details.
/// </remarks>
public enum WordDialogTab
{
  /// <summary>
  /// General tab of the IOptions dialog box.
  /// </summary>
  ToolsOptionsTabGeneral = 203,
  /// <summary>
  /// IView tab of the IOptions dialog box.
  /// </summary>
  ToolsOptionsTabView = 204,
  /// <summary>
  /// Print tab of the IOptions dialog box.
  /// </summary>
  ToolsOptionsTabPrint = 208,
  /// <summary>
  /// Save tab of the IOptions dialog box.
  /// </summary>
  ToolsOptionsTabSave = 209,
  /// <summary>
  /// Spelling and Grammar tab of the IOptions dialog box.
  /// </summary>
  ToolsOptionsTabProofread = 211,
  /// <summary>
  /// User Information tab of the IOptions dialog box.
  /// </summary>
  ToolsOptionsTabUserInfo = 213,
  /// <summary>
  /// Edit tab of the IOptions dialog box.
  /// </summary>
  ToolsOptionsTabEdit = 224,
  /// <summary>
  /// File Locations tab of the IOptions dialog box.
  /// </summary>
  ToolsOptionsTabFileLocations = 225,
  /// <summary>
  /// Track Changes tab of the IOptions dialog box.
  /// </summary>
  ToolsOptionsTabTrackChanges = 386,
  /// <summary>
  /// Compatibility tab of the IOptions dialog box.
  /// </summary>
  ToolsOptionsTabCompatibility = 525,
  /// <summary>
  /// Asian Typography tab of the IOptions dialog box.
  /// </summary>
  ToolsOptionsTabTypography = 739,
  /// <summary>
  /// Hangul Hanja Conversion tab of the IOptions dialog box.
  /// </summary>
  ToolsOptionsTabHangulHanjaConversion = 786,
  /// <summary>
  /// Not supported.
  /// </summary>
  ToolsOptionsTabFuzzy = 790,
  /// <summary>
  /// Complex Scripts tab of the IOptions dialog box.
  /// </summary>
  ToolsOptionsTabBidi = 1029,
  /// <summary>
  /// Not supported.
  /// </summary>
  ToolsOptionsTabAcetate = 1266,
  /// <summary>
  /// Security tab of the IOptions dialog box.
  /// </summary>
  ToolsOptionsTabSecurity = 1361,
  /// <summary>
  /// Margins tab of the IPage Setup dialog box.
  /// </summary>
  FilePageSetupTabMargins = 150000,
  /// <summary>
  /// Paper tab of the IPage Setup dialog box.
  /// </summary>
  FilePageSetupTabPaper = 150001,
  /// <summary>
  /// Layout tab of the IPage Setup dialog box.
  /// </summary>
  FilePageSetupTabLayout = 150003,
  /// <summary>
  /// Margins tab of the IPage Setup dialog box, with Apply To drop-down list active.
  /// </summary>
  FilePageSetupTabCharsLines = 150004,
  /// <summary>
  /// Symbols tab of the Symbol dialog box.
  /// </summary>
  InsertSymbolTabSymbols = 200000,
  /// <summary>
  /// Special ICharacters tab of the Symbol dialog box.
  /// </summary>
  InsertSymbolTabSpecialCharacters = 200001,
  /// <summary>
  /// All IFootnotes tab of the Note IOptions dialog box.
  /// </summary>
  NoteOptionsTabAllFootnotes = 300000,
  /// <summary>
  /// All IEndnotes tab of the Note IOptions dialog box.
  /// </summary>
  NoteOptionsTabAllEndnotes = 300001,
  /// <summary>
  /// IIndex tab of the IIndex and ITables dialog box.
  /// </summary>
  InsertIndexAndTablesTabIndex = 400000,
  /// <summary>
  /// ITable of Contents tab of the IIndex and ITables dialog box.
  /// </summary>
  InsertIndexAndTablesTabTableOfContents = 400001,
  /// <summary>
  /// ITable of Figures tab of the IIndex and ITables dialog box.
  /// </summary>
  InsertIndexAndTablesTabTableOfFigures = 400002,
  /// <summary>
  /// ITable of Authorities tab of the IIndex and ITables dialog box.
  /// </summary>
  InsertIndexAndTablesTabTableOfAuthorities = 400003,
  /// <summary>
  /// IStyles tab of the Organizer dialog box.
  /// </summary>
  OrganizerTabStyles = 500000,
  /// <summary>
  /// AutoText tab of the Organizer dialog box.
  /// </summary>
  OrganizerTabAutoText = 500001,
  /// <summary>
  /// Command Bars tab of the Organizer dialog box.
  /// </summary>
  OrganizerTabCommandBars = 500002,
  /// <summary>
  /// Macros tab of the Organizer dialog box.
  /// </summary>
  OrganizerTabMacros = 500003,
  /// <summary>
  /// IFont tab of the IFont dialog box.
  /// </summary>
  FormatFontTabFont = 600000,
  /// <summary>
  /// Character Spacing tab of the IFont dialog box.
  /// </summary>
  FormatFontTabCharacterSpacing = 600001,
  /// <summary>
  /// Animation tab of the IFont dialog box.
  /// </summary>
  FormatFontTabAnimation = 600002,
  /// <summary>
  /// IBorders tab of the IBorders dialog box.
  /// </summary>
  FormatBordersAndShadingTabBorders = 700000,
  /// <summary>
  /// IPage IBorder tab of the IBorders dialog box.
  /// </summary>
  FormatBordersAndShadingTabPageBorder = 700001,
  /// <summary>
  /// IShading tab of the IBorders dialog box.
  /// </summary>
  FormatBordersAndShadingTabShading = 700002,
  /// <summary>
  /// Envelopes tab of the Envelopes and Labels dialog box.
  /// </summary>
  ToolsEnvelopesAndLabelsTabEnvelopes = 800000,
  /// <summary>
  /// Labels tab of the Envelopes and Labels dialog box. wdDialogFormatParagraphTabIndentsAndSpacing 1000000Indents
  /// and Spacing tab of the IParagraph dialog box. wdDialogFormatParagraphTabTextFlow 1000001Line and IPage IBreaks
  /// tab of the IParagraph dialog box. wdDialogFormatParagraphTabTeisai 1000002Line and IPage IBreaks tab of the
  /// IParagraph dialog box, with choices appropriate for Asian text. wdDialogFormatDrawingObjectTabColorsAndLines
  /// 1200000Colors and ILines tab of the Format Drawing Object dialog box. wdDialogFormatDrawingObjectTabSize
  /// 1200001Size tab of the Format Drawing Object dialog box. wdDialogFormatDrawingObjectTabPosition
  /// 1200002Position tab of the Format Drawing Object dialog box. wdDialogFormatDrawingObjectTabWrapping
  /// 1200003Wrapping tab of the Format Drawing Object dialog box. wdDialogFormatDrawingObjectTabPicture
  /// 1200004Picture tab of the Format Drawing Object dialog box. wdDialogFormatDrawingObjectTabTextbox
  /// 1200005Textbox tab of the Format Drawing Object dialog box. wdDialogFormatDrawingObjectTabWeb 1200006Web tab
  /// of the Format Drawing Object dialog box. wdDialogFormatDrawingObjectTabHR 1200007Colors and ILines tab of the
  /// Format Drawing Object dialog box. wdDialogToolsAutoCorrectExceptionsTabFirstLetter 1400000First Letter tab of
  /// the IAutoCorrect Exceptions dialog box. wdDialogToolsAutoCorrectExceptionsTabInitialCaps 1400001Initial Caps
  /// tab of the IAutoCorrect Exceptions dialog box.
  /// wdDialogToolsAutoCorrectExceptionsTabHangulAndAlphabet1400002Hangul and Alphabet tab of the IAutoCorrect
  /// Exceptions dialog box. Available Ionly in multi-language versions. wdDialogToolsAutoCorrectExceptionsTabIac
  /// 1400003Other Corrections tab of the IAutoCorrect Exceptions dialog box.
  /// wdDialogFormatBulletsAndNumberingTabBulleted 1500000Bulleted tab of the Bullets and Numbering dialog box.
  /// wdDialogFormatBulletsAndNumberingTabNumbered 1500001Numbered tab of the Bullets and Numbering dialog box.
  /// wdDialogFormatBulletsAndNumberingTabOutlineNumbered1500002Outline Numbered tab of the Bullets and Numbering
  /// dialog box. wdDialogLetterWizardTabLetterFormat 1600000Letter Format tab of the Letter Wizard dialog box.
  /// wdDialogLetterWizardTabRecipientInfo 1600001Recipient Info tab of the Letter Wizard dialog box.
  /// wdDialogLetterWizardTabOtherElements 1600002Other Elements tab of the Letter Wizard dialog box.
  /// wdDialogLetterWizardTabSenderInfo 1600003Sender Info tab of the Letter Wizard dialog box.
  /// wdDialogToolsAutoManagerTabAutoCorrect 1700000AutoCorrect tab of the IAutoCorrect dialog box.
  /// wdDialogToolsAutoManagerTabAutoFormatAsYouType 1700001Format As You Type tab of the IAutoCorrect dialog box.
  /// wdDialogToolsAutoManagerTabAutoText 1700002AutoText tab of the IAutoCorrect dialog box.
  /// wdDialogToolsAutoManagerTabAutoFormat 1700003AutoFormat tab of the IAutoCorrect dialog box.
  /// wdDialogToolsAutoManagerTabSmartTags 1700004Smart Tags tab of the IAutoCorrect dialog box.
  /// wdDialogTablePropertiesTabTable 1800000Table tab of the ITable Properties dialog box.
  /// wdDialogTablePropertiesTabRow 1800001Row tab of the ITable Properties dialog box.
  /// wdDialogTablePropertiesTabColumn 1800002Column tab of the ITable Properties dialog box.
  /// wdDialogTablePropertiesTabCell 1800003Cell tab of the ITable Properties dialog box.
  /// wdDialogEmailOptionsTabSignature 1900000E-mail Signature tab of the E- mail IOptions dialog box.
  /// wdDialogEmailOptionsTabStationary 1900001Personal Stationary tab of the E-mail IOptions dialog box.
  /// </summary>
  ToolsEnvelopesAndLabelsTabLabels = 800001,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  FormatParagraphTabIndentsAndSpacing = 1000000,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  FormatParagraphTabTextFlow = 1000001,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  FormatParagraphTabTeisai = 1000002,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  FormatDrawingObjectTabColorsAndLines = 1200000,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  FormatDrawingObjectTabSize = 1200001,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  FormatDrawingObjectTabPosition = 1200002,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  FormatDrawingObjectTabWrapping = 1200003,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  FormatDrawingObjectTabPicture = 1200004,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  FormatDrawingObjectTabTextbox = 1200005,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  FormatDrawingObjectTabWeb = 1200006,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  FormatDrawingObjectTabHR = 1200007,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  ToolsAutoCorrectExceptionsTabFirstLetter = 1400000,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  ToolsAutoCorrectExceptionsTabInitialCaps = 1400001,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  ToolsAutoCorrectExceptionsTabHangulAndAlphabet = 1400002,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  ToolsAutoCorrectExceptionsTabIac = 1400003,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  FormatBulletsAndNumberingTabBulleted = 1500000,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  FormatBulletsAndNumberingTabNumbered = 1500001,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  FormatBulletsAndNumberingTabOutlineNumbered = 1500002,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  LetterWizardTabLetterFormat = 1600000,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  LetterWizardTabRecipientInfo = 1600001,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  LetterWizardTabOtherElements = 1600002,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  LetterWizardTabSenderInfo = 1600003,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  ToolsAutoManagerTabAutoCorrect = 1700000,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  ToolsAutoManagerTabAutoFormatAsYouType = 1700001,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  ToolsAutoManagerTabAutoText = 1700002,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  ToolsAutoManagerTabAutoFormat = 1700003,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  ToolsAutoManagerTabSmartTags = 1700004,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  TablePropertiesTabTable = 1800000,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  TablePropertiesTabRow = 1800001,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  TablePropertiesTabColumn = 1800002,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  TablePropertiesTabCell = 1800003,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  EmailOptionsTabSignature = 1900000,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  EmailOptionsTabStationary = 1900001,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  EmailOptionsTabQuoting = 1900002,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  WebOptionsGeneral = 2000000,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  WebOptionsBrowsers = 2000000,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  WebOptionsFiles = 2000001,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  WebOptionsPictures = 2000002,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  WebOptionsEncoding = 2000003,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  WebOptionsFonts = 2000004,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  ITemplates = 2100000,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  TemplatesXMLSchema = 2100001,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  TemplatesXMLExpansionPacks = 2100002,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  TemplatesLinkedCSS = 2100003,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  StyleManagementTabEdit = 2200000,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  StyleManagementTabRecommend = 2200001,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  StyleManagementTabRestrict = 2200002
}


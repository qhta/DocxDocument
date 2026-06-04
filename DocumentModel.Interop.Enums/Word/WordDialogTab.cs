namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the active tab when the specified dialog box is displayed.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdworddialogtab?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdWordDialogTab))]
public enum WordDialogTab
{
  /// <summary>
  /// General tab of the Options dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogToolsOptionsTabGeneral))]
  ToolsOptionsTabGeneral = 203,
  /// <summary>
  /// View tab of the Options dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogToolsOptionsTabView))]
  ToolsOptionsTabView = 204,
  /// <summary>
  /// Print tab of the Options dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogToolsOptionsTabPrint))]
  ToolsOptionsTabPrint = 208,
  /// <summary>
  /// Save tab of the Options dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogToolsOptionsTabSave))]
  ToolsOptionsTabSave = 209,
  /// <summary>
  /// Spelling and Grammar tab of the Options dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogToolsOptionsTabProofread))]
  ToolsOptionsTabProofread = 211,
  /// <summary>
  /// User Information tab of the Options dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogToolsOptionsTabUserInfo))]
  ToolsOptionsTabUserInfo = 213,
  /// <summary>
  /// Edit tab of the Options dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogToolsOptionsTabEdit))]
  ToolsOptionsTabEdit = 224,
  /// <summary>
  /// File Locations tab of the Options dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogToolsOptionsTabFileLocations))]
  ToolsOptionsTabFileLocations = 225,
  /// <summary>
  /// Track Changes tab of the Options dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogToolsOptionsTabTrackChanges))]
  ToolsOptionsTabTrackChanges = 386,
  /// <summary>
  /// Compatibility tab of the Options dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogToolsOptionsTabCompatibility))]
  ToolsOptionsTabCompatibility = 525,
  /// <summary>
  /// Asian Typography tab of the Options dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogToolsOptionsTabTypography))]
  ToolsOptionsTabTypography = 739,
  /// <summary>
  /// Hangul Hanja Conversion tab of the Options dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogToolsOptionsTabHangulHanjaConversion))]
  ToolsOptionsTabHangulHanjaConversion = 786,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogToolsOptionsTabFuzzy))]
  ToolsOptionsTabFuzzy = 790,
  /// <summary>
  /// Complex Scripts tab of the Options dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogToolsOptionsTabBidi))]
  ToolsOptionsTabBidi = 1029,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogToolsOptionsTabAcetate))]
  ToolsOptionsTabAcetate = 1266,
  /// <summary>
  /// Security tab of the Options dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogToolsOptionsTabSecurity))]
  ToolsOptionsTabSecurity = 1361,
  /// <summary>
  /// Margins tab of the Page Setup dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogFilePageSetupTabMargins))]
  FilePageSetupTabMargins = 150000,
  /// <summary>
  /// Paper tab of the Page Setup dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogFilePageSetupTabPaper))]
  FilePageSetupTabPaper = 150001,
  /// <summary>
  /// Layout tab of the Page Setup dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogFilePageSetupTabLayout))]
  FilePageSetupTabLayout = 150003,
  /// <summary>
  /// Margins tab of the Page Setup dialog box, with Apply To drop-down list active.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogFilePageSetupTabCharsLines))]
  FilePageSetupTabCharsLines = 150004,
  /// <summary>
  /// Symbols tab of the Symbol dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogInsertSymbolTabSymbols))]
  InsertSymbolTabSymbols = 200000,
  /// <summary>
  /// Special Characters tab of the Symbol dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogInsertSymbolTabSpecialCharacters))]
  InsertSymbolTabSpecialCharacters = 200001,
  /// <summary>
  /// All Footnotes tab of the Note Options dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogNoteOptionsTabAllFootnotes))]
  NoteOptionsTabAllFootnotes = 300000,
  /// <summary>
  /// All Endnotes tab of the Note Options dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogNoteOptionsTabAllEndnotes))]
  NoteOptionsTabAllEndnotes = 300001,
  /// <summary>
  /// Index tab of the Index and Tables dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogInsertIndexAndTablesTabIndex))]
  InsertIndexAndTablesTabIndex = 400000,
  /// <summary>
  /// Table of Contents tab of the Index and Tables dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogInsertIndexAndTablesTabTableOfContents))]
  InsertIndexAndTablesTabTableOfContents = 400001,
  /// <summary>
  /// Table of Figures tab of the Index and Tables dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogInsertIndexAndTablesTabTableOfFigures))]
  InsertIndexAndTablesTabTableOfFigures = 400002,
  /// <summary>
  /// Table of Authorities tab of the Index and Tables dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogInsertIndexAndTablesTabTableOfAuthorities))]
  InsertIndexAndTablesTabTableOfAuthorities = 400003,
  /// <summary>
  /// Styles tab of the Organizer dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogOrganizerTabStyles))]
  OrganizerTabStyles = 500000,
  /// <summary>
  /// AutoText tab of the Organizer dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogOrganizerTabAutoText))]
  OrganizerTabAutoText = 500001,
  /// <summary>
  /// Command Bars tab of the Organizer dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogOrganizerTabCommandBars))]
  OrganizerTabCommandBars = 500002,
  /// <summary>
  /// Macros tab of the Organizer dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogOrganizerTabMacros))]
  OrganizerTabMacros = 500003,
  /// <summary>
  /// Font tab of the Font dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogFormatFontTabFont))]
  FormatFontTabFont = 600000,
  /// <summary>
  /// Character Spacing tab of the Font dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogFormatFontTabCharacterSpacing))]
  FormatFontTabCharacterSpacing = 600001,
  /// <summary>
  /// Animation tab of the Font dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogFormatFontTabAnimation))]
  FormatFontTabAnimation = 600002,
  /// <summary>
  /// Borders tab of the Borders dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogFormatBordersAndShadingTabBorders))]
  FormatBordersAndShadingTabBorders = 700000,
  /// <summary>
  /// Page Border tab of the Borders dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogFormatBordersAndShadingTabPageBorder))]
  FormatBordersAndShadingTabPageBorder = 700001,
  /// <summary>
  /// Shading tab of the Borders dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogFormatBordersAndShadingTabShading))]
  FormatBordersAndShadingTabShading = 700002,
  /// <summary>
  /// Envelopes tab of the Envelopes and Labels dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogToolsEnvelopesAndLabelsTabEnvelopes))]
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
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogToolsEnvelopesAndLabelsTabLabels))]
  ToolsEnvelopesAndLabelsTabLabels = 800001,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogFormatParagraphTabIndentsAndSpacing))]
  FormatParagraphTabIndentsAndSpacing = 1000000,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogFormatParagraphTabTextFlow))]
  FormatParagraphTabTextFlow = 1000001,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogFormatParagraphTabTeisai))]
  FormatParagraphTabTeisai = 1000002,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogFormatDrawingObjectTabColorsAndLines))]
  FormatDrawingObjectTabColorsAndLines = 1200000,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogFormatDrawingObjectTabSize))]
  FormatDrawingObjectTabSize = 1200001,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogFormatDrawingObjectTabPosition))]
  FormatDrawingObjectTabPosition = 1200002,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogFormatDrawingObjectTabWrapping))]
  FormatDrawingObjectTabWrapping = 1200003,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogFormatDrawingObjectTabPicture))]
  FormatDrawingObjectTabPicture = 1200004,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogFormatDrawingObjectTabTextbox))]
  FormatDrawingObjectTabTextbox = 1200005,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogFormatDrawingObjectTabWeb))]
  FormatDrawingObjectTabWeb = 1200006,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogFormatDrawingObjectTabHR))]
  FormatDrawingObjectTabHR = 1200007,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogToolsAutoCorrectExceptionsTabFirstLetter))]
  ToolsAutoCorrectExceptionsTabFirstLetter = 1400000,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogToolsAutoCorrectExceptionsTabInitialCaps))]
  ToolsAutoCorrectExceptionsTabInitialCaps = 1400001,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogToolsAutoCorrectExceptionsTabHangulAndAlphabet))]
  ToolsAutoCorrectExceptionsTabHangulAndAlphabet = 1400002,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogToolsAutoCorrectExceptionsTabIac))]
  ToolsAutoCorrectExceptionsTabIac = 1400003,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogFormatBulletsAndNumberingTabBulleted))]
  FormatBulletsAndNumberingTabBulleted = 1500000,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogFormatBulletsAndNumberingTabNumbered))]
  FormatBulletsAndNumberingTabNumbered = 1500001,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogFormatBulletsAndNumberingTabOutlineNumbered))]
  FormatBulletsAndNumberingTabOutlineNumbered = 1500002,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogLetterWizardTabLetterFormat))]
  LetterWizardTabLetterFormat = 1600000,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogLetterWizardTabRecipientInfo))]
  LetterWizardTabRecipientInfo = 1600001,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogLetterWizardTabOtherElements))]
  LetterWizardTabOtherElements = 1600002,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogLetterWizardTabSenderInfo))]
  LetterWizardTabSenderInfo = 1600003,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogToolsAutoManagerTabAutoCorrect))]
  ToolsAutoManagerTabAutoCorrect = 1700000,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogToolsAutoManagerTabAutoFormatAsYouType))]
  ToolsAutoManagerTabAutoFormatAsYouType = 1700001,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogToolsAutoManagerTabAutoText))]
  ToolsAutoManagerTabAutoText = 1700002,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogToolsAutoManagerTabAutoFormat))]
  ToolsAutoManagerTabAutoFormat = 1700003,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogToolsAutoManagerTabSmartTags))]
  ToolsAutoManagerTabSmartTags = 1700004,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogTablePropertiesTabTable))]
  TablePropertiesTabTable = 1800000,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogTablePropertiesTabRow))]
  TablePropertiesTabRow = 1800001,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogTablePropertiesTabColumn))]
  TablePropertiesTabColumn = 1800002,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogTablePropertiesTabCell))]
  TablePropertiesTabCell = 1800003,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogEmailOptionsTabSignature))]
  EmailOptionsTabSignature = 1900000,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogEmailOptionsTabStationary))]
  EmailOptionsTabStationary = 1900001,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogEmailOptionsTabQuoting))]
  EmailOptionsTabQuoting = 1900002,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogWebOptionsGeneral))]
  WebOptionsGeneral = 2000000,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogWebOptionsBrowsers))]
  WebOptionsBrowsers = 2000000,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogWebOptionsFiles))]
  WebOptionsFiles = 2000001,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogWebOptionsPictures))]
  WebOptionsPictures = 2000002,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogWebOptionsEncoding))]
  WebOptionsEncoding = 2000003,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogWebOptionsFonts))]
  WebOptionsFonts = 2000004,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogTemplates))]
  Templates = 2100000,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogTemplatesXMLSchema))]
  TemplatesXMLSchema = 2100001,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogTemplatesXMLExpansionPacks))]
  TemplatesXMLExpansionPacks = 2100002,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogTemplatesLinkedCSS))]
  TemplatesLinkedCSS = 2100003,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogStyleManagementTabEdit))]
  StyleManagementTabEdit = 2200000,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogStyleManagementTabRecommend))]
  StyleManagementTabRecommend = 2200001,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialogTab.wdDialogStyleManagementTabRestrict))]
  StyleManagementTabRestrict = 2200002
}

namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the active tab when the specified dialog box is displayed.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdworddialogtab?view=office-pia` for Office interop details.
/// </remarks>
public enum WdWordDialogTab
{
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  ToolsOptionsTabGeneral = 203,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  ToolsOptionsTabView = 204,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  ToolsOptionsTabPrint = 208,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  ToolsOptionsTabSave = 209,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  ToolsOptionsTabProofread = 211,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  ToolsOptionsTabUserInfo = 213,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  ToolsOptionsTabEdit = 224,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  ToolsOptionsTabFileLocations = 225,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  ToolsOptionsTabTrackChanges = 386,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  ToolsOptionsTabCompatibility = 525,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  ToolsOptionsTabTypography = 739,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  ToolsOptionsTabHangulHanjaConversion = 786,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  ToolsOptionsTabFuzzy = 790,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  ToolsOptionsTabBidi = 1029,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  ToolsOptionsTabAcetate = 1266,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  ToolsOptionsTabSecurity = 1361,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  FilePageSetupTabMargins = 150000,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  FilePageSetupTabPaper = 150001,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  FilePageSetupTabLayout = 150003,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  FilePageSetupTabCharsLines = 150004,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  InsertSymbolTabSymbols = 200000,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  InsertSymbolTabSpecialCharacters = 200001,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  NoteOptionsTabAllFootnotes = 300000,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  NoteOptionsTabAllEndnotes = 300001,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  InsertIndexAndTablesTabIndex = 400000,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  InsertIndexAndTablesTabTableOfContents = 400001,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  InsertIndexAndTablesTabTableOfFigures = 400002,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  InsertIndexAndTablesTabTableOfAuthorities = 400003,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  OrganizerTabStyles = 500000,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  OrganizerTabAutoText = 500001,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  OrganizerTabCommandBars = 500002,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  OrganizerTabMacros = 500003,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  FormatFontTabFont = 600000,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  FormatFontTabCharacterSpacing = 600001,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  FormatFontTabAnimation = 600002,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  FormatBordersAndShadingTabBorders = 700000,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  FormatBordersAndShadingTabPageBorder = 700001,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  FormatBordersAndShadingTabShading = 700002,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
  /// </summary>
  ToolsEnvelopesAndLabelsTabEnvelopes = 800000,
  /// <summary>
  /// Specifies the active tab when the specified dialog box is displayed.
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
  Templates = 2100000,
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

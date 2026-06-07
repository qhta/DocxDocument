namespace DocumentModel.Wordprocessing;

/// <summary>
/// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
/// applicable, that you can use to get or set values in a dialog box.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdworddialog?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType(typeof(Microsoft.Office.Interop.Word.WdWordDialog))]
public enum WordDialog
{
  /// <summary>
  /// APPNAME, APPCOPYRIGHT, APPUSERNAME, APPORGANIZATION, APPSERIALNUMBER
  /// </summary>
  [InteropEnumValue("wdDialogHelpAbout")]
  HelpAbout = 9,
  /// <summary>
  /// WPCommand, HelpText, DemoGuidance
  /// </summary>
  [InteropEnumValue("wdDialogHelpWordPerfectHelp")]
  HelpWordPerfectHelp = 10,
  /// <summary>
  /// FileName, Directory, ITemplate, Title, Created, LastSaved, LastSavedBy, IRevision, Time, Printed, IPages, IWords,
  /// ICharacters, IParagraphs, Lines,
  /// </summary>
  [InteropEnumValue("wdDialogFileStatistics")]
  DocumentStatistics = 78,
  /// <summary>
  /// ITemplate, NewTemplate, DocumentType, Visible
  /// </summary>
  [InteropEnumValue("wdDialogFileNew")]
  FileNew = 79,
  /// <summary>
  /// Name, ConfirmConversions, ReadOnly, LinkToSource, AddToMru, PasswordDoc, PasswordDot, Revert,
  /// WritePasswordDoc, WritePasswordDot, Connection, SQLStatement, SQLStatement1, Format, Encoding, Visible,
  /// OpenExclusive, OpenAndRepair, SubType,
  /// </summary>
  [InteropEnumValue("wdDialogFileOpen")]
  FileOpen = 80,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("wdDialogMailMergeOpenDataSource")]
  MailMergeOpenDataSource = 81,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("wdDialogMailMergeOpenHeaderSource")]
  MailMergeOpenHeaderSource = 82,
  /// <summary>
  /// Name, Format, LockAnnot, Password, AddToMru, WritePassword, RecommendReadOnly, EmbedFonts,
  /// NativePictureFormat, FormsData, SaveAsAOCELetter, WriteVersion, VersionDesc, InsertLineBreaks,
  /// AllowSubstitutions, LineEnding,
  /// </summary>
  [InteropEnumValue("wdDialogFileSaveAs")]
  FileSaveAs = 84,
  /// <summary>
  /// Title, Subject, Author, Keywords, IComments, FileName, Directory, ITemplate, CreateDate, LastSavedDate,
  /// LastSavedBy, RevisionNumber, EditTime, LastPrintedDate, NumPages, NumWords, NumChars, NumParas, NumLines,
  /// Update, FileSize
  /// </summary>
  [InteropEnumValue("wdDialogFileSummaryInfo")]
  FileSummaryInfo = 86,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("wdDialogToolsTemplates")]
  ToolsTemplates = 87,
  /// <summary>
  /// Background, AppendPrFile, IRange, PrToFileName, From, To, Type, NumCopies, IPages, Order, PrintToFile, Collate,
  /// FileName, Printer, OutputPrinter, DuplexPrint, PrintZoomColumn, PrintZoomRow, PrintZoomPaperWidth,
  /// PrintZoomPaperHeight, ZoomPaper
  /// </summary>
  [InteropEnumValue("wdDialogFilePrint")]
  FilePrint = 88,
  /// <summary>
  /// Printer, IOptions, Network, DoNotSetAsSysDefault
  /// </summary>
  [InteropEnumValue("wdDialogFilePrintSetup")]
  FilePrintSetup = 97,
  /// <summary>
  /// SearchName, SearchPath, Name, SubDir, Title, Author, Keywords, Subject, IOptions, MatchCase, Text,
  /// PatternMatch, DateSavedFrom, DateSavedTo, SavedBy, DateCreatedFrom, DateCreatedTo, IView, SortBy, ListBy,
  /// SelectedFile, Add, Delete, ShowFolders, MatchByte
  /// </summary>
  [InteropEnumValue("wdDialogFileFind")]
  FileFind = 99,
  /// <summary>
  /// IPoints, Underline, Color, StrikeThrough, Superscript, Subscript, Hidden, SmallCaps, AllCaps, Spacing,
  /// Position, Kerning, KerningMin, Default, Tab, IFont, Bold, Italic, DoubleStrikeThrough, Shadow, Outline, Emboss,
  /// Engrave, Scale, Animations, CharAccent, FontMajor, FontLowAnsi, FontHighAnsi, CharacterWidthGrid, ColorRGB,
  /// UnderlineColor, PointsBi, ColorBi, FontNameBi, BoldBi, ItalicBi,
  /// </summary>
  [InteropEnumValue("wdDialogFormatAddrFonts")]
  FormatAddrFonts = 103,
  /// <summary>
  /// IconNumber, Link, DisplayIcon, Class, DataType, IconFileName, Caption, Floating
  /// </summary>
  [InteropEnumValue("wdDialogEditPasteSpecial")]
  EditPasteSpecial = 111,
  /// <summary>
  /// IFind, Replace, Direction, MatchCase, WholeWord, PatternMatch, SoundsLike, FindNext, ReplaceOne, ReplaceAll,
  /// Format, Wrap, FindAllWordForms, MatchByte, FuzzyFind, Destination, CorrectEnd, MatchKashida, MatchDiacritics,
  /// MatchAlefHamza,
  /// </summary>
  [InteropEnumValue("wdDialogEditFind")]
  EditFind = 112,
  /// <summary>
  /// IFind, Replace, Direction, MatchCase, WholeWord, PatternMatch, SoundsLike, FindNext, ReplaceOne, ReplaceAll,
  /// Format, Wrap, FindAllWordForms, MatchByte, FuzzyFind, Destination, CorrectEnd, MatchKashida, MatchDiacritics,
  /// MatchAlefHamza,
  /// </summary>
  [InteropEnumValue("wdDialogEditReplace")]
  EditReplace = 117,
  /// <summary>
  /// (none)
  /// </summary>
  [InteropEnumValue("wdDialogEditStyle")]
  EditStyle = 120,
  /// <summary>
  /// UpdateMode, Locked, SavePictureInDoc, UpdateNow, OpenSource, KillLink, Link, IApplication, Item, FileName,
  /// </summary>
  [InteropEnumValue("wdDialogEditLinks")]
  EditLinks = 124,
  /// <summary>
  /// Verb
  /// </summary>
  [InteropEnumValue("wdDialogEditObject")]
  EditObject = 125,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("wdDialogTextToTable")]
  TextToTable = 127,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("wdDialogTableToText")]
  TableToText = 128,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("wdDialogTableInsertTable")]
  TableInsertTable = 129,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("wdDialogTableInsertCells")]
  TableInsertCells = 130,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("wdDialogTableInsertRow")]
  TableInsertRow = 131,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("wdDialogTableDeleteCells")]
  TableDeleteCells = 133,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("wdDialogTableSplitCells")]
  TableSplitCells = 137,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("wdDialogTableRowHeight")]
  TableRowHeight = 142,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("wdDialogTableColumnWidth")]
  TableColumnWidth = 143,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("wdDialogToolsCustomize")]
  ToolsCustomize = 152,
  /// <summary>
  /// Type
  /// </summary>
  [InteropEnumValue("wdDialogInsertBreak")]
  InsertBreak = 159,
  /// <summary>
  /// IFont, Tab, CharNum, CharNumLow, Unicode, Hint
  /// </summary>
  [InteropEnumValue("wdDialogInsertSymbol")]
  InsertSymbol = 162,
  /// <summary>
  /// Name, LinkToFile, New, FloatOverText
  /// </summary>
  [InteropEnumValue("wdDialogInsertPicture")]
  InsertPicture = 163,
  /// <summary>
  /// Name, IRange, ConfirmConversions, Link,
  /// </summary>
  [InteropEnumValue("wdDialogInsertFile")]
  InsertFile = 164,
  /// <summary>
  /// DateTimePic, InsertAsField, DbCharField, DateLanguage, CalendarType
  /// </summary>
  [InteropEnumValue("wdDialogInsertDateTime")]
  InsertDateTime = 165,
  /// <summary>
  /// Field
  /// </summary>
  [InteropEnumValue("wdDialogInsertField")]
  InsertField = 166,
  /// <summary>
  /// MergeField, WordField
  /// </summary>
  [InteropEnumValue("wdDialogInsertMergeField")]
  InsertMergeField = 167,
  /// <summary>
  /// Name, SortBy, Add, Delete, Goto, Hidden
  /// </summary>
  [InteropEnumValue("wdDialogInsertBookmark")]
  InsertBookmark = 168,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("wdDialogMarkIndexEntry")]
  MarkIndexEntry = 169,
  /// <summary>
  /// Outline, IFields, From, To, TableId, AddedStyles, Caption, HeadingSeparator, Replace, MarkEntry, AutoMark,
  /// MarkCitation, Type, RightAlignPageNumbers, Passim, KeepFormatting, IColumns, ICategory, Label, ShowPageNumbers,
  /// AccentedLetters, Filter, SortBy, Leader, TOCUseHyperlinks, TOCHidePageNumInWeb, IndexLanguage,
  /// </summary>
  [InteropEnumValue("wdDialogInsertIndex")]
  InsertIndex = 170,
  /// <summary>
  /// Outline, IFields, From, To, TableId, AddedStyles, Caption, HeadingSeparator, Replace, MarkEntry, AutoMark,
  /// MarkCitation, Type, RightAlignPageNumbers, Passim, KeepFormatting, IColumns, ICategory, Label, ShowPageNumbers,
  /// AccentedLetters, Filter, SortBy, Leader, TOCUseHyperlinks, TOCHidePageNumInWeb, IndexLanguage,
  /// </summary>
  [InteropEnumValue("wdDialogInsertTableOfContents")]
  InsertTableOfContents = 171,
  /// <summary>
  /// IconNumber, FileName, Link, DisplayIcon, Tab, Class, IconFileName, Caption, Floating
  /// </summary>
  [InteropEnumValue("wdDialogInsertObject")]
  InsertObject = 172,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("wdDialogToolsCreateEnvelope")]
  ToolsCreateEnvelope = 173,
  /// <summary>
  /// IPoints, Underline, Color, StrikeThrough, Superscript, Subscript, Hidden, SmallCaps, AllCaps, Spacing,
  /// Position, Kerning, KerningMin, Default, Tab, IFont, Bold, Italic, DoubleStrikeThrough, Shadow, Outline, Emboss,
  /// Engrave, Scale, Animations, CharAccent, FontMajor, FontLowAnsi, FontHighAnsi, CharacterWidthGrid, ColorRGB,
  /// UnderlineColor, PointsBi, ColorBi, FontNameBi, BoldBi, ItalicBi,
  /// </summary>
  [InteropEnumValue("wdDialogFormatFont")]
  FormatFont = 174,
  /// <summary>
  /// LeftIndent, RightIndent, Before, After, LineSpacingRule, LineSpacing, Alignment, WidowControl, KeepWithNext,
  /// KeepTogether, PageBreak, NoLineNum, DontHyphen, Tab, FirstIndent, OutlineLevel, Kinsoku, WordWrap,
  /// OverflowPunct, TopLinePunct, AutoSpaceDE, LineHeightGrid, AutoSpaceDN, CharAlign, CharacterUnitLeftIndent,
  /// AdjustRight, CharacterUnitFirstIndent, CharacterUnitRightIndent, LineUnitBefore, LineUnitAfter,
  /// NoSpaceBetweenParagraphsOfSameStyle,
  /// </summary>
  [InteropEnumValue("wdDialogFormatParagraph")] 
  FormatParagraph = 175,
  /// <summary>
  /// SectionStart, VertAlign, IEndnotes, LineNum, StartingNum, FromText, CountBy, NumMode,
  /// </summary>
  [InteropEnumValue("wdDialogFormatSectionLayout")]
  FormatSectionLayout = 176,
  /// <summary>
  /// IColumns, ColumnNo, ColumnWidth, ColumnSpacing, EvenlySpaced, ApplyColsTo, ColLine, StartNewCol, FlowColumnsRtl
  /// </summary>
  [InteropEnumValue("wdDialogFormatColumns")]
  FormatColumns = 177,
  /// <summary>
  /// Tab, PaperSize, TopMargin, BottomMargin, LeftMargin, RightMargin, Gutter, PageWidth, PageHeight, Orientation,
  /// FirstPage, OtherPages, VertAlign, ApplyPropsTo, Default, FacingPages, HeaderDistance, FooterDistance,
  /// SectionStart, OddAndEvenPages, DifferentFirstPage, IEndnotes, LineNum, StartingNum, FromText, CountBy, NumMode,
  /// TwoOnOne, GutterPosition, LayoutMode, CharsLine, LinesPage, CharPitch, LinePitch, DocFontName, DocFontSize,
  /// PageColumns, TextFlow, FirstPageOnLeft, SectionType, RTLAlignment, FolioPrint
  /// </summary>
  [InteropEnumValue("wdDialogFilePageSetup")]
  FilePageSetup = 178,
  /// <summary>
  /// Tab, PaperSize, TopMargin, BottomMargin, LeftMargin, RightMargin, Gutter, PageWidth, PageHeight, Orientation,
  /// FirstPage, OtherPages, VertAlign, ApplyPropsTo, Default, FacingPages, HeaderDistance, FooterDistance,
  /// SectionStart, OddAndEvenPages, DifferentFirstPage, IEndnotes, LineNum, StartingNum, FromText, CountBy, NumMode,
  /// TwoOnOne, GutterPosition, LayoutMode, CharsLine, LinesPage, CharPitch, LinePitch, DocFontName, DocFontSize,
  /// PageColumns, TextFlow, FirstPageOnLeft, SectionType, RTLAlignment
  /// </summary>
  [InteropEnumValue("wdDialogFileDocumentLayout")]
  FileDocumentLayout = 178,
  /// <summary>
  /// Position, DefTabs, Align, Leader, Set, Clear,
  /// </summary>
  [InteropEnumValue("wdDialogFormatTabs")]
  FormatTabs = 179,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogFormatStyle")]
  FormatStyle = 180,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogFormatDefineStyleFont")]
  FormatDefineStyleFont = 181,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogFormatDefineStylePara")]
  FormatDefineStylePara = 182,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogFormatDefineStyleTabs")]
  FormatDefineStyleTabs = 183,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogFormatDefineStyleFrame")]
  FormatDefineStyleFrame = 184,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogFormatDefineStyleBorders")]
  FormatDefineStyleBorders = 185,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogFormatDefineStyleLang")]
  FormatDefineStyleLang = 186,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogFormatPicture")]
  FormatPicture = 187,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsLanguage")]
  ToolsLanguage = 188,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogFormatBordersAndShading")]
  FormatBordersAndShading = 189,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogFormatFrame")]
  FormatFrame = 190,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsThesaurus")]
  ToolsThesaurus = 194,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsHyphenation")]
  ToolsHyphenation = 195,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsBulletsNumbers")]
  ToolsBulletsNumbers = 196,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsRevisions")]
  ToolsRevisions = 197,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsHighlightChanges")]
  ToolsHighlightChanges = 197,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsCompareDocuments")]
  ToolsCompareDocuments = 198,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogTableSort")]
  TableSort = 199,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsOptionsGeneral")]
  ToolsOptionsGeneral = 203,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsOptionsView")]
  ToolsOptionsView = 204,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsOptionsAdvanced")]
  ToolsAdvancedSettings = 206,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsOptionsPrint")]
  ToolsOptionsPrint = 208,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsOptionsSave")]
  ToolsOptionsSave = 209,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsOptionsSpellingAndGrammar")]
  ToolsOptionsSpellingAndGrammar = 211,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsOptionsUserInfo")]
  ToolsOptionsUserInfo = 213,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsMacroRecord")]
  ToolsMacroRecord = 214,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsMacro")]
  ToolsMacro = 215,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogWindowActivate")]
  WindowActivate = 220,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogFormatRetAddrFonts")]
  FormatRetAddrFonts = 221,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogOrganizer")]
  Organizer = 222,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsOptionsEdit")]
  ToolsOptionsEdit = 224,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsOptionsFileLocations")]
  ToolsOptionsFileLocations = 225,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsWordCount")]
  ToolsWordCount = 228,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogControlRun")]
  ControlRun = 235,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogInsertPageNumbers")]
  InsertPageNumbers = 294,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogFormatPageNumber")]
  FormatPageNumber = 298,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogCopyFile")]
  CopyFile = 300,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogFormatChangeCase")]
  FormatChangeCase = 322,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogUpdateTOC")]
  UpdateTOC = 331,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogInsertDatabase")]
  InsertDatabase = 341,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogTableFormula")]
  TableFormula = 348,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogFormFieldOptions")]
  FormFieldOptions = 353,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogInsertCaption")]
  InsertCaption = 357,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogInsertCaptionNumbering")]
  InsertCaptionNumbering = 358,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogInsertAutoCaption")]
  InsertAutoCaption = 359,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogFormFieldHelp")]
  FormFieldHelp = 361,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogInsertCrossReference")]
  InsertCrossReference = 367,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogInsertFootnote")]
  InsertFootnote = 370,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogNoteOptions")]
  NoteOptions = 373,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsAutoCorrect")]
  ToolsAutoCorrect = 378,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsOptionsTrackChanges")]
  ToolsOptionsTrackChanges = 386,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogConvertObject")]
  ConvertObject = 392,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogInsertAddCaption")]
  InsertAddCaption = 402,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogConnect")]
  Connect = 420,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsCustomizeKeyboard")]
  ToolsCustomizeKeyboard = 432,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsCustomizeMenus")]
  ToolsCustomizeMenus = 433,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsMergeDocuments")]
  ToolsMergeDocuments = 435,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogMarkTableOfContentsEntry")]
  MarkTableOfContentsEntry = 442,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogFileMacPageSetupGX")]
  FileMacPageSetupGX = 444,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogFilePrintOneCopy")]
  FilePrintOneCopy = 445,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogEditFrame")]
  EditFrame = 458,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogMarkCitation")]
  MarkCitation = 463,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogTableOfContentsOptions")]
  TableOfContentsOptions = 470,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogInsertTableOfAuthorities")]
  InsertTableOfAuthorities = 471,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogInsertTableOfFigures")]
  InsertTableOfFigures = 472,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogInsertIndexAndTables")]
  InsertIndexAndTables = 473,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogInsertFormField")]
  InsertFormField = 483,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogFormatDropCap")]
  FormatDropCap = 488,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsCreateLabels")]
  ToolsCreateLabels = 489,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsProtectDocument")]
  ToolsProtectDocument = 503,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogFormatStyleGallery")]
  FormatStyleGallery = 505,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsAcceptRejectChanges")]
  ToolsAcceptRejectChanges = 506,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogHelpWordPerfectHelpOptions")]
  HelpWordPerfectHelpOptions = 511,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsUnprotectDocument")]
  ToolsUnprotectDocument = 521,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsOptionsCompatibility")]
  ToolsOptionsCompatibility = 525,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogTableOfCaptionsOptions")]
  TableOfCaptionsOptions = 551,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogTableAutoFormat")]
  TableAutoFormat = 563,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogMailMergeFindRecord")]
  MailMergeFindRecord = 569,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogReviewAfmtRevisions")]
  ReviewAfmtRevisions = 570,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogViewZoom")]
  ViewZoom = 577,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsProtectSection")]
  ToolsProtectSection = 578,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogFontSubstitution")]
  FontSubstitution = 581,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogInsertSubdocument")]
  InsertSubdocument = 583,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogNewToolbar")]
  NewToolbar = 586,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsEnvelopesAndLabels")]
  ToolsEnvelopesAndLabels = 607,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogFormatCallout")]
  FormatCallout = 610,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogTableFormatCell")]
  TableFormatCell = 612,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsCustomizeMenuBar")]
  ToolsCustomizeMenuBar = 615,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogFileRoutingSlip")]
  FileRoutingSlip = 624,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogEditTOACategory")]
  EditTOACategory = 625,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsManageFields")]
  ToolsManageFields = 631,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogDrawSnapToGrid")]
  DrawSnapToGrid = 633,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogDrawAlign")]
  DrawAlign = 634,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogMailMergeCreateDataSource")]
  MailMergeCreateDataSource = 642,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogMailMergeCreateHeaderSource")]
  MailMergeCreateHeaderSource = 643,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogIMailMerge")]
  IMailMerge = 676,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogMailMergeCheck")]
  MailMergeCheck = 677,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogMailMergeHelper")]
  MailMergeHelper = 680,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogMailMergeQueryOptions")]
  MailMergeQueryOptions = 681,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogFileMacPageSetup")]
  FileMacPageSetup = 685,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogListCommands")]
  ListCommands = 723,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogEditCreatePublisher")]
  EditCreatePublisher = 732,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogEditSubscribeTo")]
  EditSubscribeTo = 733,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogEditPublishOptions")]
  EditPublishOptions = 735,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogEditSubscribeOptions")]
  EditSubscribeOptions = 736,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogFileMacCustomPageSetupGX")]
  FileMacCustomPageSetupGX = 737,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsOptionsTypography")]
  ToolsOptionsTypography = 739,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsAutoCorrectExceptions")]
  ToolsAutoCorrectExceptions = 762,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsOptionsAutoFormatAsYouType")]
  ToolsOptionsAutoFormatAsYouType = 778,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogMailMergeUseAddressBook")]
  MailMergeUseAddressBook = 779,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsHangulHanjaConversion")]
  ToolsHangulHanjaConversion = 784,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsOptionsFuzzy")]
  ToolsOptionsFuzzy = 790,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogEditGoToOld")]
  EditGoToOld = 811,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogInsertNumber")]
  InsertNumber = 812,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogLetterWizard")]
  LetterWizard = 821,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogFormatBulletsAndNumbering")]
  FormatBulletsAndNumbering = 824,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsSpellingAndGrammar")]
  ToolsSpellingAndGrammar = 828,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsCreateDirectory")]
  ToolsCreateDirectory = 833,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogTableWrapping")]
  TableWrapping = 854,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogFormatTheme")]
  FormatTheme = 855,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogTableProperties")]
  TableProperties = 861,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogIEmailOptions")]
  IEmailOptions = 863,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogCreateAutoText")]
  CreateAutoText = 872,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsAutoSummarize")]
  ToolsAutoSummarize = 874,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsGrammarSettings")]
  ToolsGrammarSettings = 885,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogEditGoTo")]
  EditGoTo = 896,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogIWebOptions")]
  IWebOptions = 898,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsAutoManager")]
  ToolsAutoManager = 915,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogInsertHyperlink")]
  InsertHyperlink = 925,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogFileVersions")]
  FileVersions = 945,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsOptionsAutoFormat")]
  ToolsOptionsAutoFormat = 959,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogFormatDrawingObject")]
  FormatDrawingObject = 960,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsOptions")]
  ToolsOptions = 974,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogFitText")]
  FitText = 983,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogEditAutoText")]
  EditAutoText = 985,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogPhoneticGuide")]
  PhoneticGuide = 986,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsDictionary")]
  ToolsDictionary = 989,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogFileSaveVersion")]
  FileSaveVersion = 1007,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsOptionsBidi")]
  ToolsOptionsBidi = 1029,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogFrameSetProperties")]
  FrameSetProperties = 1074,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogTableTableOptions")]
  TableTableOptions = 1080,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogTableCellOptions")]
  TableCellOptions = 1081,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogIMESetDefault")]
  IMESetDefault = 1094,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogFileNew2007")]
  FileNew2007 = 1116,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogConsistencyChecker")]
  ConsistencyChecker = 1121,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogTCSCTranslator")]
  TCSCTranslator = 1156,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogHorizontalInVertical")]
  HorizontalInVertical = 1160,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogTwoLinesInOne")]
  TwoLinesInOne = 1161,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogFormatEncloseCharacters")]
  FormatEncloseCharacters = 1162,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogFormatStylesCustom")]
  FormatStylesCustom = 1248,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogCSSLinks")]
  CSSLinks = 1261,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogMailMergeFieldMapping")]
  MailMergeFieldMapping = 1304,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogMailMergeInsertAddressBlock")]
  MailMergeInsertAddressBlock = 1305,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogMailMergeInsertGreetingLine")]
  MailMergeInsertGreetingLine = 1306,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogMailMergeInsertFields")]
  MailMergeInsertFields = 1307,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogMailMergeRecipients")]
  MailMergeRecipients = 1308,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogInsertWebComponent")]
  InsertWebComponent = 1324,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogMailMergeFindRecipient")]
  MailMergeFindRecipient = 1326,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogMailMergeSetDocumentType")]
  MailMergeSetDocumentType = 1339,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsOptionsEditCopyPaste")]
  ToolsOptionsEditCopyPaste = 1356,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsOptionsSecurity")]
  ToolsOptionsSecurity = 1361,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogSearch")]
  Search = 1363,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogLabelOptions")]
  LabelOptions = 1367,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogShowRepairs")]
  ShowRepairs = 1381,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogToolsOptionsSmartTag")]
  ToolsOptionsSmartTag = 1395,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogSchemaLibrary")]
  SchemaLibrary = 1417,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogXMLOptions")]
  XMLOptions = 1425,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogFormattingRestrictions")]
  FormattingRestrictions = 1427,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogMyPermission")]
  MyPermission = 1437,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogXMLElementAttributes")]
  XMLElementAttributes = 1460,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogPermission")]
  Permission = 1469,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogDocumentInspector")]
  DocumentInspector = 1482,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogSourceManager")]
  SourceManager = 1920,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogCreateSource")]
  CreateSource = 1922,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogStyleManagement")]
  StyleManagement = 1948,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogBuildingBlockOrganizer")]
  BuildingBlockOrganizer = 2067,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogInsertSource")]
  InsertSource = 2120,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogIOMathRecognizedFunctions")]
  IOMathRecognizedFunctions = 2165,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogInsertPlaceholder")]
  InsertPlaceholder = 2348,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogExportAsFixedFormat")]
  ExportAsFixedFormat = 2349,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogContentControlProperties")]
  ContentControlProperties = 2394,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogCompatibilityChecker")]
  CompatibilityChecker = 2439,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogMailMergeInsertAsk")]
  MailMergeInsertAsk = 4047,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogMailMergeInsertFillIn")]
  MailMergeInsertFillIn = 4048,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogMailMergeInsertIf")]
  MailMergeInsertIf = 4049,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogMailMergeInsertNextIf")]
  MailMergeInsertNextIf = 4053,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogMailMergeInsertSet")]
  MailMergeInsertSet = 4054,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [InteropEnumValue("wdDialogMailMergeInsertSkipIf")]
  MailMergeInsertSkipIf = 4055
}


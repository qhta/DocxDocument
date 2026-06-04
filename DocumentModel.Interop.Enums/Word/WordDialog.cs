namespace DocumentModel.Interop.Word;

/// <summary>
/// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
/// applicable, that you can use to get or set values in a dialog box.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdworddialog?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdWordDialog")]
public enum WordDialog
{
  /// <summary>
  /// APPNAME, APPCOPYRIGHT, APPUSERNAME, APPORGANIZATION, APPSERIALNUMBER
  /// </summary>
  [WordInteropEnumValue("wdDialogHelpAbout")]
  HelpAbout = 9,
  /// <summary>
  /// WPCommand, HelpText, DemoGuidance
  /// </summary>
  [WordInteropEnumValue("wdDialogHelpWordPerfectHelp")]
  HelpWordPerfectHelp = 10,
  /// <summary>
  /// FileName, Directory, Template, Title, Created, LastSaved, LastSavedBy, Revision, Time, Printed, Pages, Words,
  /// Characters, Paragraphs, Lines,
  /// </summary>
  [WordInteropEnumValue("wdDialogDocumentStatistics")]
  DocumentStatistics = 78,
  /// <summary>
  /// Template, NewTemplate, DocumentType, Visible
  /// </summary>
  [WordInteropEnumValue("wdDialogFileNew")]
  FileNew = 79,
  /// <summary>
  /// Name, ConfirmConversions, ReadOnly, LinkToSource, AddToMru, PasswordDoc, PasswordDot, Revert,
  /// WritePasswordDoc, WritePasswordDot, Connection, SQLStatement, SQLStatement1, Format, Encoding, Visible,
  /// OpenExclusive, OpenAndRepair, SubType,
  /// </summary>
  [WordInteropEnumValue("wdDialogFileOpen")]
  FileOpen = 80,
  /// <summary>
  /// No description is available.
  /// </summary>
  [WordInteropEnumValue("wdDialogMailMergeOpenDataSource")]
  MailMergeOpenDataSource = 81,
  /// <summary>
  /// No description is available.
  /// </summary>
  [WordInteropEnumValue("wdDialogMailMergeOpenHeaderSource")]
  MailMergeOpenHeaderSource = 82,
  /// <summary>
  /// Name, Format, LockAnnot, Password, AddToMru, WritePassword, RecommendReadOnly, EmbedFonts,
  /// NativePictureFormat, FormsData, SaveAsAOCELetter, WriteVersion, VersionDesc, InsertLineBreaks,
  /// AllowSubstitutions, LineEnding,
  /// </summary>
  [WordInteropEnumValue("wdDialogFileSaveAs")]
  FileSaveAs = 84,
  /// <summary>
  /// Title, Subject, Author, Keywords, Comments, FileName, Directory, Template, CreateDate, LastSavedDate,
  /// LastSavedBy, RevisionNumber, EditTime, LastPrintedDate, NumPages, NumWords, NumChars, NumParas, NumLines,
  /// Update, FileSize
  /// </summary>
  [WordInteropEnumValue("wdDialogFileSummaryInfo")]
  FileSummaryInfo = 86,
  /// <summary>
  /// No description is available.
  /// </summary>
  [WordInteropEnumValue("wdDialogToolsTemplates")]
  ToolsTemplates = 87,
  /// <summary>
  /// Background, AppendPrFile, Range, PrToFileName, From, To, Type, NumCopies, Pages, Order, PrintToFile, Collate,
  /// FileName, Printer, OutputPrinter, DuplexPrint, PrintZoomColumn, PrintZoomRow, PrintZoomPaperWidth,
  /// PrintZoomPaperHeight, ZoomPaper
  /// </summary>
  [WordInteropEnumValue("wdDialogFilePrint")]
  FilePrint = 88,
  /// <summary>
  /// Printer, Options, Network, DoNotSetAsSysDefault
  /// </summary>
  [WordInteropEnumValue("wdDialogFilePrintSetup")]
  FilePrintSetup = 97,
  /// <summary>
  /// SearchName, SearchPath, Name, SubDir, Title, Author, Keywords, Subject, Options, MatchCase, Text,
  /// PatternMatch, DateSavedFrom, DateSavedTo, SavedBy, DateCreatedFrom, DateCreatedTo, View, SortBy, ListBy,
  /// SelectedFile, Add, Delete, ShowFolders, MatchByte
  /// </summary>
  [WordInteropEnumValue("wdDialogFileFind")]
  FileFind = 99,
  /// <summary>
  /// Points, Underline, Color, StrikeThrough, Superscript, Subscript, Hidden, SmallCaps, AllCaps, Spacing,
  /// Position, Kerning, KerningMin, Default, Tab, Font, Bold, Italic, DoubleStrikeThrough, Shadow, Outline, Emboss,
  /// Engrave, Scale, Animations, CharAccent, FontMajor, FontLowAnsi, FontHighAnsi, CharacterWidthGrid, ColorRGB,
  /// UnderlineColor, PointsBi, ColorBi, NameBi, BoldBi, ItalicBi,
  /// </summary>
  [WordInteropEnumValue("wdDialogFormatAddrFonts")]
  FormatAddrFonts = 103,
  /// <summary>
  /// IconNumber, Link, DisplayIcon, Class, DataType, IconFileName, Caption, Floating
  /// </summary>
  [WordInteropEnumValue("wdDialogEditPasteSpecial")]
  EditPasteSpecial = 111,
  /// <summary>
  /// Find, Replace, Direction, MatchCase, WholeWord, PatternMatch, SoundsLike, FindNext, ReplaceOne, ReplaceAll,
  /// Format, Wrap, FindAllWordForms, MatchByte, FuzzyFind, Destination, CorrectEnd, MatchKashida, MatchDiacritics,
  /// MatchAlefHamza,
  /// </summary>
  [WordInteropEnumValue("wdDialogEditFind")]
  EditFind = 112,
  /// <summary>
  /// Find, Replace, Direction, MatchCase, WholeWord, PatternMatch, SoundsLike, FindNext, ReplaceOne, ReplaceAll,
  /// Format, Wrap, FindAllWordForms, MatchByte, FuzzyFind, Destination, CorrectEnd, MatchKashida, MatchDiacritics,
  /// MatchAlefHamza,
  /// </summary>
  [WordInteropEnumValue("wdDialogEditReplace")]
  EditReplace = 117,
  /// <summary>
  /// (none)
  /// </summary>
  [WordInteropEnumValue("wdDialogEditStyle")]
  EditStyle = 120,
  /// <summary>
  /// UpdateMode, Locked, SavePictureInDoc, UpdateNow, OpenSource, KillLink, Link, Application, Item, FileName,
  /// </summary>
  [WordInteropEnumValue("wdDialogEditLinks")]
  EditLinks = 124,
  /// <summary>
  /// Verb
  /// </summary>
  [WordInteropEnumValue("wdDialogEditObject")]
  EditObject = 125,
  /// <summary>
  /// No description is available.
  /// </summary>
  [WordInteropEnumValue("wdDialogTextToTable")]
  TextToTable = 127,
  /// <summary>
  /// No description is available.
  /// </summary>
  [WordInteropEnumValue("wdDialogTableToText")]
  TableToText = 128,
  /// <summary>
  /// No description is available.
  /// </summary>
  [WordInteropEnumValue("wdDialogTableInsertTable")]
  TableInsertTable = 129,
  /// <summary>
  /// No description is available.
  /// </summary>
  [WordInteropEnumValue("wdDialogTableInsertCells")]
  TableInsertCells = 130,
  /// <summary>
  /// No description is available.
  /// </summary>
  [WordInteropEnumValue("wdDialogTableInsertRow")]
  TableInsertRow = 131,
  /// <summary>
  /// No description is available.
  /// </summary>
  [WordInteropEnumValue("wdDialogTableDeleteCells")]
  TableDeleteCells = 133,
  /// <summary>
  /// No description is available.
  /// </summary>
  [WordInteropEnumValue("wdDialogTableSplitCells")]
  TableSplitCells = 137,
  /// <summary>
  /// No description is available.
  /// </summary>
  [WordInteropEnumValue("wdDialogTableRowHeight")]
  TableRowHeight = 142,
  /// <summary>
  /// No description is available.
  /// </summary>
  [WordInteropEnumValue("wdDialogTableColumnWidth")]
  TableColumnWidth = 143,
  /// <summary>
  /// No description is available.
  /// </summary>
  [WordInteropEnumValue("wdDialogToolsCustomize")]
  ToolsCustomize = 152,
  /// <summary>
  /// Type
  /// </summary>
  [WordInteropEnumValue("wdDialogInsertBreak")]
  InsertBreak = 159,
  /// <summary>
  /// Font, Tab, CharNum, CharNumLow, Unicode, Hint
  /// </summary>
  [WordInteropEnumValue("wdDialogInsertSymbol")]
  InsertSymbol = 162,
  /// <summary>
  /// Name, LinkToFile, New, FloatOverText
  /// </summary>
  [WordInteropEnumValue("wdDialogInsertPicture")]
  InsertPicture = 163,
  /// <summary>
  /// Name, Range, ConfirmConversions, Link,
  /// </summary>
  [WordInteropEnumValue("wdDialogInsertFile")]
  InsertFile = 164,
  /// <summary>
  /// DateTimePic, InsertAsField, DbCharField, DateLanguage, CalendarType
  /// </summary>
  [WordInteropEnumValue("wdDialogInsertDateTime")]
  InsertDateTime = 165,
  /// <summary>
  /// Field
  /// </summary>
  [WordInteropEnumValue("wdDialogInsertField")]
  InsertField = 166,
  /// <summary>
  /// MergeField, WordField
  /// </summary>
  [WordInteropEnumValue("wdDialogInsertMergeField")]
  InsertMergeField = 167,
  /// <summary>
  /// Name, SortBy, Add, Delete, Goto, Hidden
  /// </summary>
  [WordInteropEnumValue("wdDialogInsertBookmark")]
  InsertBookmark = 168,
  /// <summary>
  /// No description is available.
  /// </summary>
  [WordInteropEnumValue("wdDialogMarkIndexEntry")]
  MarkIndexEntry = 169,
  /// <summary>
  /// Outline, Fields, From, To, TableId, AddedStyles, Caption, HeadingSeparator, Replace, MarkEntry, AutoMark,
  /// MarkCitation, Type, RightAlignPageNumbers, Passim, KeepFormatting, Columns, Category, Label, ShowPageNumbers,
  /// AccentedLetters, Filter, SortBy, Leader, TOCUseHyperlinks, TOCHidePageNumInWeb, IndexLanguage,
  /// </summary>
  [WordInteropEnumValue("wdDialogInsertIndex")]
  InsertIndex = 170,
  /// <summary>
  /// Outline, Fields, From, To, TableId, AddedStyles, Caption, HeadingSeparator, Replace, MarkEntry, AutoMark,
  /// MarkCitation, Type, RightAlignPageNumbers, Passim, KeepFormatting, Columns, Category, Label, ShowPageNumbers,
  /// AccentedLetters, Filter, SortBy, Leader, TOCUseHyperlinks, TOCHidePageNumInWeb, IndexLanguage,
  /// </summary>
  [WordInteropEnumValue("wdDialogInsertTableOfContents")]
  InsertTableOfContents = 171,
  /// <summary>
  /// IconNumber, FileName, Link, DisplayIcon, Tab, Class, IconFileName, Caption, Floating
  /// </summary>
  [WordInteropEnumValue("wdDialogInsertObject")]
  InsertObject = 172,
  /// <summary>
  /// No description is available.
  /// </summary>
  [WordInteropEnumValue("wdDialogToolsCreateEnvelope")]
  ToolsCreateEnvelope = 173,
  /// <summary>
  /// Points, Underline, Color, StrikeThrough, Superscript, Subscript, Hidden, SmallCaps, AllCaps, Spacing,
  /// Position, Kerning, KerningMin, Default, Tab, Font, Bold, Italic, DoubleStrikeThrough, Shadow, Outline, Emboss,
  /// Engrave, Scale, Animations, CharAccent, FontMajor, FontLowAnsi, FontHighAnsi, CharacterWidthGrid, ColorRGB,
  /// UnderlineColor, PointsBi, ColorBi, NameBi, BoldBi, ItalicBi,
  /// </summary>
  [WordInteropEnumValue("wdDialogFormatFont")]
  FormatFont = 174,
  /// <summary>
  /// LeftIndent, RightIndent, Before, After, LineSpacingRule, LineSpacing, Alignment, WidowControl, KeepWithNext,
  /// KeepTogether, PageBreak, NoLineNum, DontHyphen, Tab, FirstIndent, OutlineLevel, Kinsoku, WordWrap,
  /// OverflowPunct, TopLinePunct, AutoSpaceDE, LineHeightGrid, AutoSpaceDN, CharAlign, CharacterUnitLeftIndent,
  /// AdjustRight, CharacterUnitFirstIndent, CharacterUnitRightIndent, LineUnitBefore, LineUnitAfter,
  /// NoSpaceBetweenParagraphsOfSameStyle,
  /// </summary>
  [WordInteropEnumValue("wdDialogFormatParagraph")]
  FormatParagraph = 175,
  /// <summary>
  /// SectionStart, VertAlign, Endnotes, LineNum, StartingNum, FromText, CountBy, NumMode,
  /// </summary>
  [WordInteropEnumValue("wdDialogFormatSectionLayout")]
  FormatSectionLayout = 176,
  /// <summary>
  /// Columns, ColumnNo, ColumnWidth, ColumnSpacing, EvenlySpaced, ApplyColsTo, ColLine, StartNewCol, FlowColumnsRtl
  /// </summary>
  [WordInteropEnumValue("wdDialogFormatColumns")]
  FormatColumns = 177,
  /// <summary>
  /// Tab, PaperSize, TopMargin, BottomMargin, LeftMargin, RightMargin, Gutter, PageWidth, PageHeight, Orientation,
  /// FirstPage, OtherPages, VertAlign, ApplyPropsTo, Default, FacingPages, HeaderDistance, FooterDistance,
  /// SectionStart, OddAndEvenPages, DifferentFirstPage, Endnotes, LineNum, StartingNum, FromText, CountBy, NumMode,
  /// TwoOnOne, GutterPosition, LayoutMode, CharsLine, LinesPage, CharPitch, LinePitch, DocName, DocFontSize,
  /// PageColumns, TextFlow, FirstPageOnLeft, SectionType, RTLAlignment, FolioPrint
  /// </summary>
  [WordInteropEnumValue("wdDialogFilePageSetup")]
  FilePageSetup = 178,
  /// <summary>
  /// Tab, PaperSize, TopMargin, BottomMargin, LeftMargin, RightMargin, Gutter, PageWidth, PageHeight, Orientation,
  /// FirstPage, OtherPages, VertAlign, ApplyPropsTo, Default, FacingPages, HeaderDistance, FooterDistance,
  /// SectionStart, OddAndEvenPages, DifferentFirstPage, Endnotes, LineNum, StartingNum, FromText, CountBy, NumMode,
  /// TwoOnOne, GutterPosition, LayoutMode, CharsLine, LinesPage, CharPitch, LinePitch, DocName, DocFontSize,
  /// PageColumns, TextFlow, FirstPageOnLeft, SectionType, RTLAlignment
  /// </summary>
  [WordInteropEnumValue("wdDialogFileDocumentLayout")]
  FileDocumentLayout = 178,
  /// <summary>
  /// Position, DefTabs, Align, Leader, Set, Clear,
  /// </summary>
  [WordInteropEnumValue("wdDialogFormatTabs")]
  FormatTabs = 179,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogFormatStyle")]
  FormatStyle = 180,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogFormatDefineStyleFont")]
  FormatDefineStyleFont = 181,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogFormatDefineStylePara")]
  FormatDefineStylePara = 182,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogFormatDefineStyleTabs")]
  FormatDefineStyleTabs = 183,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogFormatDefineStyleFrame")]
  FormatDefineStyleFrame = 184,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogFormatDefineStyleBorders")]
  FormatDefineStyleBorders = 185,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogFormatDefineStyleLang")]
  FormatDefineStyleLang = 186,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogFormatPicture")]
  FormatPicture = 187,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogToolsLanguage")]
  ToolsLanguage = 188,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogFormatBordersAndShading")]
  FormatBordersAndShading = 189,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogFormatFrame")]
  FormatFrame = 190,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogToolsThesaurus")]
  ToolsThesaurus = 194,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogToolsHyphenation")]
  ToolsHyphenation = 195,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogToolsBulletsNumbers")]
  ToolsBulletsNumbers = 196,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogToolsRevisions")]
  ToolsRevisions = 197,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogToolsHighlightChanges")]
  ToolsHighlightChanges = 197,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogToolsCompareDocuments")]
  ToolsCompareDocuments = 198,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogTableSort")]
  TableSort = 199,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogToolsOptionsGeneral")]
  ToolsOptionsGeneral = 203,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogToolsOptionsView")]
  ToolsOptionsView = 204,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogToolsAdvancedSettings")]
  ToolsAdvancedSettings = 206,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogToolsOptionsPrint")]
  ToolsOptionsPrint = 208,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogToolsOptionsSave")]
  ToolsOptionsSave = 209,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogToolsOptionsSpellingAndGrammar")]
  ToolsOptionsSpellingAndGrammar = 211,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogToolsOptionsUserInfo")]
  ToolsOptionsUserInfo = 213,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogToolsMacroRecord")]
  ToolsMacroRecord = 214,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogToolsMacro")]
  ToolsMacro = 215,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogWindowActivate")]
  WindowActivate = 220,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogFormatRetAddrFonts")]
  FormatRetAddrFonts = 221,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogOrganizer")]
  Organizer = 222,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogToolsOptionsEdit")]
  ToolsOptionsEdit = 224,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogToolsOptionsFileLocations")]
  ToolsOptionsFileLocations = 225,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogToolsWordCount")]
  ToolsWordCount = 228,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogControlRun")]
  ControlRun = 235,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogInsertPageNumbers")]
  InsertPageNumbers = 294,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogFormatPageNumber")]
  FormatPageNumber = 298,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogCopyFile")]
  CopyFile = 300,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogFormatChangeCase")]
  FormatChangeCase = 322,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogUpdateTOC")]
  UpdateTOC = 331,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogInsertDatabase")]
  InsertDatabase = 341,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogTableFormula")]
  TableFormula = 348,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogFormFieldOptions")]
  FormFieldOptions = 353,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogInsertCaption")]
  InsertCaption = 357,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogInsertCaptionNumbering")]
  InsertCaptionNumbering = 358,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogInsertAutoCaption")]
  InsertAutoCaption = 359,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogFormFieldHelp")]
  FormFieldHelp = 361,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogInsertCrossReference")]
  InsertCrossReference = 367,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogInsertFootnote")]
  InsertFootnote = 370,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogNoteOptions")]
  NoteOptions = 373,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogToolsAutoCorrect")]
  ToolsAutoCorrect = 378,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogToolsOptionsTrackChanges")]
  ToolsOptionsTrackChanges = 386,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogConvertObject")]
  ConvertObject = 392,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogInsertAddCaption")]
  InsertAddCaption = 402,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogConnect")]
  Connect = 420,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogToolsCustomizeKeyboard")]
  ToolsCustomizeKeyboard = 432,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogToolsCustomizeMenus")]
  ToolsCustomizeMenus = 433,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogToolsMergeDocuments")]
  ToolsMergeDocuments = 435,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogMarkTableOfContentsEntry")]
  MarkTableOfContentsEntry = 442,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogFileMacPageSetupGX")]
  FileMacPageSetupGX = 444,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogFilePrintOneCopy")]
  FilePrintOneCopy = 445,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogEditFrame")]
  EditFrame = 458,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogMarkCitation")]
  MarkCitation = 463,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogTableOfContentsOptions")]
  TableOfContentsOptions = 470,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogInsertTableOfAuthorities")]
  InsertTableOfAuthorities = 471,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogInsertTableOfFigures")]
  InsertTableOfFigures = 472,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogInsertIndexAndTables")]
  InsertIndexAndTables = 473,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogInsertFormField")]
  InsertFormField = 483,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogFormatDropCap")]
  FormatDropCap = 488,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogToolsCreateLabels")]
  ToolsCreateLabels = 489,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogToolsProtectDocument")]
  ToolsProtectDocument = 503,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogFormatStyleGallery")]
  FormatStyleGallery = 505,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogToolsAcceptRejectChanges")]
  ToolsAcceptRejectChanges = 506,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogHelpWordPerfectHelpOptions")]
  HelpWordPerfectHelpOptions = 511,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogToolsUnprotectDocument")]
  ToolsUnprotectDocument = 521,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogToolsOptionsCompatibility")]
  ToolsOptionsCompatibility = 525,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogTableOfCaptionsOptions")]
  TableOfCaptionsOptions = 551,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogTableAutoFormat")]
  TableAutoFormat = 563,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogMailMergeFindRecord")]
  MailMergeFindRecord = 569,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogReviewAfmtRevisions")]
  ReviewAfmtRevisions = 570,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogViewZoom")]
  ViewZoom = 577,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogToolsProtectSection")]
  ToolsProtectSection = 578,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogFontSubstitution")]
  FontSubstitution = 581,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogInsertSubdocument")]
  InsertSubdocument = 583,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogNewToolbar")]
  NewToolbar = 586,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogToolsEnvelopesAndLabels")]
  ToolsEnvelopesAndLabels = 607,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogFormatCallout")]
  FormatCallout = 610,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogTableFormatCell")]
  TableFormatCell = 612,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogToolsCustomizeMenuBar")]
  ToolsCustomizeMenuBar = 615,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogFileRoutingSlip")]
  FileRoutingSlip = 624,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogEditTOACategory")]
  EditTOACategory = 625,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogToolsManageFields")]
  ToolsManageFields = 631,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogDrawSnapToGrid")]
  DrawSnapToGrid = 633,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogDrawAlign")]
  DrawAlign = 634,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogMailMergeCreateDataSource")]
  MailMergeCreateDataSource = 642,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogMailMergeCreateHeaderSource")]
  MailMergeCreateHeaderSource = 643,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogMailMerge")]
  MailMerge = 676,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogMailMergeCheck")]
  MailMergeCheck = 677,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogMailMergeHelper")]
  MailMergeHelper = 680,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogMailMergeQueryOptions")]
  MailMergeQueryOptions = 681,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogFileMacPageSetup")]
  FileMacPageSetup = 685,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogListCommands")]
  ListCommands = 723,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogEditCreatePublisher")]
  EditCreatePublisher = 732,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogEditSubscribeTo")]
  EditSubscribeTo = 733,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogEditPublishOptions")]
  EditPublishOptions = 735,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogEditSubscribeOptions")]
  EditSubscribeOptions = 736,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogFileMacCustomPageSetupGX")]
  FileMacCustomPageSetupGX = 737,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogToolsOptionsTypography")]
  ToolsOptionsTypography = 739,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogToolsAutoCorrectExceptions")]
  ToolsAutoCorrectExceptions = 762,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogToolsOptionsAutoFormatAsYouType")]
  ToolsOptionsAutoFormatAsYouType = 778,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogMailMergeUseAddressBook")]
  MailMergeUseAddressBook = 779,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogToolsHangulHanjaConversion")]
  ToolsHangulHanjaConversion = 784,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogToolsOptionsFuzzy")]
  ToolsOptionsFuzzy = 790,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogEditGoToOld")]
  EditGoToOld = 811,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogInsertNumber")]
  InsertNumber = 812,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogLetterWizard")]
  LetterWizard = 821,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogFormatBulletsAndNumbering")]
  FormatBulletsAndNumbering = 824,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogToolsSpellingAndGrammar")]
  ToolsSpellingAndGrammar = 828,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogToolsCreateDirectory")]
  ToolsCreateDirectory = 833,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogTableWrapping")]
  TableWrapping = 854,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogFormatTheme")]
  FormatTheme = 855,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogTableProperties")]
  TableProperties = 861,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogEmailOptions")]
  EmailOptions = 863,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogCreateAutoText")]
  CreateAutoText = 872,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogToolsAutoSummarize")]
  ToolsAutoSummarize = 874,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogToolsGrammarSettings")]
  ToolsGrammarSettings = 885,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogEditGoTo")]
  EditGoTo = 896,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogWebOptions")]
  WebOptions = 898,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogToolsAutoManager")]
  ToolsAutoManager = 915,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogInsertHyperlink")]
  InsertHyperlink = 925,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogFileVersions")]
  FileVersions = 945,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogToolsOptionsAutoFormat")]
  ToolsOptionsAutoFormat = 959,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogFormatDrawingObject")]
  FormatDrawingObject = 960,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogToolsOptions")]
  ToolsOptions = 974,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogFitText")]
  FitText = 983,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogEditAutoText")]
  EditAutoText = 985,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogPhoneticGuide")]
  PhoneticGuide = 986,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogToolsDictionary")]
  ToolsDictionary = 989,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogFileSaveVersion")]
  FileSaveVersion = 1007,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogToolsOptionsBidi")]
  ToolsOptionsBidi = 1029,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogFrameSetProperties")]
  FrameSetProperties = 1074,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogTableTableOptions")]
  TableTableOptions = 1080,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogTableCellOptions")]
  TableCellOptions = 1081,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogIMESetDefault")]
  IMESetDefault = 1094,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogFileNew2007")]
  FileNew2007 = 1116,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogConsistencyChecker")]
  ConsistencyChecker = 1121,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogTCSCTranslator")]
  TCSCTranslator = 1156,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogHorizontalInVertical")]
  HorizontalInVertical = 1160,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogTwoLinesInOne")]
  TwoLinesInOne = 1161,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogFormatEncloseCharacters")]
  FormatEncloseCharacters = 1162,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogFormatStylesCustom")]
  FormatStylesCustom = 1248,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogCSSLinks")]
  CSSLinks = 1261,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogMailMergeFieldMapping")]
  MailMergeFieldMapping = 1304,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogMailMergeInsertAddressBlock")]
  MailMergeInsertAddressBlock = 1305,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogMailMergeInsertGreetingLine")]
  MailMergeInsertGreetingLine = 1306,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogMailMergeInsertFields")]
  MailMergeInsertFields = 1307,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogMailMergeRecipients")]
  MailMergeRecipients = 1308,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogInsertWebComponent")]
  InsertWebComponent = 1324,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogMailMergeFindRecipient")]
  MailMergeFindRecipient = 1326,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogMailMergeSetDocumentType")]
  MailMergeSetDocumentType = 1339,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogToolsOptionsEditCopyPaste")]
  ToolsOptionsEditCopyPaste = 1356,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogToolsOptionsSecurity")]
  ToolsOptionsSecurity = 1361,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogSearch")]
  Search = 1363,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogLabelOptions")]
  LabelOptions = 1367,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogShowRepairs")]
  ShowRepairs = 1381,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogToolsOptionsSmartTag")]
  ToolsOptionsSmartTag = 1395,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogSchemaLibrary")]
  SchemaLibrary = 1417,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogXMLOptions")]
  XMLOptions = 1425,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogFormattingRestrictions")]
  FormattingRestrictions = 1427,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogMyPermission")]
  MyPermission = 1437,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogXMLElementAttributes")]
  XMLElementAttributes = 1460,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogPermission")]
  Permission = 1469,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogDocumentInspector")]
  DocumentInspector = 1482,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogSourceManager")]
  SourceManager = 1920,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogCreateSource")]
  CreateSource = 1922,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogStyleManagement")]
  StyleManagement = 1948,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogBuildingBlockOrganizer")]
  BuildingBlockOrganizer = 2067,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogInsertSource")]
  InsertSource = 2120,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogOMathRecognizedFunctions")]
  OMathRecognizedFunctions = 2165,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogInsertPlaceholder")]
  InsertPlaceholder = 2348,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogExportAsFixedFormat")]
  ExportAsFixedFormat = 2349,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogContentControlProperties")]
  ContentControlProperties = 2394,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogCompatibilityChecker")]
  CompatibilityChecker = 2439,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogMailMergeInsertAsk")]
  MailMergeInsertAsk = 4047,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogMailMergeInsertFillIn")]
  MailMergeInsertFillIn = 4048,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogMailMergeInsertIf")]
  MailMergeInsertIf = 4049,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogMailMergeInsertNextIf")]
  MailMergeInsertNextIf = 4053,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogMailMergeInsertSet")]
  MailMergeInsertSet = 4054,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue("wdDialogMailMergeInsertSkipIf")]
  MailMergeInsertSkipIf = 4055
}

namespace DocumentModel.Interop.Word;

/// <summary>
/// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
/// applicable, that you can use to get or set values in a dialog box.
/// </summary>
public enum WdWordDialog
{
  /// <summary>
  /// APPNAME, APPCOPYRIGHT, APPUSERNAME, APPORGANIZATION, APPSERIALNUMBER
  /// </summary>
  HelpAbout = unchecked((int)9),
  /// <summary>
  /// WPCommand, HelpText, DemoGuidance
  /// </summary>
  HelpWordPerfectHelp = unchecked((int)10),
  /// <summary>
  /// FileName, Directory, Template, Title, Created, LastSaved, LastSavedBy, Revision, Time, Printed, Pages, Words,
  /// Characters, Paragraphs, Lines, FileSize
  /// </summary>
  DocumentStatistics = unchecked((int)78),
  /// <summary>
  /// Template, NewTemplate, DocumentType, Visible
  /// </summary>
  FileNew = unchecked((int)79),
  /// <summary>
  /// Name, ConfirmConversions, ReadOnly, LinkToSource, AddToMru, PasswordDoc, PasswordDot, Revert,
  /// WritePasswordDoc, WritePasswordDot, Connection, SQLStatement, SQLStatement1, Format, Encoding, Visible,
  /// OpenExclusive, OpenAndRepair, SubType,
  /// [System.Runtime.InteropServices.Guid("6EC6B31B-AA8E-31A3-8211-3ADB9601AC42")] public enum WdWordDialog ﾉ
  /// Expand table DocumentDirection, NoEncodingDialog, XMLTransform wdDialogMailMergeOpenDataSource81
  /// wdDialogMailMergeOpenHeaderSource82
  /// </summary>
  FileOpen = unchecked((int)80),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  MailMergeOpenDataSource = unchecked((int)81),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  MailMergeOpenHeaderSource = unchecked((int)82),
  /// <summary>
  /// Name, Format, LockAnnot, Password, AddToMru, WritePassword, RecommendReadOnly, EmbedFonts,
  /// NativePictureFormat, FormsData, SaveAsAOCELetter, WriteVersion, VersionDesc, InsertLineBreaks,
  /// AllowSubstitutions, LineEnding, AddBiDiMarks
  /// </summary>
  FileSaveAs = unchecked((int)84),
  /// <summary>
  /// Title, Subject, Author, Keywords, Comments, FileName, Directory, Template, CreateDate, LastSavedDate,
  /// LastSavedBy, RevisionNumber, EditTime, LastPrintedDate, NumPages, NumWords, NumChars, NumParas, NumLines,
  /// Update, FileSize
  /// </summary>
  FileSummaryInfo = unchecked((int)86),
  /// <summary>
  /// wdDialogFilePrint 88 Background, AppendPrFile, Range, PrToFileName, From, To, Type, NumCopies, Pages, Order,
  /// PrintToFile, Collate, FileName, Printer, OutputPrinter, DuplexPrint, PrintZoomColumn, PrintZoomRow,
  /// PrintZoomPaperWidth, PrintZoomPaperHeight, ZoomPaper
  /// </summary>
  ToolsTemplates = unchecked((int)87),
  /// <summary>
  /// Background, AppendPrFile, Range, PrToFileName, From, To, Type, NumCopies, Pages, Order, PrintToFile, Collate,
  /// FileName, Printer, OutputPrinter, DuplexPrint, PrintZoomColumn, PrintZoomRow, PrintZoomPaperWidth,
  /// PrintZoomPaperHeight, ZoomPaper
  /// </summary>
  FilePrint = unchecked((int)88),
  /// <summary>
  /// Printer, Options, Network, DoNotSetAsSysDefault
  /// </summary>
  FilePrintSetup = unchecked((int)97),
  /// <summary>
  /// SearchName, SearchPath, Name, SubDir, Title, Author, Keywords, Subject, Options, MatchCase, Text,
  /// PatternMatch, DateSavedFrom, DateSavedTo, SavedBy, DateCreatedFrom, DateCreatedTo, View, SortBy, ListBy,
  /// SelectedFile, Add, Delete, ShowFolders, MatchByte
  /// </summary>
  FileFind = unchecked((int)99),
  /// <summary>
  /// Points, Underline, Color, StrikeThrough, Superscript, Subscript, Hidden, SmallCaps, AllCaps, Spacing,
  /// Position, Kerning, KerningMin, Default, Tab, Font, Bold, Italic, DoubleStrikeThrough, Shadow, Outline, Emboss,
  /// Engrave, Scale, Animations, CharAccent, FontMajor, FontLowAnsi, FontHighAnsi, CharacterWidthGrid, ColorRGB,
  /// UnderlineColor, PointsBi, ColorBi, FontNameBi, BoldBi, ItalicBi, DiacColor
  /// </summary>
  FormatAddrFonts = unchecked((int)103),
  /// <summary>
  /// IconNumber, Link, DisplayIcon, Class, DataType, IconFileName, Caption, Floating
  /// </summary>
  EditPasteSpecial = unchecked((int)111),
  /// <summary>
  /// Find, Replace, Direction, MatchCase, WholeWord, PatternMatch, SoundsLike, FindNext, ReplaceOne, ReplaceAll,
  /// Format, Wrap, FindAllWordForms, MatchByte, FuzzyFind, Destination, CorrectEnd, MatchKashida, MatchDiacritics,
  /// MatchAlefHamza, MatchControl
  /// </summary>
  EditFind = unchecked((int)112),
  /// <summary>
  /// Find, Replace, Direction, MatchCase, WholeWord, PatternMatch, SoundsLike, FindNext, ReplaceOne, ReplaceAll,
  /// Format, Wrap, FindAllWordForms, MatchByte, FuzzyFind, Destination, CorrectEnd, MatchKashida, MatchDiacritics,
  /// MatchAlefHamza, MatchControl
  /// </summary>
  EditReplace = unchecked((int)117),
  /// <summary>
  /// (none)
  /// </summary>
  EditStyle = unchecked((int)120),
  /// <summary>
  /// UpdateMode, Locked, SavePictureInDoc, UpdateNow, OpenSource, KillLink, Link, Application, Item, FileName,
  /// PreserveFormatLinkUpdate
  /// </summary>
  EditLinks = unchecked((int)124),
  /// <summary>
  /// Verb
  /// </summary>
  EditObject = unchecked((int)125),
  /// <summary>
  /// wdDialogTableToText 128
  /// </summary>
  TextToTable = unchecked((int)127),
  /// <summary>
  /// wdDialogTableInsertTable 129
  /// </summary>
  TableToText = unchecked((int)128),
  /// <summary>
  /// wdDialogTableInsertCells 130
  /// </summary>
  TableInsertTable = unchecked((int)129),
  /// <summary>
  /// wdDialogTableInsertRow 131
  /// </summary>
  TableInsertCells = unchecked((int)130),
  /// <summary>
  /// wdDialogTableDeleteCells 133
  /// </summary>
  TableInsertRow = unchecked((int)131),
  /// <summary>
  /// wdDialogTableSplitCells 137
  /// </summary>
  TableDeleteCells = unchecked((int)133),
  /// <summary>
  /// wdDialogTableRowHeight 142
  /// </summary>
  TableSplitCells = unchecked((int)137),
  /// <summary>
  /// wdDialogTableColumnWidth 143
  /// </summary>
  TableRowHeight = unchecked((int)142),
  /// <summary>
  /// wdDialogToolsCustomize 152
  /// </summary>
  TableColumnWidth = unchecked((int)143),
  /// <summary>
  /// wdDialogInsertBreak 159 Type
  /// </summary>
  ToolsCustomize = unchecked((int)152),
  /// <summary>
  /// Type
  /// </summary>
  InsertBreak = unchecked((int)159),
  /// <summary>
  /// Font, Tab, CharNum, CharNumLow, Unicode, Hint
  /// </summary>
  InsertSymbol = unchecked((int)162),
  /// <summary>
  /// Name, LinkToFile, New, FloatOverText
  /// </summary>
  InsertPicture = unchecked((int)163),
  /// <summary>
  /// Name, Range, ConfirmConversions, Link, Attachment
  /// </summary>
  InsertFile = unchecked((int)164),
  /// <summary>
  /// DateTimePic, InsertAsField, DbCharField, DateLanguage, CalendarType
  /// </summary>
  InsertDateTime = unchecked((int)165),
  /// <summary>
  /// Field
  /// </summary>
  InsertField = unchecked((int)166),
  /// <summary>
  /// MergeField, WordField
  /// </summary>
  InsertMergeField = unchecked((int)167),
  /// <summary>
  /// Name, SortBy, Add, Delete, Goto, Hidden
  /// </summary>
  InsertBookmark = unchecked((int)168),
  /// <summary>
  /// wdDialogInsertIndex 170 Outline, Fields, From, To, TableId, AddedStyles, Caption, HeadingSeparator, Replace,
  /// MarkEntry, AutoMark, MarkCitation, Type, RightAlignPageNumbers, Passim, KeepFormatting, Columns, Category,
  /// Label, ShowPageNumbers, AccentedLetters, Filter, SortBy, Leader, TOCUseHyperlinks, TOCHidePageNumInWeb,
  /// IndexLanguage, UseOutlineLevel
  /// </summary>
  MarkIndexEntry = unchecked((int)169),
  /// <summary>
  /// Outline, Fields, From, To, TableId, AddedStyles, Caption, HeadingSeparator, Replace, MarkEntry, AutoMark,
  /// MarkCitation, Type, RightAlignPageNumbers, Passim, KeepFormatting, Columns, Category, Label, ShowPageNumbers,
  /// AccentedLetters, Filter, SortBy, Leader, TOCUseHyperlinks, TOCHidePageNumInWeb, IndexLanguage, UseOutlineLevel
  /// </summary>
  InsertIndex = unchecked((int)170),
  /// <summary>
  /// Outline, Fields, From, To, TableId, AddedStyles, Caption, HeadingSeparator, Replace, MarkEntry, AutoMark,
  /// MarkCitation, Type, RightAlignPageNumbers, Passim, KeepFormatting, Columns, Category, Label, ShowPageNumbers,
  /// AccentedLetters, Filter, SortBy, Leader, TOCUseHyperlinks, TOCHidePageNumInWeb, IndexLanguage, UseOutlineLevel
  /// </summary>
  InsertTableOfContents = unchecked((int)171),
  /// <summary>
  /// IconNumber, FileName, Link, DisplayIcon, Tab, Class, IconFileName, Caption, Floating
  /// </summary>
  InsertObject = unchecked((int)172),
  /// <summary>
  /// wdDialogFormatFont 174 Points, Underline, Color, StrikeThrough, Superscript, Subscript, Hidden, SmallCaps,
  /// AllCaps, Spacing, Position, Kerning, KerningMin, Default, Tab, Font, Bold, Italic, DoubleStrikeThrough,
  /// Shadow, Outline, Emboss, Engrave, Scale, Animations, CharAccent, FontMajor, FontLowAnsi, FontHighAnsi,
  /// CharacterWidthGrid, ColorRGB, UnderlineColor, PointsBi, ColorBi, FontNameBi, BoldBi, ItalicBi, DiacColor
  /// </summary>
  ToolsCreateEnvelope = unchecked((int)173),
  /// <summary>
  /// Points, Underline, Color, StrikeThrough, Superscript, Subscript, Hidden, SmallCaps, AllCaps, Spacing,
  /// Position, Kerning, KerningMin, Default, Tab, Font, Bold, Italic, DoubleStrikeThrough, Shadow, Outline, Emboss,
  /// Engrave, Scale, Animations, CharAccent, FontMajor, FontLowAnsi, FontHighAnsi, CharacterWidthGrid, ColorRGB,
  /// UnderlineColor, PointsBi, ColorBi, FontNameBi, BoldBi, ItalicBi, DiacColor
  /// </summary>
  FormatFont = unchecked((int)174),
  /// <summary>
  /// LeftIndent, RightIndent, Before, After, LineSpacingRule, LineSpacing, Alignment, WidowControl, KeepWithNext,
  /// KeepTogether, PageBreak, NoLineNum, DontHyphen, Tab, FirstIndent, OutlineLevel, Kinsoku, WordWrap,
  /// OverflowPunct, TopLinePunct, AutoSpaceDE, LineHeightGrid, AutoSpaceDN, CharAlign, CharacterUnitLeftIndent,
  /// AdjustRight, CharacterUnitFirstIndent, CharacterUnitRightIndent, LineUnitBefore, LineUnitAfter,
  /// NoSpaceBetweenParagraphsOfSameStyle, OrientationBi
  /// </summary>
  FormatParagraph = unchecked((int)175),
  /// <summary>
  /// SectionStart, VertAlign, Endnotes, LineNum, StartingNum, FromText, CountBy, NumMode, SectionType
  /// </summary>
  FormatSectionLayout = unchecked((int)176),
  /// <summary>
  /// Columns, ColumnNo, ColumnWidth, ColumnSpacing, EvenlySpaced, ApplyColsTo, ColLine, StartNewCol, FlowColumnsRtl
  /// </summary>
  FormatColumns = unchecked((int)177),
  /// <summary>
  /// Tab, PaperSize, TopMargin, BottomMargin, LeftMargin, RightMargin, Gutter, PageWidth, PageHeight, Orientation,
  /// FirstPage, OtherPages, VertAlign, ApplyPropsTo, Default, FacingPages, HeaderDistance, FooterDistance,
  /// SectionStart, OddAndEvenPages, DifferentFirstPage, Endnotes, LineNum, StartingNum, FromText, CountBy, NumMode,
  /// TwoOnOne, GutterPosition, LayoutMode, CharsLine, LinesPage, CharPitch, LinePitch, DocFontName, DocFontSize,
  /// PageColumns, TextFlow, FirstPageOnLeft, SectionType, RTLAlignment, FolioPrint
  /// </summary>
  FilePageSetup = unchecked((int)178),
  /// <summary>
  /// Tab, PaperSize, TopMargin, BottomMargin, LeftMargin, RightMargin, Gutter, PageWidth, PageHeight, Orientation,
  /// FirstPage, OtherPages, VertAlign, ApplyPropsTo, Default, FacingPages, HeaderDistance, FooterDistance,
  /// SectionStart, OddAndEvenPages, DifferentFirstPage, Endnotes, LineNum, StartingNum, FromText, CountBy, NumMode,
  /// TwoOnOne, GutterPosition, LayoutMode, CharsLine, LinesPage, CharPitch, LinePitch, DocFontName, DocFontSize,
  /// PageColumns, TextFlow, FirstPageOnLeft, SectionType, RTLAlignment
  /// </summary>
  FileDocumentLayout = unchecked((int)178),
  /// <summary>
  /// Position, DefTabs, Align, Leader, Set, Clear, ClearAll
  /// </summary>
  FormatTabs = unchecked((int)179),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  FormatStyle = unchecked((int)180),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  FormatDefineStyleFont = unchecked((int)181),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  FormatDefineStylePara = unchecked((int)182),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  FormatDefineStyleTabs = unchecked((int)183),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  FormatDefineStyleFrame = unchecked((int)184),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  FormatDefineStyleBorders = unchecked((int)185),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  FormatDefineStyleLang = unchecked((int)186),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  FormatPicture = unchecked((int)187),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  ToolsLanguage = unchecked((int)188),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  FormatBordersAndShading = unchecked((int)189),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  FormatFrame = unchecked((int)190),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  ToolsThesaurus = unchecked((int)194),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  ToolsHyphenation = unchecked((int)195),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  ToolsBulletsNumbers = unchecked((int)196),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  ToolsRevisions = unchecked((int)197),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  ToolsHighlightChanges = unchecked((int)197),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  ToolsCompareDocuments = unchecked((int)198),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  TableSort = unchecked((int)199),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  ToolsOptionsGeneral = unchecked((int)203),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  ToolsOptionsView = unchecked((int)204),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  ToolsAdvancedSettings = unchecked((int)206),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  ToolsOptionsPrint = unchecked((int)208),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  ToolsOptionsSave = unchecked((int)209),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  ToolsOptionsSpellingAndGrammar = unchecked((int)211),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  ToolsOptionsUserInfo = unchecked((int)213),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  ToolsMacroRecord = unchecked((int)214),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  ToolsMacro = unchecked((int)215),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  WindowActivate = unchecked((int)220),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  FormatRetAddrFonts = unchecked((int)221),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  Organizer = unchecked((int)222),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  ToolsOptionsEdit = unchecked((int)224),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  ToolsOptionsFileLocations = unchecked((int)225),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  ToolsWordCount = unchecked((int)228),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  ControlRun = unchecked((int)235),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  InsertPageNumbers = unchecked((int)294),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  FormatPageNumber = unchecked((int)298),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  CopyFile = unchecked((int)300),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  FormatChangeCase = unchecked((int)322),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  UpdateTOC = unchecked((int)331),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  InsertDatabase = unchecked((int)341),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  TableFormula = unchecked((int)348),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  FormFieldOptions = unchecked((int)353),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  InsertCaption = unchecked((int)357),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  InsertCaptionNumbering = unchecked((int)358),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  InsertAutoCaption = unchecked((int)359),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  FormFieldHelp = unchecked((int)361),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  InsertCrossReference = unchecked((int)367),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  InsertFootnote = unchecked((int)370),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  NoteOptions = unchecked((int)373),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  ToolsAutoCorrect = unchecked((int)378),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  ToolsOptionsTrackChanges = unchecked((int)386),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  ConvertObject = unchecked((int)392),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  InsertAddCaption = unchecked((int)402),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  Connect = unchecked((int)420),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  ToolsCustomizeKeyboard = unchecked((int)432),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  ToolsCustomizeMenus = unchecked((int)433),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  ToolsMergeDocuments = unchecked((int)435),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  MarkTableOfContentsEntry = unchecked((int)442),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  FileMacPageSetupGX = unchecked((int)444),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  FilePrintOneCopy = unchecked((int)445),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  EditFrame = unchecked((int)458),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  MarkCitation = unchecked((int)463),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  TableOfContentsOptions = unchecked((int)470),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  InsertTableOfAuthorities = unchecked((int)471),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  InsertTableOfFigures = unchecked((int)472),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  InsertIndexAndTables = unchecked((int)473),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  InsertFormField = unchecked((int)483),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  FormatDropCap = unchecked((int)488),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  ToolsCreateLabels = unchecked((int)489),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  ToolsProtectDocument = unchecked((int)503),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  FormatStyleGallery = unchecked((int)505),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  ToolsAcceptRejectChanges = unchecked((int)506),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  HelpWordPerfectHelpOptions = unchecked((int)511),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  ToolsUnprotectDocument = unchecked((int)521),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  ToolsOptionsCompatibility = unchecked((int)525),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  TableOfCaptionsOptions = unchecked((int)551),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  TableAutoFormat = unchecked((int)563),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  MailMergeFindRecord = unchecked((int)569),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  ReviewAfmtRevisions = unchecked((int)570),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  ViewZoom = unchecked((int)577),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  ToolsProtectSection = unchecked((int)578),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  FontSubstitution = unchecked((int)581),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  InsertSubdocument = unchecked((int)583),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  NewToolbar = unchecked((int)586),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  ToolsEnvelopesAndLabels = unchecked((int)607),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  FormatCallout = unchecked((int)610),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  TableFormatCell = unchecked((int)612),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  ToolsCustomizeMenuBar = unchecked((int)615),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  FileRoutingSlip = unchecked((int)624),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  EditTOACategory = unchecked((int)625),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  ToolsManageFields = unchecked((int)631),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  DrawSnapToGrid = unchecked((int)633),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  DrawAlign = unchecked((int)634),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  MailMergeCreateDataSource = unchecked((int)642),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  MailMergeCreateHeaderSource = unchecked((int)643),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  MailMerge = unchecked((int)676),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  MailMergeCheck = unchecked((int)677),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  MailMergeHelper = unchecked((int)680),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  MailMergeQueryOptions = unchecked((int)681),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  FileMacPageSetup = unchecked((int)685),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  ListCommands = unchecked((int)723),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  EditCreatePublisher = unchecked((int)732),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  EditSubscribeTo = unchecked((int)733),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  EditPublishOptions = unchecked((int)735),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  EditSubscribeOptions = unchecked((int)736),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  FileMacCustomPageSetupGX = unchecked((int)737),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  ToolsOptionsTypography = unchecked((int)739),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  ToolsAutoCorrectExceptions = unchecked((int)762),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  ToolsOptionsAutoFormatAsYouType = unchecked((int)778),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  MailMergeUseAddressBook = unchecked((int)779),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  ToolsHangulHanjaConversion = unchecked((int)784),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  ToolsOptionsFuzzy = unchecked((int)790),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  EditGoToOld = unchecked((int)811),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  InsertNumber = unchecked((int)812),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  LetterWizard = unchecked((int)821),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  FormatBulletsAndNumbering = unchecked((int)824),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  ToolsSpellingAndGrammar = unchecked((int)828),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  ToolsCreateDirectory = unchecked((int)833),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  TableWrapping = unchecked((int)854),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  FormatTheme = unchecked((int)855),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  TableProperties = unchecked((int)861),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  EmailOptions = unchecked((int)863),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  CreateAutoText = unchecked((int)872),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  ToolsAutoSummarize = unchecked((int)874),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  ToolsGrammarSettings = unchecked((int)885),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  EditGoTo = unchecked((int)896),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  WebOptions = unchecked((int)898),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  ToolsAutoManager = unchecked((int)915),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  InsertHyperlink = unchecked((int)925),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  FileVersions = unchecked((int)945),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  ToolsOptionsAutoFormat = unchecked((int)959),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  FormatDrawingObject = unchecked((int)960),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  ToolsOptions = unchecked((int)974),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  FitText = unchecked((int)983),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  EditAutoText = unchecked((int)985),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  PhoneticGuide = unchecked((int)986),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  ToolsDictionary = unchecked((int)989),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  FileSaveVersion = unchecked((int)1007),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  ToolsOptionsBidi = unchecked((int)1029),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  FrameSetProperties = unchecked((int)1074),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  TableTableOptions = unchecked((int)1080),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  TableCellOptions = unchecked((int)1081),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  IMESetDefault = unchecked((int)1094),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  FileNew2007 = unchecked((int)1116),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  ConsistencyChecker = unchecked((int)1121),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  TCSCTranslator = unchecked((int)1156),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  HorizontalInVertical = unchecked((int)1160),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  TwoLinesInOne = unchecked((int)1161),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  FormatEncloseCharacters = unchecked((int)1162),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  FormatStylesCustom = unchecked((int)1248),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  CSSLinks = unchecked((int)1261),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  MailMergeFieldMapping = unchecked((int)1304),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  MailMergeInsertAddressBlock = unchecked((int)1305),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  MailMergeInsertGreetingLine = unchecked((int)1306),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  MailMergeInsertFields = unchecked((int)1307),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  MailMergeRecipients = unchecked((int)1308),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  InsertWebComponent = unchecked((int)1324),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  MailMergeFindRecipient = unchecked((int)1326),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  MailMergeSetDocumentType = unchecked((int)1339),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  ToolsOptionsEditCopyPaste = unchecked((int)1356),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  ToolsOptionsSecurity = unchecked((int)1361),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  Search = unchecked((int)1363),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  LabelOptions = unchecked((int)1367),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  ShowRepairs = unchecked((int)1381),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  ToolsOptionsSmartTag = unchecked((int)1395),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  SchemaLibrary = unchecked((int)1417),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  XMLOptions = unchecked((int)1425),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  FormattingRestrictions = unchecked((int)1427),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  MyPermission = unchecked((int)1437),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  XMLElementAttributes = unchecked((int)1460),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  Permission = unchecked((int)1469),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  DocumentInspector = unchecked((int)1482),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  SourceManager = unchecked((int)1920),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  CreateSource = unchecked((int)1922),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  StyleManagement = unchecked((int)1948),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  BuildingBlockOrganizer = unchecked((int)2067),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  InsertSource = unchecked((int)2120),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  OMathRecognizedFunctions = unchecked((int)2165),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  InsertPlaceholder = unchecked((int)2348),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  ExportAsFixedFormat = unchecked((int)2349),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  ContentControlProperties = unchecked((int)2394),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  CompatibilityChecker = unchecked((int)2439),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  MailMergeInsertAsk = unchecked((int)4047),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  MailMergeInsertFillIn = unchecked((int)4048),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  MailMergeInsertIf = unchecked((int)4049),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  MailMergeInsertNextIf = unchecked((int)4053),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  MailMergeInsertSet = unchecked((int)4054),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  MailMergeInsertSkipIf = unchecked((int)4055)
}

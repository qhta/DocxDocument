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
  wdDialogHelpAbout = unchecked((int)9),
  /// <summary>
  /// WPCommand, HelpText, DemoGuidance
  /// </summary>
  wdDialogHelpWordPerfectHelp = unchecked((int)10),
  /// <summary>
  /// FileName, Directory, Template, Title, Created, LastSaved, LastSavedBy, Revision, Time, Printed, Pages, Words,
  /// Characters, Paragraphs, Lines, FileSize
  /// </summary>
  wdDialogDocumentStatistics = unchecked((int)78),
  /// <summary>
  /// Template, NewTemplate, DocumentType, Visible
  /// </summary>
  wdDialogFileNew = unchecked((int)79),
  /// <summary>
  /// Name, ConfirmConversions, ReadOnly, LinkToSource, AddToMru, PasswordDoc, PasswordDot, Revert,
  /// WritePasswordDoc, WritePasswordDot, Connection, SQLStatement, SQLStatement1, Format, Encoding, Visible,
  /// OpenExclusive, OpenAndRepair, SubType,
  /// [System.Runtime.InteropServices.Guid("6EC6B31B-AA8E-31A3-8211-3ADB9601AC42")] public enum WdWordDialog ﾉ
  /// Expand table DocumentDirection, NoEncodingDialog, XMLTransform wdDialogMailMergeOpenDataSource81
  /// wdDialogMailMergeOpenHeaderSource82
  /// </summary>
  wdDialogFileOpen = unchecked((int)80),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogMailMergeOpenDataSource = unchecked((int)81),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogMailMergeOpenHeaderSource = unchecked((int)82),
  /// <summary>
  /// Name, Format, LockAnnot, Password, AddToMru, WritePassword, RecommendReadOnly, EmbedFonts,
  /// NativePictureFormat, FormsData, SaveAsAOCELetter, WriteVersion, VersionDesc, InsertLineBreaks,
  /// AllowSubstitutions, LineEnding, AddBiDiMarks
  /// </summary>
  wdDialogFileSaveAs = unchecked((int)84),
  /// <summary>
  /// Title, Subject, Author, Keywords, Comments, FileName, Directory, Template, CreateDate, LastSavedDate,
  /// LastSavedBy, RevisionNumber, EditTime, LastPrintedDate, NumPages, NumWords, NumChars, NumParas, NumLines,
  /// Update, FileSize
  /// </summary>
  wdDialogFileSummaryInfo = unchecked((int)86),
  /// <summary>
  /// wdDialogFilePrint 88 Background, AppendPrFile, Range, PrToFileName, From, To, Type, NumCopies, Pages, Order,
  /// PrintToFile, Collate, FileName, Printer, OutputPrinter, DuplexPrint, PrintZoomColumn, PrintZoomRow,
  /// PrintZoomPaperWidth, PrintZoomPaperHeight, ZoomPaper
  /// </summary>
  wdDialogToolsTemplates = unchecked((int)87),
  /// <summary>
  /// Background, AppendPrFile, Range, PrToFileName, From, To, Type, NumCopies, Pages, Order, PrintToFile, Collate,
  /// FileName, Printer, OutputPrinter, DuplexPrint, PrintZoomColumn, PrintZoomRow, PrintZoomPaperWidth,
  /// PrintZoomPaperHeight, ZoomPaper
  /// </summary>
  wdDialogFilePrint = unchecked((int)88),
  /// <summary>
  /// Printer, Options, Network, DoNotSetAsSysDefault
  /// </summary>
  wdDialogFilePrintSetup = unchecked((int)97),
  /// <summary>
  /// SearchName, SearchPath, Name, SubDir, Title, Author, Keywords, Subject, Options, MatchCase, Text,
  /// PatternMatch, DateSavedFrom, DateSavedTo, SavedBy, DateCreatedFrom, DateCreatedTo, View, SortBy, ListBy,
  /// SelectedFile, Add, Delete, ShowFolders, MatchByte
  /// </summary>
  wdDialogFileFind = unchecked((int)99),
  /// <summary>
  /// Points, Underline, Color, StrikeThrough, Superscript, Subscript, Hidden, SmallCaps, AllCaps, Spacing,
  /// Position, Kerning, KerningMin, Default, Tab, Font, Bold, Italic, DoubleStrikeThrough, Shadow, Outline, Emboss,
  /// Engrave, Scale, Animations, CharAccent, FontMajor, FontLowAnsi, FontHighAnsi, CharacterWidthGrid, ColorRGB,
  /// UnderlineColor, PointsBi, ColorBi, FontNameBi, BoldBi, ItalicBi, DiacColor
  /// </summary>
  wdDialogFormatAddrFonts = unchecked((int)103),
  /// <summary>
  /// IconNumber, Link, DisplayIcon, Class, DataType, IconFileName, Caption, Floating
  /// </summary>
  wdDialogEditPasteSpecial = unchecked((int)111),
  /// <summary>
  /// Find, Replace, Direction, MatchCase, WholeWord, PatternMatch, SoundsLike, FindNext, ReplaceOne, ReplaceAll,
  /// Format, Wrap, FindAllWordForms, MatchByte, FuzzyFind, Destination, CorrectEnd, MatchKashida, MatchDiacritics,
  /// MatchAlefHamza, MatchControl
  /// </summary>
  wdDialogEditFind = unchecked((int)112),
  /// <summary>
  /// Find, Replace, Direction, MatchCase, WholeWord, PatternMatch, SoundsLike, FindNext, ReplaceOne, ReplaceAll,
  /// Format, Wrap, FindAllWordForms, MatchByte, FuzzyFind, Destination, CorrectEnd, MatchKashida, MatchDiacritics,
  /// MatchAlefHamza, MatchControl
  /// </summary>
  wdDialogEditReplace = unchecked((int)117),
  /// <summary>
  /// (none)
  /// </summary>
  wdDialogEditStyle = unchecked((int)120),
  /// <summary>
  /// UpdateMode, Locked, SavePictureInDoc, UpdateNow, OpenSource, KillLink, Link, Application, Item, FileName,
  /// PreserveFormatLinkUpdate
  /// </summary>
  wdDialogEditLinks = unchecked((int)124),
  /// <summary>
  /// Verb
  /// </summary>
  wdDialogEditObject = unchecked((int)125),
  /// <summary>
  /// wdDialogTableToText 128
  /// </summary>
  wdDialogTextToTable = unchecked((int)127),
  /// <summary>
  /// wdDialogTableInsertTable 129
  /// </summary>
  wdDialogTableToText = unchecked((int)128),
  /// <summary>
  /// wdDialogTableInsertCells 130
  /// </summary>
  wdDialogTableInsertTable = unchecked((int)129),
  /// <summary>
  /// wdDialogTableInsertRow 131
  /// </summary>
  wdDialogTableInsertCells = unchecked((int)130),
  /// <summary>
  /// wdDialogTableDeleteCells 133
  /// </summary>
  wdDialogTableInsertRow = unchecked((int)131),
  /// <summary>
  /// wdDialogTableSplitCells 137
  /// </summary>
  wdDialogTableDeleteCells = unchecked((int)133),
  /// <summary>
  /// wdDialogTableRowHeight 142
  /// </summary>
  wdDialogTableSplitCells = unchecked((int)137),
  /// <summary>
  /// wdDialogTableColumnWidth 143
  /// </summary>
  wdDialogTableRowHeight = unchecked((int)142),
  /// <summary>
  /// wdDialogToolsCustomize 152
  /// </summary>
  wdDialogTableColumnWidth = unchecked((int)143),
  /// <summary>
  /// wdDialogInsertBreak 159 Type
  /// </summary>
  wdDialogToolsCustomize = unchecked((int)152),
  /// <summary>
  /// Type
  /// </summary>
  wdDialogInsertBreak = unchecked((int)159),
  /// <summary>
  /// Font, Tab, CharNum, CharNumLow, Unicode, Hint
  /// </summary>
  wdDialogInsertSymbol = unchecked((int)162),
  /// <summary>
  /// Name, LinkToFile, New, FloatOverText
  /// </summary>
  wdDialogInsertPicture = unchecked((int)163),
  /// <summary>
  /// Name, Range, ConfirmConversions, Link, Attachment
  /// </summary>
  wdDialogInsertFile = unchecked((int)164),
  /// <summary>
  /// DateTimePic, InsertAsField, DbCharField, DateLanguage, CalendarType
  /// </summary>
  wdDialogInsertDateTime = unchecked((int)165),
  /// <summary>
  /// Field
  /// </summary>
  wdDialogInsertField = unchecked((int)166),
  /// <summary>
  /// MergeField, WordField
  /// </summary>
  wdDialogInsertMergeField = unchecked((int)167),
  /// <summary>
  /// Name, SortBy, Add, Delete, Goto, Hidden
  /// </summary>
  wdDialogInsertBookmark = unchecked((int)168),
  /// <summary>
  /// wdDialogInsertIndex 170 Outline, Fields, From, To, TableId, AddedStyles, Caption, HeadingSeparator, Replace,
  /// MarkEntry, AutoMark, MarkCitation, Type, RightAlignPageNumbers, Passim, KeepFormatting, Columns, Category,
  /// Label, ShowPageNumbers, AccentedLetters, Filter, SortBy, Leader, TOCUseHyperlinks, TOCHidePageNumInWeb,
  /// IndexLanguage, UseOutlineLevel
  /// </summary>
  wdDialogMarkIndexEntry = unchecked((int)169),
  /// <summary>
  /// Outline, Fields, From, To, TableId, AddedStyles, Caption, HeadingSeparator, Replace, MarkEntry, AutoMark,
  /// MarkCitation, Type, RightAlignPageNumbers, Passim, KeepFormatting, Columns, Category, Label, ShowPageNumbers,
  /// AccentedLetters, Filter, SortBy, Leader, TOCUseHyperlinks, TOCHidePageNumInWeb, IndexLanguage, UseOutlineLevel
  /// </summary>
  wdDialogInsertIndex = unchecked((int)170),
  /// <summary>
  /// Outline, Fields, From, To, TableId, AddedStyles, Caption, HeadingSeparator, Replace, MarkEntry, AutoMark,
  /// MarkCitation, Type, RightAlignPageNumbers, Passim, KeepFormatting, Columns, Category, Label, ShowPageNumbers,
  /// AccentedLetters, Filter, SortBy, Leader, TOCUseHyperlinks, TOCHidePageNumInWeb, IndexLanguage, UseOutlineLevel
  /// </summary>
  wdDialogInsertTableOfContents = unchecked((int)171),
  /// <summary>
  /// IconNumber, FileName, Link, DisplayIcon, Tab, Class, IconFileName, Caption, Floating
  /// </summary>
  wdDialogInsertObject = unchecked((int)172),
  /// <summary>
  /// wdDialogFormatFont 174 Points, Underline, Color, StrikeThrough, Superscript, Subscript, Hidden, SmallCaps,
  /// AllCaps, Spacing, Position, Kerning, KerningMin, Default, Tab, Font, Bold, Italic, DoubleStrikeThrough,
  /// Shadow, Outline, Emboss, Engrave, Scale, Animations, CharAccent, FontMajor, FontLowAnsi, FontHighAnsi,
  /// CharacterWidthGrid, ColorRGB, UnderlineColor, PointsBi, ColorBi, FontNameBi, BoldBi, ItalicBi, DiacColor
  /// </summary>
  wdDialogToolsCreateEnvelope = unchecked((int)173),
  /// <summary>
  /// Points, Underline, Color, StrikeThrough, Superscript, Subscript, Hidden, SmallCaps, AllCaps, Spacing,
  /// Position, Kerning, KerningMin, Default, Tab, Font, Bold, Italic, DoubleStrikeThrough, Shadow, Outline, Emboss,
  /// Engrave, Scale, Animations, CharAccent, FontMajor, FontLowAnsi, FontHighAnsi, CharacterWidthGrid, ColorRGB,
  /// UnderlineColor, PointsBi, ColorBi, FontNameBi, BoldBi, ItalicBi, DiacColor
  /// </summary>
  wdDialogFormatFont = unchecked((int)174),
  /// <summary>
  /// LeftIndent, RightIndent, Before, After, LineSpacingRule, LineSpacing, Alignment, WidowControl, KeepWithNext,
  /// KeepTogether, PageBreak, NoLineNum, DontHyphen, Tab, FirstIndent, OutlineLevel, Kinsoku, WordWrap,
  /// OverflowPunct, TopLinePunct, AutoSpaceDE, LineHeightGrid, AutoSpaceDN, CharAlign, CharacterUnitLeftIndent,
  /// AdjustRight, CharacterUnitFirstIndent, CharacterUnitRightIndent, LineUnitBefore, LineUnitAfter,
  /// NoSpaceBetweenParagraphsOfSameStyle, OrientationBi
  /// </summary>
  wdDialogFormatParagraph = unchecked((int)175),
  /// <summary>
  /// SectionStart, VertAlign, Endnotes, LineNum, StartingNum, FromText, CountBy, NumMode, SectionType
  /// </summary>
  wdDialogFormatSectionLayout = unchecked((int)176),
  /// <summary>
  /// Columns, ColumnNo, ColumnWidth, ColumnSpacing, EvenlySpaced, ApplyColsTo, ColLine, StartNewCol, FlowColumnsRtl
  /// </summary>
  wdDialogFormatColumns = unchecked((int)177),
  /// <summary>
  /// Tab, PaperSize, TopMargin, BottomMargin, LeftMargin, RightMargin, Gutter, PageWidth, PageHeight, Orientation,
  /// FirstPage, OtherPages, VertAlign, ApplyPropsTo, Default, FacingPages, HeaderDistance, FooterDistance,
  /// SectionStart, OddAndEvenPages, DifferentFirstPage, Endnotes, LineNum, StartingNum, FromText, CountBy, NumMode,
  /// TwoOnOne, GutterPosition, LayoutMode, CharsLine, LinesPage, CharPitch, LinePitch, DocFontName, DocFontSize,
  /// PageColumns, TextFlow, FirstPageOnLeft, SectionType, RTLAlignment, FolioPrint
  /// </summary>
  wdDialogFilePageSetup = unchecked((int)178),
  /// <summary>
  /// Tab, PaperSize, TopMargin, BottomMargin, LeftMargin, RightMargin, Gutter, PageWidth, PageHeight, Orientation,
  /// FirstPage, OtherPages, VertAlign, ApplyPropsTo, Default, FacingPages, HeaderDistance, FooterDistance,
  /// SectionStart, OddAndEvenPages, DifferentFirstPage, Endnotes, LineNum, StartingNum, FromText, CountBy, NumMode,
  /// TwoOnOne, GutterPosition, LayoutMode, CharsLine, LinesPage, CharPitch, LinePitch, DocFontName, DocFontSize,
  /// PageColumns, TextFlow, FirstPageOnLeft, SectionType, RTLAlignment
  /// </summary>
  wdDialogFileDocumentLayout = unchecked((int)178),
  /// <summary>
  /// Position, DefTabs, Align, Leader, Set, Clear, ClearAll
  /// </summary>
  wdDialogFormatTabs = unchecked((int)179),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogFormatStyle = unchecked((int)180),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogFormatDefineStyleFont = unchecked((int)181),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogFormatDefineStylePara = unchecked((int)182),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogFormatDefineStyleTabs = unchecked((int)183),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogFormatDefineStyleFrame = unchecked((int)184),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogFormatDefineStyleBorders = unchecked((int)185),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogFormatDefineStyleLang = unchecked((int)186),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogFormatPicture = unchecked((int)187),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogToolsLanguage = unchecked((int)188),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogFormatBordersAndShading = unchecked((int)189),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogFormatFrame = unchecked((int)190),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogToolsThesaurus = unchecked((int)194),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogToolsHyphenation = unchecked((int)195),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogToolsBulletsNumbers = unchecked((int)196),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogToolsRevisions = unchecked((int)197),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogToolsHighlightChanges = unchecked((int)197),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogToolsCompareDocuments = unchecked((int)198),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogTableSort = unchecked((int)199),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogToolsOptionsGeneral = unchecked((int)203),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogToolsOptionsView = unchecked((int)204),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogToolsAdvancedSettings = unchecked((int)206),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogToolsOptionsPrint = unchecked((int)208),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogToolsOptionsSave = unchecked((int)209),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogToolsOptionsSpellingAndGrammar = unchecked((int)211),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogToolsOptionsUserInfo = unchecked((int)213),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogToolsMacroRecord = unchecked((int)214),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogToolsMacro = unchecked((int)215),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogWindowActivate = unchecked((int)220),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogFormatRetAddrFonts = unchecked((int)221),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogOrganizer = unchecked((int)222),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogToolsOptionsEdit = unchecked((int)224),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogToolsOptionsFileLocations = unchecked((int)225),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogToolsWordCount = unchecked((int)228),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogControlRun = unchecked((int)235),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogInsertPageNumbers = unchecked((int)294),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogFormatPageNumber = unchecked((int)298),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogCopyFile = unchecked((int)300),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogFormatChangeCase = unchecked((int)322),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogUpdateTOC = unchecked((int)331),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogInsertDatabase = unchecked((int)341),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogTableFormula = unchecked((int)348),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogFormFieldOptions = unchecked((int)353),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogInsertCaption = unchecked((int)357),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogInsertCaptionNumbering = unchecked((int)358),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogInsertAutoCaption = unchecked((int)359),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogFormFieldHelp = unchecked((int)361),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogInsertCrossReference = unchecked((int)367),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogInsertFootnote = unchecked((int)370),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogNoteOptions = unchecked((int)373),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogToolsAutoCorrect = unchecked((int)378),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogToolsOptionsTrackChanges = unchecked((int)386),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogConvertObject = unchecked((int)392),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogInsertAddCaption = unchecked((int)402),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogConnect = unchecked((int)420),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogToolsCustomizeKeyboard = unchecked((int)432),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogToolsCustomizeMenus = unchecked((int)433),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogToolsMergeDocuments = unchecked((int)435),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogMarkTableOfContentsEntry = unchecked((int)442),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogFileMacPageSetupGX = unchecked((int)444),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogFilePrintOneCopy = unchecked((int)445),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogEditFrame = unchecked((int)458),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogMarkCitation = unchecked((int)463),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogTableOfContentsOptions = unchecked((int)470),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogInsertTableOfAuthorities = unchecked((int)471),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogInsertTableOfFigures = unchecked((int)472),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogInsertIndexAndTables = unchecked((int)473),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogInsertFormField = unchecked((int)483),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogFormatDropCap = unchecked((int)488),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogToolsCreateLabels = unchecked((int)489),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogToolsProtectDocument = unchecked((int)503),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogFormatStyleGallery = unchecked((int)505),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogToolsAcceptRejectChanges = unchecked((int)506),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogHelpWordPerfectHelpOptions = unchecked((int)511),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogToolsUnprotectDocument = unchecked((int)521),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogToolsOptionsCompatibility = unchecked((int)525),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogTableOfCaptionsOptions = unchecked((int)551),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogTableAutoFormat = unchecked((int)563),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogMailMergeFindRecord = unchecked((int)569),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogReviewAfmtRevisions = unchecked((int)570),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogViewZoom = unchecked((int)577),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogToolsProtectSection = unchecked((int)578),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogFontSubstitution = unchecked((int)581),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogInsertSubdocument = unchecked((int)583),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogNewToolbar = unchecked((int)586),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogToolsEnvelopesAndLabels = unchecked((int)607),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogFormatCallout = unchecked((int)610),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogTableFormatCell = unchecked((int)612),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogToolsCustomizeMenuBar = unchecked((int)615),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogFileRoutingSlip = unchecked((int)624),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogEditTOACategory = unchecked((int)625),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogToolsManageFields = unchecked((int)631),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogDrawSnapToGrid = unchecked((int)633),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogDrawAlign = unchecked((int)634),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogMailMergeCreateDataSource = unchecked((int)642),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogMailMergeCreateHeaderSource = unchecked((int)643),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogMailMerge = unchecked((int)676),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogMailMergeCheck = unchecked((int)677),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogMailMergeHelper = unchecked((int)680),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogMailMergeQueryOptions = unchecked((int)681),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogFileMacPageSetup = unchecked((int)685),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogListCommands = unchecked((int)723),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogEditCreatePublisher = unchecked((int)732),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogEditSubscribeTo = unchecked((int)733),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogEditPublishOptions = unchecked((int)735),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogEditSubscribeOptions = unchecked((int)736),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogFileMacCustomPageSetupGX = unchecked((int)737),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogToolsOptionsTypography = unchecked((int)739),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogToolsAutoCorrectExceptions = unchecked((int)762),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogToolsOptionsAutoFormatAsYouType = unchecked((int)778),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogMailMergeUseAddressBook = unchecked((int)779),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogToolsHangulHanjaConversion = unchecked((int)784),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogToolsOptionsFuzzy = unchecked((int)790),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogEditGoToOld = unchecked((int)811),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogInsertNumber = unchecked((int)812),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogLetterWizard = unchecked((int)821),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogFormatBulletsAndNumbering = unchecked((int)824),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogToolsSpellingAndGrammar = unchecked((int)828),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogToolsCreateDirectory = unchecked((int)833),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogTableWrapping = unchecked((int)854),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogFormatTheme = unchecked((int)855),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogTableProperties = unchecked((int)861),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogEmailOptions = unchecked((int)863),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogCreateAutoText = unchecked((int)872),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogToolsAutoSummarize = unchecked((int)874),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogToolsGrammarSettings = unchecked((int)885),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogEditGoTo = unchecked((int)896),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogWebOptions = unchecked((int)898),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogToolsAutoManager = unchecked((int)915),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogInsertHyperlink = unchecked((int)925),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogFileVersions = unchecked((int)945),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogToolsOptionsAutoFormat = unchecked((int)959),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogFormatDrawingObject = unchecked((int)960),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogToolsOptions = unchecked((int)974),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogFitText = unchecked((int)983),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogEditAutoText = unchecked((int)985),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogPhoneticGuide = unchecked((int)986),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogToolsDictionary = unchecked((int)989),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogFileSaveVersion = unchecked((int)1007),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogToolsOptionsBidi = unchecked((int)1029),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogFrameSetProperties = unchecked((int)1074),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogTableTableOptions = unchecked((int)1080),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogTableCellOptions = unchecked((int)1081),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogIMESetDefault = unchecked((int)1094),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogFileNew2007 = unchecked((int)1116),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogConsistencyChecker = unchecked((int)1121),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogTCSCTranslator = unchecked((int)1156),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogHorizontalInVertical = unchecked((int)1160),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogTwoLinesInOne = unchecked((int)1161),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogFormatEncloseCharacters = unchecked((int)1162),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogFormatStylesCustom = unchecked((int)1248),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogCSSLinks = unchecked((int)1261),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogMailMergeFieldMapping = unchecked((int)1304),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogMailMergeInsertAddressBlock = unchecked((int)1305),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogMailMergeInsertGreetingLine = unchecked((int)1306),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogMailMergeInsertFields = unchecked((int)1307),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogMailMergeRecipients = unchecked((int)1308),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogInsertWebComponent = unchecked((int)1324),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogMailMergeFindRecipient = unchecked((int)1326),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogMailMergeSetDocumentType = unchecked((int)1339),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogToolsOptionsEditCopyPaste = unchecked((int)1356),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogToolsOptionsSecurity = unchecked((int)1361),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogSearch = unchecked((int)1363),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogLabelOptions = unchecked((int)1367),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogShowRepairs = unchecked((int)1381),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogToolsOptionsSmartTag = unchecked((int)1395),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogSchemaLibrary = unchecked((int)1417),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogXMLOptions = unchecked((int)1425),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogFormattingRestrictions = unchecked((int)1427),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogMyPermission = unchecked((int)1437),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogXMLElementAttributes = unchecked((int)1460),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogPermission = unchecked((int)1469),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogDocumentInspector = unchecked((int)1482),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogSourceManager = unchecked((int)1920),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogCreateSource = unchecked((int)1922),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogStyleManagement = unchecked((int)1948),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogBuildingBlockOrganizer = unchecked((int)2067),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogInsertSource = unchecked((int)2120),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogOMathRecognizedFunctions = unchecked((int)2165),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogInsertPlaceholder = unchecked((int)2348),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogExportAsFixedFormat = unchecked((int)2349),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogContentControlProperties = unchecked((int)2394),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogCompatibilityChecker = unchecked((int)2439),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogMailMergeInsertAsk = unchecked((int)4047),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogMailMergeInsertFillIn = unchecked((int)4048),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogMailMergeInsertIf = unchecked((int)4049),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogMailMergeInsertNextIf = unchecked((int)4053),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogMailMergeInsertSet = unchecked((int)4054),
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  wdDialogMailMergeInsertSkipIf = unchecked((int)4055)
}

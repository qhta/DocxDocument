namespace DocumentModel.Interop.Word;

/// <summary>
/// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
/// applicable, that you can use to get or set values in a dialog box.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdworddialog?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdWordDialog))]
public enum WordDialog
{
  /// <summary>
  /// APPNAME, APPCOPYRIGHT, APPUSERNAME, APPORGANIZATION, APPSERIALNUMBER
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogHelpAbout))]
  HelpAbout = 9,
  /// <summary>
  /// WPCommand, HelpText, DemoGuidance
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogHelpWordPerfectHelp))]
  HelpWordPerfectHelp = 10,
  /// <summary>
  /// FileName, Directory, Template, Title, Created, LastSaved, LastSavedBy, Revision, Time, Printed, Pages, Words,
  /// Characters, Paragraphs, Lines,
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogDocumentStatistics))]
  DocumentStatistics = 78,
  /// <summary>
  /// Template, NewTemplate, DocumentType, Visible
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogFileNew))]
  FileNew = 79,
  /// <summary>
  /// Name, ConfirmConversions, ReadOnly, LinkToSource, AddToMru, PasswordDoc, PasswordDot, Revert,
  /// WritePasswordDoc, WritePasswordDot, Connection, SQLStatement, SQLStatement1, Format, Encoding, Visible,
  /// OpenExclusive, OpenAndRepair, SubType,
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogFileOpen))]
  FileOpen = 80,
  /// <summary>
  /// No description is available.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogMailMergeOpenDataSource))]
  MailMergeOpenDataSource = 81,
  /// <summary>
  /// No description is available.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogMailMergeOpenHeaderSource))]
  MailMergeOpenHeaderSource = 82,
  /// <summary>
  /// Name, Format, LockAnnot, Password, AddToMru, WritePassword, RecommendReadOnly, EmbedFonts,
  /// NativePictureFormat, FormsData, SaveAsAOCELetter, WriteVersion, VersionDesc, InsertLineBreaks,
  /// AllowSubstitutions, LineEnding,
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogFileSaveAs))]
  FileSaveAs = 84,
  /// <summary>
  /// Title, Subject, Author, Keywords, Comments, FileName, Directory, Template, CreateDate, LastSavedDate,
  /// LastSavedBy, RevisionNumber, EditTime, LastPrintedDate, NumPages, NumWords, NumChars, NumParas, NumLines,
  /// Update, FileSize
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogFileSummaryInfo))]
  FileSummaryInfo = 86,
  /// <summary>
  /// No description is available.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogToolsTemplates))]
  ToolsTemplates = 87,
  /// <summary>
  /// Background, AppendPrFile, Range, PrToFileName, From, To, Type, NumCopies, Pages, Order, PrintToFile, Collate,
  /// FileName, Printer, OutputPrinter, DuplexPrint, PrintZoomColumn, PrintZoomRow, PrintZoomPaperWidth,
  /// PrintZoomPaperHeight, ZoomPaper
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogFilePrint))]
  FilePrint = 88,
  /// <summary>
  /// Printer, Options, Network, DoNotSetAsSysDefault
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogFilePrintSetup))]
  FilePrintSetup = 97,
  /// <summary>
  /// SearchName, SearchPath, Name, SubDir, Title, Author, Keywords, Subject, Options, MatchCase, Text,
  /// PatternMatch, DateSavedFrom, DateSavedTo, SavedBy, DateCreatedFrom, DateCreatedTo, View, SortBy, ListBy,
  /// SelectedFile, Add, Delete, ShowFolders, MatchByte
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogFileFind))]
  FileFind = 99,
  /// <summary>
  /// Points, Underline, Color, StrikeThrough, Superscript, Subscript, Hidden, SmallCaps, AllCaps, Spacing,
  /// Position, Kerning, KerningMin, Default, Tab, Font, Bold, Italic, DoubleStrikeThrough, Shadow, Outline, Emboss,
  /// Engrave, Scale, Animations, CharAccent, FontMajor, FontLowAnsi, FontHighAnsi, CharacterWidthGrid, ColorRGB,
  /// UnderlineColor, PointsBi, ColorBi, NameBi, BoldBi, ItalicBi,
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogFormatAddrFonts))]
  FormatAddrFonts = 103,
  /// <summary>
  /// IconNumber, Link, DisplayIcon, Class, DataType, IconFileName, Caption, Floating
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogEditPasteSpecial))]
  EditPasteSpecial = 111,
  /// <summary>
  /// Find, Replace, Direction, MatchCase, WholeWord, PatternMatch, SoundsLike, FindNext, ReplaceOne, ReplaceAll,
  /// Format, Wrap, FindAllWordForms, MatchByte, FuzzyFind, Destination, CorrectEnd, MatchKashida, MatchDiacritics,
  /// MatchAlefHamza,
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogEditFind))]
  EditFind = 112,
  /// <summary>
  /// Find, Replace, Direction, MatchCase, WholeWord, PatternMatch, SoundsLike, FindNext, ReplaceOne, ReplaceAll,
  /// Format, Wrap, FindAllWordForms, MatchByte, FuzzyFind, Destination, CorrectEnd, MatchKashida, MatchDiacritics,
  /// MatchAlefHamza,
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogEditReplace))]
  EditReplace = 117,
  /// <summary>
  /// (none)
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogEditStyle))]
  EditStyle = 120,
  /// <summary>
  /// UpdateMode, Locked, SavePictureInDoc, UpdateNow, OpenSource, KillLink, Link, Application, Item, FileName,
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogEditLinks))]
  EditLinks = 124,
  /// <summary>
  /// Verb
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogEditObject))]
  EditObject = 125,
  /// <summary>
  /// No description is available.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogTextToTable))]
  TextToTable = 127,
  /// <summary>
  /// No description is available.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogTableToText))]
  TableToText = 128,
  /// <summary>
  /// No description is available.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogTableInsertTable))]
  TableInsertTable = 129,
  /// <summary>
  /// No description is available.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogTableInsertCells))]
  TableInsertCells = 130,
  /// <summary>
  /// No description is available.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogTableInsertRow))]
  TableInsertRow = 131,
  /// <summary>
  /// No description is available.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogTableDeleteCells))]
  TableDeleteCells = 133,
  /// <summary>
  /// No description is available.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogTableSplitCells))]
  TableSplitCells = 137,
  /// <summary>
  /// No description is available.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogTableRowHeight))]
  TableRowHeight = 142,
  /// <summary>
  /// No description is available.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogTableColumnWidth))]
  TableColumnWidth = 143,
  /// <summary>
  /// No description is available.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogToolsCustomize))]
  ToolsCustomize = 152,
  /// <summary>
  /// Type
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogInsertBreak))]
  InsertBreak = 159,
  /// <summary>
  /// Font, Tab, CharNum, CharNumLow, Unicode, Hint
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogInsertSymbol))]
  InsertSymbol = 162,
  /// <summary>
  /// Name, LinkToFile, New, FloatOverText
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogInsertPicture))]
  InsertPicture = 163,
  /// <summary>
  /// Name, Range, ConfirmConversions, Link,
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogInsertFile))]
  InsertFile = 164,
  /// <summary>
  /// DateTimePic, InsertAsField, DbCharField, DateLanguage, CalendarType
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogInsertDateTime))]
  InsertDateTime = 165,
  /// <summary>
  /// Field
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogInsertField))]
  InsertField = 166,
  /// <summary>
  /// MergeField, WordField
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogInsertMergeField))]
  InsertMergeField = 167,
  /// <summary>
  /// Name, SortBy, Add, Delete, Goto, Hidden
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogInsertBookmark))]
  InsertBookmark = 168,
  /// <summary>
  /// No description is available.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogMarkIndexEntry))]
  MarkIndexEntry = 169,
  /// <summary>
  /// Outline, Fields, From, To, TableId, AddedStyles, Caption, HeadingSeparator, Replace, MarkEntry, AutoMark,
  /// MarkCitation, Type, RightAlignPageNumbers, Passim, KeepFormatting, Columns, Category, Label, ShowPageNumbers,
  /// AccentedLetters, Filter, SortBy, Leader, TOCUseHyperlinks, TOCHidePageNumInWeb, IndexLanguage,
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogInsertIndex))]
  InsertIndex = 170,
  /// <summary>
  /// Outline, Fields, From, To, TableId, AddedStyles, Caption, HeadingSeparator, Replace, MarkEntry, AutoMark,
  /// MarkCitation, Type, RightAlignPageNumbers, Passim, KeepFormatting, Columns, Category, Label, ShowPageNumbers,
  /// AccentedLetters, Filter, SortBy, Leader, TOCUseHyperlinks, TOCHidePageNumInWeb, IndexLanguage,
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogInsertTableOfContents))]
  InsertTableOfContents = 171,
  /// <summary>
  /// IconNumber, FileName, Link, DisplayIcon, Tab, Class, IconFileName, Caption, Floating
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogInsertObject))]
  InsertObject = 172,
  /// <summary>
  /// No description is available.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogToolsCreateEnvelope))]
  ToolsCreateEnvelope = 173,
  /// <summary>
  /// Points, Underline, Color, StrikeThrough, Superscript, Subscript, Hidden, SmallCaps, AllCaps, Spacing,
  /// Position, Kerning, KerningMin, Default, Tab, Font, Bold, Italic, DoubleStrikeThrough, Shadow, Outline, Emboss,
  /// Engrave, Scale, Animations, CharAccent, FontMajor, FontLowAnsi, FontHighAnsi, CharacterWidthGrid, ColorRGB,
  /// UnderlineColor, PointsBi, ColorBi, NameBi, BoldBi, ItalicBi,
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogFormatFont))]
  FormatFont = 174,
  /// <summary>
  /// LeftIndent, RightIndent, Before, After, LineSpacingRule, LineSpacing, Alignment, WidowControl, KeepWithNext,
  /// KeepTogether, PageBreak, NoLineNum, DontHyphen, Tab, FirstIndent, OutlineLevel, Kinsoku, WordWrap,
  /// OverflowPunct, TopLinePunct, AutoSpaceDE, LineHeightGrid, AutoSpaceDN, CharAlign, CharacterUnitLeftIndent,
  /// AdjustRight, CharacterUnitFirstIndent, CharacterUnitRightIndent, LineUnitBefore, LineUnitAfter,
  /// NoSpaceBetweenParagraphsOfSameStyle,
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogFormatParagraph))]
  FormatParagraph = 175,
  /// <summary>
  /// SectionStart, VertAlign, Endnotes, LineNum, StartingNum, FromText, CountBy, NumMode,
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogFormatSectionLayout))]
  FormatSectionLayout = 176,
  /// <summary>
  /// Columns, ColumnNo, ColumnWidth, ColumnSpacing, EvenlySpaced, ApplyColsTo, ColLine, StartNewCol, FlowColumnsRtl
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogFormatColumns))]
  FormatColumns = 177,
  /// <summary>
  /// Tab, PaperSize, TopMargin, BottomMargin, LeftMargin, RightMargin, Gutter, PageWidth, PageHeight, Orientation,
  /// FirstPage, OtherPages, VertAlign, ApplyPropsTo, Default, FacingPages, HeaderDistance, FooterDistance,
  /// SectionStart, OddAndEvenPages, DifferentFirstPage, Endnotes, LineNum, StartingNum, FromText, CountBy, NumMode,
  /// TwoOnOne, GutterPosition, LayoutMode, CharsLine, LinesPage, CharPitch, LinePitch, DocName, DocFontSize,
  /// PageColumns, TextFlow, FirstPageOnLeft, SectionType, RTLAlignment, FolioPrint
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogFilePageSetup))]
  FilePageSetup = 178,
  /// <summary>
  /// Tab, PaperSize, TopMargin, BottomMargin, LeftMargin, RightMargin, Gutter, PageWidth, PageHeight, Orientation,
  /// FirstPage, OtherPages, VertAlign, ApplyPropsTo, Default, FacingPages, HeaderDistance, FooterDistance,
  /// SectionStart, OddAndEvenPages, DifferentFirstPage, Endnotes, LineNum, StartingNum, FromText, CountBy, NumMode,
  /// TwoOnOne, GutterPosition, LayoutMode, CharsLine, LinesPage, CharPitch, LinePitch, DocName, DocFontSize,
  /// PageColumns, TextFlow, FirstPageOnLeft, SectionType, RTLAlignment
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogFileDocumentLayout))]
  FileDocumentLayout = 178,
  /// <summary>
  /// Position, DefTabs, Align, Leader, Set, Clear,
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogFormatTabs))]
  FormatTabs = 179,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogFormatStyle))]
  FormatStyle = 180,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogFormatDefineStyleFont))]
  FormatDefineStyleFont = 181,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogFormatDefineStylePara))]
  FormatDefineStylePara = 182,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogFormatDefineStyleTabs))]
  FormatDefineStyleTabs = 183,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogFormatDefineStyleFrame))]
  FormatDefineStyleFrame = 184,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogFormatDefineStyleBorders))]
  FormatDefineStyleBorders = 185,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogFormatDefineStyleLang))]
  FormatDefineStyleLang = 186,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogFormatPicture))]
  FormatPicture = 187,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogToolsLanguage))]
  ToolsLanguage = 188,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogFormatBordersAndShading))]
  FormatBordersAndShading = 189,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogFormatFrame))]
  FormatFrame = 190,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogToolsThesaurus))]
  ToolsThesaurus = 194,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogToolsHyphenation))]
  ToolsHyphenation = 195,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogToolsBulletsNumbers))]
  ToolsBulletsNumbers = 196,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogToolsRevisions))]
  ToolsRevisions = 197,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogToolsHighlightChanges))]
  ToolsHighlightChanges = 197,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogToolsCompareDocuments))]
  ToolsCompareDocuments = 198,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogTableSort))]
  TableSort = 199,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogToolsOptionsGeneral))]
  ToolsOptionsGeneral = 203,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogToolsOptionsView))]
  ToolsOptionsView = 204,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogToolsAdvancedSettings))]
  ToolsAdvancedSettings = 206,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogToolsOptionsPrint))]
  ToolsOptionsPrint = 208,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogToolsOptionsSave))]
  ToolsOptionsSave = 209,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogToolsOptionsSpellingAndGrammar))]
  ToolsOptionsSpellingAndGrammar = 211,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogToolsOptionsUserInfo))]
  ToolsOptionsUserInfo = 213,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogToolsMacroRecord))]
  ToolsMacroRecord = 214,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogToolsMacro))]
  ToolsMacro = 215,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogWindowActivate))]
  WindowActivate = 220,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogFormatRetAddrFonts))]
  FormatRetAddrFonts = 221,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogOrganizer))]
  Organizer = 222,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogToolsOptionsEdit))]
  ToolsOptionsEdit = 224,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogToolsOptionsFileLocations))]
  ToolsOptionsFileLocations = 225,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogToolsWordCount))]
  ToolsWordCount = 228,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogControlRun))]
  ControlRun = 235,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogInsertPageNumbers))]
  InsertPageNumbers = 294,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogFormatPageNumber))]
  FormatPageNumber = 298,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogCopyFile))]
  CopyFile = 300,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogFormatChangeCase))]
  FormatChangeCase = 322,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogUpdateTOC))]
  UpdateTOC = 331,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogInsertDatabase))]
  InsertDatabase = 341,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogTableFormula))]
  TableFormula = 348,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogFormFieldOptions))]
  FormFieldOptions = 353,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogInsertCaption))]
  InsertCaption = 357,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogInsertCaptionNumbering))]
  InsertCaptionNumbering = 358,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogInsertAutoCaption))]
  InsertAutoCaption = 359,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogFormFieldHelp))]
  FormFieldHelp = 361,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogInsertCrossReference))]
  InsertCrossReference = 367,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogInsertFootnote))]
  InsertFootnote = 370,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogNoteOptions))]
  NoteOptions = 373,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogToolsAutoCorrect))]
  ToolsAutoCorrect = 378,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogToolsOptionsTrackChanges))]
  ToolsOptionsTrackChanges = 386,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogConvertObject))]
  ConvertObject = 392,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogInsertAddCaption))]
  InsertAddCaption = 402,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogConnect))]
  Connect = 420,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogToolsCustomizeKeyboard))]
  ToolsCustomizeKeyboard = 432,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogToolsCustomizeMenus))]
  ToolsCustomizeMenus = 433,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogToolsMergeDocuments))]
  ToolsMergeDocuments = 435,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogMarkTableOfContentsEntry))]
  MarkTableOfContentsEntry = 442,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogFileMacPageSetupGX))]
  FileMacPageSetupGX = 444,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogFilePrintOneCopy))]
  FilePrintOneCopy = 445,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogEditFrame))]
  EditFrame = 458,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogMarkCitation))]
  MarkCitation = 463,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogTableOfContentsOptions))]
  TableOfContentsOptions = 470,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogInsertTableOfAuthorities))]
  InsertTableOfAuthorities = 471,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogInsertTableOfFigures))]
  InsertTableOfFigures = 472,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogInsertIndexAndTables))]
  InsertIndexAndTables = 473,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogInsertFormField))]
  InsertFormField = 483,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogFormatDropCap))]
  FormatDropCap = 488,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogToolsCreateLabels))]
  ToolsCreateLabels = 489,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogToolsProtectDocument))]
  ToolsProtectDocument = 503,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogFormatStyleGallery))]
  FormatStyleGallery = 505,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogToolsAcceptRejectChanges))]
  ToolsAcceptRejectChanges = 506,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogHelpWordPerfectHelpOptions))]
  HelpWordPerfectHelpOptions = 511,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogToolsUnprotectDocument))]
  ToolsUnprotectDocument = 521,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogToolsOptionsCompatibility))]
  ToolsOptionsCompatibility = 525,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogTableOfCaptionsOptions))]
  TableOfCaptionsOptions = 551,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogTableAutoFormat))]
  TableAutoFormat = 563,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogMailMergeFindRecord))]
  MailMergeFindRecord = 569,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogReviewAfmtRevisions))]
  ReviewAfmtRevisions = 570,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogViewZoom))]
  ViewZoom = 577,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogToolsProtectSection))]
  ToolsProtectSection = 578,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogFontSubstitution))]
  FontSubstitution = 581,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogInsertSubdocument))]
  InsertSubdocument = 583,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogNewToolbar))]
  NewToolbar = 586,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogToolsEnvelopesAndLabels))]
  ToolsEnvelopesAndLabels = 607,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogFormatCallout))]
  FormatCallout = 610,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogTableFormatCell))]
  TableFormatCell = 612,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogToolsCustomizeMenuBar))]
  ToolsCustomizeMenuBar = 615,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogFileRoutingSlip))]
  FileRoutingSlip = 624,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogEditTOACategory))]
  EditTOACategory = 625,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogToolsManageFields))]
  ToolsManageFields = 631,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogDrawSnapToGrid))]
  DrawSnapToGrid = 633,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogDrawAlign))]
  DrawAlign = 634,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogMailMergeCreateDataSource))]
  MailMergeCreateDataSource = 642,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogMailMergeCreateHeaderSource))]
  MailMergeCreateHeaderSource = 643,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogMailMerge))]
  MailMerge = 676,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogMailMergeCheck))]
  MailMergeCheck = 677,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogMailMergeHelper))]
  MailMergeHelper = 680,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogMailMergeQueryOptions))]
  MailMergeQueryOptions = 681,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogFileMacPageSetup))]
  FileMacPageSetup = 685,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogListCommands))]
  ListCommands = 723,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogEditCreatePublisher))]
  EditCreatePublisher = 732,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogEditSubscribeTo))]
  EditSubscribeTo = 733,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogEditPublishOptions))]
  EditPublishOptions = 735,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogEditSubscribeOptions))]
  EditSubscribeOptions = 736,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogFileMacCustomPageSetupGX))]
  FileMacCustomPageSetupGX = 737,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogToolsOptionsTypography))]
  ToolsOptionsTypography = 739,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogToolsAutoCorrectExceptions))]
  ToolsAutoCorrectExceptions = 762,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogToolsOptionsAutoFormatAsYouType))]
  ToolsOptionsAutoFormatAsYouType = 778,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogMailMergeUseAddressBook))]
  MailMergeUseAddressBook = 779,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogToolsHangulHanjaConversion))]
  ToolsHangulHanjaConversion = 784,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogToolsOptionsFuzzy))]
  ToolsOptionsFuzzy = 790,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogEditGoToOld))]
  EditGoToOld = 811,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogInsertNumber))]
  InsertNumber = 812,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogLetterWizard))]
  LetterWizard = 821,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogFormatBulletsAndNumbering))]
  FormatBulletsAndNumbering = 824,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogToolsSpellingAndGrammar))]
  ToolsSpellingAndGrammar = 828,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogToolsCreateDirectory))]
  ToolsCreateDirectory = 833,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogTableWrapping))]
  TableWrapping = 854,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogFormatTheme))]
  FormatTheme = 855,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogTableProperties))]
  TableProperties = 861,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogEmailOptions))]
  EmailOptions = 863,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogCreateAutoText))]
  CreateAutoText = 872,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogToolsAutoSummarize))]
  ToolsAutoSummarize = 874,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogToolsGrammarSettings))]
  ToolsGrammarSettings = 885,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogEditGoTo))]
  EditGoTo = 896,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogWebOptions))]
  WebOptions = 898,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogToolsAutoManager))]
  ToolsAutoManager = 915,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogInsertHyperlink))]
  InsertHyperlink = 925,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogFileVersions))]
  FileVersions = 945,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogToolsOptionsAutoFormat))]
  ToolsOptionsAutoFormat = 959,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogFormatDrawingObject))]
  FormatDrawingObject = 960,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogToolsOptions))]
  ToolsOptions = 974,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogFitText))]
  FitText = 983,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogEditAutoText))]
  EditAutoText = 985,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogPhoneticGuide))]
  PhoneticGuide = 986,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogToolsDictionary))]
  ToolsDictionary = 989,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogFileSaveVersion))]
  FileSaveVersion = 1007,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogToolsOptionsBidi))]
  ToolsOptionsBidi = 1029,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogFrameSetProperties))]
  FrameSetProperties = 1074,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogTableTableOptions))]
  TableTableOptions = 1080,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogTableCellOptions))]
  TableCellOptions = 1081,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogIMESetDefault))]
  IMESetDefault = 1094,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogFileNew2007))]
  FileNew2007 = 1116,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogConsistencyChecker))]
  ConsistencyChecker = 1121,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogTCSCTranslator))]
  TCSCTranslator = 1156,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogHorizontalInVertical))]
  HorizontalInVertical = 1160,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogTwoLinesInOne))]
  TwoLinesInOne = 1161,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogFormatEncloseCharacters))]
  FormatEncloseCharacters = 1162,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogFormatStylesCustom))]
  FormatStylesCustom = 1248,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogCSSLinks))]
  CSSLinks = 1261,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogMailMergeFieldMapping))]
  MailMergeFieldMapping = 1304,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogMailMergeInsertAddressBlock))]
  MailMergeInsertAddressBlock = 1305,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogMailMergeInsertGreetingLine))]
  MailMergeInsertGreetingLine = 1306,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogMailMergeInsertFields))]
  MailMergeInsertFields = 1307,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogMailMergeRecipients))]
  MailMergeRecipients = 1308,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogInsertWebComponent))]
  InsertWebComponent = 1324,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogMailMergeFindRecipient))]
  MailMergeFindRecipient = 1326,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogMailMergeSetDocumentType))]
  MailMergeSetDocumentType = 1339,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogToolsOptionsEditCopyPaste))]
  ToolsOptionsEditCopyPaste = 1356,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogToolsOptionsSecurity))]
  ToolsOptionsSecurity = 1361,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogSearch))]
  Search = 1363,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogLabelOptions))]
  LabelOptions = 1367,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogShowRepairs))]
  ShowRepairs = 1381,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogToolsOptionsSmartTag))]
  ToolsOptionsSmartTag = 1395,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogSchemaLibrary))]
  SchemaLibrary = 1417,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogXMLOptions))]
  XMLOptions = 1425,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogFormattingRestrictions))]
  FormattingRestrictions = 1427,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogMyPermission))]
  MyPermission = 1437,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogXMLElementAttributes))]
  XMLElementAttributes = 1460,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogPermission))]
  Permission = 1469,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogDocumentInspector))]
  DocumentInspector = 1482,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogSourceManager))]
  SourceManager = 1920,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogCreateSource))]
  CreateSource = 1922,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogStyleManagement))]
  StyleManagement = 1948,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogBuildingBlockOrganizer))]
  BuildingBlockOrganizer = 2067,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogInsertSource))]
  InsertSource = 2120,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogOMathRecognizedFunctions))]
  OMathRecognizedFunctions = 2165,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogInsertPlaceholder))]
  InsertPlaceholder = 2348,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogExportAsFixedFormat))]
  ExportAsFixedFormat = 2349,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogContentControlProperties))]
  ContentControlProperties = 2394,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogCompatibilityChecker))]
  CompatibilityChecker = 2439,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogMailMergeInsertAsk))]
  MailMergeInsertAsk = 4047,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogMailMergeInsertFillIn))]
  MailMergeInsertFillIn = 4048,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogMailMergeInsertIf))]
  MailMergeInsertIf = 4049,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogMailMergeInsertNextIf))]
  MailMergeInsertNextIf = 4053,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogMailMergeInsertSet))]
  MailMergeInsertSet = 4054,
  /// <summary>
  /// Indicates the Microsoft Office Word dialog boxes with which you can work and specifies arguments, if
  /// applicable, that you can use to get or set values in a dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWordDialog.wdDialogMailMergeInsertSkipIf))]
  MailMergeInsertSkipIf = 4055
}

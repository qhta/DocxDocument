using DocumentModel.Wordprocessing.Drawings;

namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents a contiguous area in a document.
/// </summary>
/// <remarks>
///   A Range object can represent a single character, a word, a sentence, a paragraph,
///   or the entire document. It corresponds to the Microsoft.Office.Interop.Word.Range interface.
/// </remarks>
public interface Range
{
  #region Range Boundaries and Position

  /// <summary>
  ///   Gets or sets the starting character position of the range.
  /// </summary>
  public int Start { get; set; }

  /// <summary>
  ///   Gets or sets the ending character position of the range.
  /// </summary>
  public int End { get; set; }

  /// <summary>
  ///   Gets the starting position of the range relative to the start of the story.
  /// </summary>
  public int StoryStart { get; }

  /// <summary>
  ///   Gets the ending position of the range relative to the start of the story.
  /// </summary>
  public int StoryEnd { get; }

  /// <summary>
  ///   Gets the type of story that contains the range.
  /// </summary>
  public StoryKind StoryType { get; }

  #endregion

  #region Text Content

  /// <summary>
  ///   Gets or sets the text of the range.
  /// </summary>
  public string? Text { get; set; }

  /// <summary>
  ///   Gets or sets the formatted text of the range (includes formatting codes).
  /// </summary>
  public string? FormattedText { get; set; }

  /// <summary>
  ///   Gets the number of characters in the range.
  /// </summary>
  public int Characters { get; }

  /// <summary>
  ///   Gets the number of words in the range.
  /// </summary>
  public int Words { get; }

  /// <summary>
  ///   Gets the number of sentences in the range.
  /// </summary>
  public int Sentences { get; }

  /// <summary>
  ///   Gets the number of paragraphs in the range.
  /// </summary>
  public int ParagraphsCount { get; }

  #endregion

  #region Collections

  /// <summary>
  ///   Gets the collection of paragraphs in the range.
  /// </summary>
  public Paragraphs? Paragraphs { get; }

  /// <summary>
  ///   Gets the collection of sentences in the range.
  /// </summary>
  public Sentences? SentencesCollection { get; }

  /// <summary>
  ///   Gets the collection of words in the range.
  /// </summary>
  public Words? WordsCollection { get; }

  /// <summary>
  ///   Gets the collection of characters in the range.
  /// </summary>
  public Characters? CharactersCollection { get; }

  /// <summary>
  ///   Gets the collection of fields in the range.
  /// </summary>
  public Fields? Fields { get; }

  /// <summary>
  ///   Gets the collection of bookmarks in the range.
  /// </summary>
  public Bookmarks? Bookmarks { get; }

  /// <summary>
  ///   Gets the collection of hyperlinks in the range.
  /// </summary>
  public Hyperlinks? Hyperlinks { get; }

  /// <summary>
  ///   Gets the collection of tables in the range.
  /// </summary>
  public Tables? Tables { get; }

  /// <summary>
  ///   Gets the collection of sections in the range.
  /// </summary>
  public Sections? Sections { get; }

  /// <summary>
  ///   Gets the collection of comments in the range.
  /// </summary>
  public Comments? Comments { get; }

  /// <summary>
  ///   Gets the collection of footnotes in the range.
  /// </summary>
  public Footnotes? Footnotes { get; }

  /// <summary>
  ///   Gets the collection of endnotes in the range.
  /// </summary>
  public Endnotes? Endnotes { get; }

  /// <summary>
  ///   Gets the collection of inline shapes in the range.
  /// </summary>
  public InlineShapes? InlineShapes { get; }

  /// <summary>
  ///   Gets the collection of shapes in the range.
  /// </summary>
  public Shapes? Shapes { get; }

  /// <summary>
  ///   Gets the collection of content controls in the range.
  /// </summary>
  public ContentControls? ContentControls { get; }

  /// <summary>
  ///   Gets the collection of revisions (tracked changes) in the range.
  /// </summary>
  public Revisions? Revisions { get; }

  /// <summary>
  ///   Gets the collection of subdocuments in the range.
  /// </summary>
  public Subdocuments? Subdocuments { get; }

  #endregion

  #region Formatting Properties

  /// <summary>
  ///   Gets or sets the font formatting for the range.
  /// </summary>
  public TextFormat? Font { get; set; }

  /// <summary>
  ///   Gets or sets the paragraph format for the range.
  /// </summary>
  public ParagraphFormat? ParagraphFormat { get; set; }

  /// <summary>
  ///   Gets or sets the list format for the range.
  /// </summary>
  public ListFormat? ListFormat { get; set; }

  /// <summary>
  ///   Gets or sets the style applied to the range.
  /// </summary>
  public string? Style { get; set; }

  /// <summary>
  ///   Gets or sets the language ID for the range.
  /// </summary>
  public int? LanguageID { get; set; }

  /// <summary>
  ///   Gets or sets whether the text is bold.
  /// </summary>
  public bool? Bold { get; set; }

  /// <summary>
  ///   Gets or sets whether the text is italic.
  /// </summary>
  public bool? Italic { get; set; }

  /// <summary>
  ///   Gets or sets the underline style.
  /// </summary>
  public UnderlineKind? Underline { get; set; }

  /// <summary>
  ///   Gets or sets the font name.
  /// </summary>
  public string? FontName { get; set; }

  /// <summary>
  ///   Gets or sets the font size in points.
  /// </summary>
  public float? FontSize { get; set; }

  /// <summary>
  ///   Gets or sets the highlight color.
  /// </summary>
  public ColorKind? HighlightColor { get; set; }

  /// <summary>
  ///   Gets or sets the case of the text.
  /// </summary>
  public CaseKind? Case { get; set; }

  /// <summary>
  ///   Gets or sets whether the text is all caps.
  /// </summary>
  public bool? AllCaps { get; set; }

  /// <summary>
  ///   Gets or sets whether the text is small caps.
  /// </summary>
  public bool? SmallCaps { get; set; }

  /// <summary>
  ///   Gets or sets whether the text has a strikethrough.
  /// </summary>
  public bool? StrikeThrough { get; set; }

  /// <summary>
  ///   Gets or sets whether the text has a double strikethrough.
  /// </summary>
  public bool? DoubleStrikeThrough { get; set; }

  /// <summary>
  ///   Gets or sets whether the text is subscript.
  /// </summary>
  public bool? Subscript { get; set; }

  /// <summary>
  ///   Gets or sets whether the text is superscript.
  /// </summary>
  public bool? Superscript { get; set; }

  /// <summary>
  ///   Gets or sets the character spacing in points.
  /// </summary>
  public float? CharacterSpacing { get; set; }

  /// <summary>
  ///   Gets or sets the character scaling percentage.
  /// </summary>
  public int? CharacterScale { get; set; }

  /// <summary>
  ///   Gets or sets whether the text is hidden.
  /// </summary>
  public bool? Hidden { get; set; }

  /// <summary>
  ///   Gets or sets the text color.
  /// </summary>
  public Color? TextColor { get; set; }

  /// <summary>
  ///   Gets or sets the shading applied to the range.
  /// </summary>
  public Shading? Shading { get; set; }

  /// <summary>
  ///   Gets or sets the borders for the range.
  /// </summary>
  public Borders? Borders { get; set; }

  #endregion

  #region Parent Objects

  /// <summary>
  ///   Gets the document that contains the range.
  /// </summary>
  public Document? Document { get; }

  /// <summary>
  ///   Gets the parent object of the range.
  /// </summary>
  public object? Parent { get; }

  /// <summary>
  ///   Gets the application object.
  /// </summary>
  public Application? Application { get; }

  #endregion

  #region Information Properties

  /// <summary>
  ///   Gets information about the range.
  /// </summary>
  /// <param name="type">The type of information to retrieve.</param>
  /// <returns>The requested information.</returns>
  public object? GetInformation(InformationKind type);

  /// <summary>
  ///   Indicates whether the range is in a table.
  /// </summary>
  public bool IsInTable { get; }

  /// <summary>
  ///   Gets the table that contains the range.
  /// </summary>
  public Table? Table { get; }

  /// <summary>
  ///   Gets the table cell that contains the range.
  /// </summary>
  public TableCell? Cell { get; }

  /// <summary>
  ///   Gets the column number of the range within a table.
  /// </summary>
  public int? ColumnNumber { get; }

  /// <summary>
  ///   Gets the row number of the range within a table.
  /// </summary>
  public int? RowNumber { get; }

  /// <summary>
  ///   Indicates whether the range is at the start of the document.
  /// </summary>
  public bool IsAtStartOfDocument { get; }

  /// <summary>
  ///   Indicates whether the range is at the end of the document.
  /// </summary>
  public bool IsAtEndOfDocument { get; }

  /// <summary>
  ///   Gets the orientation (horizontal or vertical) of the text in the range.
  /// </summary>
  public TextOrientationKind? Orientation { get; set; }

  #endregion

  #region Range Manipulation Methods

  /// <summary>
  ///   Collapses the range to the starting or ending position.
  /// </summary>
  /// <param name="direction">Direction to collapse (start or end).</param>
  public void Collapse(CollapseDirectionKind? direction = null);

  /// <summary>
  ///   Expands the range to a larger unit.
  /// </summary>
  /// <param name="unit">The unit to expand to (character, word, sentence, paragraph, etc.).</param>
  /// <returns>The number of units expanded.</returns>
  public int Expand(UnitKind unit);

  /// <summary>
  ///   Moves the range by the specified number of units.
  /// </summary>
  /// <param name="unit">The unit of movement.</param>
  /// <param name="count">The number of units to move.</param>
  /// <returns>The number of units actually moved.</returns>
  public int Move(UnitKind unit, int count = 1);

  /// <summary>
  ///   Moves the start position of the range.
  /// </summary>
  /// <param name="unit">The unit of movement.</param>
  /// <param name="count">The number of units to move.</param>
  /// <returns>The number of units actually moved.</returns>
  public int MoveStart(UnitKind unit, int count = 1);

  /// <summary>
  ///   Moves the end position of the range.
  /// </summary>
  /// <param name="unit">The unit of movement.</param>
  /// <param name="count">The number of units to move.</param>
  /// <returns>The number of units actually moved.</returns>
  public int MoveEnd(UnitKind unit, int count = 1);

  /// <summary>
  ///   Moves the range until the specified text is found.
  /// </summary>
  /// <param name="cset">The character set to move until.</param>
  /// <param name="count">The number of characters to move.</param>
  /// <returns>The actual number of characters moved.</returns>
  public int MoveUntil(string cset, int? count = null);

  /// <summary>
  ///   Moves the range while the specified characters are found.
  /// </summary>
  /// <param name="cset">The character set to move while.</param>
  /// <param name="count">The number of characters to move.</param>
  /// <returns>The actual number of characters moved.</returns>
  public int MoveWhile(string cset, int? count = null);

  /// <summary>
  ///   Moves the start of the range until the specified text is found.
  /// </summary>
  /// <param name="cset">The character set to move until.</param>
  /// <param name="count">The number of characters to move.</param>
  /// <returns>The actual number of characters moved.</returns>
  public int MoveStartUntil(string cset, int? count = null);

  /// <summary>
  ///   Moves the start of the range while the specified characters are found.
  /// </summary>
  /// <param name="cset">The character set to move while.</param>
  /// <param name="count">The number of characters to move.</param>
  /// <returns>The actual number of characters moved.</returns>
  public int MoveStartWhile(string cset, int? count = null);

  /// <summary>
  ///   Moves the end of the range until the specified text is found.
  /// </summary>
  /// <param name="cset">The character set to move until.</param>
  /// <param name="count">The number of characters to move.</param>
  /// <returns>The actual number of characters moved.</returns>
  public int MoveEndUntil(string cset, int? count = null);

  /// <summary>
  ///   Moves the end of the range while the specified characters are found.
  /// </summary>
  /// <param name="cset">The character set to move while.</param>
  /// <param name="count">The number of characters to move.</param>
  /// <returns>The actual number of characters moved.</returns>
  public int MoveEndWhile(string cset, int? count = null);

  /// <summary>
  ///   Selects the range.
  /// </summary>
  public void Select();

  /// <summary>
  ///   Creates a duplicate of the range.
  /// </summary>
  /// <returns>A new Range object that is a duplicate of this range.</returns>
  public Range? Duplicate();

  /// <summary>
  ///   Sets the range to include the specified start and end positions.
  /// </summary>
  /// <param name="start">The starting character position.</param>
  /// <param name="end">The ending character position.</param>
  public void SetRange(int start, int end);

  #endregion

  #region Text Manipulation Methods

  /// <summary>
  ///   Inserts text at the beginning or end of the range.
  /// </summary>
  /// <param name="text">The text to insert.</param>
  /// <param name="before">True to insert before, false to insert after.</param>
  public void InsertText(string text, bool before = false);

  /// <summary>
  ///   Inserts text before the range.
  /// </summary>
  /// <param name="text">The text to insert.</param>
  public void InsertBefore(string text);

  /// <summary>
  ///   Inserts text after the range.
  /// </summary>
  /// <param name="text">The text to insert.</param>
  public void InsertAfter(string text);

  /// <summary>
  ///   Inserts a paragraph mark.
  /// </summary>
  public void InsertParagraph();

  /// <summary>
  ///   Inserts a paragraph mark before the range.
  /// </summary>
  public void InsertParagraphBefore();

  /// <summary>
  ///   Inserts a paragraph mark after the range.
  /// </summary>
  public void InsertParagraphAfter();

  /// <summary>
  ///   Inserts a break (page, section, column, etc.).
  /// </summary>
  /// <param name="type">The type of break to insert.</param>
  public void InsertBreak(BreakKind type);

  /// <summary>
  ///   Inserts a file at the range.
  /// </summary>
  /// <param name="fileName">The path to the file.</param>
  /// <param name="range">Optional range within the file.</param>
  /// <param name="confirmConversions">Whether to confirm conversions.</param>
  /// <param name="link">Whether to insert as a link.</param>
  /// <param name="attachment">Whether to insert as an attachment.</param>
  public void InsertFile(string fileName, string? range = null, bool? confirmConversions = null,
                         bool? link = null, bool? attachment = null);

  /// <summary>
  ///   Inserts XML content.
  /// </summary>
  /// <param name="xml">The XML content to insert.</param>
  /// <param name="transform">Optional XSL transform.</param>
  public void InsertXML(string xml, string? transform = null);

  /// <summary>
  ///   Deletes the content of the range.
  /// </summary>
  /// <param name="unit">Optional unit to delete (character, word, etc.).</param>
  /// <param name="count">Number of units to delete.</param>
  /// <returns>The number of units deleted.</returns>
  public int Delete(UnitKind? unit = null, int count = 1);

  /// <summary>
  ///   Cuts the content of the range to the clipboard.
  /// </summary>
  public void Cut();

  /// <summary>
  ///   Copies the content of the range to the clipboard.
  /// </summary>
  public void Copy();

  /// <summary>
  ///   Pastes content from the clipboard into the range.
  /// </summary>
  public void Paste();

  /// <summary>
  ///   Pastes content with special formatting options.
  /// </summary>
  /// <param name="iconIndex">Icon index for display.</param>
  /// <param name="link">Whether to paste as a link.</param>
  /// <param name="placement">Placement of the pasted content.</param>
  /// <param name="displayAsIcon">Whether to display as an icon.</param>
  /// <param name="dataType">The data type to paste.</param>
  /// <param name="iconFileName">File name for the icon.</param>
  /// <param name="iconLabel">Label for the icon.</param>
  public void PasteSpecial(int? iconIndex = null, bool? link = null, int? placement = null,
                          bool? displayAsIcon = null, int? dataType = null,
                          string? iconFileName = null, string? iconLabel = null);

  /// <summary>
  ///   Copies formatting from the range.
  /// </summary>
  public void CopyFormat();

  /// <summary>
  ///   Pastes formatting to the range.
  /// </summary>
  public void PasteFormat();

  #endregion

  #region Find and Replace

  /// <summary>
  ///   Gets the Find object for searching within the range.
  /// </summary>
  public Find? Find { get; }

  /// <summary>
  ///   Gets the Replacement object for find and replace operations.
  /// </summary>
  public Replacement? Replacement { get; }

  #endregion

  #region Comparison and Testing

  /// <summary>
  ///   Compares the position of this range with another range.
  /// </summary>
  /// <param name="other">The range to compare with.</param>
  /// <returns>Comparison result indicating position relationship.</returns>
  public ComparisonKind? Compare(Range other);

  /// <summary>
  ///   Tests if this range is equal to another range.
  /// </summary>
  /// <param name="other">The range to compare with.</param>
  /// <returns>True if ranges are equal.</returns>
  public bool IsEqual(Range other);

  /// <summary>
  ///   Tests if this range overlaps with another range.
  /// </summary>
  /// <param name="other">The range to test for overlap.</param>
  /// <returns>True if ranges overlap.</returns>
  public bool Overlaps(Range other);

  /// <summary>
  ///   Determines if a range is within this range.
  /// </summary>
  /// <param name="other">The range to test.</param>
  /// <returns>True if the other range is within this range.</returns>
  public bool InRange(Range other);

  #endregion

  #region Content Insertion Methods

  /// <summary>
  ///   Inserts a symbol at the range.
  /// </summary>
  /// <param name="characterNumber">The character code of the symbol.</param>
  /// <param name="font">The font for the symbol.</param>
  /// <param name="unicode">Whether the character is Unicode.</param>
  /// <param name="bias">The bias for the insertion.</param>
  public void InsertSymbol(int characterNumber, string? font = null, bool? unicode = null, int? bias = null);

  /// <summary>
  ///   Inserts a cross-reference.
  /// </summary>
  /// <param name="referenceType">The type of reference.</param>
  /// <param name="referenceKind">The kind of reference.</param>
  /// <param name="referenceItem">The item to reference.</param>
  /// <param name="insertAsHyperlink">Whether to insert as a hyperlink.</param>
  /// <param name="includePosition">Whether to include position.</param>
  /// <param name="separateNumbers">Whether to separate numbers.</param>
  /// <param name="separatorString">The separator string.</param>
  public void InsertCrossReference(string referenceType, int referenceKind, string referenceItem,
                                   bool? insertAsHyperlink = null, bool? includePosition = null,
                                   bool? separateNumbers = null, string? separatorString = null);

  /// <summary>
  ///   Inserts a caption.
  /// </summary>
  /// <param name="label">The caption label.</param>
  /// <param name="title">The caption title.</param>
  /// <param name="titleAutoText">Auto text for the title.</param>
  /// <param name="position">Position of the caption.</param>
  /// <param name="excludeLabel">Whether to exclude the label.</param>
  public void InsertCaption(string label, string? title = null, string? titleAutoText = null,
                           CaptionPositionKind? position = null, bool? excludeLabel = null);

  /// <summary>
  ///   Inserts a table of contents.
  /// </summary>
  /// <param name="useHeadingStyles">Whether to use heading styles.</param>
  /// <param name="upperHeadingLevel">Upper heading level.</param>
  /// <param name="lowerHeadingLevel">Lower heading level.</param>
  /// <param name="useFields">Whether to use fields.</param>
  /// <param name="tableID">Table identifier.</param>
  /// <param name="rightAlignPageNumbers">Whether to right-align page numbers.</param>
  /// <param name="includePageNumbers">Whether to include page numbers.</param>
  /// <param name="addedStyles">Additional styles to include.</param>
  /// <param name="useHyperlinks">Whether to use hyperlinks.</param>
  /// <param name="hidePageNumbersInWeb">Whether to hide page numbers in web view.</param>
  /// <param name="useOutlineLevels">Whether to use outline levels.</param>
  public void InsertTableOfContents(bool? useHeadingStyles = null, int? upperHeadingLevel = null,
                                   int? lowerHeadingLevel = null, bool? useFields = null,
                                   string? tableID = null, bool? rightAlignPageNumbers = null,
                                   bool? includePageNumbers = null, string? addedStyles = null,
                                   bool? useHyperlinks = null, bool? hidePageNumbersInWeb = null,
                                   bool? useOutlineLevels = null);

  /// <summary>
  ///   Inserts a table of figures.
  /// </summary>
  /// <param name="label">The label to use.</param>
  /// <param name="includeLabel">Whether to include the label.</param>
  /// <param name="useHeadingStyles">Whether to use heading styles.</param>
  /// <param name="upperHeadingLevel">Upper heading level.</param>
  /// <param name="lowerHeadingLevel">Lower heading level.</param>
  /// <param name="useFields">Whether to use fields.</param>
  /// <param name="tableID">Table identifier.</param>
  /// <param name="rightAlignPageNumbers">Whether to right-align page numbers.</param>
  /// <param name="includePageNumbers">Whether to include page numbers.</param>
  /// <param name="addedStyles">Additional styles to include.</param>
  /// <param name="useHyperlinks">Whether to use hyperlinks.</param>
  /// <param name="hidePageNumbersInWeb">Whether to hide page numbers in web view.</param>
  /// <param name="useOutlineLevels">Whether to use outline levels.</param>
  public void InsertTableOfFigures(string? label = null, bool? includeLabel = null,
                                  bool? useHeadingStyles = null, int? upperHeadingLevel = null,
                                  int? lowerHeadingLevel = null, bool? useFields = null,
                                  string? tableID = null, bool? rightAlignPageNumbers = null,
                                  bool? includePageNumbers = null, string? addedStyles = null,
                                  bool? useHyperlinks = null, bool? hidePageNumbersInWeb = null,
                                  bool? useOutlineLevels = null);

  /// <summary>
  ///   Inserts an index.
  /// </summary>
  /// <param name="type">The type of index.</param>
  /// <param name="rightAlignPageNumbers">Whether to right-align page numbers.</param>
  /// <param name="includePageNumbers">Whether to include page numbers.</param>
  /// <param name="numberOfColumns">Number of columns.</param>
  /// <param name="useHeadingStyles">Whether to use heading styles.</param>
  public void InsertIndex(IndexKind type, bool? rightAlignPageNumbers = null,
                         bool? includePageNumbers = null, int? numberOfColumns = null,
                         bool? useHeadingStyles = null);

  /// <summary>
  ///   Inserts a database as a table.
  /// </summary>
  /// <param name="format">The format for the table.</param>
  /// <param name="style">The style to apply.</param>
  /// <param name="linkToSource">Whether to link to the source.</param>
  /// <param name="connection">Database connection string.</param>
  /// <param name="sqlStatement">SQL statement to execute.</param>
  /// <param name="passwordDocument">Password for the document.</param>
  /// <param name="passwordTemplate">Password for the template.</param>
  /// <param name="writePasswordDocument">Write password for the document.</param>
  /// <param name="writePasswordTemplate">Write password for the template.</param>
  /// <param name="dataSource">The data source.</param>
  /// <param name="from">Starting record.</param>
  /// <param name="to">Ending record.</param>
  /// <param name="includeFields">Whether to include fields.</param>
  public void InsertDatabase(int? format = null, string? style = null, bool? linkToSource = null,
                            string? connection = null, string? sqlStatement = null,
                            string? passwordDocument = null, string? passwordTemplate = null,
                            string? writePasswordDocument = null, string? writePasswordTemplate = null,
                            string? dataSource = null, int? from = null, int? to = null,
                            bool? includeFields = null);

  /// <summary>
  ///   Inserts a date and/or time field.
  /// </summary>
  /// <param name="dateTimeFormat">The format string for date/time.</param>
  /// <param name="insertAsField">Whether to insert as a field.</param>
  /// <param name="insertAsFullWidth">Whether to insert as full width.</param>
  /// <param name="dateLanguage">The language for the date.</param>
  /// <param name="calendarType">The calendar type.</param>
  public void InsertDateTime(string? dateTimeFormat = null, bool? insertAsField = null,
                            bool? insertAsFullWidth = null, int? dateLanguage = null,
                            int? calendarType = null);

  /// <summary>
  ///   Inserts auto text.
  /// </summary>
  public void InsertAutoText();

  #endregion

  #region Spell Check and Grammar

  /// <summary>
  ///   Gets the spelling errors collection for the range.
  /// </summary>
  public ProofreadingErrors? SpellingErrors { get; }

  /// <summary>
  ///   Gets the grammar errors collection for the range.
  /// </summary>
  public ProofreadingErrors? GrammaticalErrors { get; }

  /// <summary>
  ///   Checks spelling in the range.
  /// </summary>
  /// <param name="customDictionary">Custom dictionary to use.</param>
  /// <param name="ignoreUppercase">Whether to ignore uppercase words.</param>
  /// <param name="alwaysSuggest">Whether to always suggest corrections.</param>
  /// <param name="customDictionary2">Second custom dictionary.</param>
  public void CheckSpelling(string? customDictionary = null, bool? ignoreUppercase = null,
                           bool? alwaysSuggest = null, string? customDictionary2 = null);

  /// <summary>
  ///   Checks grammar in the range.
  /// </summary>
  public void CheckGrammar();

  /// <summary>
  ///   Gets suggestions for spelling corrections.
  /// </summary>
  /// <param name="customDictionary">Custom dictionary to use.</param>
  /// <param name="ignoreUppercase">Whether to ignore uppercase words.</param>
  /// <param name="mainDictionary">Main dictionary language.</param>
  /// <param name="suggestionMode">Suggestion mode.</param>
  /// <param name="customDictionary2">Second custom dictionary.</param>
  /// <returns>Collection of spelling suggestions.</returns>
  public SpellingSuggestions? GetSpellingSuggestions(string? customDictionary = null,
                                                     bool? ignoreUppercase = null,
                                                     int? mainDictionary = null,
                                                     int? suggestionMode = null,
                                                     string? customDictionary2 = null);

  #endregion

  #region Calculation and Conversion

  /// <summary>
  ///   Calculates a mathematical expression in the range.
  /// </summary>
  /// <returns>The result of the calculation.</returns>
  public float Calculate();

  /// <summary>
  ///   Converts the units of measurements in the range.
  /// </summary>
  /// <param name="oldUnits">The old units.</param>
  /// <param name="newUnits">The new units.</param>
  public void ConvertUnits(MeasurementUnitsKind oldUnits, MeasurementUnitsKind newUnits);

  /// <summary>
  ///   Converts Chinese text between simplified and traditional.
  /// </summary>
  /// <param name="direction">Direction of conversion.</param>
  /// <param name="commonTerms">Whether to convert common terms.</param>
  public void ConvertHangulAndHanja(HangulHanjaConversionKind direction, bool? commonTerms = null);

  /// <summary>
  ///   Converts numbers to text.
  /// </summary>
  public void ConvertNumbersToText();

  /// <summary>
  ///   Converts text to numbers.
  /// </summary>
  public void ConvertTextToNumbers();

  #endregion

  #region Next and Previous

  /// <summary>
  ///   Returns a range object that represents the next unit of the specified type.
  /// </summary>
  /// <param name="unit">The unit type.</param>
  /// <param name="count">The number of units.</param>
  /// <returns>The next range.</returns>
  public Range? Next(UnitKind unit, int count = 1);

  /// <summary>
  ///   Returns a range object that represents the previous unit of the specified type.
  /// </summary>
  /// <param name="unit">The unit type.</param>
  /// <param name="count">The number of units.</param>
  /// <returns>The previous range.</returns>
  public Range? Previous(UnitKind unit, int count = 1);

  /// <summary>
  ///   Returns the next subdocument in the collection.
  /// </summary>
  /// <returns>The next subdocument range.</returns>
  public Range? NextSubdocument();

  /// <summary>
  ///   Returns the previous subdocument in the collection.
  /// </summary>
  /// <returns>The previous subdocument range.</returns>
  public Range? PreviousSubdocument();

  #endregion

  #region Miscellaneous Methods

  /// <summary>
  ///   Sorts the paragraphs in the range.
  /// </summary>
  /// <param name="excludeHeader">Whether to exclude the header.</param>
  /// <param name="fieldNumber">Field number to sort by.</param>
  /// <param name="sortFieldType">Type of sort field.</param>
  /// <param name="sortOrder">Sort order (ascending/descending).</param>
  /// <param name="fieldNumber2">Second field number.</param>
  /// <param name="sortFieldType2">Second field type.</param>
  /// <param name="sortOrder2">Second sort order.</param>
  /// <param name="fieldNumber3">Third field number.</param>
  /// <param name="sortFieldType3">Third field type.</param>
  /// <param name="sortOrder3">Third sort order.</param>
  /// <param name="caseSensitive">Whether sort is case sensitive.</param>
  /// <param name="languageID">Language for sorting.</param>
  public void Sort(bool? excludeHeader = null, string? fieldNumber = null,
                  SortFieldKind? sortFieldType = null, SortOrderKind? sortOrder = null,
                  string? fieldNumber2 = null, SortFieldKind? sortFieldType2 = null,
                  SortOrderKind? sortOrder2 = null, string? fieldNumber3 = null,
                  SortFieldKind? sortFieldType3 = null, SortOrderKind? sortOrder3 = null,
                  bool? caseSensitive = null, int? languageID = null);

  /// <summary>
  ///   Sorts the table in the range.
  /// </summary>
  /// <param name="excludeHeader">Whether to exclude the header row.</param>
  /// <param name="fieldNumber">Field number to sort by.</param>
  /// <param name="sortFieldType">Type of sort field.</param>
  /// <param name="sortOrder">Sort order.</param>
  public void SortTable(bool? excludeHeader = null, string? fieldNumber = null,
                       SortFieldKind? sortFieldType = null, SortOrderKind? sortOrder = null);

  /// <summary>
  ///   Converts the range to a table.
  /// </summary>
  /// <param name="separator">Character separator.</param>
  /// <param name="numRows">Number of rows.</param>
  /// <param name="numColumns">Number of columns.</param>
  /// <param name="initialColumnWidth">Initial column width.</param>
  /// <param name="format">Table format.</param>
  /// <param name="applyBorders">Whether to apply borders.</param>
  /// <param name="applyShading">Whether to apply shading.</param>
  /// <param name="applyFont">Whether to apply font.</param>
  /// <param name="applyColor">Whether to apply color.</param>
  /// <param name="applyHeadingRows">Whether to apply heading rows.</param>
  /// <param name="applyLastRow">Whether to apply last row.</param>
  /// <param name="applyFirstColumn">Whether to apply first column.</param>
  /// <param name="applyLastColumn">Whether to apply last column.</param>
  /// <param name="autoFit">Whether to auto fit.</param>
  /// <param name="autoFitBehavior">Auto fit behavior.</param>
  /// <param name="defaultTableBehavior">Default table behavior.</param>
  /// <returns>The created table.</returns>
  public Table? ConvertToTable(string? separator = null, int? numRows = null, int? numColumns = null,
                               int? initialColumnWidth = null, int? format = null,
                               bool? applyBorders = null, bool? applyShading = null,
                               bool? applyFont = null, bool? applyColor = null,
                               bool? applyHeadingRows = null, bool? applyLastRow = null,
                               bool? applyFirstColumn = null, bool? applyLastColumn = null,
                               bool? autoFit = null, int? autoFitBehavior = null,
                               int? defaultTableBehavior = null);

  /// <summary>
  ///   Looks up information in a reference source.
  /// </summary>
  public void LookupNameProperties();

  /// <summary>
  ///   Computes statistics for the range.
  /// </summary>
  /// <param name="statistic">The type of statistic to compute.</param>
  /// <param name="includeFootnotesAndEndnotes">Whether to include footnotes and endnotes.</param>
  /// <returns>The computed statistic value.</returns>
  public int ComputeStatistics(StatisticKind statistic, bool? includeFootnotesAndEndnotes = null);

  /// <summary>
  ///   Detects the language of the text in the range.
  /// </summary>
  public void DetectLanguage();

  /// <summary>
  ///   Gets or sets whether to suppress line numbers.
  /// </summary>
  public bool? NoProofing { get; set; }

  /// <summary>
  ///   Gets or sets whether language detection is disabled for this range.
  /// </summary>
  public bool? LanguageDetected { get; set; }

  /// <summary>
  ///   Scrolls the range into view.
  /// </summary>
  /// <param name="start">Whether to scroll to the start of the range.</param>
  public void ScrollIntoView(bool? start = null);

  /// <summary>
  ///   Returns the next story range.
  /// </summary>
  /// <returns>The next story range.</returns>
  public Range? NextStoryRange { get; }

  /// <summary>
  ///   Gets the read-only status of the range.
  /// </summary>
  public bool IsReadOnly { get; }

  /// <summary>
  ///   Updates all fields in the range.
  /// </summary>
  public void UpdateFields();

  /// <summary>
  ///   Auto formats the range.
  /// </summary>
  public void AutoFormat();

  /// <summary>
  ///   Calculates the position of the range.
  /// </summary>
  /// <param name="horizontalPosition">Output horizontal position.</param>
  /// <param name="verticalPosition">Output vertical position.</param>
  /// <param name="width">Output width.</param>
  /// <param name="height">Output height.</param>
  /// <param name="relativeTo">What the position is relative to.</param>
  public void GetSpellingSuggestions(out float horizontalPosition, out float verticalPosition,
                                    out float width, out float height, int? relativeTo = null);

  #endregion
}

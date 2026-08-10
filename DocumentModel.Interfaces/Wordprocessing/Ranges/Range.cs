using DocumentModel.HTML;
using DocumentModel.Wordprocessing;

namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a contiguous area in a document.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range?view=word-pia"/>
public partial interface IRange : IModelObject
{
  /// <summary>
  /// Returns or sets the text in the specified range.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.text?view=word-pia"/>
  public string Text { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets a Range object that includes the formatted text in the specified range or selection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.formattedtext?view=word-pia"/>
  public IRange FormattedText { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the starting character position of a range.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.start?view=word-pia"/>
  public int Start { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the ending character position of a range.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.end?view=word-pia"/>
  public int End { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets a TextFormat object that represents the character formatting of the specified object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.font?view=word-pia"/>
  public ITextFormat TextFormat { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns a Range object that represents all the properties of the specified range.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.duplicate?view=word-pia"/>
  public IRange Duplicate { get; }

  /// <summary>
  /// Returns the story type for the specified range.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.storytype?view=word-pia"/>
  public StoryType StoryType { get; }

  /// <summary>
  /// Returns a Tables collection that represents all the tables in the specified range.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.tables?view=word-pia"/>
  public ITables Tables { get; }

  /// <summary>
  /// Returns a Words collection that represents all the words in a range.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.words?view=word-pia"/>
  public Words Words { get; }

  /// <summary>
  /// Returns a Sentences collection that represents all the sentences in the range.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.sentences?view=word-pia"/>
  public ISentences Sentences { get; }

  /// <summary>
  /// Returns a Characters collection that represents the characters in a range.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.characters?view=word-pia"/>
  public ICharacters Characters { get; }

  /// <summary>
  /// Returns a Footnotes collection that represents all the footnotes in a range.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.footnotes?view=word-pia"/>
  public IFootnotes Footnotes { get; }

  /// <summary>
  /// Returns a Endnotes collection that represents all the endnotes in a range.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.endnotes?view=word-pia"/>
  public IEndnotes Endnotes { get; }

  /// <summary>
  /// Returns a Comments collection that represents all the comments in the specified range.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.comments?view=word-pia"/>
  public IComments Comments { get; }

  /// <summary>
  /// Returns a Cells collection that represents the table cells in a range.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.cells?view=word-pia"/>
  public ICells Cells { get; }

  /// <summary>
  /// Returns a Sections collection that represents the sections in the specified range.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.sections?view=word-pia"/>
  public ISections Sections { get; }

  /// <summary>
  /// Returns a Paragraphs collection that represents all the paragraphs in the specified range.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.paragraphs?view=word-pia"/>
  public IParagraphs Paragraphs { get; }

  /// <summary>
  /// Returns a Borders collection that represents all the borders for the specified object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.borders?view=word-pia"/>
  public IBorders Borders { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns a Shading object that refers to the shading formatting for the specified object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.shading?view=word-pia"/>
  public DMD.IShading Shading { get; }

  /// <summary>
  /// Returns a TextRetrievalMode object that controls how text is retrieved from the specified range.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.textretrievalmode?view=word-pia"/>
  public ITextRetrievalMode TextRetrievalMode { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns a read-only Fields collection that represents all the fields in the range.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.fields?view=word-pia"/>
  public IFields Fields { get; }

  /// <summary>
  /// Returns a FormFields collection that represents all the form fields in the range.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.formfields?view=word-pia"/>
  public IFormFields FormFields { get; }

  /// <summary>
  /// Returns a Frames collection that represents all the frames in a range.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.frames?view=word-pia"/>
  public IFrames Frames { get; }

  /// <summary>
  /// Returns or sets a ParagraphFormat object that represents the paragraph settings for the specified range.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.paragraphformat?view=word-pia"/>
  public IParagraphFormat ParagraphFormat { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns a ListFormat object that represents all the list formatting characteristics of a range.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.listformat?view=word-pia"/>
  public IListFormat ListFormat { get; }

  /// <summary>
  /// Returns a Bookmarks collection that represents all the bookmarks in a range.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.bookmarks?view=word-pia"/>
  public IBookmarks Bookmarks { get; }

  /// <summary>
  /// Determines if the font or range is formatted as bold.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.bold?view=word-pia"/>
  public int Bold { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Determines if the range is formatted as italic.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.italic?view=word-pia"/>
  public int Italic { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the type of underline applied to the range.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.underline?view=word-pia"/>
  public UnderlineType Underline { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the emphasis mark for a character or designated character string.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.emphasismark?view=word-pia"/>
  public EmphasisMark EmphasisMark { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Determines if Microsoft Word ignores the number of characters per line for the range.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.disablecharacterspacegrid?view=word-pia"/>
  public bool DisableCharacterSpaceGrid { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns a Revisions collection that represents the tracked changes in the range.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.revisions?view=word-pia"/>
  public IRevisions Revisions { get; }

  /// <summary>
  /// Returns or sets the style for the specified object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.style?view=word-pia"/>
  public object Style { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns the number of characters in the story that contains the specified range.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.storylength?view=word-pia"/>
  public int StoryLength { get; }

  /// <summary>
  /// Returns or sets the language for the specified object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.languageid?view=word-pia"/>
  public LanguageID LanguageID { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns a SynonymInfo object that contains information from the thesaurus on synonyms, antonyms, or related
  /// words and expressions for the specified word or phrase.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.synonyminfo?view=word-pia"/>
  public ISynonymInfo SynonymInfo { get; }

  /// <summary>
  /// Returns a Hyperlinks collection that represents all the hyperlinks in the specified range.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.hyperlinks?view=word-pia"/>
  public IHyperlinks Hyperlinks { get; }

  /// <summary>
  /// Returns a ListParagraphs collection that represents all the numbered paragraphs in the range.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.listparagraphs?view=word-pia"/>
  public IListParagraphs ListParagraphs { get; }

  /// <summary>
  /// Returns a Subdocuments collection that represents all the subdocuments in the specified range.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.subdocuments?view=word-pia"/>
  public ISubdocuments Subdocuments { get; }

  /// <summary>
  /// Determines if a grammar check has been run on the specified range.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.grammarchecked?view=word-pia"/>
  public bool GrammarChecked { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Determines if spelling has been checked throughout the specified range.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.spellingchecked?view=word-pia"/>
  public bool SpellingChecked { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the highlight color for the specified range.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.highlightcolorindex?view=word-pia"/>
  public ColorIndex HighlightColorIndex { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns a Columns collection that represents all the table columns in the range.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.columns?view=word-pia"/>
  public IColumns Columns { get; }

  /// <summary>
  /// Returns a Rows collection that represents all the table rows in a range.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.rows?view=word-pia"/>
  public IRows Rows { get; }

  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.canedit?view=word-pia"/>
  public int CanEdit { get; }

  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.canpaste?view=word-pia"/>
  public int CanPaste { get; }

  /// <summary>
  /// Determines if the specified range is collapsed and is located at the end-of-row mark in a table.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.isendofrowmark?view=word-pia"/>
  public bool IsEndOfRowMark { get; }

  /// <summary>
  /// Returns the number of the bookmark that encloses the beginning of the specified selection or range; returns 0
  /// (zero) if there's no corresponding bookmark.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.bookmarkid?view=word-pia"/>
  public int BookmarkID { get; }

  /// <summary>
  /// Returns the number of the last bookmark that starts before or at the same place as the specified range.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.previousbookmarkid?view=word-pia"/>
  public int PreviousBookmarkID { get; }

  /// <summary>
  /// Returns a Find object that contains the criteria for a find operation.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.find?view=word-pia"/>
  public IFind Find { get; }

  /// <summary>
  /// Returns a PageSetup object that's associated with the specified range.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.pagesetup?view=word-pia"/>
  public IPageSetup PageSetup { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns a ShapeRange collection that represents all the Shape objects in the specified range.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.shaperange?view=word-pia"/>
  public DMD.IShapeRange ShapeRange { get; }

  /// <summary>
  /// Returns or sets a CharacterCase constant that represents the case of the text in the specified range.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.case?view=word-pia"/>
  public CharacterCase Case { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns a ReadabilityStatistics collection that represents the readability statistics for the specified range.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.readabilitystatistics?view=word-pia"/>
  public IReadabilityStatistics ReadabilityStatistics { get; }

  /// <summary>
  /// Returns a ProofreadingErrors collection that represents the sentences that failed the grammar check on the
  /// specified range.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.grammaticalerrors?view=word-pia"/>
  public IProofreadingErrors GrammaticalErrors { get; }

  /// <summary>
  /// Returns a ProofreadingErrors collection that represents the words identified as spelling errors in the
  /// specified range.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.spellingerrors?view=word-pia"/>
  public IProofreadingErrors SpellingErrors { get; }

  /// <summary>
  /// Returns or sets the orientation of text in a range when the Text Direction feature is enabled.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.orientation?view=word-pia"/>
  public TextOrientation Orientation { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns a IInlineShapes collection that represents all the InlineShape objects in a document, range, or
  /// selection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.inlineshapes?view=word-pia"/>
  public DMD.IInlineShapes InlineShapes { get; }

  /// <summary>
  /// Returns a Range object that refers to the next story as shown in the following table.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.nextstoryrange?view=word-pia"/>
  public IRange NextStoryRange { get; }

  /// <summary>
  /// Returns or sets an East Asian language for the specified object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.languageidfareast?view=word-pia"/>
  public LanguageID LanguageIDFarEast { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the language for the specified object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.languageidother?view=word-pia"/>
  public LanguageID LanguageIDOther { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets a value that specifies whether Microsoft Word has detected the language of the specified text.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.languagedetected?view=word-pia"/>
  public bool LanguageDetected { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the width (in the current measurement units) in which Microsoft Word fits the text in the
  /// current range.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.fittextwidth?view=word-pia"/>
  public float FitTextWidth { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the formatting for horizontal text set within vertical text.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.horizontalinvertical?view=word-pia"/>
  public HorizontalInVerticalType HorizontalInVertical { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets whether Microsoft Word sets two lines of text in one and specifies the characters that enclose
  /// the text, if any.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.twolinesinone?view=word-pia"/>
  public Wordprocessing.TwoLinesInOneType TwoLinesInOne { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Determines if the specified range contains combined characters.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.combinecharacters?view=word-pia"/>
  public bool CombineCharacters { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Determines if the spelling and grammar checker ignores the specified text.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.noproofing?view=word-pia"/>
  public int NoProofing { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns a Tables collection that represents the tables at the outermost nesting level in the current range.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.topleveltables?view=word-pia"/>
  public ITables TopLevelTables { get; }

  /// <summary>
  /// Returns a Scripts collection that represents the collection of HTML scripts in the specified object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.scripts?view=word-pia"/>
  public IScripts Scripts { get; }

  /// <summary>
  /// Returns or sets the character width of the specified range.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.characterwidth?view=word-pia"/>
  public CharacterWidth CharacterWidth { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets whether the specified range of Japanese language text is hiragana or katakana.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.kana?view=word-pia"/>
  public Kana Kana { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Determines if the font or range is formatted as bold.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.boldbi?view=word-pia"/>
  public int BoldBi { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Determines if the range is formatted as italic.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.italicbi?view=word-pia"/>
  public int ItalicBi { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the identifying label for the specified object when the current document is saved as a Web
  /// page.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.id?view=word-pia"/>
  public string ID { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns a HTMLDivisions object that represents an HTML division in a Web document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.htmldivisions?view=word-pia"/>
  public IHTMLDivisions HTMLDivisions { get; }

  /// <summary>
  /// Returns a SmartTags object that represents a smart tag in a range.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.smarttags?view=word-pia"/>
  public ISmartTags SmartTags { get; }

  /// <summary>
  /// Determines if all nonprinting characters (such as hidden text, tab marks, space marks, and paragraph marks)
  /// are displayed.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.showall?view=word-pia"/>
  public bool ShowAll { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns a Document object associated with the specified range.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.document?view=word-pia"/>
  public IDocument Document { get; }

  /// <summary>
  /// Returns a FootnoteOptions object that represents the footnote options in a range.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.footnoteoptions?view=word-pia"/>
  public IFootnoteOptions FootnoteOptions { get; }

  /// <summary>
  /// Returns a EndnoteOptions object that represents the endnotes in a range or selection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.endnoteoptions?view=word-pia"/>
  public IEndnoteOptions EndnoteOptions { get; }

  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.xmlnodes?view=word-pia"/>
  public IXMLNodes XMLNodes { get; }

  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.xmlparentnode?view=word-pia"/>
  public IXMLNode XMLParentNode { get; }

  /// <summary>
  /// Returns an Editors object that represents all the users authorized to modify a selection or range within a
  /// document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.editors?view=word-pia"/>
  public IEditors Editors { get; }

  /// <summary>
  /// Returns a picture representation of how a selection or range of text appears.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.enhmetafilebits?view=word-pia"/>
  public object EnhMetaFileBits { get; }

  /// <summary>
  /// Returns a Object that represents the style used to format one or more characters. Read-only.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.characterstyle?view=word-pia"/>
  public object CharacterStyle { get; }

  /// <summary>
  /// Returns an Object that represents the style used to format a paragraph. Read-only.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.paragraphstyle?view=word-pia"/>
  public object ParagraphStyle { get; }

  /// <summary>
  /// Returns an Object that represents the style used to format a bulleted list or numbered list. Read-only.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.liststyle?view=word-pia"/>
  public object ListStyle { get; }

  /// <summary>
  /// Returns a Object that represents the style used to format a table. Read-only.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.tablestyle?view=word-pia"/>
  public object TableStyle { get; }

  /// <summary>
  /// Returns a ContentControls collection that represents the content controls contained within a range. Read-only.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.contentcontrols?view=word-pia"/>
  public IContentControls ContentControls { get; }

  /// <summary>
  /// Returns a String that represents the XML contained within the range in the Microsoft Office Word Open XML
  /// format. Read-only.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.wordopenxml?view=word-pia"/>
  public string WordOpenXML { get; }

  /// <summary>
  /// Returns a ContentControl object that represents the parent content control for the specified range. Read-only.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.parentcontentcontrol?view=word-pia"/>
  public IContentControl ParentContentControl { get; }

  /// <summary>
  /// Gets a CoAuthLocks collection object that represents all the locks in the range.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.locks?view=word-pia"/>
  public ICoAuthLocks Locks { get; }

  /// <summary>
  /// Gets a CoAuthUpdates collection object that represents all the available updates in the range.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.updates?view=word-pia"/>
  public ICoAuthUpdates Updates { get; }

  /// <summary>
  /// Gets a Conflicts collection object that contains all the conflict objects in the range.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.conflicts?view=word-pia"/>
  public IConflicts Conflicts { get; }

  /// <summary>
  /// Returns an Integer (int in C#) that indicates whether the text in the specified range is visible on the
  /// screen. Read-only.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.textvisibleonscreen?view=word-pia"/>
  public int TextVisibleOnScreen { get; }
}

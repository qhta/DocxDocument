namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a contiguous area in a document.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range?view=word-pia"/>
public partial interface Range : InteropObject
{
  /// <summary>
  /// The text.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.text?view=word-pia"/>
  public string Text { get; set; }

  /// <summary>
  /// The formatted text.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.formattedtext?view=word-pia"/>
  public Range FormattedText { get; set; }

  /// <summary>
  /// The start.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.start?view=word-pia"/>
  public int Start { get; set; }

  /// <summary>
  /// The end.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.end?view=word-pia"/>
  public int End { get; set; }

  /// <summary>
  /// The font.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.font?view=word-pia"/>
  public Font Font { get; set; }

  /// <summary>
  /// The duplicate.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.duplicate?view=word-pia"/>
  public Range Duplicate { get; }

  /// <summary>
  /// The story type.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.storytype?view=word-pia"/>
  public WdStoryType StoryType { get; }

  /// <summary>
  /// The tables.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.tables?view=word-pia"/>
  public Tables Tables { get; }

  /// <summary>
  /// The words.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.words?view=word-pia"/>
  public Words Words { get; }

  /// <summary>
  /// The sentences.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.sentences?view=word-pia"/>
  public Sentences Sentences { get; }

  /// <summary>
  /// The characters.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.characters?view=word-pia"/>
  public Characters Characters { get; }

  /// <summary>
  /// The footnotes.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.footnotes?view=word-pia"/>
  public Footnotes Footnotes { get; }

  /// <summary>
  /// The endnotes.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.endnotes?view=word-pia"/>
  public Endnotes Endnotes { get; }

  /// <summary>
  /// The comments.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.comments?view=word-pia"/>
  public Comments Comments { get; }

  /// <summary>
  /// The cells.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.cells?view=word-pia"/>
  public Cells Cells { get; }

  /// <summary>
  /// The sections.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.sections?view=word-pia"/>
  public Sections Sections { get; }

  /// <summary>
  /// The paragraphs.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.paragraphs?view=word-pia"/>
  public Paragraphs Paragraphs { get; }

  /// <summary>
  /// The borders.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.borders?view=word-pia"/>
  public Borders Borders { get; set; }

  /// <summary>
  /// The shading.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.shading?view=word-pia"/>
  public Shading Shading { get; }

  /// <summary>
  /// The text retrieval mode.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.textretrievalmode?view=word-pia"/>
  public TextRetrievalMode TextRetrievalMode { get; set; }

  /// <summary>
  /// The fields.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.fields?view=word-pia"/>
  public Fields Fields { get; }

  /// <summary>
  /// The form fields.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.formfields?view=word-pia"/>
  public FormFields FormFields { get; }

  /// <summary>
  /// The frames.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.frames?view=word-pia"/>
  public Frames Frames { get; }

  /// <summary>
  /// The paragraph format.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.paragraphformat?view=word-pia"/>
  public ParagraphFormat ParagraphFormat { get; set; }

  /// <summary>
  /// The list format.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.listformat?view=word-pia"/>
  public ListFormat ListFormat { get; }

  /// <summary>
  /// The bookmarks.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.bookmarks?view=word-pia"/>
  public Bookmarks Bookmarks { get; }

  /// <summary>
  /// The bold.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.bold?view=word-pia"/>
  public int Bold { get; set; }

  /// <summary>
  /// The italic.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.italic?view=word-pia"/>
  public int Italic { get; set; }

  /// <summary>
  /// The underline.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.underline?view=word-pia"/>
  public WdUnderline Underline { get; set; }

  /// <summary>
  /// The emphasis mark.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.emphasismark?view=word-pia"/>
  public WdEmphasisMark EmphasisMark { get; set; }

  /// <summary>
  /// The disable character space grid.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.disablecharacterspacegrid?view=word-pia"/>
  public bool DisableCharacterSpaceGrid { get; set; }

  /// <summary>
  /// The revisions.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.revisions?view=word-pia"/>
  public Revisions Revisions { get; }

  /// <summary>
  /// The style.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.style?view=word-pia"/>
  public object Style { get; set; }

  /// <summary>
  /// The story length.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.storylength?view=word-pia"/>
  public int StoryLength { get; }

  /// <summary>
  /// The language id.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.languageid?view=word-pia"/>
  public WdLanguageID LanguageID { get; set; }

  /// <summary>
  /// The synonym info.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.synonyminfo?view=word-pia"/>
  public SynonymInfo SynonymInfo { get; }

  /// <summary>
  /// The hyperlinks.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.hyperlinks?view=word-pia"/>
  public Hyperlinks Hyperlinks { get; }

  /// <summary>
  /// The list paragraphs.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.listparagraphs?view=word-pia"/>
  public ListParagraphs ListParagraphs { get; }

  /// <summary>
  /// The subdocuments.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.subdocuments?view=word-pia"/>
  public Subdocuments Subdocuments { get; }

  /// <summary>
  /// The grammar checked.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.grammarchecked?view=word-pia"/>
  public bool GrammarChecked { get; set; }

  /// <summary>
  /// The spelling checked.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.spellingchecked?view=word-pia"/>
  public bool SpellingChecked { get; set; }

  /// <summary>
  /// The highlight color index.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.highlightcolorindex?view=word-pia"/>
  public WdColorIndex HighlightColorIndex { get; set; }

  /// <summary>
  /// The columns.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.columns?view=word-pia"/>
  public Columns Columns { get; }

  /// <summary>
  /// The rows.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.rows?view=word-pia"/>
  public Rows Rows { get; }

  /// <summary>
  /// The can edit.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.canedit?view=word-pia"/>
  public int CanEdit { get; }

  /// <summary>
  /// The can paste.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.canpaste?view=word-pia"/>
  public int CanPaste { get; }

  /// <summary>
  /// The is end of row mark.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.isendofrowmark?view=word-pia"/>
  public bool IsEndOfRowMark { get; }

  /// <summary>
  /// The bookmark id.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.bookmarkid?view=word-pia"/>
  public int BookmarkID { get; }

  /// <summary>
  /// The previous bookmark id.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.previousbookmarkid?view=word-pia"/>
  public int PreviousBookmarkID { get; }

  /// <summary>
  /// The find.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.find?view=word-pia"/>
  public Find Find { get; }

  /// <summary>
  /// The page setup.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.pagesetup?view=word-pia"/>
  public PageSetup PageSetup { get; set; }

  /// <summary>
  /// The shape range.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.shaperange?view=word-pia"/>
  public ShapeRange ShapeRange { get; }

  /// <summary>
  /// The case.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.case?view=word-pia"/>
  public WdCharacterCase Case { get; set; }

  /// <summary>
  /// The readability statistics.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.readabilitystatistics?view=word-pia"/>
  public ReadabilityStatistics ReadabilityStatistics { get; }

  /// <summary>
  /// The grammatical errors.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.grammaticalerrors?view=word-pia"/>
  public ProofreadingErrors GrammaticalErrors { get; }

  /// <summary>
  /// The spelling errors.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.spellingerrors?view=word-pia"/>
  public ProofreadingErrors SpellingErrors { get; }

  /// <summary>
  /// The orientation.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.orientation?view=word-pia"/>
  public WdTextOrientation Orientation { get; set; }

  /// <summary>
  /// The inline shapes.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.inlineshapes?view=word-pia"/>
  public InlineShapes InlineShapes { get; }

  /// <summary>
  /// The next story range.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.nextstoryrange?view=word-pia"/>
  public Range NextStoryRange { get; }

  /// <summary>
  /// The language idfar east.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.languageidfareast?view=word-pia"/>
  public WdLanguageID LanguageIDFarEast { get; set; }

  /// <summary>
  /// The language idother.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.languageidother?view=word-pia"/>
  public WdLanguageID LanguageIDOther { get; set; }

  /// <summary>
  /// The language detected.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.languagedetected?view=word-pia"/>
  public bool LanguageDetected { get; set; }

  /// <summary>
  /// The fit text width.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.fittextwidth?view=word-pia"/>
  public float FitTextWidth { get; set; }

  /// <summary>
  /// The horizontal in vertical.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.horizontalinvertical?view=word-pia"/>
  public WdHorizontalInVerticalType HorizontalInVertical { get; set; }

  /// <summary>
  /// The two lines in one.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.twolinesinone?view=word-pia"/>
  public WdTwoLinesInOneType TwoLinesInOne { get; set; }

  /// <summary>
  /// The combine characters.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.combinecharacters?view=word-pia"/>
  public bool CombineCharacters { get; set; }

  /// <summary>
  /// The no proofing.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.noproofing?view=word-pia"/>
  public int NoProofing { get; set; }

  /// <summary>
  /// The top level tables.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.topleveltables?view=word-pia"/>
  public Tables TopLevelTables { get; }

  /// <summary>
  /// The scripts.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.scripts?view=word-pia"/>
  public Core.Scripts Scripts { get; }

  /// <summary>
  /// The character width.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.characterwidth?view=word-pia"/>
  public WdCharacterWidth CharacterWidth { get; set; }

  /// <summary>
  /// The kana.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.kana?view=word-pia"/>
  public WdKana Kana { get; set; }

  /// <summary>
  /// The bold bi.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.boldbi?view=word-pia"/>
  public int BoldBi { get; set; }

  /// <summary>
  /// The italic bi.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.italicbi?view=word-pia"/>
  public int ItalicBi { get; set; }

  /// <summary>
  /// The id.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.id?view=word-pia"/>
  public string ID { get; set; }

  /// <summary>
  /// The htmldivisions.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.htmldivisions?view=word-pia"/>
  public HTMLDivisions HTMLDivisions { get; }

  /// <summary>
  /// The smart tags.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.smarttags?view=word-pia"/>
  public SmartTags SmartTags { get; }

  /// <summary>
  /// The show all.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.showall?view=word-pia"/>
  public bool ShowAll { get; set; }

  /// <summary>
  /// The document.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.document?view=word-pia"/>
  public Document Document { get; }

  /// <summary>
  /// The footnote options.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.footnoteoptions?view=word-pia"/>
  public FootnoteOptions FootnoteOptions { get; }

  /// <summary>
  /// The endnote options.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.endnoteoptions?view=word-pia"/>
  public EndnoteOptions EndnoteOptions { get; }

  /// <summary>
  /// The xmlnodes.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.xmlnodes?view=word-pia"/>
  public XMLNodes XMLNodes { get; }

  /// <summary>
  /// The xmlparent node.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.xmlparentnode?view=word-pia"/>
  public XMLNode XMLParentNode { get; }

  /// <summary>
  /// The editors.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.editors?view=word-pia"/>
  public Editors Editors { get; }

  /// <summary>
  /// The enh meta file bits.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.enhmetafilebits?view=word-pia"/>
  public object EnhMetaFileBits { get; }

  /// <summary>
  /// The omaths.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.omaths?view=word-pia"/>
  public OMaths OMaths { get; }

  /// <summary>
  /// The character style.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.characterstyle?view=word-pia"/>
  public object CharacterStyle { get; }

  /// <summary>
  /// The paragraph style.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.paragraphstyle?view=word-pia"/>
  public object ParagraphStyle { get; }

  /// <summary>
  /// The list style.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.liststyle?view=word-pia"/>
  public object ListStyle { get; }

  /// <summary>
  /// The table style.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.tablestyle?view=word-pia"/>
  public object TableStyle { get; }

  /// <summary>
  /// The content controls.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.contentcontrols?view=word-pia"/>
  public ContentControls ContentControls { get; }

  /// <summary>
  /// The word open xml.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.wordopenxml?view=word-pia"/>
  public string WordOpenXML { get; }

  /// <summary>
  /// The parent content control.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.parentcontentcontrol?view=word-pia"/>
  public ContentControl ParentContentControl { get; }

  /// <summary>
  /// The locks.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.locks?view=word-pia"/>
  public CoAuthLocks Locks { get; }

  /// <summary>
  /// The updates.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.updates?view=word-pia"/>
  public CoAuthUpdates Updates { get; }

  /// <summary>
  /// The conflicts.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.conflicts?view=word-pia"/>
  public Conflicts Conflicts { get; }

  /// <summary>
  /// The text visible on screen.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.textvisibleonscreen?view=word-pia"/>
  public int TextVisibleOnScreen { get; }
}

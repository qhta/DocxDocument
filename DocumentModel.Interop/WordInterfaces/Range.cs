namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a contiguous area in a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range?view=word-pia"/>
public partial interface Range : InteropObject
{
  /// <summary>
  /// The text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.text?view=word-pia"/>
  public string Text { get; set; }

  /// <summary>
  /// The formatted text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.formattedtext?view=word-pia"/>
  public Range FormattedText { get; set; }

  /// <summary>
  /// The start.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.start?view=word-pia"/>
  public int Start { get; set; }

  /// <summary>
  /// The end.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.end?view=word-pia"/>
  public int End { get; set; }

  /// <summary>
  /// The font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.font?view=word-pia"/>
  public Font Font { get; set; }

  /// <summary>
  /// The duplicate.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.duplicate?view=word-pia"/>
  public Range Duplicate { get; }

  /// <summary>
  /// The story type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.storytype?view=word-pia"/>
  public WdStoryType StoryType { get; }

  /// <summary>
  /// The tables.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.tables?view=word-pia"/>
  public Tables Tables { get; }

  /// <summary>
  /// The words.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.words?view=word-pia"/>
  public Words Words { get; }

  /// <summary>
  /// The sentences.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.sentences?view=word-pia"/>
  public Sentences Sentences { get; }

  /// <summary>
  /// The characters.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.characters?view=word-pia"/>
  public Characters Characters { get; }

  /// <summary>
  /// The footnotes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.footnotes?view=word-pia"/>
  public Footnotes Footnotes { get; }

  /// <summary>
  /// The endnotes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.endnotes?view=word-pia"/>
  public Endnotes Endnotes { get; }

  /// <summary>
  /// The comments.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.comments?view=word-pia"/>
  public Comments Comments { get; }

  /// <summary>
  /// The cells.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.cells?view=word-pia"/>
  public Cells Cells { get; }

  /// <summary>
  /// The sections.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.sections?view=word-pia"/>
  public Sections Sections { get; }

  /// <summary>
  /// The paragraphs.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.paragraphs?view=word-pia"/>
  public Paragraphs Paragraphs { get; }

  /// <summary>
  /// The borders.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.borders?view=word-pia"/>
  public Borders Borders { get; set; }

  /// <summary>
  /// The shading.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.shading?view=word-pia"/>
  public Shading Shading { get; }

  /// <summary>
  /// The text retrieval mode.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.textretrievalmode?view=word-pia"/>
  public TextRetrievalMode TextRetrievalMode { get; set; }

  /// <summary>
  /// The fields.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.fields?view=word-pia"/>
  public Fields Fields { get; }

  /// <summary>
  /// The form fields.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.formfields?view=word-pia"/>
  public FormFields FormFields { get; }

  /// <summary>
  /// The frames.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.frames?view=word-pia"/>
  public Frames Frames { get; }

  /// <summary>
  /// The paragraph format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.paragraphformat?view=word-pia"/>
  public ParagraphFormat ParagraphFormat { get; set; }

  /// <summary>
  /// The list format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.listformat?view=word-pia"/>
  public ListFormat ListFormat { get; }

  /// <summary>
  /// The bookmarks.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.bookmarks?view=word-pia"/>
  public Bookmarks Bookmarks { get; }

  /// <summary>
  /// The bold.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.bold?view=word-pia"/>
  public int Bold { get; set; }

  /// <summary>
  /// The italic.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.italic?view=word-pia"/>
  public int Italic { get; set; }

  /// <summary>
  /// The underline.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.underline?view=word-pia"/>
  public WdUnderline Underline { get; set; }

  /// <summary>
  /// The emphasis mark.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.emphasismark?view=word-pia"/>
  public WdEmphasisMark EmphasisMark { get; set; }

  /// <summary>
  /// The disable character space grid.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.disablecharacterspacegrid?view=word-pia"/>
  public bool DisableCharacterSpaceGrid { get; set; }

  /// <summary>
  /// The revisions.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.revisions?view=word-pia"/>
  public Revisions Revisions { get; }

  /// <summary>
  /// The style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.style?view=word-pia"/>
  public object Style { get; set; }

  /// <summary>
  /// The story length.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.storylength?view=word-pia"/>
  public int StoryLength { get; }

  /// <summary>
  /// The language id.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.languageid?view=word-pia"/>
  public WdLanguageID LanguageID { get; set; }

  /// <summary>
  /// The synonym info.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.synonyminfo?view=word-pia"/>
  public SynonymInfo SynonymInfo { get; }

  /// <summary>
  /// The hyperlinks.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.hyperlinks?view=word-pia"/>
  public Hyperlinks Hyperlinks { get; }

  /// <summary>
  /// The list paragraphs.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.listparagraphs?view=word-pia"/>
  public ListParagraphs ListParagraphs { get; }

  /// <summary>
  /// The subdocuments.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.subdocuments?view=word-pia"/>
  public Subdocuments Subdocuments { get; }

  /// <summary>
  /// The grammar checked.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.grammarchecked?view=word-pia"/>
  public bool GrammarChecked { get; set; }

  /// <summary>
  /// The spelling checked.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.spellingchecked?view=word-pia"/>
  public bool SpellingChecked { get; set; }

  /// <summary>
  /// The highlight color index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.highlightcolorindex?view=word-pia"/>
  public WdColorIndex HighlightColorIndex { get; set; }

  /// <summary>
  /// The columns.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.columns?view=word-pia"/>
  public Columns Columns { get; }

  /// <summary>
  /// The rows.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.rows?view=word-pia"/>
  public Rows Rows { get; }

  /// <summary>
  /// The can edit.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.canedit?view=word-pia"/>
  public int CanEdit { get; }

  /// <summary>
  /// The can paste.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.canpaste?view=word-pia"/>
  public int CanPaste { get; }

  /// <summary>
  /// The is end of row mark.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.isendofrowmark?view=word-pia"/>
  public bool IsEndOfRowMark { get; }

  /// <summary>
  /// The bookmark id.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.bookmarkid?view=word-pia"/>
  public int BookmarkID { get; }

  /// <summary>
  /// The previous bookmark id.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.previousbookmarkid?view=word-pia"/>
  public int PreviousBookmarkID { get; }

  /// <summary>
  /// The find.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.find?view=word-pia"/>
  public Find Find { get; }

  /// <summary>
  /// The page setup.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.pagesetup?view=word-pia"/>
  public PageSetup PageSetup { get; set; }

  /// <summary>
  /// The shape range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.shaperange?view=word-pia"/>
  public ShapeRange ShapeRange { get; }

  /// <summary>
  /// The case.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.case?view=word-pia"/>
  public WdCharacterCase Case { get; set; }

  /// <summary>
  /// The readability statistics.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.readabilitystatistics?view=word-pia"/>
  public ReadabilityStatistics ReadabilityStatistics { get; }

  /// <summary>
  /// The grammatical errors.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.grammaticalerrors?view=word-pia"/>
  public ProofreadingErrors GrammaticalErrors { get; }

  /// <summary>
  /// The spelling errors.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.spellingerrors?view=word-pia"/>
  public ProofreadingErrors SpellingErrors { get; }

  /// <summary>
  /// The orientation.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.orientation?view=word-pia"/>
  public WdTextOrientation Orientation { get; set; }

  /// <summary>
  /// The inline shapes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.inlineshapes?view=word-pia"/>
  public InlineShapes InlineShapes { get; }

  /// <summary>
  /// The next story range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.nextstoryrange?view=word-pia"/>
  public Range NextStoryRange { get; }

  /// <summary>
  /// The language idfar east.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.languageidfareast?view=word-pia"/>
  public WdLanguageID LanguageIDFarEast { get; set; }

  /// <summary>
  /// The language idother.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.languageidother?view=word-pia"/>
  public WdLanguageID LanguageIDOther { get; set; }

  /// <summary>
  /// The language detected.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.languagedetected?view=word-pia"/>
  public bool LanguageDetected { get; set; }

  /// <summary>
  /// The fit text width.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.fittextwidth?view=word-pia"/>
  public float FitTextWidth { get; set; }

  /// <summary>
  /// The horizontal in vertical.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.horizontalinvertical?view=word-pia"/>
  public WdHorizontalInVerticalType HorizontalInVertical { get; set; }

  /// <summary>
  /// The two lines in one.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.twolinesinone?view=word-pia"/>
  public WdTwoLinesInOneType TwoLinesInOne { get; set; }

  /// <summary>
  /// The combine characters.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.combinecharacters?view=word-pia"/>
  public bool CombineCharacters { get; set; }

  /// <summary>
  /// The no proofing.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.noproofing?view=word-pia"/>
  public int NoProofing { get; set; }

  /// <summary>
  /// The top level tables.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.topleveltables?view=word-pia"/>
  public Tables TopLevelTables { get; }

  /// <summary>
  /// The scripts.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.scripts?view=word-pia"/>
  public Core.Scripts Scripts { get; }

  /// <summary>
  /// The character width.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.characterwidth?view=word-pia"/>
  public WdCharacterWidth CharacterWidth { get; set; }

  /// <summary>
  /// The kana.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.kana?view=word-pia"/>
  public WdKana Kana { get; set; }

  /// <summary>
  /// The bold bi.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.boldbi?view=word-pia"/>
  public int BoldBi { get; set; }

  /// <summary>
  /// The italic bi.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.italicbi?view=word-pia"/>
  public int ItalicBi { get; set; }

  /// <summary>
  /// The id.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.id?view=word-pia"/>
  public string ID { get; set; }

  /// <summary>
  /// The htmldivisions.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.htmldivisions?view=word-pia"/>
  public HTMLDivisions HTMLDivisions { get; }

  /// <summary>
  /// The smart tags.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.smarttags?view=word-pia"/>
  public SmartTags SmartTags { get; }

  /// <summary>
  /// The show all.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.showall?view=word-pia"/>
  public bool ShowAll { get; set; }

  /// <summary>
  /// The document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.document?view=word-pia"/>
  public Document Document { get; }

  /// <summary>
  /// The footnote options.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.footnoteoptions?view=word-pia"/>
  public FootnoteOptions FootnoteOptions { get; }

  /// <summary>
  /// The endnote options.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.endnoteoptions?view=word-pia"/>
  public EndnoteOptions EndnoteOptions { get; }

  /// <summary>
  /// The xmlnodes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.xmlnodes?view=word-pia"/>
  public XMLNodes XMLNodes { get; }

  /// <summary>
  /// The xmlparent node.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.xmlparentnode?view=word-pia"/>
  public XMLNode XMLParentNode { get; }

  /// <summary>
  /// The editors.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.editors?view=word-pia"/>
  public Editors Editors { get; }

  /// <summary>
  /// The enh meta file bits.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.enhmetafilebits?view=word-pia"/>
  public object EnhMetaFileBits { get; }

  /// <summary>
  /// The omaths.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.omaths?view=word-pia"/>
  public OMaths OMaths { get; }

  /// <summary>
  /// The character style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.characterstyle?view=word-pia"/>
  public object CharacterStyle { get; }

  /// <summary>
  /// The paragraph style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.paragraphstyle?view=word-pia"/>
  public object ParagraphStyle { get; }

  /// <summary>
  /// The list style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.liststyle?view=word-pia"/>
  public object ListStyle { get; }

  /// <summary>
  /// The table style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.tablestyle?view=word-pia"/>
  public object TableStyle { get; }

  /// <summary>
  /// The content controls.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.contentcontrols?view=word-pia"/>
  public ContentControls ContentControls { get; }

  /// <summary>
  /// The word open xml.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.wordopenxml?view=word-pia"/>
  public string WordOpenXML { get; }

  /// <summary>
  /// The parent content control.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.parentcontentcontrol?view=word-pia"/>
  public ContentControl ParentContentControl { get; }

  /// <summary>
  /// The locks.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.locks?view=word-pia"/>
  public CoAuthLocks Locks { get; }

  /// <summary>
  /// The updates.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.updates?view=word-pia"/>
  public CoAuthUpdates Updates { get; }

  /// <summary>
  /// The conflicts.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.conflicts?view=word-pia"/>
  public Conflicts Conflicts { get; }

  /// <summary>
  /// The text visible on screen.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.textvisibleonscreen?view=word-pia"/>
  public int TextVisibleOnScreen { get; }
}

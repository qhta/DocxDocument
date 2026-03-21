namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a contiguous area in a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range?view=word-pia"/>
public partial interface Range : InteropObject
{
  /// <summary>
  /// Returns or sets the text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.text?view=word-pia"/>
  public string Text { get; set; }

  /// <summary>
  /// Returns or sets the formatted text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.formattedtext?view=word-pia"/>
  public Range FormattedText { get; set; }

  /// <summary>
  /// Returns or sets the start.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.start?view=word-pia"/>
  public int Start { get; set; }

  /// <summary>
  /// Returns or sets the end.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.end?view=word-pia"/>
  public int End { get; set; }

  /// <summary>
  /// Returns or sets the font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.font?view=word-pia"/>
  public Font Font { get; set; }

  /// <summary>
  /// Returns the duplicate.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.duplicate?view=word-pia"/>
  public Range Duplicate { get; }

  /// <summary>
  /// Returns the story type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.storytype?view=word-pia"/>
  public WdStoryType StoryType { get; }

  /// <summary>
  /// Returns the tables.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.tables?view=word-pia"/>
  public Tables Tables { get; }

  /// <summary>
  /// Returns the words.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.words?view=word-pia"/>
  public Words Words { get; }

  /// <summary>
  /// Returns the sentences.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.sentences?view=word-pia"/>
  public Sentences Sentences { get; }

  /// <summary>
  /// Returns the characters.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.characters?view=word-pia"/>
  public Characters Characters { get; }

  /// <summary>
  /// Returns the footnotes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.footnotes?view=word-pia"/>
  public Footnotes Footnotes { get; }

  /// <summary>
  /// Returns the endnotes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.endnotes?view=word-pia"/>
  public Endnotes Endnotes { get; }

  /// <summary>
  /// Returns the comments.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.comments?view=word-pia"/>
  public Comments Comments { get; }

  /// <summary>
  /// Returns the cells.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.cells?view=word-pia"/>
  public Cells Cells { get; }

  /// <summary>
  /// Returns the sections.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.sections?view=word-pia"/>
  public Sections Sections { get; }

  /// <summary>
  /// Returns the paragraphs.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.paragraphs?view=word-pia"/>
  public Paragraphs Paragraphs { get; }

  /// <summary>
  /// Returns or sets the borders.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.borders?view=word-pia"/>
  public Borders Borders { get; set; }

  /// <summary>
  /// Returns the shading.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.shading?view=word-pia"/>
  public Shading Shading { get; }

  /// <summary>
  /// Returns or sets the text retrieval mode.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.textretrievalmode?view=word-pia"/>
  public TextRetrievalMode TextRetrievalMode { get; set; }

  /// <summary>
  /// Returns the fields.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.fields?view=word-pia"/>
  public Fields Fields { get; }

  /// <summary>
  /// Returns the form fields.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.formfields?view=word-pia"/>
  public FormFields FormFields { get; }

  /// <summary>
  /// Returns the frames.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.frames?view=word-pia"/>
  public Frames Frames { get; }

  /// <summary>
  /// Returns or sets the paragraph format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.paragraphformat?view=word-pia"/>
  public ParagraphFormat ParagraphFormat { get; set; }

  /// <summary>
  /// Returns the list format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.listformat?view=word-pia"/>
  public ListFormat ListFormat { get; }

  /// <summary>
  /// Returns the bookmarks.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.bookmarks?view=word-pia"/>
  public Bookmarks Bookmarks { get; }

  /// <summary>
  /// Returns or sets the bold.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.bold?view=word-pia"/>
  public int Bold { get; set; }

  /// <summary>
  /// Returns or sets the italic.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.italic?view=word-pia"/>
  public int Italic { get; set; }

  /// <summary>
  /// Returns or sets the underline.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.underline?view=word-pia"/>
  public WdUnderline Underline { get; set; }

  /// <summary>
  /// Returns or sets the emphasis mark.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.emphasismark?view=word-pia"/>
  public WdEmphasisMark EmphasisMark { get; set; }

  /// <summary>
  /// Returns or sets whether disable character space grid.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.disablecharacterspacegrid?view=word-pia"/>
  public bool DisableCharacterSpaceGrid { get; set; }

  /// <summary>
  /// Returns the revisions.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.revisions?view=word-pia"/>
  public Revisions Revisions { get; }

  /// <summary>
  /// Returns or sets the style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.style?view=word-pia"/>
  public object Style { get; set; }

  /// <summary>
  /// Returns the story length.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.storylength?view=word-pia"/>
  public int StoryLength { get; }

  /// <summary>
  /// Returns or sets the language i d.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.languageid?view=word-pia"/>
  public WdLanguageID LanguageID { get; set; }

  /// <summary>
  /// Returns the synonym info.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.synonyminfo?view=word-pia"/>
  public SynonymInfo SynonymInfo { get; }

  /// <summary>
  /// Returns the hyperlinks.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.hyperlinks?view=word-pia"/>
  public Hyperlinks Hyperlinks { get; }

  /// <summary>
  /// Returns the list paragraphs.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.listparagraphs?view=word-pia"/>
  public ListParagraphs ListParagraphs { get; }

  /// <summary>
  /// Returns the subdocuments.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.subdocuments?view=word-pia"/>
  public Subdocuments Subdocuments { get; }

  /// <summary>
  /// Returns or sets whether grammar checked.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.grammarchecked?view=word-pia"/>
  public bool GrammarChecked { get; set; }

  /// <summary>
  /// Returns or sets whether spelling checked.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.spellingchecked?view=word-pia"/>
  public bool SpellingChecked { get; set; }

  /// <summary>
  /// Returns or sets the highlight color index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.highlightcolorindex?view=word-pia"/>
  public WdColorIndex HighlightColorIndex { get; set; }

  /// <summary>
  /// Returns the columns.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.columns?view=word-pia"/>
  public Columns Columns { get; }

  /// <summary>
  /// Returns the rows.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.rows?view=word-pia"/>
  public Rows Rows { get; }

  /// <summary>
  /// Returns the can edit.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.canedit?view=word-pia"/>
  public int CanEdit { get; }

  /// <summary>
  /// Returns the can paste.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.canpaste?view=word-pia"/>
  public int CanPaste { get; }

  /// <summary>
  /// Returns whether end of row mark.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.isendofrowmark?view=word-pia"/>
  public bool IsEndOfRowMark { get; }

  /// <summary>
  /// Returns the bookmark i d.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.bookmarkid?view=word-pia"/>
  public int BookmarkID { get; }

  /// <summary>
  /// Returns the previous bookmark i d.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.previousbookmarkid?view=word-pia"/>
  public int PreviousBookmarkID { get; }

  /// <summary>
  /// Returns the find.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.find?view=word-pia"/>
  public Find Find { get; }

  /// <summary>
  /// Returns or sets the page setup.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.pagesetup?view=word-pia"/>
  public PageSetup PageSetup { get; set; }

  /// <summary>
  /// Returns the shape range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.shaperange?view=word-pia"/>
  public ShapeRange ShapeRange { get; }

  /// <summary>
  /// Returns or sets the case.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.case?view=word-pia"/>
  public WdCharacterCase Case { get; set; }

  /// <summary>
  /// Returns the readability statistics.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.readabilitystatistics?view=word-pia"/>
  public ReadabilityStatistics ReadabilityStatistics { get; }

  /// <summary>
  /// Returns the grammatical errors.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.grammaticalerrors?view=word-pia"/>
  public ProofreadingErrors GrammaticalErrors { get; }

  /// <summary>
  /// Returns the spelling errors.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.spellingerrors?view=word-pia"/>
  public ProofreadingErrors SpellingErrors { get; }

  /// <summary>
  /// Returns or sets the orientation.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.orientation?view=word-pia"/>
  public WdTextOrientation Orientation { get; set; }

  /// <summary>
  /// Returns the inline shapes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.inlineshapes?view=word-pia"/>
  public InlineShapes InlineShapes { get; }

  /// <summary>
  /// Returns the next story range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.nextstoryrange?view=word-pia"/>
  public Range NextStoryRange { get; }

  /// <summary>
  /// Returns or sets the language i d far east.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.languageidfareast?view=word-pia"/>
  public WdLanguageID LanguageIDFarEast { get; set; }

  /// <summary>
  /// Returns or sets the language i d other.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.languageidother?view=word-pia"/>
  public WdLanguageID LanguageIDOther { get; set; }

  /// <summary>
  /// Returns or sets whether language detected.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.languagedetected?view=word-pia"/>
  public bool LanguageDetected { get; set; }

  /// <summary>
  /// Returns or sets the fit text width.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.fittextwidth?view=word-pia"/>
  public float FitTextWidth { get; set; }

  /// <summary>
  /// Returns or sets the horizontal in vertical.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.horizontalinvertical?view=word-pia"/>
  public WdHorizontalInVerticalType HorizontalInVertical { get; set; }

  /// <summary>
  /// Returns or sets the two lines in one.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.twolinesinone?view=word-pia"/>
  public WdTwoLinesInOneType TwoLinesInOne { get; set; }

  /// <summary>
  /// Returns or sets whether combine characters.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.combinecharacters?view=word-pia"/>
  public bool CombineCharacters { get; set; }

  /// <summary>
  /// Returns or sets the no proofing.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.noproofing?view=word-pia"/>
  public int NoProofing { get; set; }

  /// <summary>
  /// Returns the top level tables.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.topleveltables?view=word-pia"/>
  public Tables TopLevelTables { get; }

  /// <summary>
  /// Returns the scripts.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.scripts?view=word-pia"/>
  public Core.Scripts Scripts { get; }

  /// <summary>
  /// Returns or sets the character width.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.characterwidth?view=word-pia"/>
  public WdCharacterWidth CharacterWidth { get; set; }

  /// <summary>
  /// Returns or sets the kana.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.kana?view=word-pia"/>
  public WdKana Kana { get; set; }

  /// <summary>
  /// Returns or sets the bold bi.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.boldbi?view=word-pia"/>
  public int BoldBi { get; set; }

  /// <summary>
  /// Returns or sets the italic bi.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.italicbi?view=word-pia"/>
  public int ItalicBi { get; set; }

  /// <summary>
  /// Returns or sets the i d.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.id?view=word-pia"/>
  public string ID { get; set; }

  /// <summary>
  /// Returns the h t m l divisions.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.htmldivisions?view=word-pia"/>
  public HTMLDivisions HTMLDivisions { get; }

  /// <summary>
  /// Returns the smart tags.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.smarttags?view=word-pia"/>
  public SmartTags SmartTags { get; }

  /// <summary>
  /// Returns or sets whether show all.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.showall?view=word-pia"/>
  public bool ShowAll { get; set; }

  /// <summary>
  /// Returns the document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.document?view=word-pia"/>
  public Document Document { get; }

  /// <summary>
  /// Returns the footnote options.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.footnoteoptions?view=word-pia"/>
  public FootnoteOptions FootnoteOptions { get; }

  /// <summary>
  /// Returns the endnote options.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.endnoteoptions?view=word-pia"/>
  public EndnoteOptions EndnoteOptions { get; }

  /// <summary>
  /// Returns the x m l nodes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.xmlnodes?view=word-pia"/>
  public XMLNodes XMLNodes { get; }

  /// <summary>
  /// Returns the x m l parent node.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.xmlparentnode?view=word-pia"/>
  public XMLNode XMLParentNode { get; }

  /// <summary>
  /// Returns the editors.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.editors?view=word-pia"/>
  public Editors Editors { get; }

  /// <summary>
  /// Returns the enh meta file bits.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.enhmetafilebits?view=word-pia"/>
  public object EnhMetaFileBits { get; }

  /// <summary>
  /// Returns the o maths.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.omaths?view=word-pia"/>
  public OMaths OMaths { get; }

  /// <summary>
  /// Returns the character style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.characterstyle?view=word-pia"/>
  public object CharacterStyle { get; }

  /// <summary>
  /// Returns the paragraph style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.paragraphstyle?view=word-pia"/>
  public object ParagraphStyle { get; }

  /// <summary>
  /// Returns the list style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.liststyle?view=word-pia"/>
  public object ListStyle { get; }

  /// <summary>
  /// Returns the table style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.tablestyle?view=word-pia"/>
  public object TableStyle { get; }

  /// <summary>
  /// Returns the content controls.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.contentcontrols?view=word-pia"/>
  public ContentControls ContentControls { get; }

  /// <summary>
  /// Returns the word open x m l.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.wordopenxml?view=word-pia"/>
  public string WordOpenXML { get; }

  /// <summary>
  /// Returns the parent content control.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.parentcontentcontrol?view=word-pia"/>
  public ContentControl ParentContentControl { get; }

  /// <summary>
  /// Returns the locks.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.locks?view=word-pia"/>
  public CoAuthLocks Locks { get; }

  /// <summary>
  /// Returns the updates.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.updates?view=word-pia"/>
  public CoAuthUpdates Updates { get; }

  /// <summary>
  /// Returns the conflicts.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.conflicts?view=word-pia"/>
  public Conflicts Conflicts { get; }

  /// <summary>
  /// Returns the text visible on screen.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.range.textvisibleonscreen?view=word-pia"/>
  public int TextVisibleOnScreen { get; }
}

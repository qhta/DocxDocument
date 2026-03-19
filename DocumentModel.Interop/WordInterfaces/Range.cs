namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a contiguous area in a document.
/// </summary>
public partial interface Range : InteropObject
{
  /// <summary>
  /// The text.
  /// </summary>
  public string Text { get; set; }

  /// <summary>
  /// The formatted text.
  /// </summary>
  public Range FormattedText { get; set; }

  /// <summary>
  /// The start.
  /// </summary>
  public int Start { get; set; }

  /// <summary>
  /// The end.
  /// </summary>
  public int End { get; set; }

  /// <summary>
  /// The font.
  /// </summary>
  public Font Font { get; set; }

  /// <summary>
  /// The duplicate.
  /// </summary>
  public Range Duplicate { get; }

  /// <summary>
  /// The story type.
  /// </summary>
  public WdStoryType StoryType { get; }

  /// <summary>
  /// The tables.
  /// </summary>
  public Tables Tables { get; }

  /// <summary>
  /// The words.
  /// </summary>
  public Words Words { get; }

  /// <summary>
  /// The sentences.
  /// </summary>
  public Sentences Sentences { get; }

  /// <summary>
  /// The characters.
  /// </summary>
  public Characters Characters { get; }

  /// <summary>
  /// The footnotes.
  /// </summary>
  public Footnotes Footnotes { get; }

  /// <summary>
  /// The endnotes.
  /// </summary>
  public Endnotes Endnotes { get; }

  /// <summary>
  /// The comments.
  /// </summary>
  public Comments Comments { get; }

  /// <summary>
  /// The cells.
  /// </summary>
  public Cells Cells { get; }

  /// <summary>
  /// The sections.
  /// </summary>
  public Sections Sections { get; }

  /// <summary>
  /// The paragraphs.
  /// </summary>
  public Paragraphs Paragraphs { get; }

  /// <summary>
  /// The borders.
  /// </summary>
  public Borders Borders { get; set; }

  /// <summary>
  /// The shading.
  /// </summary>
  public Shading Shading { get; }

  /// <summary>
  /// The text retrieval mode.
  /// </summary>
  public TextRetrievalMode TextRetrievalMode { get; set; }

  /// <summary>
  /// The fields.
  /// </summary>
  public Fields Fields { get; }

  /// <summary>
  /// The form fields.
  /// </summary>
  public FormFields FormFields { get; }

  /// <summary>
  /// The frames.
  /// </summary>
  public Frames Frames { get; }

  /// <summary>
  /// The paragraph format.
  /// </summary>
  public ParagraphFormat ParagraphFormat { get; set; }

  /// <summary>
  /// The list format.
  /// </summary>
  public ListFormat ListFormat { get; }

  /// <summary>
  /// The bookmarks.
  /// </summary>
  public Bookmarks Bookmarks { get; }

  /// <summary>
  /// The bold.
  /// </summary>
  public int Bold { get; set; }

  /// <summary>
  /// The italic.
  /// </summary>
  public int Italic { get; set; }

  /// <summary>
  /// The underline.
  /// </summary>
  public WdUnderline Underline { get; set; }

  /// <summary>
  /// The emphasis mark.
  /// </summary>
  public WdEmphasisMark EmphasisMark { get; set; }

  /// <summary>
  /// The disable character space grid.
  /// </summary>
  public bool DisableCharacterSpaceGrid { get; set; }

  /// <summary>
  /// The revisions.
  /// </summary>
  public Revisions Revisions { get; }

  /// <summary>
  /// The style.
  /// </summary>
  public object Style { get; set; }

  /// <summary>
  /// The story length.
  /// </summary>
  public int StoryLength { get; }

  /// <summary>
  /// The language id.
  /// </summary>
  public WdLanguageID LanguageID { get; set; }

  /// <summary>
  /// The synonym info.
  /// </summary>
  public SynonymInfo SynonymInfo { get; }

  /// <summary>
  /// The hyperlinks.
  /// </summary>
  public Hyperlinks Hyperlinks { get; }

  /// <summary>
  /// The list paragraphs.
  /// </summary>
  public ListParagraphs ListParagraphs { get; }

  /// <summary>
  /// The subdocuments.
  /// </summary>
  public Subdocuments Subdocuments { get; }

  /// <summary>
  /// The grammar checked.
  /// </summary>
  public bool GrammarChecked { get; set; }

  /// <summary>
  /// The spelling checked.
  /// </summary>
  public bool SpellingChecked { get; set; }

  /// <summary>
  /// The highlight color index.
  /// </summary>
  public WdColorIndex HighlightColorIndex { get; set; }

  /// <summary>
  /// The columns.
  /// </summary>
  public Columns Columns { get; }

  /// <summary>
  /// The rows.
  /// </summary>
  public Rows Rows { get; }

  /// <summary>
  /// The can edit.
  /// </summary>
  public int CanEdit { get; }

  /// <summary>
  /// The can paste.
  /// </summary>
  public int CanPaste { get; }

  /// <summary>
  /// The is end of row mark.
  /// </summary>
  public bool IsEndOfRowMark { get; }

  /// <summary>
  /// The bookmark id.
  /// </summary>
  public int BookmarkID { get; }

  /// <summary>
  /// The previous bookmark id.
  /// </summary>
  public int PreviousBookmarkID { get; }

  /// <summary>
  /// The find.
  /// </summary>
  public Find Find { get; }

  /// <summary>
  /// The page setup.
  /// </summary>
  public PageSetup PageSetup { get; set; }

  /// <summary>
  /// The shape range.
  /// </summary>
  public ShapeRange ShapeRange { get; }

  /// <summary>
  /// The case.
  /// </summary>
  public WdCharacterCase Case { get; set; }

  /// <summary>
  /// The readability statistics.
  /// </summary>
  public ReadabilityStatistics ReadabilityStatistics { get; }

  /// <summary>
  /// The grammatical errors.
  /// </summary>
  public ProofreadingErrors GrammaticalErrors { get; }

  /// <summary>
  /// The spelling errors.
  /// </summary>
  public ProofreadingErrors SpellingErrors { get; }

  /// <summary>
  /// The orientation.
  /// </summary>
  public WdTextOrientation Orientation { get; set; }

  /// <summary>
  /// The inline shapes.
  /// </summary>
  public InlineShapes InlineShapes { get; }

  /// <summary>
  /// The next story range.
  /// </summary>
  public Range NextStoryRange { get; }

  /// <summary>
  /// The language idfar east.
  /// </summary>
  public WdLanguageID LanguageIDFarEast { get; set; }

  /// <summary>
  /// The language idother.
  /// </summary>
  public WdLanguageID LanguageIDOther { get; set; }

  /// <summary>
  /// The language detected.
  /// </summary>
  public bool LanguageDetected { get; set; }

  /// <summary>
  /// The fit text width.
  /// </summary>
  public float FitTextWidth { get; set; }

  /// <summary>
  /// The horizontal in vertical.
  /// </summary>
  public WdHorizontalInVerticalType HorizontalInVertical { get; set; }

  /// <summary>
  /// The two lines in one.
  /// </summary>
  public WdTwoLinesInOneType TwoLinesInOne { get; set; }

  /// <summary>
  /// The combine characters.
  /// </summary>
  public bool CombineCharacters { get; set; }

  /// <summary>
  /// The no proofing.
  /// </summary>
  public int NoProofing { get; set; }

  /// <summary>
  /// The top level tables.
  /// </summary>
  public Tables TopLevelTables { get; }

  /// <summary>
  /// The scripts.
  /// </summary>
  public Core.Scripts Scripts { get; }

  /// <summary>
  /// The character width.
  /// </summary>
  public WdCharacterWidth CharacterWidth { get; set; }

  /// <summary>
  /// The kana.
  /// </summary>
  public WdKana Kana { get; set; }

  /// <summary>
  /// The bold bi.
  /// </summary>
  public int BoldBi { get; set; }

  /// <summary>
  /// The italic bi.
  /// </summary>
  public int ItalicBi { get; set; }

  /// <summary>
  /// The id.
  /// </summary>
  public string ID { get; set; }

  /// <summary>
  /// The htmldivisions.
  /// </summary>
  public HTMLDivisions HTMLDivisions { get; }

  /// <summary>
  /// The smart tags.
  /// </summary>
  public SmartTags SmartTags { get; }

  /// <summary>
  /// The show all.
  /// </summary>
  public bool ShowAll { get; set; }

  /// <summary>
  /// The document.
  /// </summary>
  public Document Document { get; }

  /// <summary>
  /// The footnote options.
  /// </summary>
  public FootnoteOptions FootnoteOptions { get; }

  /// <summary>
  /// The endnote options.
  /// </summary>
  public EndnoteOptions EndnoteOptions { get; }

  /// <summary>
  /// The xmlnodes.
  /// </summary>
  public XMLNodes XMLNodes { get; }

  /// <summary>
  /// The xmlparent node.
  /// </summary>
  public XMLNode XMLParentNode { get; }

  /// <summary>
  /// The editors.
  /// </summary>
  public Editors Editors { get; }

  /// <summary>
  /// The enh meta file bits.
  /// </summary>
  public object EnhMetaFileBits { get; }

  /// <summary>
  /// The omaths.
  /// </summary>
  public OMaths OMaths { get; }

  /// <summary>
  /// The character style.
  /// </summary>
  public object CharacterStyle { get; }

  /// <summary>
  /// The paragraph style.
  /// </summary>
  public object ParagraphStyle { get; }

  /// <summary>
  /// The list style.
  /// </summary>
  public object ListStyle { get; }

  /// <summary>
  /// The table style.
  /// </summary>
  public object TableStyle { get; }

  /// <summary>
  /// The content controls.
  /// </summary>
  public ContentControls ContentControls { get; }

  /// <summary>
  /// The word open xml.
  /// </summary>
  public string WordOpenXML { get; }

  /// <summary>
  /// The parent content control.
  /// </summary>
  public ContentControl ParentContentControl { get; }

  /// <summary>
  /// The locks.
  /// </summary>
  public CoAuthLocks Locks { get; }

  /// <summary>
  /// The updates.
  /// </summary>
  public CoAuthUpdates Updates { get; }

  /// <summary>
  /// The conflicts.
  /// </summary>
  public Conflicts Conflicts { get; }

  /// <summary>
  /// The text visible on screen.
  /// </summary>
  public int TextVisibleOnScreen { get; }
}

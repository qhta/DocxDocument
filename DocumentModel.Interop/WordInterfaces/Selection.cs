namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the current selection in a window or pane.
/// </summary>
public partial interface Selection : InteropObject
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
  /// The type.
  /// </summary>
  public WdSelectionType Type { get; }

  /// <summary>
  /// The story type.
  /// </summary>
  public WdStoryType StoryType { get; }

  /// <summary>
  /// The style.
  /// </summary>
  public object Style { get; set; }

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
  /// The page setup.
  /// </summary>
  public PageSetup PageSetup { get; set; }

  /// <summary>
  /// The bookmarks.
  /// </summary>
  public Bookmarks Bookmarks { get; }

  /// <summary>
  /// The story length.
  /// </summary>
  public int StoryLength { get; }

  /// <summary>
  /// The language id.
  /// </summary>
  public WdLanguageID LanguageID { get; set; }

  /// <summary>
  /// The language idfar east.
  /// </summary>
  public WdLanguageID LanguageIDFarEast { get; set; }

  /// <summary>
  /// The language idother.
  /// </summary>
  public WdLanguageID LanguageIDOther { get; set; }

  /// <summary>
  /// The hyperlinks.
  /// </summary>
  public Hyperlinks Hyperlinks { get; }

  /// <summary>
  /// The columns.
  /// </summary>
  public Columns Columns { get; }

  /// <summary>
  /// The rows.
  /// </summary>
  public Rows Rows { get; }

  /// <summary>
  /// The header footer.
  /// </summary>
  public HeaderFooter HeaderFooter { get; }

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
  /// The range.
  /// </summary>
  public Range Range { get; }

  /// <summary>
  /// The flags.
  /// </summary>
  public WdSelectionFlags Flags { get; set; }

  /// <summary>
  /// The active.
  /// </summary>
  public bool Active { get; }

  /// <summary>
  /// The start is active.
  /// </summary>
  public bool StartIsActive { get; set; }

  /// <summary>
  /// The ipat end of line.
  /// </summary>
  public bool IPAtEndOfLine { get; }

  /// <summary>
  /// The extend mode.
  /// </summary>
  public bool ExtendMode { get; set; }

  /// <summary>
  /// The column select mode.
  /// </summary>
  public bool ColumnSelectMode { get; set; }

  /// <summary>
  /// The orientation.
  /// </summary>
  public WdTextOrientation Orientation { get; set; }

  /// <summary>
  /// The inline shapes.
  /// </summary>
  public InlineShapes InlineShapes { get; }

  /// <summary>
  /// The document.
  /// </summary>
  public Document Document { get; }

  /// <summary>
  /// The shape range.
  /// </summary>
  public ShapeRange ShapeRange { get; }

  /// <summary>
  /// The no proofing.
  /// </summary>
  public int NoProofing { get; set; }

  /// <summary>
  /// The top level tables.
  /// </summary>
  public Tables TopLevelTables { get; }

  /// <summary>
  /// The language detected.
  /// </summary>
  public bool LanguageDetected { get; set; }

  /// <summary>
  /// The fit text width.
  /// </summary>
  public float FitTextWidth { get; set; }

  /// <summary>
  /// The htmldivisions.
  /// </summary>
  public HTMLDivisions HTMLDivisions { get; }

  /// <summary>
  /// The smart tags.
  /// </summary>
  public SmartTags SmartTags { get; }

  /// <summary>
  /// The child shape range.
  /// </summary>
  public ShapeRange ChildShapeRange { get; }

  /// <summary>
  /// The has child shape range.
  /// </summary>
  public bool HasChildShapeRange { get; }

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
  /// The word open xml.
  /// </summary>
  public string WordOpenXML { get; }

  /// <summary>
  /// The content controls.
  /// </summary>
  public ContentControls ContentControls { get; }

  /// <summary>
  /// The parent content control.
  /// </summary>
  public ContentControl ParentContentControl { get; }
}

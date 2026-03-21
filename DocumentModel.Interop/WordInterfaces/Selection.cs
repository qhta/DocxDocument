namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the current selection in a window or pane.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection?view=word-pia"/>
public partial interface Selection : InteropObject
{
  /// <summary>
  /// The text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.text?view=word-pia"/>
  public string Text { get; set; }

  /// <summary>
  /// The formatted text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.formattedtext?view=word-pia"/>
  public Range FormattedText { get; set; }

  /// <summary>
  /// The start.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.start?view=word-pia"/>
  public int Start { get; set; }

  /// <summary>
  /// The end.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.end?view=word-pia"/>
  public int End { get; set; }

  /// <summary>
  /// The font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.font?view=word-pia"/>
  public Font Font { get; set; }

  /// <summary>
  /// The type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.type?view=word-pia"/>
  public WdSelectionType Type { get; }

  /// <summary>
  /// The story type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.storytype?view=word-pia"/>
  public WdStoryType StoryType { get; }

  /// <summary>
  /// The style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.style?view=word-pia"/>
  public object Style { get; set; }

  /// <summary>
  /// The tables.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.tables?view=word-pia"/>
  public Tables Tables { get; }

  /// <summary>
  /// The words.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.words?view=word-pia"/>
  public Words Words { get; }

  /// <summary>
  /// The sentences.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.sentences?view=word-pia"/>
  public Sentences Sentences { get; }

  /// <summary>
  /// The characters.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.characters?view=word-pia"/>
  public Characters Characters { get; }

  /// <summary>
  /// The footnotes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.footnotes?view=word-pia"/>
  public Footnotes Footnotes { get; }

  /// <summary>
  /// The endnotes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.endnotes?view=word-pia"/>
  public Endnotes Endnotes { get; }

  /// <summary>
  /// The comments.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.comments?view=word-pia"/>
  public Comments Comments { get; }

  /// <summary>
  /// The cells.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.cells?view=word-pia"/>
  public Cells Cells { get; }

  /// <summary>
  /// The sections.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.sections?view=word-pia"/>
  public Sections Sections { get; }

  /// <summary>
  /// The paragraphs.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.paragraphs?view=word-pia"/>
  public Paragraphs Paragraphs { get; }

  /// <summary>
  /// The borders.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.borders?view=word-pia"/>
  public Borders Borders { get; set; }

  /// <summary>
  /// The shading.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.shading?view=word-pia"/>
  public Shading Shading { get; }

  /// <summary>
  /// The fields.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.fields?view=word-pia"/>
  public Fields Fields { get; }

  /// <summary>
  /// The form fields.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.formfields?view=word-pia"/>
  public FormFields FormFields { get; }

  /// <summary>
  /// The frames.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.frames?view=word-pia"/>
  public Frames Frames { get; }

  /// <summary>
  /// The paragraph format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.paragraphformat?view=word-pia"/>
  public ParagraphFormat ParagraphFormat { get; set; }

  /// <summary>
  /// The page setup.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.pagesetup?view=word-pia"/>
  public PageSetup PageSetup { get; set; }

  /// <summary>
  /// The bookmarks.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.bookmarks?view=word-pia"/>
  public Bookmarks Bookmarks { get; }

  /// <summary>
  /// The story length.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.storylength?view=word-pia"/>
  public int StoryLength { get; }

  /// <summary>
  /// The language id.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.languageid?view=word-pia"/>
  public WdLanguageID LanguageID { get; set; }

  /// <summary>
  /// The language idfar east.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.languageidfareast?view=word-pia"/>
  public WdLanguageID LanguageIDFarEast { get; set; }

  /// <summary>
  /// The language idother.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.languageidother?view=word-pia"/>
  public WdLanguageID LanguageIDOther { get; set; }

  /// <summary>
  /// The hyperlinks.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.hyperlinks?view=word-pia"/>
  public Hyperlinks Hyperlinks { get; }

  /// <summary>
  /// The columns.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.columns?view=word-pia"/>
  public Columns Columns { get; }

  /// <summary>
  /// The rows.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.rows?view=word-pia"/>
  public Rows Rows { get; }

  /// <summary>
  /// The header footer.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.headerfooter?view=word-pia"/>
  public HeaderFooter HeaderFooter { get; }

  /// <summary>
  /// The is end of row mark.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.isendofrowmark?view=word-pia"/>
  public bool IsEndOfRowMark { get; }

  /// <summary>
  /// The bookmark id.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.bookmarkid?view=word-pia"/>
  public int BookmarkID { get; }

  /// <summary>
  /// The previous bookmark id.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.previousbookmarkid?view=word-pia"/>
  public int PreviousBookmarkID { get; }

  /// <summary>
  /// The find.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.find?view=word-pia"/>
  public Find Find { get; }

  /// <summary>
  /// The range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.range?view=word-pia"/>
  public Range Range { get; }

  /// <summary>
  /// The flags.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.flags?view=word-pia"/>
  public WdSelectionFlags Flags { get; set; }

  /// <summary>
  /// The active.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.active?view=word-pia"/>
  public bool Active { get; }

  /// <summary>
  /// The start is active.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.startisactive?view=word-pia"/>
  public bool StartIsActive { get; set; }

  /// <summary>
  /// The ipat end of line.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.ipatendofline?view=word-pia"/>
  public bool IPAtEndOfLine { get; }

  /// <summary>
  /// The extend mode.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.extendmode?view=word-pia"/>
  public bool ExtendMode { get; set; }

  /// <summary>
  /// The column select mode.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.columnselectmode?view=word-pia"/>
  public bool ColumnSelectMode { get; set; }

  /// <summary>
  /// The orientation.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.orientation?view=word-pia"/>
  public WdTextOrientation Orientation { get; set; }

  /// <summary>
  /// The inline shapes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.inlineshapes?view=word-pia"/>
  public InlineShapes InlineShapes { get; }

  /// <summary>
  /// The document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.document?view=word-pia"/>
  public Document Document { get; }

  /// <summary>
  /// The shape range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.shaperange?view=word-pia"/>
  public ShapeRange ShapeRange { get; }

  /// <summary>
  /// The no proofing.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.noproofing?view=word-pia"/>
  public int NoProofing { get; set; }

  /// <summary>
  /// The top level tables.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.topleveltables?view=word-pia"/>
  public Tables TopLevelTables { get; }

  /// <summary>
  /// The language detected.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.languagedetected?view=word-pia"/>
  public bool LanguageDetected { get; set; }

  /// <summary>
  /// The fit text width.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.fittextwidth?view=word-pia"/>
  public float FitTextWidth { get; set; }

  /// <summary>
  /// The htmldivisions.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.htmldivisions?view=word-pia"/>
  public HTMLDivisions HTMLDivisions { get; }

  /// <summary>
  /// The smart tags.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.smarttags?view=word-pia"/>
  public SmartTags SmartTags { get; }

  /// <summary>
  /// The child shape range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.childshaperange?view=word-pia"/>
  public ShapeRange ChildShapeRange { get; }

  /// <summary>
  /// The has child shape range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.haschildshaperange?view=word-pia"/>
  public bool HasChildShapeRange { get; }

  /// <summary>
  /// The footnote options.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.footnoteoptions?view=word-pia"/>
  public FootnoteOptions FootnoteOptions { get; }

  /// <summary>
  /// The endnote options.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.endnoteoptions?view=word-pia"/>
  public EndnoteOptions EndnoteOptions { get; }

  /// <summary>
  /// The xmlnodes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.xmlnodes?view=word-pia"/>
  public XMLNodes XMLNodes { get; }

  /// <summary>
  /// The xmlparent node.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.xmlparentnode?view=word-pia"/>
  public XMLNode XMLParentNode { get; }

  /// <summary>
  /// The editors.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.editors?view=word-pia"/>
  public Editors Editors { get; }

  /// <summary>
  /// The enh meta file bits.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.enhmetafilebits?view=word-pia"/>
  public object EnhMetaFileBits { get; }

  /// <summary>
  /// The omaths.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.omaths?view=word-pia"/>
  public OMaths OMaths { get; }

  /// <summary>
  /// The word open xml.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.wordopenxml?view=word-pia"/>
  public string WordOpenXML { get; }

  /// <summary>
  /// The content controls.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.contentcontrols?view=word-pia"/>
  public ContentControls ContentControls { get; }

  /// <summary>
  /// The parent content control.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.parentcontentcontrol?view=word-pia"/>
  public ContentControl ParentContentControl { get; }
}

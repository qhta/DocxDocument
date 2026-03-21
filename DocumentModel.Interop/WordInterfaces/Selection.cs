namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the current selection in a window or pane.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection?view=word-pia"/>
public partial interface Selection : InteropObject
{
  /// <summary>
  /// Returns or sets the text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.text?view=word-pia"/>
  public string Text { get; set; }

  /// <summary>
  /// Returns or sets the formatted text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.formattedtext?view=word-pia"/>
  public Range FormattedText { get; set; }

  /// <summary>
  /// Returns or sets the start.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.start?view=word-pia"/>
  public int Start { get; set; }

  /// <summary>
  /// Returns or sets the end.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.end?view=word-pia"/>
  public int End { get; set; }

  /// <summary>
  /// Returns or sets the font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.font?view=word-pia"/>
  public Font Font { get; set; }

  /// <summary>
  /// Returns the type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.type?view=word-pia"/>
  public WdSelectionType Type { get; }

  /// <summary>
  /// Returns the story type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.storytype?view=word-pia"/>
  public WdStoryType StoryType { get; }

  /// <summary>
  /// Returns or sets the style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.style?view=word-pia"/>
  public object Style { get; set; }

  /// <summary>
  /// Returns the tables.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.tables?view=word-pia"/>
  public Tables Tables { get; }

  /// <summary>
  /// Returns the words.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.words?view=word-pia"/>
  public Words Words { get; }

  /// <summary>
  /// Returns the sentences.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.sentences?view=word-pia"/>
  public Sentences Sentences { get; }

  /// <summary>
  /// Returns the characters.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.characters?view=word-pia"/>
  public Characters Characters { get; }

  /// <summary>
  /// Returns the footnotes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.footnotes?view=word-pia"/>
  public Footnotes Footnotes { get; }

  /// <summary>
  /// Returns the endnotes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.endnotes?view=word-pia"/>
  public Endnotes Endnotes { get; }

  /// <summary>
  /// Returns the comments.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.comments?view=word-pia"/>
  public Comments Comments { get; }

  /// <summary>
  /// Returns the cells.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.cells?view=word-pia"/>
  public Cells Cells { get; }

  /// <summary>
  /// Returns the sections.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.sections?view=word-pia"/>
  public Sections Sections { get; }

  /// <summary>
  /// Returns the paragraphs.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.paragraphs?view=word-pia"/>
  public Paragraphs Paragraphs { get; }

  /// <summary>
  /// Returns or sets the borders.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.borders?view=word-pia"/>
  public Borders Borders { get; set; }

  /// <summary>
  /// Returns the shading.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.shading?view=word-pia"/>
  public Shading Shading { get; }

  /// <summary>
  /// Returns the fields.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.fields?view=word-pia"/>
  public Fields Fields { get; }

  /// <summary>
  /// Returns the form fields.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.formfields?view=word-pia"/>
  public FormFields FormFields { get; }

  /// <summary>
  /// Returns the frames.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.frames?view=word-pia"/>
  public Frames Frames { get; }

  /// <summary>
  /// Returns or sets the paragraph format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.paragraphformat?view=word-pia"/>
  public ParagraphFormat ParagraphFormat { get; set; }

  /// <summary>
  /// Returns or sets the page setup.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.pagesetup?view=word-pia"/>
  public PageSetup PageSetup { get; set; }

  /// <summary>
  /// Returns the bookmarks.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.bookmarks?view=word-pia"/>
  public Bookmarks Bookmarks { get; }

  /// <summary>
  /// Returns the story length.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.storylength?view=word-pia"/>
  public int StoryLength { get; }

  /// <summary>
  /// Returns or sets the language i d.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.languageid?view=word-pia"/>
  public WdLanguageID LanguageID { get; set; }

  /// <summary>
  /// Returns or sets the language i d far east.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.languageidfareast?view=word-pia"/>
  public WdLanguageID LanguageIDFarEast { get; set; }

  /// <summary>
  /// Returns or sets the language i d other.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.languageidother?view=word-pia"/>
  public WdLanguageID LanguageIDOther { get; set; }

  /// <summary>
  /// Returns the hyperlinks.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.hyperlinks?view=word-pia"/>
  public Hyperlinks Hyperlinks { get; }

  /// <summary>
  /// Returns the columns.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.columns?view=word-pia"/>
  public Columns Columns { get; }

  /// <summary>
  /// Returns the rows.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.rows?view=word-pia"/>
  public Rows Rows { get; }

  /// <summary>
  /// Returns the header footer.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.headerfooter?view=word-pia"/>
  public HeaderFooter HeaderFooter { get; }

  /// <summary>
  /// Returns whether end of row mark.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.isendofrowmark?view=word-pia"/>
  public bool IsEndOfRowMark { get; }

  /// <summary>
  /// Returns the bookmark i d.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.bookmarkid?view=word-pia"/>
  public int BookmarkID { get; }

  /// <summary>
  /// Returns the previous bookmark i d.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.previousbookmarkid?view=word-pia"/>
  public int PreviousBookmarkID { get; }

  /// <summary>
  /// Returns the find.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.find?view=word-pia"/>
  public Find Find { get; }

  /// <summary>
  /// Returns the range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.range?view=word-pia"/>
  public Range Range { get; }

  /// <summary>
  /// Returns or sets the flags.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.flags?view=word-pia"/>
  public WdSelectionFlags Flags { get; set; }

  /// <summary>
  /// Returns whether active.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.active?view=word-pia"/>
  public bool Active { get; }

  /// <summary>
  /// Returns or sets whether start is active.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.startisactive?view=word-pia"/>
  public bool StartIsActive { get; set; }

  /// <summary>
  /// Returns whether i p at end of line.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.ipatendofline?view=word-pia"/>
  public bool IPAtEndOfLine { get; }

  /// <summary>
  /// Returns or sets whether extend mode.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.extendmode?view=word-pia"/>
  public bool ExtendMode { get; set; }

  /// <summary>
  /// Returns or sets whether column select mode.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.columnselectmode?view=word-pia"/>
  public bool ColumnSelectMode { get; set; }

  /// <summary>
  /// Returns or sets the orientation.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.orientation?view=word-pia"/>
  public WdTextOrientation Orientation { get; set; }

  /// <summary>
  /// Returns the inline shapes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.inlineshapes?view=word-pia"/>
  public InlineShapes InlineShapes { get; }

  /// <summary>
  /// Returns the document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.document?view=word-pia"/>
  public Document Document { get; }

  /// <summary>
  /// Returns the shape range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.shaperange?view=word-pia"/>
  public ShapeRange ShapeRange { get; }

  /// <summary>
  /// Returns or sets the no proofing.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.noproofing?view=word-pia"/>
  public int NoProofing { get; set; }

  /// <summary>
  /// Returns the top level tables.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.topleveltables?view=word-pia"/>
  public Tables TopLevelTables { get; }

  /// <summary>
  /// Returns or sets whether language detected.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.languagedetected?view=word-pia"/>
  public bool LanguageDetected { get; set; }

  /// <summary>
  /// Returns or sets the fit text width.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.fittextwidth?view=word-pia"/>
  public float FitTextWidth { get; set; }

  /// <summary>
  /// Returns the h t m l divisions.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.htmldivisions?view=word-pia"/>
  public HTMLDivisions HTMLDivisions { get; }

  /// <summary>
  /// Returns the smart tags.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.smarttags?view=word-pia"/>
  public SmartTags SmartTags { get; }

  /// <summary>
  /// Returns the child shape range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.childshaperange?view=word-pia"/>
  public ShapeRange ChildShapeRange { get; }

  /// <summary>
  /// Returns whether child shape range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.haschildshaperange?view=word-pia"/>
  public bool HasChildShapeRange { get; }

  /// <summary>
  /// Returns the footnote options.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.footnoteoptions?view=word-pia"/>
  public FootnoteOptions FootnoteOptions { get; }

  /// <summary>
  /// Returns the endnote options.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.endnoteoptions?view=word-pia"/>
  public EndnoteOptions EndnoteOptions { get; }

  /// <summary>
  /// Returns the x m l nodes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.xmlnodes?view=word-pia"/>
  public XMLNodes XMLNodes { get; }

  /// <summary>
  /// Returns the x m l parent node.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.xmlparentnode?view=word-pia"/>
  public XMLNode XMLParentNode { get; }

  /// <summary>
  /// Returns the editors.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.editors?view=word-pia"/>
  public Editors Editors { get; }

  /// <summary>
  /// Returns the enh meta file bits.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.enhmetafilebits?view=word-pia"/>
  public object EnhMetaFileBits { get; }

  /// <summary>
  /// Returns the o maths.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.omaths?view=word-pia"/>
  public OMaths OMaths { get; }

  /// <summary>
  /// Returns the word open x m l.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.wordopenxml?view=word-pia"/>
  public string WordOpenXML { get; }

  /// <summary>
  /// Returns the content controls.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.contentcontrols?view=word-pia"/>
  public ContentControls ContentControls { get; }

  /// <summary>
  /// Returns the parent content control.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.parentcontentcontrol?view=word-pia"/>
  public ContentControl ParentContentControl { get; }
}

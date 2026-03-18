namespace DocumentModel.Interop;

/// <summary>
/// Contains the view attributes (show all, field shading, table gridlines, and so on) for a window or pane.
/// </summary>
public partial interface View : InteropObject
{
  /// <summary>
  /// The type.
  /// </summary>
  public WdViewType Type { get; set; }

  /// <summary>
  /// The full screen.
  /// </summary>
  public bool FullScreen { get; set; }

  /// <summary>
  /// The draft.
  /// </summary>
  public bool Draft { get; set; }

  /// <summary>
  /// The show all.
  /// </summary>
  public bool ShowAll { get; set; }

  /// <summary>
  /// The show field codes.
  /// </summary>
  public bool ShowFieldCodes { get; set; }

  /// <summary>
  /// The mail merge data view.
  /// </summary>
  public bool MailMergeDataView { get; set; }

  /// <summary>
  /// The magnifier.
  /// </summary>
  public bool Magnifier { get; set; }

  /// <summary>
  /// The show first line only.
  /// </summary>
  public bool ShowFirstLineOnly { get; set; }

  /// <summary>
  /// The show format.
  /// </summary>
  public bool ShowFormat { get; set; }

  /// <summary>
  /// The zoom.
  /// </summary>
  public Zoom Zoom { get; }

  /// <summary>
  /// The show object anchors.
  /// </summary>
  public bool ShowObjectAnchors { get; set; }

  /// <summary>
  /// The show text boundaries.
  /// </summary>
  public bool ShowTextBoundaries { get; set; }

  /// <summary>
  /// The show highlight.
  /// </summary>
  public bool ShowHighlight { get; set; }

  /// <summary>
  /// The show drawings.
  /// </summary>
  public bool ShowDrawings { get; set; }

  /// <summary>
  /// The show tabs.
  /// </summary>
  public bool ShowTabs { get; set; }

  /// <summary>
  /// The show spaces.
  /// </summary>
  public bool ShowSpaces { get; set; }

  /// <summary>
  /// The show paragraphs.
  /// </summary>
  public bool ShowParagraphs { get; set; }

  /// <summary>
  /// The show hyphens.
  /// </summary>
  public bool ShowHyphens { get; set; }

  /// <summary>
  /// The show hidden text.
  /// </summary>
  public bool ShowHiddenText { get; set; }

  /// <summary>
  /// The wrap to window.
  /// </summary>
  public bool WrapToWindow { get; set; }

  /// <summary>
  /// The show picture place holders.
  /// </summary>
  public bool ShowPicturePlaceHolders { get; set; }

  /// <summary>
  /// The show bookmarks.
  /// </summary>
  public bool ShowBookmarks { get; set; }

  /// <summary>
  /// The field shading.
  /// </summary>
  public WdFieldShading FieldShading { get; set; }

  /// <summary>
  /// The show animation.
  /// </summary>
  public bool ShowAnimation { get; set; }

  /// <summary>
  /// The table gridlines.
  /// </summary>
  public bool TableGridlines { get; set; }

  /// <summary>
  /// The enlarge fonts less than.
  /// </summary>
  public int EnlargeFontsLessThan { get; set; }

  /// <summary>
  /// The show main text layer.
  /// </summary>
  public bool ShowMainTextLayer { get; set; }

  /// <summary>
  /// The seek view.
  /// </summary>
  public WdSeekView SeekView { get; set; }

  /// <summary>
  /// The split special.
  /// </summary>
  public WdSpecialPane SplitSpecial { get; set; }

  /// <summary>
  /// The browse to window.
  /// </summary>
  public int BrowseToWindow { get; set; }

  /// <summary>
  /// The show optional breaks.
  /// </summary>
  public bool ShowOptionalBreaks { get; set; }

  /// <summary>
  /// The display page boundaries.
  /// </summary>
  public bool DisplayPageBoundaries { get; set; }

  /// <summary>
  /// The display smart tags.
  /// </summary>
  public bool DisplaySmartTags { get; set; }

  /// <summary>
  /// The show revisions and comments.
  /// </summary>
  public bool ShowRevisionsAndComments { get; set; }

  /// <summary>
  /// The show comments.
  /// </summary>
  public bool ShowComments { get; set; }

  /// <summary>
  /// The show insertions and deletions.
  /// </summary>
  public bool ShowInsertionsAndDeletions { get; set; }

  /// <summary>
  /// The show format changes.
  /// </summary>
  public bool ShowFormatChanges { get; set; }

  /// <summary>
  /// The revisions view.
  /// </summary>
  public WdRevisionsView RevisionsView { get; set; }

  /// <summary>
  /// The revisions mode.
  /// </summary>
  public WdRevisionsMode RevisionsMode { get; set; }

  /// <summary>
  /// The revisions balloon width.
  /// </summary>
  public float RevisionsBalloonWidth { get; set; }

  /// <summary>
  /// The revisions balloon width type.
  /// </summary>
  public WdRevisionsBalloonWidthType RevisionsBalloonWidthType { get; set; }

  /// <summary>
  /// The revisions balloon side.
  /// </summary>
  public WdRevisionsBalloonMargin RevisionsBalloonSide { get; set; }

  /// <summary>
  /// The reviewers.
  /// </summary>
  public Reviewers Reviewers { get; }

  /// <summary>
  /// The revisions balloon show connecting lines.
  /// </summary>
  public bool RevisionsBalloonShowConnectingLines { get; set; }

  /// <summary>
  /// The reading layout.
  /// </summary>
  public bool ReadingLayout { get; set; }

  /// <summary>
  /// The show xmlmarkup.
  /// </summary>
  public int ShowXMLMarkup { get; set; }

  /// <summary>
  /// The shade editable ranges.
  /// </summary>
  public int ShadeEditableRanges { get; set; }

  /// <summary>
  /// The show ink annotations.
  /// </summary>
  public bool ShowInkAnnotations { get; set; }

  /// <summary>
  /// The display backgrounds.
  /// </summary>
  public bool DisplayBackgrounds { get; set; }

  /// <summary>
  /// The reading layout actual view.
  /// </summary>
  public bool ReadingLayoutActualView { get; set; }

  /// <summary>
  /// The reading layout allow multiple pages.
  /// </summary>
  public bool ReadingLayoutAllowMultiplePages { get; set; }

  /// <summary>
  /// The reading layout allow editing.
  /// </summary>
  public bool ReadingLayoutAllowEditing { get; set; }

  /// <summary>
  /// The reading layout truncate margins.
  /// </summary>
  public WdReadingLayoutMargin ReadingLayoutTruncateMargins { get; set; }

  /// <summary>
  /// The show markup area highlight.
  /// </summary>
  public bool ShowMarkupAreaHighlight { get; set; }

  /// <summary>
  /// The panning.
  /// </summary>
  public bool Panning { get; set; }

  /// <summary>
  /// The show crop marks.
  /// </summary>
  public bool ShowCropMarks { get; set; }

  /// <summary>
  /// The markup mode.
  /// </summary>
  public WdRevisionsMode MarkupMode { get; set; }

  /// <summary>
  /// The conflict mode.
  /// </summary>
  public bool ConflictMode { get; set; }

  /// <summary>
  /// The show other authors.
  /// </summary>
  public bool ShowOtherAuthors { get; set; }

  /// <summary>
  /// The revisions filter.
  /// </summary>
  public RevisionsFilter RevisionsFilter { get; }

  /// <summary>
  /// The page color.
  /// </summary>
  public WdPageColor PageColor { get; set; }

  /// <summary>
  /// The column width.
  /// </summary>
  public WdColumnWidth ColumnWidth { get; set; }
}

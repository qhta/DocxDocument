namespace DocumentModel.Interop.Word;

/// <summary>
/// Contains the view attributes (show all, field shading, table gridlines, and so on) for a window or pane.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view?view=word-pia"/>
public partial interface View : InteropObject
{
  /// <summary>
  /// Returns or sets the type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.type?view=word-pia"/>
  public WdViewType Type { get; set; }

  /// <summary>
  /// Returns or sets whether full screen.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.fullscreen?view=word-pia"/>
  public bool FullScreen { get; set; }

  /// <summary>
  /// Returns or sets whether draft.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.draft?view=word-pia"/>
  public bool Draft { get; set; }

  /// <summary>
  /// Returns or sets whether show all.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showall?view=word-pia"/>
  public bool ShowAll { get; set; }

  /// <summary>
  /// Returns or sets whether show field codes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showfieldcodes?view=word-pia"/>
  public bool ShowFieldCodes { get; set; }

  /// <summary>
  /// Returns or sets whether mail merge data view.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.mailmergedataview?view=word-pia"/>
  public bool MailMergeDataView { get; set; }

  /// <summary>
  /// Returns or sets whether magnifier.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.magnifier?view=word-pia"/>
  public bool Magnifier { get; set; }

  /// <summary>
  /// Returns or sets whether show first line only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showfirstlineonly?view=word-pia"/>
  public bool ShowFirstLineOnly { get; set; }

  /// <summary>
  /// Returns or sets whether show format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showformat?view=word-pia"/>
  public bool ShowFormat { get; set; }

  /// <summary>
  /// Returns the zoom.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.zoom?view=word-pia"/>
  public Zoom Zoom { get; }

  /// <summary>
  /// Returns or sets whether show object anchors.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showobjectanchors?view=word-pia"/>
  public bool ShowObjectAnchors { get; set; }

  /// <summary>
  /// Returns or sets whether show text boundaries.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showtextboundaries?view=word-pia"/>
  public bool ShowTextBoundaries { get; set; }

  /// <summary>
  /// Returns or sets whether show highlight.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showhighlight?view=word-pia"/>
  public bool ShowHighlight { get; set; }

  /// <summary>
  /// Returns or sets whether show drawings.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showdrawings?view=word-pia"/>
  public bool ShowDrawings { get; set; }

  /// <summary>
  /// Returns or sets whether show tabs.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showtabs?view=word-pia"/>
  public bool ShowTabs { get; set; }

  /// <summary>
  /// Returns or sets whether show spaces.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showspaces?view=word-pia"/>
  public bool ShowSpaces { get; set; }

  /// <summary>
  /// Returns or sets whether show paragraphs.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showparagraphs?view=word-pia"/>
  public bool ShowParagraphs { get; set; }

  /// <summary>
  /// Returns or sets whether show hyphens.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showhyphens?view=word-pia"/>
  public bool ShowHyphens { get; set; }

  /// <summary>
  /// Returns or sets whether show hidden text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showhiddentext?view=word-pia"/>
  public bool ShowHiddenText { get; set; }

  /// <summary>
  /// Returns or sets whether wrap to window.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.wraptowindow?view=word-pia"/>
  public bool WrapToWindow { get; set; }

  /// <summary>
  /// Returns or sets whether show picture place holders.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showpictureplaceholders?view=word-pia"/>
  public bool ShowPicturePlaceHolders { get; set; }

  /// <summary>
  /// Returns or sets whether show bookmarks.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showbookmarks?view=word-pia"/>
  public bool ShowBookmarks { get; set; }

  /// <summary>
  /// Returns or sets the field shading.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.fieldshading?view=word-pia"/>
  public WdFieldShading FieldShading { get; set; }

  /// <summary>
  /// Returns or sets whether show animation.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showanimation?view=word-pia"/>
  public bool ShowAnimation { get; set; }

  /// <summary>
  /// Returns or sets whether table gridlines.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.tablegridlines?view=word-pia"/>
  public bool TableGridlines { get; set; }

  /// <summary>
  /// Returns or sets the enlarge fonts less than.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.enlargefontslessthan?view=word-pia"/>
  public int EnlargeFontsLessThan { get; set; }

  /// <summary>
  /// Returns or sets whether show main text layer.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showmaintextlayer?view=word-pia"/>
  public bool ShowMainTextLayer { get; set; }

  /// <summary>
  /// Returns or sets the seek view.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.seekview?view=word-pia"/>
  public WdSeekView SeekView { get; set; }

  /// <summary>
  /// Returns or sets the split special.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.splitspecial?view=word-pia"/>
  public WdSpecialPane SplitSpecial { get; set; }

  /// <summary>
  /// Returns or sets the browse to window.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.browsetowindow?view=word-pia"/>
  public int BrowseToWindow { get; set; }

  /// <summary>
  /// Returns or sets whether show optional breaks.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showoptionalbreaks?view=word-pia"/>
  public bool ShowOptionalBreaks { get; set; }

  /// <summary>
  /// Returns or sets whether display page boundaries.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.displaypageboundaries?view=word-pia"/>
  public bool DisplayPageBoundaries { get; set; }

  /// <summary>
  /// Returns or sets whether display smart tags.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.displaysmarttags?view=word-pia"/>
  public bool DisplaySmartTags { get; set; }

  /// <summary>
  /// Returns or sets whether show revisions and comments.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showrevisionsandcomments?view=word-pia"/>
  public bool ShowRevisionsAndComments { get; set; }

  /// <summary>
  /// Returns or sets whether show comments.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showcomments?view=word-pia"/>
  public bool ShowComments { get; set; }

  /// <summary>
  /// Returns or sets whether show insertions and deletions.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showinsertionsanddeletions?view=word-pia"/>
  public bool ShowInsertionsAndDeletions { get; set; }

  /// <summary>
  /// Returns or sets whether show format changes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showformatchanges?view=word-pia"/>
  public bool ShowFormatChanges { get; set; }

  /// <summary>
  /// Returns or sets the revisions view.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.revisionsview?view=word-pia"/>
  public WdRevisionsView RevisionsView { get; set; }

  /// <summary>
  /// Returns or sets the revisions mode.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.revisionsmode?view=word-pia"/>
  public WdRevisionsMode RevisionsMode { get; set; }

  /// <summary>
  /// Returns or sets the revisions balloon width.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.revisionsballoonwidth?view=word-pia"/>
  public float RevisionsBalloonWidth { get; set; }

  /// <summary>
  /// Returns or sets the revisions balloon width type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.revisionsballoonwidthtype?view=word-pia"/>
  public WdRevisionsBalloonWidthType RevisionsBalloonWidthType { get; set; }

  /// <summary>
  /// Returns or sets the revisions balloon side.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.revisionsballoonside?view=word-pia"/>
  public WdRevisionsBalloonMargin RevisionsBalloonSide { get; set; }

  /// <summary>
  /// Returns the reviewers.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.reviewers?view=word-pia"/>
  public Reviewers Reviewers { get; }

  /// <summary>
  /// Returns or sets whether revisions balloon show connecting lines.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.revisionsballoonshowconnectinglines?view=word-pia"/>
  public bool RevisionsBalloonShowConnectingLines { get; set; }

  /// <summary>
  /// Returns or sets whether reading layout.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.readinglayout?view=word-pia"/>
  public bool ReadingLayout { get; set; }

  /// <summary>
  /// Returns or sets the show x m l markup.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showxmlmarkup?view=word-pia"/>
  public int ShowXMLMarkup { get; set; }

  /// <summary>
  /// Returns or sets the shade editable ranges.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.shadeeditableranges?view=word-pia"/>
  public int ShadeEditableRanges { get; set; }

  /// <summary>
  /// Returns or sets whether show ink annotations.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showinkannotations?view=word-pia"/>
  public bool ShowInkAnnotations { get; set; }

  /// <summary>
  /// Returns or sets whether display backgrounds.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.displaybackgrounds?view=word-pia"/>
  public bool DisplayBackgrounds { get; set; }

  /// <summary>
  /// Returns or sets whether reading layout actual view.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.readinglayoutactualview?view=word-pia"/>
  public bool ReadingLayoutActualView { get; set; }

  /// <summary>
  /// Returns or sets whether reading layout allow multiple pages.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.readinglayoutallowmultiplepages?view=word-pia"/>
  public bool ReadingLayoutAllowMultiplePages { get; set; }

  /// <summary>
  /// Returns or sets whether reading layout allow editing.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.readinglayoutallowediting?view=word-pia"/>
  public bool ReadingLayoutAllowEditing { get; set; }

  /// <summary>
  /// Returns or sets the reading layout truncate margins.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.readinglayouttruncatemargins?view=word-pia"/>
  public WdReadingLayoutMargin ReadingLayoutTruncateMargins { get; set; }

  /// <summary>
  /// Returns or sets whether show markup area highlight.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showmarkupareahighlight?view=word-pia"/>
  public bool ShowMarkupAreaHighlight { get; set; }

  /// <summary>
  /// Returns or sets whether panning.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.panning?view=word-pia"/>
  public bool Panning { get; set; }

  /// <summary>
  /// Returns or sets whether show crop marks.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showcropmarks?view=word-pia"/>
  public bool ShowCropMarks { get; set; }

  /// <summary>
  /// Returns or sets the markup mode.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.markupmode?view=word-pia"/>
  public WdRevisionsMode MarkupMode { get; set; }

  /// <summary>
  /// Returns or sets whether conflict mode.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.conflictmode?view=word-pia"/>
  public bool ConflictMode { get; set; }

  /// <summary>
  /// Returns or sets whether show other authors.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showotherauthors?view=word-pia"/>
  public bool ShowOtherAuthors { get; set; }

  /// <summary>
  /// Returns the revisions filter.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.revisionsfilter?view=word-pia"/>
  public RevisionsFilter RevisionsFilter { get; }

  /// <summary>
  /// Returns or sets the page color.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.pagecolor?view=word-pia"/>
  public WdPageColor PageColor { get; set; }

  /// <summary>
  /// Returns or sets the column width.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.columnwidth?view=word-pia"/>
  public WdColumnWidth ColumnWidth { get; set; }
}

namespace DocumentModel.Interop.Word;

/// <summary>
/// Contains the view attributes (show all, field shading, table gridlines, and so on) for a window or pane.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view?view=word-pia"/>
public partial interface View : InteropObject
{
  /// <summary>
  /// The type.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.type?view=word-pia"/>
  public WdViewType Type { get; set; }

  /// <summary>
  /// The full screen.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.fullscreen?view=word-pia"/>
  public bool FullScreen { get; set; }

  /// <summary>
  /// The draft.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.draft?view=word-pia"/>
  public bool Draft { get; set; }

  /// <summary>
  /// The show all.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showall?view=word-pia"/>
  public bool ShowAll { get; set; }

  /// <summary>
  /// The show field codes.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showfieldcodes?view=word-pia"/>
  public bool ShowFieldCodes { get; set; }

  /// <summary>
  /// The mail merge data view.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.mailmergedataview?view=word-pia"/>
  public bool MailMergeDataView { get; set; }

  /// <summary>
  /// The magnifier.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.magnifier?view=word-pia"/>
  public bool Magnifier { get; set; }

  /// <summary>
  /// The show first line only.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showfirstlineonly?view=word-pia"/>
  public bool ShowFirstLineOnly { get; set; }

  /// <summary>
  /// The show format.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showformat?view=word-pia"/>
  public bool ShowFormat { get; set; }

  /// <summary>
  /// The zoom.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.zoom?view=word-pia"/>
  public Zoom Zoom { get; }

  /// <summary>
  /// The show object anchors.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showobjectanchors?view=word-pia"/>
  public bool ShowObjectAnchors { get; set; }

  /// <summary>
  /// The show text boundaries.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showtextboundaries?view=word-pia"/>
  public bool ShowTextBoundaries { get; set; }

  /// <summary>
  /// The show highlight.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showhighlight?view=word-pia"/>
  public bool ShowHighlight { get; set; }

  /// <summary>
  /// The show drawings.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showdrawings?view=word-pia"/>
  public bool ShowDrawings { get; set; }

  /// <summary>
  /// The show tabs.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showtabs?view=word-pia"/>
  public bool ShowTabs { get; set; }

  /// <summary>
  /// The show spaces.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showspaces?view=word-pia"/>
  public bool ShowSpaces { get; set; }

  /// <summary>
  /// The show paragraphs.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showparagraphs?view=word-pia"/>
  public bool ShowParagraphs { get; set; }

  /// <summary>
  /// The show hyphens.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showhyphens?view=word-pia"/>
  public bool ShowHyphens { get; set; }

  /// <summary>
  /// The show hidden text.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showhiddentext?view=word-pia"/>
  public bool ShowHiddenText { get; set; }

  /// <summary>
  /// The wrap to window.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.wraptowindow?view=word-pia"/>
  public bool WrapToWindow { get; set; }

  /// <summary>
  /// The show picture place holders.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showpictureplaceholders?view=word-pia"/>
  public bool ShowPicturePlaceHolders { get; set; }

  /// <summary>
  /// The show bookmarks.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showbookmarks?view=word-pia"/>
  public bool ShowBookmarks { get; set; }

  /// <summary>
  /// The field shading.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.fieldshading?view=word-pia"/>
  public WdFieldShading FieldShading { get; set; }

  /// <summary>
  /// The show animation.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showanimation?view=word-pia"/>
  public bool ShowAnimation { get; set; }

  /// <summary>
  /// The table gridlines.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.tablegridlines?view=word-pia"/>
  public bool TableGridlines { get; set; }

  /// <summary>
  /// The enlarge fonts less than.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.enlargefontslessthan?view=word-pia"/>
  public int EnlargeFontsLessThan { get; set; }

  /// <summary>
  /// The show main text layer.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showmaintextlayer?view=word-pia"/>
  public bool ShowMainTextLayer { get; set; }

  /// <summary>
  /// The seek view.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.seekview?view=word-pia"/>
  public WdSeekView SeekView { get; set; }

  /// <summary>
  /// The split special.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.splitspecial?view=word-pia"/>
  public WdSpecialPane SplitSpecial { get; set; }

  /// <summary>
  /// The browse to window.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.browsetowindow?view=word-pia"/>
  public int BrowseToWindow { get; set; }

  /// <summary>
  /// The show optional breaks.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showoptionalbreaks?view=word-pia"/>
  public bool ShowOptionalBreaks { get; set; }

  /// <summary>
  /// The display page boundaries.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.displaypageboundaries?view=word-pia"/>
  public bool DisplayPageBoundaries { get; set; }

  /// <summary>
  /// The display smart tags.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.displaysmarttags?view=word-pia"/>
  public bool DisplaySmartTags { get; set; }

  /// <summary>
  /// The show revisions and comments.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showrevisionsandcomments?view=word-pia"/>
  public bool ShowRevisionsAndComments { get; set; }

  /// <summary>
  /// The show comments.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showcomments?view=word-pia"/>
  public bool ShowComments { get; set; }

  /// <summary>
  /// The show insertions and deletions.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showinsertionsanddeletions?view=word-pia"/>
  public bool ShowInsertionsAndDeletions { get; set; }

  /// <summary>
  /// The show format changes.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showformatchanges?view=word-pia"/>
  public bool ShowFormatChanges { get; set; }

  /// <summary>
  /// The revisions view.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.revisionsview?view=word-pia"/>
  public WdRevisionsView RevisionsView { get; set; }

  /// <summary>
  /// The revisions mode.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.revisionsmode?view=word-pia"/>
  public WdRevisionsMode RevisionsMode { get; set; }

  /// <summary>
  /// The revisions balloon width.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.revisionsballoonwidth?view=word-pia"/>
  public float RevisionsBalloonWidth { get; set; }

  /// <summary>
  /// The revisions balloon width type.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.revisionsballoonwidthtype?view=word-pia"/>
  public WdRevisionsBalloonWidthType RevisionsBalloonWidthType { get; set; }

  /// <summary>
  /// The revisions balloon side.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.revisionsballoonside?view=word-pia"/>
  public WdRevisionsBalloonMargin RevisionsBalloonSide { get; set; }

  /// <summary>
  /// The reviewers.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.reviewers?view=word-pia"/>
  public Reviewers Reviewers { get; }

  /// <summary>
  /// The revisions balloon show connecting lines.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.revisionsballoonshowconnectinglines?view=word-pia"/>
  public bool RevisionsBalloonShowConnectingLines { get; set; }

  /// <summary>
  /// The reading layout.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.readinglayout?view=word-pia"/>
  public bool ReadingLayout { get; set; }

  /// <summary>
  /// The show xmlmarkup.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showxmlmarkup?view=word-pia"/>
  public int ShowXMLMarkup { get; set; }

  /// <summary>
  /// The shade editable ranges.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.shadeeditableranges?view=word-pia"/>
  public int ShadeEditableRanges { get; set; }

  /// <summary>
  /// The show ink annotations.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showinkannotations?view=word-pia"/>
  public bool ShowInkAnnotations { get; set; }

  /// <summary>
  /// The display backgrounds.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.displaybackgrounds?view=word-pia"/>
  public bool DisplayBackgrounds { get; set; }

  /// <summary>
  /// The reading layout actual view.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.readinglayoutactualview?view=word-pia"/>
  public bool ReadingLayoutActualView { get; set; }

  /// <summary>
  /// The reading layout allow multiple pages.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.readinglayoutallowmultiplepages?view=word-pia"/>
  public bool ReadingLayoutAllowMultiplePages { get; set; }

  /// <summary>
  /// The reading layout allow editing.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.readinglayoutallowediting?view=word-pia"/>
  public bool ReadingLayoutAllowEditing { get; set; }

  /// <summary>
  /// The reading layout truncate margins.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.readinglayouttruncatemargins?view=word-pia"/>
  public WdReadingLayoutMargin ReadingLayoutTruncateMargins { get; set; }

  /// <summary>
  /// The show markup area highlight.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showmarkupareahighlight?view=word-pia"/>
  public bool ShowMarkupAreaHighlight { get; set; }

  /// <summary>
  /// The panning.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.panning?view=word-pia"/>
  public bool Panning { get; set; }

  /// <summary>
  /// The show crop marks.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showcropmarks?view=word-pia"/>
  public bool ShowCropMarks { get; set; }

  /// <summary>
  /// The markup mode.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.markupmode?view=word-pia"/>
  public WdRevisionsMode MarkupMode { get; set; }

  /// <summary>
  /// The conflict mode.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.conflictmode?view=word-pia"/>
  public bool ConflictMode { get; set; }

  /// <summary>
  /// The show other authors.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showotherauthors?view=word-pia"/>
  public bool ShowOtherAuthors { get; set; }

  /// <summary>
  /// The revisions filter.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.revisionsfilter?view=word-pia"/>
  public RevisionsFilter RevisionsFilter { get; }

  /// <summary>
  /// The page color.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.pagecolor?view=word-pia"/>
  public WdPageColor PageColor { get; set; }

  /// <summary>
  /// The column width.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.columnwidth?view=word-pia"/>
  public WdColumnWidth ColumnWidth { get; set; }
}

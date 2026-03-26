namespace DocumentModel.Interop.Word;

/// <summary>
/// Contains the view attributes (show all, field shading, table gridlines, and so on) for a window or pane.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view?view=word-pia"/>
public partial interface View : InteropObject
{
  /// <summary>
  /// Returns or sets the view type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.type?view=word-pia"/>
  public ViewType Type { get; set; }

  /// <summary>
  /// True if the window is in full-screen view.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.fullscreen?view=word-pia"/>
  public bool FullScreen { get; set; }

  /// <summary>
  /// True if all the text in a window is displayed in the same sans-serif font with minimal formatting to speed up
  /// display.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.draft?view=word-pia"/>
  public bool Draft { get; set; }

  /// <summary>
  /// True if all nonprinting characters (such as hidden text, tab marks, space marks, and paragraph marks) are
  /// displayed.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showall?view=word-pia"/>
  public bool ShowAll { get; set; }

  /// <summary>
  /// True if field codes are displayed.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showfieldcodes?view=word-pia"/>
  public bool ShowFieldCodes { get; set; }

  /// <summary>
  /// True if mail merge data is displayed instead of mail merge fields in the specified window.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.mailmergedataview?view=word-pia"/>
  public bool MailMergeDataView { get; set; }

  /// <summary>
  /// True if the pointer is displayed as a magnifying glass in print preview, indicating that the user can click to
  /// zoom in on a particular area of the page or zoom out to see an entire page or spread of pages.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.magnifier?view=word-pia"/>
  public bool Magnifier { get; set; }

  /// <summary>
  /// True if only the first line of body text is shown in outline view.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showfirstlineonly?view=word-pia"/>
  public bool ShowFirstLineOnly { get; set; }

  /// <summary>
  /// True if character formatting is visible in outline view.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showformat?view=word-pia"/>
  public bool ShowFormat { get; set; }

  /// <summary>
  /// Returns a Zoom object that represents the magnification for the specified view.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.zoom?view=word-pia"/>
  public Zoom Zoom { get; }

  /// <summary>
  /// True if object anchors are displayed next to items that can be positioned in print layout view.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showobjectanchors?view=word-pia"/>
  public bool ShowObjectAnchors { get; set; }

  /// <summary>
  /// True if dotted lines are displayed around page margins, text columns, objects, and frames in print layout
  /// view.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showtextboundaries?view=word-pia"/>
  public bool ShowTextBoundaries { get; set; }

  /// <summary>
  /// True if highlight formatting is displayed and printed with a document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showhighlight?view=word-pia"/>
  public bool ShowHighlight { get; set; }

  /// <summary>
  /// True if objects created with the drawing tools are displayed in print layout view.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showdrawings?view=word-pia"/>
  public bool ShowDrawings { get; set; }

  /// <summary>
  /// True if tab characters are displayed.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showtabs?view=word-pia"/>
  public bool ShowTabs { get; set; }

  /// <summary>
  /// True if space characters are displayed.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showspaces?view=word-pia"/>
  public bool ShowSpaces { get; set; }

  /// <summary>
  /// True if paragraph marks are displayed.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showparagraphs?view=word-pia"/>
  public bool ShowParagraphs { get; set; }

  /// <summary>
  /// True if optional hyphens are displayed. An optional hyphen indicates where to break a word when it falls at
  /// the end of a line.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showhyphens?view=word-pia"/>
  public bool ShowHyphens { get; set; }

  /// <summary>
  /// True if text formatted as hidden text is displayed.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showhiddentext?view=word-pia"/>
  public bool ShowHiddenText { get; set; }

  /// <summary>
  /// True if lines wrap at the right edge of the document window rather than at the right margin or the right
  /// column boundary.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.wraptowindow?view=word-pia"/>
  public bool WrapToWindow { get; set; }

  /// <summary>
  /// True if blank boxes are displayed as placeholders for pictures.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showpictureplaceholders?view=word-pia"/>
  public bool ShowPicturePlaceHolders { get; set; }

  /// <summary>
  /// True if square brackets are displayed at the beginning and end of each bookmark.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showbookmarks?view=word-pia"/>
  public bool ShowBookmarks { get; set; }

  /// <summary>
  /// Returns or sets on-screen shading for form fields.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.fieldshading?view=word-pia"/>
  public FieldShading FieldShading { get; set; }

  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showanimation?view=word-pia"/>
  public bool ShowAnimation { get; set; }

  /// <summary>
  /// True if table gridlines are displayed.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.tablegridlines?view=word-pia"/>
  public bool TableGridlines { get; set; }

  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.enlargefontslessthan?view=word-pia"/>
  public int EnlargeFontsLessThan { get; set; }

  /// <summary>
  /// True if the text in the specified document is visible when the header and footer areas are displayed.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showmaintextlayer?view=word-pia"/>
  public bool ShowMainTextLayer { get; set; }

  /// <summary>
  /// Returns or sets the document element displayed in print layout view.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.seekview?view=word-pia"/>
  public SeekView SeekView { get; set; }

  /// <summary>
  /// Returns or sets the active window pane.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.splitspecial?view=word-pia"/>
  public SpecialPane SplitSpecial { get; set; }

  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.browsetowindow?view=word-pia"/>
  public int BrowseToWindow { get; set; }

  /// <summary>
  /// True if Microsoft Word displays optional line breaks.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showoptionalbreaks?view=word-pia"/>
  public bool ShowOptionalBreaks { get; set; }

  /// <summary>
  /// True to display the top and bottom margins (white space) and the gray area (gray space) between pages in a
  /// document. False to hide from view the white and gray space so that the pages flow together as one long page.
  /// The default value is True.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.displaypageboundaries?view=word-pia"/>
  public bool DisplayPageBoundaries { get; set; }

  /// <summary>
  /// True for Microsoft Word to display an underline beneath smart tags in a document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.displaysmarttags?view=word-pia"/>
  public bool DisplaySmartTags { get; set; }

  /// <summary>
  /// True for Microsoft Word to display revisions and comments that were made to a document with Track Changes
  /// enabled.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showrevisionsandcomments?view=word-pia"/>
  public bool ShowRevisionsAndComments { get; set; }

  /// <summary>
  /// True for Microsoft Word to display the comments in a document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showcomments?view=word-pia"/>
  public bool ShowComments { get; set; }

  /// <summary>
  /// True for Microsoft Word to display insertions and deletions that were made to a document with Track Changes
  /// enabled.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showinsertionsanddeletions?view=word-pia"/>
  public bool ShowInsertionsAndDeletions { get; set; }

  /// <summary>
  /// True if character formatting is visible in outline view.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showformatchanges?view=word-pia"/>
  public bool ShowFormatChanges { get; set; }

  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.revisionsview?view=word-pia"/>
  public RevisionsView RevisionsView { get; set; }

  /// <summary>
  /// Sets or returns a constant representing the global option that specifies whether Microsoft Word displays
  /// balloons in the margin or inline with the document's text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.revisionsmode?view=word-pia"/>
  public RevisionsMode RevisionsMode { get; set; }

  /// <summary>
  /// Sets or returns a Single representing the global setting in Microsoft Word that specifies the width of the
  /// revision balloons.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.revisionsballoonwidth?view=word-pia"/>
  public float RevisionsBalloonWidth { get; set; }

  /// <summary>
  /// Sets or returns a constant representing the global setting that specifies how Microsoft Word measures the
  /// width of revision balloons.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.revisionsballoonwidthtype?view=word-pia"/>
  public RevisionsBalloonWidthType RevisionsBalloonWidthType { get; set; }

  /// <summary>
  /// Sets or returns a constant that specifies whether Microsoft Word displays revision balloons in the left or
  /// right margin in a document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.revisionsballoonside?view=word-pia"/>
  public RevisionsBalloonMargin RevisionsBalloonSide { get; set; }

  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.reviewers?view=word-pia"/>
  public Reviewers Reviewers { get; }

  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.revisionsballoonshowconnectinglines?view=word-pia"/>
  public bool RevisionsBalloonShowConnectingLines { get; set; }

  /// <summary>
  /// Sets or returns a Boolean that represents whether a document is being viewed in reading layout view.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.readinglayout?view=word-pia"/>
  public bool ReadingLayout { get; set; }

  /// <summary>
  /// Returns An Integer that represents whether XML tags are viewed in a document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showxmlmarkup?view=word-pia"/>
  public int ShowXMLMarkup { get; set; }

  /// <summary>
  /// Returns or sets an Integer that represents whether shading is applied to the ranges in a document for which
  /// users have permission to modify. True shades the ranges in a document that users can modify.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.shadeeditableranges?view=word-pia"/>
  public int ShadeEditableRanges { get; set; }

  /// <summary>
  /// Returns or sets a Boolean that shows or hides handwritten ink annotations. True displays ink annotations.
  /// False hides ink annotations.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showinkannotations?view=word-pia"/>
  public bool ShowInkAnnotations { get; set; }

  /// <summary>
  /// Returns or sets a Boolean that represents whether background colors and images are shown when a document is
  /// displayed in print layout view.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.displaybackgrounds?view=word-pia"/>
  public bool DisplayBackgrounds { get; set; }

  /// <summary>
  /// Sets or returns a Boolean that represents whether pages displayed in reading layout view are displayed using
  /// the same layout as printed pages.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.readinglayoutactualview?view=word-pia"/>
  public bool ReadingLayoutActualView { get; set; }

  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.readinglayoutallowmultiplepages?view=word-pia"/>
  public bool ReadingLayoutAllowMultiplePages { get; set; }

  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.readinglayoutallowediting?view=word-pia"/>
  public bool ReadingLayoutAllowEditing { get; set; }

  /// <summary>
  /// Returns or sets a ReadingLayoutMargin constant that represents whether margins are visible or hidden when a
  /// document is viewed in Full Screen Reading view. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.readinglayouttruncatemargins?view=word-pia"/>
  public ReadingLayoutMargin ReadingLayoutTruncateMargins { get; set; }

  /// <summary>
  /// Returns or sets a Boolean that represents whether the markup area that shows revision and comment balloons is
  /// shaded. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showmarkupareahighlight?view=word-pia"/>
  public bool ShowMarkupAreaHighlight { get; set; }

  /// <summary>
  /// Returns or sets a Boolean that represents whether Microsoft Office Word is in Panning mode. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.panning?view=word-pia"/>
  public bool Panning { get; set; }

  /// <summary>
  /// Returns or sets a Boolean that represents whether to show crop marks in the corners of pages to indicate where
  /// margins are located. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showcropmarks?view=word-pia"/>
  public bool ShowCropMarks { get; set; }

  /// <summary>
  /// Returns or sets a RevisionsMode constant that represents the display mode for tracked changes. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.markupmode?view=word-pia"/>
  public RevisionsMode MarkupMode { get; set; }

  /// <summary>
  /// Gets or sets whether the document is in conflict mode view.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.conflictmode?view=word-pia"/>
  public bool ConflictMode { get; set; }

  /// <summary>
  /// Gets or sets whether other authors' presence should be visible in the document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.showotherauthors?view=word-pia"/>
  public bool ShowOtherAuthors { get; set; }

  /// <summary>
  /// Returns an instance of a RevisionsFilter object. Read-only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.revisionsfilter?view=word-pia"/>
  public RevisionsFilter RevisionsFilter { get; }

  /// <summary>
  /// Returns and sets the page color in Reading mode. Read-write PageColor.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.pagecolor?view=word-pia"/>
  public PageColor PageColor { get; set; }

  /// <summary>
  /// Returns or gets a constant that determines the column width in reading mode. Read-write ColumnWidth
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.view.columnwidth?view=word-pia"/>
  public ColumnWidth ColumnWidth { get; set; }
}

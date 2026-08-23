namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the page setup description. The PageSetup object contains all page setup attributes (left margin,
/// bottom margin, paper size, and so on) as properties.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup?view=word-pia"/>
public partial interface IPageSetup : IModelObject
{
  /// <summary>
  /// Returns or sets the distance (in points) between the top edge of the page and the top boundary of the body
  /// text.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.topmargin?view=word-pia"/>
  public float TopMargin { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the distance (in points) between the bottom edge of the page and the bottom boundary of the
  /// body text.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.bottommargin?view=word-pia"/>
  public float BottomMargin { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the distance (in points) between the left edge of the page and the left boundary of the body
  /// text.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.leftmargin?view=word-pia"/>
  public float LeftMargin { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the distance (in points) between the right edge of the page and the right boundary of the body
  /// text.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.rightmargin?view=word-pia"/>
  public float RightMargin { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the amount (in points) of extra margin space added to each page in a document or section for
  /// binding.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.gutter?view=word-pia"/>
  public float Gutter { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the width of the page in points.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.pagewidth?view=word-pia"/>
  public float PageWidth { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the height of the page in points.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.pageheight?view=word-pia"/>
  public float PageHeight { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the orientation of the page.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.orientation?view=word-pia"/>
  public PageOrientation Orientation { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the paper tray to use for the first page of a document or section.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.firstpagetray?view=word-pia"/>
  public PaperTray FirstPageTray { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the paper tray to be used for all but the first page of a document or section.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.otherpagestray?view=word-pia"/>
  public PaperTray OtherPagesTray { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the vertical alignment of text on each page in a document or section.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.verticalalignment?view=word-pia"/>
  public VerticalAlignment VerticalAlignment { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// True if the inside and outside margins of facing pages are the same width. Can be True, False, or wdUndefined.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.mirrormargins?view=word-pia"/>
  public int MirrorMargins { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the distance (in points) between the header and the top of the page.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.headerdistance?view=word-pia"/>
  public float HeaderDistance { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the distance (in points) between the footer and the bottom of the page.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.footerdistance?view=word-pia"/>
  public float FooterDistance { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the type of section break for the specified object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.sectionstart?view=word-pia"/>
  public SectionStart SectionStart { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// True if the inside and outside margins of facing pages are the same width. Can be True, False, or wdUndefined.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.oddandevenpagesheaderfooter?view=word-pia"/>
  public int OddAndEvenPagesHeaderFooter { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// True if a different header or footer is used on the first page. Can be True, False, or wdUndefined.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.differentfirstpageheaderfooter?view=word-pia"/>
  public int DifferentFirstPageHeaderFooter { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// True if endnotes are printed at the end of the next section that doesn't suppress endnotes. Suppressed
  /// endnotes are printed before the endnotes in that section.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.suppressendnotes?view=word-pia"/>
  public int SuppressEndnotes { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the LineNumbering object that represents the line numbers for the specified PageSetup object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.linenumbering?view=word-pia"/>
  public ILineNumbering LineNumbering { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns a TextColumns collection that represents the set of text columns for the specified PageSetup object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.textcolumns?view=word-pia"/>
  public ITextColumns TextColumns { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the paper size.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.papersize?view=word-pia"/>
  public PaperSize PaperSize { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// True if Microsoft Word prints the specified document two pages per sheet.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.twopagesonone?view=word-pia"/>
  public bool TwoPagesOnOne { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.gutterontop?view=word-pia"/>
  public bool GutterOnTop { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the number of characters per line in the document grid.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.charsline?view=word-pia"/>
  public float CharsLine { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the number of lines per page in the document grid.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.linespage?view=word-pia"/>
  public float LinesPage { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// This member is for Macintosh only and should not be used.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.showgrid?view=word-pia"/>
  public bool ShowGrid { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets whether Microsoft Word uses gutters for the current document based on a right-to-left language
  /// or a left-to-right language.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.gutterstyle?view=word-pia"/>
  public GutterStyleOld GutterStyle { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the reading order and alignment for the specified sections.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.sectiondirection?view=word-pia"/>
  public SectionDirection SectionDirection { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the layout mode for the current document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.layoutmode?view=word-pia"/>
  public LayoutMode LayoutMode { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets on which side the gutter appears in a document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.gutterpos?view=word-pia"/>
  public GutterStyle GutterPos { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// True for Microsoft Word to print a document in a series of booklets so the printed pages can be folded and
  /// read as a book.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.bookfoldprinting?view=word-pia"/>
  public bool BookFoldPrinting { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// True for Microsoft Word to reverse the printing order for book fold printing of bidirectional or Asian
  /// language documents.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.bookfoldrevprinting?view=word-pia"/>
  public bool BookFoldRevPrinting { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets an Integer which represents the number of pages for each booklet.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.bookfoldprintingsheets?view=word-pia"/>
  public int BookFoldPrintingSheets { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}

namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the page setup description. The PageSetup object contains all page setup attributes (left margin,
/// bottom margin, paper size, and so on) as properties.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup?view=word-pia"/>
public partial interface PageSetup : InteropObject
{
  /// <summary>
  /// Returns or sets the distance (in points) between the top edge of the page and the top boundary of the body
  /// text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.topmargin?view=word-pia"/>
  public float TopMargin { get; set; }

  /// <summary>
  /// Returns or sets the distance (in points) between the bottom edge of the page and the bottom boundary of the
  /// body text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.bottommargin?view=word-pia"/>
  public float BottomMargin { get; set; }

  /// <summary>
  /// Returns or sets the distance (in points) between the left edge of the page and the left boundary of the body
  /// text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.leftmargin?view=word-pia"/>
  public float LeftMargin { get; set; }

  /// <summary>
  /// Returns or sets the distance (in points) between the right edge of the page and the right boundary of the body
  /// text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.rightmargin?view=word-pia"/>
  public float RightMargin { get; set; }

  /// <summary>
  /// Returns or sets the amount (in points) of extra margin space added to each page in a document or section for
  /// binding.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.gutter?view=word-pia"/>
  public float Gutter { get; set; }

  /// <summary>
  /// Returns or sets the width of the page in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.pagewidth?view=word-pia"/>
  public float PageWidth { get; set; }

  /// <summary>
  /// Returns or sets the height of the page in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.pageheight?view=word-pia"/>
  public float PageHeight { get; set; }

  /// <summary>
  /// Returns or sets the orientation of the page.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.orientation?view=word-pia"/>
  public WdOrientation Orientation { get; set; }

  /// <summary>
  /// Returns or sets the paper tray to use for the first page of a document or section.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.firstpagetray?view=word-pia"/>
  public WdPaperTray FirstPageTray { get; set; }

  /// <summary>
  /// Returns or sets the paper tray to be used for all but the first page of a document or section.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.otherpagestray?view=word-pia"/>
  public WdPaperTray OtherPagesTray { get; set; }

  /// <summary>
  /// Returns or sets the vertical alignment of text on each page in a document or section.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.verticalalignment?view=word-pia"/>
  public WdVerticalAlignment VerticalAlignment { get; set; }

  /// <summary>
  /// True if the inside and outside margins of facing pages are the same width. Can be True, False, or wdUndefined.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.mirrormargins?view=word-pia"/>
  public int MirrorMargins { get; set; }

  /// <summary>
  /// Returns or sets the distance (in points) between the header and the top of the page.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.headerdistance?view=word-pia"/>
  public float HeaderDistance { get; set; }

  /// <summary>
  /// Returns or sets the distance (in points) between the footer and the bottom of the page.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.footerdistance?view=word-pia"/>
  public float FooterDistance { get; set; }

  /// <summary>
  /// Returns or sets the type of section break for the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.sectionstart?view=word-pia"/>
  public WdSectionStart SectionStart { get; set; }

  /// <summary>
  /// True if the inside and outside margins of facing pages are the same width. Can be True, False, or wdUndefined.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.oddandevenpagesheaderfooter?view=word-pia"/>
  public int OddAndEvenPagesHeaderFooter { get; set; }

  /// <summary>
  /// True if a different header or footer is used on the first page. Can be True, False, or wdUndefined.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.differentfirstpageheaderfooter?view=word-pia"/>
  public int DifferentFirstPageHeaderFooter { get; set; }

  /// <summary>
  /// True if endnotes are printed at the end of the next section that doesn't suppress endnotes. Suppressed
  /// endnotes are printed before the endnotes in that section.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.suppressendnotes?view=word-pia"/>
  public int SuppressEndnotes { get; set; }

  /// <summary>
  /// Returns or sets the LineNumbering object that represents the line numbers for the specified PageSetup object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.linenumbering?view=word-pia"/>
  public LineNumbering LineNumbering { get; set; }

  /// <summary>
  /// Returns a TextColumns collection that represents the set of text columns for the specified PageSetup object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.textcolumns?view=word-pia"/>
  public TextColumns TextColumns { get; set; }

  /// <summary>
  /// Returns or sets the paper size.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.papersize?view=word-pia"/>
  public WdPaperSize PaperSize { get; set; }

  /// <summary>
  /// True if Microsoft Word prints the specified document two pages per sheet.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.twopagesonone?view=word-pia"/>
  public bool TwoPagesOnOne { get; set; }

  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.gutterontop?view=word-pia"/>
  public bool GutterOnTop { get; set; }

  /// <summary>
  /// Returns or sets the number of characters per line in the document grid.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.charsline?view=word-pia"/>
  public float CharsLine { get; set; }

  /// <summary>
  /// Returns or sets the number of lines per page in the document grid.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.linespage?view=word-pia"/>
  public float LinesPage { get; set; }

  /// <summary>
  /// This member is for Macintosh only and should not be used.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.showgrid?view=word-pia"/>
  public bool ShowGrid { get; set; }

  /// <summary>
  /// Returns or sets whether Microsoft Word uses gutters for the current document based on a right-to-left language
  /// or a left-to-right language.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.gutterstyle?view=word-pia"/>
  public WdGutterStyleOld GutterStyle { get; set; }

  /// <summary>
  /// Returns or sets the reading order and alignment for the specified sections.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.sectiondirection?view=word-pia"/>
  public WdSectionDirection SectionDirection { get; set; }

  /// <summary>
  /// Returns or sets the layout mode for the current document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.layoutmode?view=word-pia"/>
  public WdLayoutMode LayoutMode { get; set; }

  /// <summary>
  /// Returns or sets on which side the gutter appears in a document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.gutterpos?view=word-pia"/>
  public WdGutterStyle GutterPos { get; set; }

  /// <summary>
  /// True for Microsoft Word to print a document in a series of booklets so the printed pages can be folded and
  /// read as a book.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.bookfoldprinting?view=word-pia"/>
  public bool BookFoldPrinting { get; set; }

  /// <summary>
  /// True for Microsoft Word to reverse the printing order for book fold printing of bidirectional or Asian
  /// language documents.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.bookfoldrevprinting?view=word-pia"/>
  public bool BookFoldRevPrinting { get; set; }

  /// <summary>
  /// Returns or sets an Integer which represents the number of pages for each booklet.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.bookfoldprintingsheets?view=word-pia"/>
  public int BookFoldPrintingSheets { get; set; }
}

namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the page setup description. The PageSetup object contains all page setup attributes (left margin, bottom margin, paper size, and so on) as properties.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup?view=word-pia"/>
public partial interface PageSetup : InteropObject
{
  /// <summary>
  /// Returns or sets the top margin.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.topmargin?view=word-pia"/>
  public float TopMargin { get; set; }

  /// <summary>
  /// Returns or sets the bottom margin.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.bottommargin?view=word-pia"/>
  public float BottomMargin { get; set; }

  /// <summary>
  /// Returns or sets the left margin.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.leftmargin?view=word-pia"/>
  public float LeftMargin { get; set; }

  /// <summary>
  /// Returns or sets the right margin.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.rightmargin?view=word-pia"/>
  public float RightMargin { get; set; }

  /// <summary>
  /// Returns or sets the gutter.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.gutter?view=word-pia"/>
  public float Gutter { get; set; }

  /// <summary>
  /// Returns or sets the page width.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.pagewidth?view=word-pia"/>
  public float PageWidth { get; set; }

  /// <summary>
  /// Returns or sets the page height.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.pageheight?view=word-pia"/>
  public float PageHeight { get; set; }

  /// <summary>
  /// Returns or sets the orientation.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.orientation?view=word-pia"/>
  public WdOrientation Orientation { get; set; }

  /// <summary>
  /// Returns or sets the first page tray.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.firstpagetray?view=word-pia"/>
  public WdPaperTray FirstPageTray { get; set; }

  /// <summary>
  /// Returns or sets the other pages tray.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.otherpagestray?view=word-pia"/>
  public WdPaperTray OtherPagesTray { get; set; }

  /// <summary>
  /// Returns or sets the vertical alignment.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.verticalalignment?view=word-pia"/>
  public WdVerticalAlignment VerticalAlignment { get; set; }

  /// <summary>
  /// Returns or sets the mirror margins.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.mirrormargins?view=word-pia"/>
  public int MirrorMargins { get; set; }

  /// <summary>
  /// Returns or sets the header distance.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.headerdistance?view=word-pia"/>
  public float HeaderDistance { get; set; }

  /// <summary>
  /// Returns or sets the footer distance.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.footerdistance?view=word-pia"/>
  public float FooterDistance { get; set; }

  /// <summary>
  /// Returns or sets the section start.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.sectionstart?view=word-pia"/>
  public WdSectionStart SectionStart { get; set; }

  /// <summary>
  /// Returns or sets the odd and even pages header footer.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.oddandevenpagesheaderfooter?view=word-pia"/>
  public int OddAndEvenPagesHeaderFooter { get; set; }

  /// <summary>
  /// Returns or sets the different first page header footer.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.differentfirstpageheaderfooter?view=word-pia"/>
  public int DifferentFirstPageHeaderFooter { get; set; }

  /// <summary>
  /// Returns or sets the suppress endnotes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.suppressendnotes?view=word-pia"/>
  public int SuppressEndnotes { get; set; }

  /// <summary>
  /// Returns or sets the line numbering.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.linenumbering?view=word-pia"/>
  public LineNumbering LineNumbering { get; set; }

  /// <summary>
  /// Returns or sets the text columns.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.textcolumns?view=word-pia"/>
  public TextColumns TextColumns { get; set; }

  /// <summary>
  /// Returns or sets the paper size.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.papersize?view=word-pia"/>
  public WdPaperSize PaperSize { get; set; }

  /// <summary>
  /// Returns or sets whether two pages on one.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.twopagesonone?view=word-pia"/>
  public bool TwoPagesOnOne { get; set; }

  /// <summary>
  /// Returns or sets whether gutter on top.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.gutterontop?view=word-pia"/>
  public bool GutterOnTop { get; set; }

  /// <summary>
  /// Returns or sets the chars line.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.charsline?view=word-pia"/>
  public float CharsLine { get; set; }

  /// <summary>
  /// Returns or sets the lines page.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.linespage?view=word-pia"/>
  public float LinesPage { get; set; }

  /// <summary>
  /// Returns or sets whether show grid.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.showgrid?view=word-pia"/>
  public bool ShowGrid { get; set; }

  /// <summary>
  /// Returns or sets the gutter style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.gutterstyle?view=word-pia"/>
  public WdGutterStyleOld GutterStyle { get; set; }

  /// <summary>
  /// Returns or sets the section direction.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.sectiondirection?view=word-pia"/>
  public WdSectionDirection SectionDirection { get; set; }

  /// <summary>
  /// Returns or sets the layout mode.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.layoutmode?view=word-pia"/>
  public WdLayoutMode LayoutMode { get; set; }

  /// <summary>
  /// Returns or sets the gutter pos.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.gutterpos?view=word-pia"/>
  public WdGutterStyle GutterPos { get; set; }

  /// <summary>
  /// Returns or sets whether book fold printing.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.bookfoldprinting?view=word-pia"/>
  public bool BookFoldPrinting { get; set; }

  /// <summary>
  /// Returns or sets whether book fold rev printing.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.bookfoldrevprinting?view=word-pia"/>
  public bool BookFoldRevPrinting { get; set; }

  /// <summary>
  /// Returns or sets the book fold printing sheets.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.bookfoldprintingsheets?view=word-pia"/>
  public int BookFoldPrintingSheets { get; set; }
}

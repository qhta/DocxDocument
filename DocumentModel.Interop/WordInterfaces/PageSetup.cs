namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the page setup description. The PageSetup object contains all page setup attributes (left margin, bottom margin, paper size, and so on) as properties.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup?view=word-pia"/>
public partial interface PageSetup : InteropObject
{
  /// <summary>
  /// The top margin.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.topmargin?view=word-pia"/>
  public float TopMargin { get; set; }

  /// <summary>
  /// The bottom margin.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.bottommargin?view=word-pia"/>
  public float BottomMargin { get; set; }

  /// <summary>
  /// The left margin.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.leftmargin?view=word-pia"/>
  public float LeftMargin { get; set; }

  /// <summary>
  /// The right margin.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.rightmargin?view=word-pia"/>
  public float RightMargin { get; set; }

  /// <summary>
  /// The gutter.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.gutter?view=word-pia"/>
  public float Gutter { get; set; }

  /// <summary>
  /// The page width.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.pagewidth?view=word-pia"/>
  public float PageWidth { get; set; }

  /// <summary>
  /// The page height.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.pageheight?view=word-pia"/>
  public float PageHeight { get; set; }

  /// <summary>
  /// The orientation.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.orientation?view=word-pia"/>
  public WdOrientation Orientation { get; set; }

  /// <summary>
  /// The first page tray.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.firstpagetray?view=word-pia"/>
  public WdPaperTray FirstPageTray { get; set; }

  /// <summary>
  /// The other pages tray.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.otherpagestray?view=word-pia"/>
  public WdPaperTray OtherPagesTray { get; set; }

  /// <summary>
  /// The vertical alignment.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.verticalalignment?view=word-pia"/>
  public WdVerticalAlignment VerticalAlignment { get; set; }

  /// <summary>
  /// The mirror margins.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.mirrormargins?view=word-pia"/>
  public int MirrorMargins { get; set; }

  /// <summary>
  /// The header distance.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.headerdistance?view=word-pia"/>
  public float HeaderDistance { get; set; }

  /// <summary>
  /// The footer distance.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.footerdistance?view=word-pia"/>
  public float FooterDistance { get; set; }

  /// <summary>
  /// The section start.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.sectionstart?view=word-pia"/>
  public WdSectionStart SectionStart { get; set; }

  /// <summary>
  /// The odd and even pages header footer.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.oddandevenpagesheaderfooter?view=word-pia"/>
  public int OddAndEvenPagesHeaderFooter { get; set; }

  /// <summary>
  /// The different first page header footer.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.differentfirstpageheaderfooter?view=word-pia"/>
  public int DifferentFirstPageHeaderFooter { get; set; }

  /// <summary>
  /// The suppress endnotes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.suppressendnotes?view=word-pia"/>
  public int SuppressEndnotes { get; set; }

  /// <summary>
  /// The line numbering.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.linenumbering?view=word-pia"/>
  public LineNumbering LineNumbering { get; set; }

  /// <summary>
  /// The text columns.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.textcolumns?view=word-pia"/>
  public TextColumns TextColumns { get; set; }

  /// <summary>
  /// The paper size.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.papersize?view=word-pia"/>
  public WdPaperSize PaperSize { get; set; }

  /// <summary>
  /// The two pages on one.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.twopagesonone?view=word-pia"/>
  public bool TwoPagesOnOne { get; set; }

  /// <summary>
  /// The gutter on top.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.gutterontop?view=word-pia"/>
  public bool GutterOnTop { get; set; }

  /// <summary>
  /// The chars line.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.charsline?view=word-pia"/>
  public float CharsLine { get; set; }

  /// <summary>
  /// The lines page.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.linespage?view=word-pia"/>
  public float LinesPage { get; set; }

  /// <summary>
  /// The show grid.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.showgrid?view=word-pia"/>
  public bool ShowGrid { get; set; }

  /// <summary>
  /// The gutter style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.gutterstyle?view=word-pia"/>
  public WdGutterStyleOld GutterStyle { get; set; }

  /// <summary>
  /// The section direction.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.sectiondirection?view=word-pia"/>
  public WdSectionDirection SectionDirection { get; set; }

  /// <summary>
  /// The layout mode.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.layoutmode?view=word-pia"/>
  public WdLayoutMode LayoutMode { get; set; }

  /// <summary>
  /// The gutter pos.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.gutterpos?view=word-pia"/>
  public WdGutterStyle GutterPos { get; set; }

  /// <summary>
  /// The book fold printing.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.bookfoldprinting?view=word-pia"/>
  public bool BookFoldPrinting { get; set; }

  /// <summary>
  /// The book fold rev printing.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.bookfoldrevprinting?view=word-pia"/>
  public bool BookFoldRevPrinting { get; set; }

  /// <summary>
  /// The book fold printing sheets.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagesetup.bookfoldprintingsheets?view=word-pia"/>
  public int BookFoldPrintingSheets { get; set; }
}

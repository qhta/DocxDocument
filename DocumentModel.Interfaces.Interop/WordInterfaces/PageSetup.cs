namespace DocumentModel.Interop;

/// <summary>
/// Represents the page setup description. The PageSetup object contains all page setup attributes (left margin, bottom margin, paper size, and so on) as properties.
/// </summary>
public partial interface PageSetup : InteropObject
{
  /// <summary>
  /// The top margin.
  /// </summary>
  public float TopMargin { get; set; }

  /// <summary>
  /// The bottom margin.
  /// </summary>
  public float BottomMargin { get; set; }

  /// <summary>
  /// The left margin.
  /// </summary>
  public float LeftMargin { get; set; }

  /// <summary>
  /// The right margin.
  /// </summary>
  public float RightMargin { get; set; }

  /// <summary>
  /// The gutter.
  /// </summary>
  public float Gutter { get; set; }

  /// <summary>
  /// The page width.
  /// </summary>
  public float PageWidth { get; set; }

  /// <summary>
  /// The page height.
  /// </summary>
  public float PageHeight { get; set; }

  /// <summary>
  /// The orientation.
  /// </summary>
  public WdOrientation Orientation { get; set; }

  /// <summary>
  /// The first page tray.
  /// </summary>
  public WdPaperTray FirstPageTray { get; set; }

  /// <summary>
  /// The other pages tray.
  /// </summary>
  public WdPaperTray OtherPagesTray { get; set; }

  /// <summary>
  /// The vertical alignment.
  /// </summary>
  public WdVerticalAlignment VerticalAlignment { get; set; }

  /// <summary>
  /// The mirror margins.
  /// </summary>
  public int MirrorMargins { get; set; }

  /// <summary>
  /// The header distance.
  /// </summary>
  public float HeaderDistance { get; set; }

  /// <summary>
  /// The footer distance.
  /// </summary>
  public float FooterDistance { get; set; }

  /// <summary>
  /// The section start.
  /// </summary>
  public WdSectionStart SectionStart { get; set; }

  /// <summary>
  /// The odd and even pages header footer.
  /// </summary>
  public int OddAndEvenPagesHeaderFooter { get; set; }

  /// <summary>
  /// The different first page header footer.
  /// </summary>
  public int DifferentFirstPageHeaderFooter { get; set; }

  /// <summary>
  /// The suppress endnotes.
  /// </summary>
  public int SuppressEndnotes { get; set; }

  /// <summary>
  /// The line numbering.
  /// </summary>
  public LineNumbering LineNumbering { get; set; }

  /// <summary>
  /// The text columns.
  /// </summary>
  public TextColumns TextColumns { get; set; }

  /// <summary>
  /// The paper size.
  /// </summary>
  public WdPaperSize PaperSize { get; set; }

  /// <summary>
  /// The two pages on one.
  /// </summary>
  public bool TwoPagesOnOne { get; set; }

  /// <summary>
  /// The gutter on top.
  /// </summary>
  public bool GutterOnTop { get; set; }

  /// <summary>
  /// The chars line.
  /// </summary>
  public float CharsLine { get; set; }

  /// <summary>
  /// The lines page.
  /// </summary>
  public float LinesPage { get; set; }

  /// <summary>
  /// The show grid.
  /// </summary>
  public bool ShowGrid { get; set; }

  /// <summary>
  /// The gutter style.
  /// </summary>
  public WdGutterStyleOld GutterStyle { get; set; }

  /// <summary>
  /// The section direction.
  /// </summary>
  public WdSectionDirection SectionDirection { get; set; }

  /// <summary>
  /// The layout mode.
  /// </summary>
  public WdLayoutMode LayoutMode { get; set; }

  /// <summary>
  /// The gutter pos.
  /// </summary>
  public WdGutterStyle GutterPos { get; set; }

  /// <summary>
  /// The book fold printing.
  /// </summary>
  public bool BookFoldPrinting { get; set; }

  /// <summary>
  /// The book fold rev printing.
  /// </summary>
  public bool BookFoldRevPrinting { get; set; }

  /// <summary>
  /// The book fold printing sheets.
  /// </summary>
  public int BookFoldPrintingSheets { get; set; }
}

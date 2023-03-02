namespace DocumentModel.Wordprocessing;

/// <summary>
///   Previous Section Properties.
/// </summary>
public record PreviousSectionProperties
{
  /// <summary>
  ///   Physical Section Mark Character Revision ID
  /// </summary>
  public HexInt? RsidRPr { get; set; }

  /// <summary>
  ///   Section Deletion Revision ID
  /// </summary>
  public HexInt? RsidDel { get; set; }

  /// <summary>
  ///   Section Addition Revision ID
  /// </summary>
  public HexInt? RsidR { get; set; }

  /// <summary>
  ///   Section Properties Revision ID
  /// </summary>
  public HexInt? RsidSect { get; set; }

  /// <summary>
  ///   FootnoteProperties.
  /// </summary>
  public FootnoteProperties? FootnoteProperties { get; set; }

  /// <summary>
  ///   EndnoteProperties.
  /// </summary>
  public EndnoteProperties? EndnoteProperties { get; set; }

  /// <summary>
  ///   SectionType.
  /// </summary>
  public SectionMarkKind? SectionType { get; set; }

  /// <summary>
  ///   PageSize.
  /// </summary>
  public PageSize? PageSize { get; set; }

  /// <summary>
  ///   PageMargin.
  /// </summary>
  public PageMargin? PageMargin { get; set; }

  /// <summary>
  ///   PaperSource.
  /// </summary>
  public PaperSource? PaperSource { get; set; }

  /// <summary>
  ///   PageBorders.
  /// </summary>
  public PageBorders? PageBorders { get; set; }

  /// <summary>
  ///   LineNumberType.
  /// </summary>
  public LineNumberType? LineNumberType { get; set; }

  /// <summary>
  ///   PageNumberType.
  /// </summary>
  public PageNumberType? PageNumberType { get; set; }

  /// <summary>
  ///   Columns.
  /// </summary>
  public Columns? Columns { get; set; }

  /// <summary>
  ///   FormProtection.
  /// </summary>
  public Boolean? FormProtection { get; set; }

  /// <summary>
  ///   VerticalTextAlignmentOnPage.
  /// </summary>
  public VerticalJustificationKind? VerticalTextAlignmentOnPage { get; set; }

  /// <summary>
  ///   NoEndnote.
  /// </summary>
  public Boolean? NoEndnote { get; set; }

  /// <summary>
  ///   TitlePage.
  /// </summary>
  public Boolean? TitlePage { get; set; }

  /// <summary>
  ///   TextDirection.
  /// </summary>
  public TextDirectionKind? TextDirection { get; set; }

  /// <summary>
  ///   BiDi.
  /// </summary>
  public Boolean? BiDi { get; set; }

  /// <summary>
  ///   GutterOnRight.
  /// </summary>
  public Boolean? GutterOnRight { get; set; }

  /// <summary>
  ///   DocGrid.
  /// </summary>
  public DocGrid? DocGrid { get; set; }

  /// <summary>
  ///   PrinterSettingsReference.
  /// </summary>
  public RelationshipType? PrinterSettingsReference { get; set; }

  /// <summary>
  ///   FootnoteColumns, this property is only available in Office 2013 and later..
  /// </summary>
  public Int32? FootnoteColumns { get; set; }
}
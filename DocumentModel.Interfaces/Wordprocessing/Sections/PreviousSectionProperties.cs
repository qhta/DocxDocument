namespace DocumentModel.Wordprocessing;

/// <summary>
///   Previous ISection Properties.
/// </summary>
public class PreviousSectionProperties: ModelElement
{
  /// <summary>
  ///   Physical ISection Mark Character Revision ID
  /// </summary>
  public IHexInt? RsidRPr { get; set; }
  /// <summary>
  ///   ISection Deletion Revision ID
  /// </summary>
  public IHexInt? RsidDel { get; set; }
  /// <summary>
  ///   ISection Addition Revision ID
  /// </summary>
  public IHexInt? RsidR { get; set; }
  /// <summary>
  ///   ISection Properties Revision ID
  /// </summary>
  public IHexInt? RsidSect { get; set; }
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
  ///   IColumns.
  /// </summary>
  public IColumns? Columns { get; set; }
  /// <summary>
  ///   FormProtection.
  /// </summary>
  public bool? FormProtection { get; set; }
  /// <summary>
  ///   VerticalTextAlignmentOnPage.
  /// </summary>
  public VerticalJustificationKind? VerticalTextAlignmentOnPage { get; set; }
  /// <summary>
  ///   NoEndnote.
  /// </summary>
  public bool? NoEndnote { get; set; }
  /// <summary>
  ///   TitlePage.
  /// </summary>
  public bool? TitlePage { get; set; }
  /// <summary>
  ///   TextDirection.
  /// </summary>
  public TextDirectionKind? TextDirection { get; set; }
  /// <summary>
  ///   BiDi.
  /// </summary>
  public bool? BiDi { get; set; }
  /// <summary>
  ///   GutterOnRight.
  /// </summary>
  public bool? GutterOnRight { get; set; }
  /// <summary>
  ///   DocGrid.
  /// </summary>
  public DocGrid? DocGrid { get; set; }
  /// <summary>
  ///   PrinterSettingsReference.
  /// </summary>
  public IRelationshipType? PrinterSettingsReference { get; set; }
  /// <summary>
  ///   FootnoteColumns, this property is only available in Office 2013 and later..
  /// </summary>
  public Int32? FootnoteColumns { get; set; }
}
namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Previous ISection Properties.
/// </summary>
public class PreviousSectionProperties: ModelElement
{
  /// <summary>
  ///   Physical ISection Mark Character IRevision ID
  /// </summary>
  public HexInt? RsidRPr { get; set; }

  /// <summary>
  ///   ISection Deletion IRevision ID
  /// </summary>
  public HexInt? RsidDel { get; set; }

  /// <summary>
  ///   ISection Addition IRevision ID
  /// </summary>
  public HexInt? RsidR { get; set; }

  /// <summary>
  ///   ISection Properties IRevision ID
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
  ///   IColumns.
  /// </summary>
  public IColumns? IColumns { get; set; }

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
  public RelationshipType? PrinterSettingsReference { get; set; }

  /// <summary>
  ///   FootnoteColumns, this property is Ionly available Iin Office 2013 and later..
  /// </summary>
  public Int32? FootnoteColumns { get; set; }
}

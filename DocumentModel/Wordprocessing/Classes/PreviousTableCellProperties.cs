namespace DocumentModel.Wordprocessing;

/// <summary>
///   Previous Table Cell Properties.
/// </summary>
public record PreviousTableCellProperties
{
  /// <summary>
  ///   ConditionalFormatStyle.
  /// </summary>
  public ConditionalFormatStyle? ConditionalFormatStyle { get; set; }

  /// <summary>
  ///   TableCellWidth.
  /// </summary>
  public TableWidthType? TableCellWidth { get; set; }

  /// <summary>
  ///   GridSpan.
  /// </summary>
  public Int32? GridSpan { get; set; }

  /// <summary>
  ///   HorizontalMerge.
  /// </summary>
  public MergedCellKind? HorizontalMerge { get; set; }

  /// <summary>
  ///   VerticalMerge.
  /// </summary>
  public MergedCellKind? VerticalMerge { get; set; }

  /// <summary>
  ///   TableCellBorders.
  /// </summary>
  public TableCellBorders? TableCellBorders { get; set; }

  /// <summary>
  ///   Shading.
  /// </summary>
  public Shading? Shading { get; set; }

  /// <summary>
  ///   NoWrap.
  /// </summary>
  public Boolean? NoWrap { get; set; }

  /// <summary>
  ///   TableCellMargin.
  /// </summary>
  public TableCellMargin? TableCellMargin { get; set; }

  /// <summary>
  ///   TextDirection.
  /// </summary>
  public TextDirectionKind? TextDirection { get; set; }

  /// <summary>
  ///   TableCellFitText.
  /// </summary>
  public Boolean? TableCellFitText { get; set; }

  /// <summary>
  ///   TableCellVerticalAlignment.
  /// </summary>
  public TableVerticalAlignmentKind? TableCellVerticalAlignment { get; set; }

  /// <summary>
  ///   HideMark.
  /// </summary>
  public Boolean? HideMark { get; set; }

  public TrackChangeType? CellInsertion { get; set; }

  public TrackChangeType? CellDeletion { get; set; }

  public CellMerge? CellMerge { get; set; }
}
namespace DocumentModel.Wordprocessing;

/// <summary>
///   Table Cell Properties.
/// </summary>
public class TableCellProperties
{
  /// <summary>
  ///   ConditionalFormatStyle.
  /// </summary>
  [XmlContentElement]
  public ConditionalFormatStyle? ConditionalFormatStyle { get; set; }

  /// <summary>
  ///   TableCellWidth.
  /// </summary>
  [XmlContentElement]
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
  [XmlContentElement]
  public TableCellBorders? TableCellBorders { get; set; }

  /// <summary>
  ///   Shading.
  /// </summary>
  [XmlContentElement]
  public Shading? Shading { get; set; }

  /// <summary>
  ///   NoWrap.
  /// </summary>
  public Boolean? NoWrap { get; set; }

  /// <summary>
  ///   TableCellMargin.
  /// </summary>
  [XmlContentElement]
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

  [XmlContentElement]
  public CellInsertion? CellInsertion { get; set; }

  [XmlContentElement]
  public CellDeletion? CellDeletion { get; set; }

  [XmlContentElement]
  public CellMerge? CellMerge { get; set; }

  [XmlContentElement]
  public TableCellPropertiesChange? TableCellPropertiesChange { get; set; }
}
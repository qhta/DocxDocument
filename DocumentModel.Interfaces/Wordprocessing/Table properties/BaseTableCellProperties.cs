namespace DocumentModel.Wordprocessing;
/// <summary>
///   Base interface for all TableCellProperties classes.
///   Contains common properties.
/// </summary>
public interface BaseTableCellProperties
{
  /// <summary>
  ///   Shading.
  /// </summary>
  public Shading? Shading { get; set; }
  /// <summary>
  ///   NoWrap.
  /// </summary>
  public bool? NoWrap { get; set; }
  /// <summary>
  ///   TableCellMargin.
  /// </summary>
  public TableCellMargin? TableCellMargin { get; set; }
  /// <summary>
  ///   TableCellVerticalAlignment.
  /// </summary>
  public TableVerticalAlignmentKind? TableCellVerticalAlignment { get; set; }
}
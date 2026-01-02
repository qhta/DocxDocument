namespace DocumentModel.Wordprocessing;
/// <summary>
///   Base class for all TableCellProperties classes.
///   Contains common properties.
/// </summary>
public class BaseTableCellProperties: ModelElement
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
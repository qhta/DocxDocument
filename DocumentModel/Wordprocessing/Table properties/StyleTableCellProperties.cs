namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Style Table Cell Properties.
/// </summary>
public class StyleTableCellProperties: ModelElement
{
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
  ///   TableCellVerticalAlignment.
  /// </summary>
  public TableVerticalAlignmentKind? TableCellVerticalAlignment { get; set; }
}
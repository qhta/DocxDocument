namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of Cell objects in a table column, table row, selection, or range.
/// </summary>
public partial interface Cells : InteropObject, InteropCollection<Cell>
{
  /// <summary>
  /// The width.
  /// </summary>
  public float Width { get; set; }

  /// <summary>
  /// The height.
  /// </summary>
  public float Height { get; set; }

  /// <summary>
  /// The height rule.
  /// </summary>
  public WdRowHeightRule HeightRule { get; set; }

  /// <summary>
  /// The vertical alignment.
  /// </summary>
  public WdCellVerticalAlignment VerticalAlignment { get; set; }

  /// <summary>
  /// The borders.
  /// </summary>
  public Borders Borders { get; set; }

  /// <summary>
  /// The shading.
  /// </summary>
  public Shading Shading { get; }

  /// <summary>
  /// The nesting level.
  /// </summary>
  public int NestingLevel { get; }

  /// <summary>
  /// The preferred width.
  /// </summary>
  public float PreferredWidth { get; set; }

  /// <summary>
  /// The preferred width type.
  /// </summary>
  public WdPreferredWidthType PreferredWidthType { get; set; }
}

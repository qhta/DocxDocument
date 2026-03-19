namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single table column. The Column object is a member of the Columns collection.
/// </summary>
public partial interface Column : InteropObject
{
  /// <summary>
  /// The width.
  /// </summary>
  public float Width { get; set; }

  /// <summary>
  /// The is first.
  /// </summary>
  public bool IsFirst { get; }

  /// <summary>
  /// The is last.
  /// </summary>
  public bool IsLast { get; }

  /// <summary>
  /// The index.
  /// </summary>
  public int Index { get; }

  /// <summary>
  /// The cells.
  /// </summary>
  public Cells Cells { get; }

  /// <summary>
  /// The borders.
  /// </summary>
  public Borders Borders { get; set; }

  /// <summary>
  /// The shading.
  /// </summary>
  public Shading Shading { get; }

  /// <summary>
  /// The next.
  /// </summary>
  public Column Next { get; }

  /// <summary>
  /// The previous.
  /// </summary>
  public Column Previous { get; }

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

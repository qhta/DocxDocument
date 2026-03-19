namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of Column objects that represent the columns in a table.
/// </summary>
public partial interface Columns : InteropObject, InteropCollection<Column>
{
  /// <summary>
  /// The first.
  /// </summary>
  public Column First { get; }

  /// <summary>
  /// The last.
  /// </summary>
  public Column Last { get; }

  /// <summary>
  /// The width.
  /// </summary>
  public float Width { get; set; }

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

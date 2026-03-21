namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of Cell objects in a table column, table row, selection, or range.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cells?view=word-pia"/>
public partial interface Cells : InteropObject, InteropCollection<Cell>
{
  /// <summary>
  /// The width.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cells.width?view=word-pia"/>
  public float Width { get; set; }

  /// <summary>
  /// The height.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cells.height?view=word-pia"/>
  public float Height { get; set; }

  /// <summary>
  /// The height rule.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cells.heightrule?view=word-pia"/>
  public WdRowHeightRule HeightRule { get; set; }

  /// <summary>
  /// The vertical alignment.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cells.verticalalignment?view=word-pia"/>
  public WdCellVerticalAlignment VerticalAlignment { get; set; }

  /// <summary>
  /// The borders.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cells.borders?view=word-pia"/>
  public Borders Borders { get; set; }

  /// <summary>
  /// The shading.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cells.shading?view=word-pia"/>
  public Shading Shading { get; }

  /// <summary>
  /// The nesting level.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cells.nestinglevel?view=word-pia"/>
  public int NestingLevel { get; }

  /// <summary>
  /// The preferred width.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cells.preferredwidth?view=word-pia"/>
  public float PreferredWidth { get; set; }

  /// <summary>
  /// The preferred width type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cells.preferredwidthtype?view=word-pia"/>
  public WdPreferredWidthType PreferredWidthType { get; set; }
}

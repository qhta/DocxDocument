using DocumentModel.Wordprocessing;

namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a single table cell.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cell?view=word-pia"/>
public partial interface ICell : IModelObject
{
  /// <summary>
  /// Gets the range that represents the cell.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cell.range?view=word-pia"/>
  public IRange Range { get; }

  /// <summary>
  /// Gets the index number of the row that contains the cell.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cell.rowindex?view=word-pia"/>
  public int RowIndex { get; }

  /// <summary>
  /// Gets the index number of the column that contains the cell.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cell.columnindex?view=word-pia"/>
  public int ColumnIndex { get; }

  /// <summary>
  /// Gets or sets the width of the cell, in points.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cell.width?view=word-pia"/>
  public float Width { get; set; }

  /// <summary>
  /// Gets or sets the height of the cell, in points.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cell.height?view=word-pia"/>
  public float Height { get; set; }

  /// <summary>
  /// Gets or sets the rule for determining row height.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cell.heightrule?view=word-pia"/>
  public RowHeightRule HeightRule { get; set; }

  /// <summary>
  /// Gets or sets the vertical alignment of text in the cell.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cell.verticalalignment?view=word-pia"/>
  public TableVerticalAlignment VerticalAlignment { get; set; }

  /// <summary>
  /// Gets the column that contains the cell.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cell.column?view=word-pia"/>
  public IColumn Column { get; }

  /// <summary>
  /// Gets the row that contains the cell.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cell.row?view=word-pia"/>
  public IRow Row { get; }

  /// <summary>
  /// Gets the next cell in the table.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cell.next?view=word-pia"/>
  public ICell Next { get; }

  /// <summary>
  /// Gets the previous cell in the table.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cell.previous?view=word-pia"/>
  public ICell Previous { get; }

  /// <summary>
  /// Gets the shading formatting for the cell.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cell.shading?view=word-pia"/>
  public DMD.IShading Shading { get; }

  /// <summary>
  /// Gets or sets the border formatting for the cell.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cell.borders?view=word-pia"/>
  public IBorders Borders { get; set; }

  /// <summary>
  /// Gets the collection of tables nested within the cell.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cell.tables?view=word-pia"/>
  public ITables Tables { get; }

  /// <summary>
  /// Gets the nesting level of the cell.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cell.nestinglevel?view=word-pia"/>
  public int NestingLevel { get; }

  /// <summary>
  /// Gets or sets a value indicating whether text wraps within the cell.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cell.wordwrap?view=word-pia"/>
  public bool WordWrap { get; set; }

  /// <summary>
  /// Gets or sets the preferred width of the cell.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cell.preferredwidth?view=word-pia"/>
  public float PreferredWidth { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether text is shrunk to fit within the cell.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cell.fittext?view=word-pia"/>
  public bool FitText { get; set; }

  /// <summary>
  /// Gets or sets the top padding of the cell, in points.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cell.toppadding?view=word-pia"/>
  public float TopPadding { get; set; }

  /// <summary>
  /// Gets or sets the bottom padding of the cell, in points.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cell.bottompadding?view=word-pia"/>
  public float BottomPadding { get; set; }

  /// <summary>
  /// Gets or sets the left padding of the cell, in points.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cell.leftpadding?view=word-pia"/>
  public float LeftPadding { get; set; }

  /// <summary>
  /// Gets or sets the right padding of the cell, in points.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cell.rightpadding?view=word-pia"/>
  public float RightPadding { get; set; }

  /// <summary>
  /// Gets or sets the identifier for the cell.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cell.id?view=word-pia"/>
  public string ID { get; set; }

  /// <summary>
  /// Gets or sets the preferred width type for the cell.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cell.preferredwidthtype?view=word-pia"/>
  public PreferredWidthType PreferredWidthType { get; set; }
}

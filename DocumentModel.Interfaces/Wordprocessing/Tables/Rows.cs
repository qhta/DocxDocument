using DocumentModel.Wordprocessing;

namespace DocumentModel.Wordprocessing;

/// <summary>
/// A collection of Row objects that represent the table rows in the specified selection, range, or table.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows?view=word-pia"/>
public partial interface IRows : IModelCollection<IRow>
{
  /// <summary>
  /// Determine if the text in a table row or rows is allowed to split across a page break.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.allowbreakacrosspages?view=word-pia"/>
  public int AllowBreakAcrossPages { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets a RowAlignment constant that represents the alignment for the specified rows.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.alignment?view=word-pia"/>
  public TableRowAlignment Alignment { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Determine if the specified row or rows are formatted as a table heading.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.headingformat?view=word-pia"/>
  public int HeadingFormat { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the distance (in points) between text in adjacent columns of the specified row or rows.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.spacebetweencolumns?view=word-pia"/>
  public float SpaceBetweenColumns { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the height of the specified row or rows in a table.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.height?view=word-pia"/>
  public float Height { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the rule for determining the height of the specified rows.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.heightrule?view=word-pia"/>
  public RowHeightRule HeightRule { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets a Single that represents the left indent value (in points) for the specified table rows.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.leftindent?view=word-pia"/>
  public float LeftIndent { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns a Row object that represents the first item in the Rows collection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.first?view=word-pia"/>
  public IRow First { get; }

  /// <summary>
  /// Returns the last item in the Rows collection as a Row object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.last?view=word-pia"/>
  public IRow Last { get; }

  /// <summary>
  /// Returns a Borders collection that represents all the borders for the specified object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.borders?view=word-pia"/>
  public IBorders Borders { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns a Shading object that refers to the shading formatting for the specified object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.shading?view=word-pia"/>
  public DMD.IShading Shading { get; }

  /// <summary>
  /// Determines whether text should wrap around the specified rows.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.wraparoundtext?view=word-pia"/>
  public int WrapAroundText { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the distance (in points) between the document text and the top edge of the specified table.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.distancetop?view=word-pia"/>
  public float DistanceTop { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the distance (in points) between the document text and the bottom edge of the specified table.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.distancebottom?view=word-pia"/>
  public float DistanceBottom { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the distance (in points) between the document text and the left edge of the specified table.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.distanceleft?view=word-pia"/>
  public float DistanceLeft { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the distance (in points) between the document text and the right edge of the specified table.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.distanceright?view=word-pia"/>
  public float DistanceRight { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the horizontal distance between the edge of the rows and the item specified by the
  /// RelativeHorizontalPosition property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.horizontalposition?view=word-pia"/>
  public float HorizontalPosition { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the vertical distance between the edge of the rows and the item specified by the
  /// RelativeVerticalPosition property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.verticalposition?view=word-pia"/>
  public float VerticalPosition { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Specifies to what the horizontal position of a group of rows is relative.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.relativehorizontalposition?view=word-pia"/>
  public RelativeHorizontalPosition RelativeHorizontalPosition { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Specifies to what the vertical position of a group of rows is relative.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.relativeverticalposition?view=word-pia"/>
  public RelativeVerticalPosition RelativeVerticalPosition { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets a value that specifies whether the specified rows can overlap other rows.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.allowoverlap?view=word-pia"/>
  public int AllowOverlap { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns the nesting level of the specified rows.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.nestinglevel?view=word-pia"/>
  public int NestingLevel { get; }

  /// <summary>
  /// Returns or sets the direction in which Microsoft Word orders cells in the specified table or row.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.tabledirection?view=word-pia"/>
  public TableDirection TableDirection { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}

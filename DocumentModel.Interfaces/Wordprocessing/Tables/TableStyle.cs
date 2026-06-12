using DocumentModel.Wordprocessing;

namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a single style that can be applied to a table.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tablestyle?view=word-pia"/>
public partial interface ITableStyle : IModelObject
{
  /// <summary>
  /// Allows Microsoft Word to break the specified table across pages.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tablestyle.allowpagebreaks?view=word-pia"/>
  public bool AllowPageBreaks { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns a Borders collection that represents all the borders for the specified object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tablestyle.borders?view=word-pia"/>
  public IBorders Borders { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the amount of space (in points) to add below the contents of a single cell or all the cells in
  /// a table.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tablestyle.bottompadding?view=word-pia"/>
  public float BottomPadding { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the amount of space (in points) to add to the left of the contents of all the cells in a table
  /// style.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tablestyle.leftpadding?view=word-pia"/>
  public float LeftPadding { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the amount of space (in points) to add above the contents of all the cells in a table style.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tablestyle.toppadding?view=word-pia"/>
  public float TopPadding { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the amount of space (in points) to add to the right of the contents of all the cells in a
  /// table style.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tablestyle.rightpadding?view=word-pia"/>
  public float RightPadding { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets a constant that represents the alignment for the specified rows.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tablestyle.alignment?view=word-pia"/>
  public TableRowAlignment Alignment { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the spacing (in points) between the cells in a table style.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tablestyle.spacing?view=word-pia"/>
  public float Spacing { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the direction in which Microsoft Word orders cells in the specified table or row.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tablestyle.tabledirection?view=word-pia"/>
  public TableDirection TableDirection { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Sets or returns an Integer indicating whether lines in the rows of tables formatted with a specified style
  /// break across pages.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tablestyle.allowbreakacrosspage?view=word-pia"/>
  public int AllowBreakAcrossPage { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets a Single that represents the left indent value (in points) for the specified table style.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tablestyle.leftindent?view=word-pia"/>
  public float LeftIndent { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns a Shading object that refers to the shading formatting for the specified object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tablestyle.shading?view=word-pia"/>
  public DMD.IShading Shading { get; }

  /// <summary>
  /// Returns or sets an Integer that represents the number of rows to include in the banding when a style specifies
  /// odd- or even-row banding.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tablestyle.rowstripe?view=word-pia"/>
  public int RowStripe { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets an Integer that represents the number of columns in the banding when a style specifies odd- or
  /// even-column banding.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tablestyle.columnstripe?view=word-pia"/>
  public int ColumnStripe { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}

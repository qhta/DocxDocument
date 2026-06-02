namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents an equation matrix.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathmat?view=word-pia"/>
public interface IOMathMat : IInteropObject
{
  /// <summary>
  /// Returns the collection of matrix rows.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathmat.rows?view=word-pia"/>
  public OMathMatRows Rows { get; }

  /// <summary>
  /// Returns the collection of matrix columns.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathmat.cols?view=word-pia"/>
  public OMathMatCols Cols { get; }

  /// <summary>
  /// Returns or sets the vertical alignment of the matrix.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathmat.align?view=word-pia"/>
  public OMathVertAlignType Align { get; set; }

  /// <summary>
  /// Returns or sets whether placeholders are hidden.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathmat.plcholdhidden?view=word-pia"/>
  public bool PlcHoldHidden { get; set; }

  /// <summary>
  /// Returns or sets the row spacing rule.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathmat.rowspacingrule?view=word-pia"/>
  public OMathSpacingRule RowSpacingRule { get; set; }

  /// <summary>
  /// Returns or sets the spacing between matrix rows.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathmat.rowspacing?view=word-pia"/>
  public int RowSpacing { get; set; }

  /// <summary>
  /// Returns or sets the spacing between matrix columns.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathmat.colspacing?view=word-pia"/>
  public int ColSpacing { get; set; }

  /// <summary>
  /// Returns or sets the column gap spacing rule.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathmat.colgaprule?view=word-pia"/>
  public OMathSpacingRule ColGapRule { get; set; }

  /// <summary>
  /// Returns or sets the column gap value.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathmat.colgap?view=word-pia"/>
  public int ColGap { get; set; }


  #region methods

/// <summary>
  /// Returns the equation cell at the specified row and column.
  /// </summary>
  /// <param name="Row">Specifies the one-based row index.</param>
  /// <param name="Col">Specifies the one-based column index.</param>
  /// <returns>The equation object in the specified matrix cell.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathmat.get_cell?view=word-pia"/>
  public OMath Cell(int Row, int Col);

  #endregion methods
}

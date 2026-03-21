namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathmat?view=word-pia"/>
public partial interface OMathMat
{
  /// <summary>
  /// Returns the cell.
  /// </summary>
  /// <param name="Row">Specifies the row.</param>
  /// <param name="Col">Specifies the col.</param>
  /// <returns>The resulting value.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathmat.get_cell?view=word-pia"/>
  public OMath get_Cell(int Row, int Col);
}

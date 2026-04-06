namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathmat?view=word-pia"/>
public partial interface IOMathMat: IModelObject
{
  /// <summary>
  /// Returns the equation cell at the specified row and column.
  /// </summary>
  /// <param name="Row">Specifies the one-based row index.</param>
  /// <param name="Col">Specifies the one-based column index.</param>
  /// <returns>The equation object in the specified matrix cell.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathmat.get_cell?view=word-pia"/>
  public IOMath Cell(int Row, int Col);
}

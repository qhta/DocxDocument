namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cells?view=word-pia"/>
public partial interface ICells: IModelObject
{
  /// <summary>
  /// Adds a cell to the collection before the specified cell.
  /// </summary>
  /// <param name="BeforeCell">The cell before which the new cell is added.</param>
  /// <returns>The newly added <see cref="ICell"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cells.add?view=word-pia"/>
  public ICell Add(object BeforeCell);
}

namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathmatcols?view=word-pia"/>
public partial interface OMathMatCols
{
  /// <summary>
  /// Adds a new matrix column to the collection.
  /// </summary>
  /// <param name="BeforeCol">The column before which the new column is added.</param>
  /// <returns>The created <see cref="OMathMatCol"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathmatcols.add?view=word-pia"/>
  public OMathMatCol Add(object BeforeCol);
}

namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.columns?view=word-pia"/>
public partial interface IColumns : IModelObject
{
  /// <summary>
  /// Adds a column to the collection before the specified column.
  /// </summary>
  /// <param name="BeforeColumn">The column before which the new column is added.</param>
  /// <returns>The newly added <see cref="IColumn"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.columns.add?view=word-pia"/>
  public IColumn Add(object BeforeColumn);
}

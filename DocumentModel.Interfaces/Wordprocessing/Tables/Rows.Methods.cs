namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows?view=word-pia"/>
public partial interface IRows : IModelObject
{
  /// <summary>
  /// Adds a new row before the specified row.
  /// </summary>
  /// <param name="BeforeRow">The row before which the new row is inserted.</param>
  /// <returns>The inserted <see cref="IRow"/>.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.add?view=word-pia"/>
  public IRow Add(object BeforeRow);
}

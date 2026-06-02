namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows?view=word-pia"/>
public partial interface IRows
{
  /// <summary>
  /// Adds a new row before the specified row.
  /// </summary>
  /// <param name="BeforeRow">The row before which the new row is inserted.</param>
  /// <returns>The inserted <see cref="Row"/>.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.add?view=word-pia"/>
  public Row Add(object BeforeRow);
}

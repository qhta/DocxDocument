
namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathmatrows?view=word-pia"/>
public partial interface OMathMatRows
{
  /// <summary>
  /// Adds a new matrix row to the collection.
  /// </summary>
  /// <param name="BeforeRow">The row before which the new row is added.</param>
  /// <returns>The created <see cref="OMathMatRow"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathmatrows.add?view=word-pia"/>
  public OMathMatRow Add(object BeforeRow);
}

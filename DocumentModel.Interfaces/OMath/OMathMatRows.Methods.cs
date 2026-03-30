
namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathmatrows?view=word-pia"/>
public partial interface IOMathMatRows: IModelObject
{
  /// <summary>
  /// Adds a matrix row to the collection.
  /// </summary>
  /// <param name="BeforeRow">Specifies the row before which the new row is inserted.</param>
  /// <returns>The added matrix row object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathmatrows.add?view=word-pia"/>
  public IOMathMatRow Add(object BeforeRow);
}

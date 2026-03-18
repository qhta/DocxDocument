
namespace DocumentModel.Interop;

public partial interface OMathMatRows
{
  /// <summary>
  /// Adds a new matrix row to the collection.
  /// </summary>
  /// <param name="BeforeRow">The row before which the new row is added.</param>
  /// <returns>The created <see cref="OMathMatRow"/> object.</returns>
  public OMathMatRow Add(object BeforeRow);
}

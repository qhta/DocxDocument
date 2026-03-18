namespace DocumentModel.Interop;

public partial interface OMathMatCols
{
  /// <summary>
  /// Adds a new matrix column to the collection.
  /// </summary>
  /// <param name="BeforeCol">The column before which the new column is added.</param>
  /// <returns>The created <see cref="OMathMatCol"/> object.</returns>
  public OMathMatCol Add(object BeforeCol);
}

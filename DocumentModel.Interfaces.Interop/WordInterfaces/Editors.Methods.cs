namespace DocumentModel.Interop;

public partial interface Editors
{
  /// <summary>
  /// Returns the value produced by the item operation.
  /// </summary>
  /// <param name="Index">Specifies the index.</param>
  /// <returns>The resulting value.</returns>
  public Editor Item(object Index);
}

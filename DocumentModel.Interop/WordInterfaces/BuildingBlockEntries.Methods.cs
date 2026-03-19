namespace DocumentModel.Interop.Word;

public partial interface BuildingBlockEntries
{
  /// <summary>
  /// Returns a building block from the collection by index or name.
  /// </summary>
  /// <param name="Index">The numeric index or name of the building block.</param>
  /// <returns>The requested <see cref="BuildingBlock"/> object.</returns>
  public BuildingBlock Item(object Index);
}

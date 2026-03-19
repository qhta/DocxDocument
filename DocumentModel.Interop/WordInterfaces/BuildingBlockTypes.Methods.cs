namespace DocumentModel.Interop.Word;

public partial interface BuildingBlockTypes
{
  /// <summary>
  /// Returns a building block type from the collection.
  /// </summary>
  /// <param name="Index">A <see cref="WdBuildingBlockTypes"/> value that identifies the building block type.</param>
  /// <returns>The requested <see cref="BuildingBlockType"/> object.</returns>
  public BuildingBlockType Item(WdBuildingBlockTypes Index);
}

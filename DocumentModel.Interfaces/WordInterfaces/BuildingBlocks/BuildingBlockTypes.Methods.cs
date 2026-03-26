namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.buildingblocktypes?view=word-pia"/>
public partial interface BuildingBlockTypes: InteropObject
{
  /// <summary>
  /// Returns a building block type from the collection.
  /// </summary>
  /// <param name="Index">A <see cref="BuildingBlockTypes"/> value that identifies the building block type.</param>
  /// <returns>The requested <see cref="BuildingBlockType"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.buildingblocktypes.item?view=word-pia"/>
  public BuildingBlockType Item(BuildingBlockTypes Index);
}

namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.buildingblocks?view=word-pia"/>
public partial interface BuildingBlocks
{
  /// <summary>
  /// Returns a building block from the collection by index or name.
  /// </summary>
  /// <param name="Index">The numeric index or name of the building block.</param>
  /// <returns>The requested <see cref="BuildingBlock"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.buildingblocks.item?view=word-pia"/>
  public BuildingBlock Item(object Index);
}

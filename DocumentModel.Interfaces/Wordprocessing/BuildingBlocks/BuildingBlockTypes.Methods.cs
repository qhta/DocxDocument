namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.buildingblocktypes?view=word-pia"/>
public partial interface IBuildingBlockTypes: IModelObject
{
  /// <summary>
  /// Returns a building block type from the collection.
  /// </summary>
  /// <param name="Index">A <see cref="IBuildingBlockTypes"/> value that identifies the building block type.</param>
  /// <returns>The requested <see cref="IBuildingBlockType"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.buildingblocktypes.item?view=word-pia"/>
  public IBuildingBlockType Item(BuildingBlockEnumTypes Index);
}

namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a type of building block. Each BuildingBlockType object is a member of the BuildingBlockTypes collection.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.buildingblocktype?view=word-pia"/>
public interface IBuildingBlockType : IInteropObject
{
  /// <summary>
  /// Gets the index number of the building block type in the collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.buildingblocktype.index?view=word-pia"/>
  public int Index { get; }
  /// <summary>
  /// Gets the name of the building block type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.buildingblocktype.name?view=word-pia"/>
  public string Name { get; }
  /// <summary>
  /// Gets the categories collection for this building block type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.buildingblocktype.categories?view=word-pia"/>
  public ICategories Categories { get; }

}

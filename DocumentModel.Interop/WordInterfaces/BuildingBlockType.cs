namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a type of building block. Each BuildingBlockType object is a member of the BuildingBlockTypes collection.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.buildingblocktype?view=word-pia"/>
public interface BuildingBlockType : InteropObject
{
  /// <summary>
  /// The index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.buildingblocktype.index?view=word-pia"/>
  public int Index { get; }
  /// <summary>
  /// The name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.buildingblocktype.name?view=word-pia"/>
  public string Name { get; }
  /// <summary>
  /// The categories.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.buildingblocktype.categories?view=word-pia"/>
  public Categories Categories { get; }

}

namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents an individual category of a building block type.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.category?view=word-pia"/>
public interface ICategory : IModelObject
{
  /// <summary>
  /// Gets the index number of the category in the collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.category.index?view=word-pia"/>
  public int Index { get; }
  /// <summary>
  /// Gets the name of the category.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.category.name?view=word-pia"/>
  public string Name { get; }
  /// <summary>
  /// Gets the collection of building blocks in the category.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.category.buildingblocks?view=word-pia"/>
  public IBuildingBlocks BuildingBlocks { get; }
  /// <summary>
  /// Gets the building block type that contains this category.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.category.type?view=word-pia"/>
  public IBuildingBlockType Type { get; }

}

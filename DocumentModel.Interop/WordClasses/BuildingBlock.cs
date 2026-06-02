namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a building block in a template. A building block is pre-built content, similar to autotext, that may contain text, images, and formatting.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.buildingblock?view=word-pia"/>
public partial class BuildingBlock : InteropObject
{
  /// <summary>
  /// Gets the index number of the building block in the collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.buildingblock.index?view=word-pia"/>
  public int Index { get; set; }

  /// <summary>
  /// Gets or sets the name of the building block.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.buildingblock.name?view=word-pia"/>
  public string? Name { get; set; }

  /// <summary>
  /// Gets the building block type that contains this building block.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.buildingblock.type?view=word-pia"/>
  public BuildingBlockType Type { get; set; }

  /// <summary>
  /// Gets or sets the description of the building block.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.buildingblock.description?view=word-pia"/>
  public string? Description { get; set; }

  /// <summary>
  /// Gets the unique identifier of the building block.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.buildingblock.id?view=word-pia"/>
  public string? ID { get; set; }

  /// <summary>
  /// Gets the category of the building block.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.buildingblock.category?view=word-pia"/>
  public Category Category { get; set; }

  /// <summary>
  /// Gets or sets the content of the building block.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.buildingblock.value?view=word-pia"/>
  public string? Value { get; set; }

  /// <summary>
  /// Gets or sets the insertion behavior options for the building block.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.buildingblock.insertoptions?view=word-pia"/>
  public int InsertOptions { get; set; }
}

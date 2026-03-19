namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents an individual category of a building block type.
/// </summary>
public interface Category : InteropObject
{
  /// <summary>
  /// The index.
  /// </summary>
  public int Index { get; }
  /// <summary>
  /// The name.
  /// </summary>
  public string Name { get; }
  /// <summary>
  /// The building blocks.
  /// </summary>
  public BuildingBlocks BuildingBlocks { get; }
  /// <summary>
  /// The type.
  /// </summary>
  public BuildingBlockType Type { get; }

}

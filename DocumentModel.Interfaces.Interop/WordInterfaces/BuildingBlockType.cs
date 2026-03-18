namespace DocumentModel.Interop;

/// <summary>
/// Represents a type of building block. Each BuildingBlockType object is a member of the BuildingBlockTypes collection.
/// </summary>
public interface BuildingBlockType : InteropObject
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
  /// The categories.
  /// </summary>
  public Categories Categories { get; }

}

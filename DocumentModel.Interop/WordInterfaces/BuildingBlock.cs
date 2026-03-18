namespace DocumentModel.Interop;

/// <summary>
/// Represents a building block in a template. A building block is pre-built content, similar to autotext, that may contain text, images, and formatting.
/// </summary>
public partial interface BuildingBlock : InteropObject
{
  /// <summary>
  /// The index.
  /// </summary>
  public int Index { get; }

  /// <summary>
  /// The name.
  /// </summary>
  public string Name { get; set; }

  /// <summary>
  /// The type.
  /// </summary>
  public BuildingBlockType Type { get; }

  /// <summary>
  /// The description.
  /// </summary>
  public string Description { get; set; }

  /// <summary>
  /// The id.
  /// </summary>
  public string ID { get; }

  /// <summary>
  /// The category.
  /// </summary>
  public Category Category { get; }

  /// <summary>
  /// The value.
  /// </summary>
  public string Value { get; set; }

  /// <summary>
  /// The insert options.
  /// </summary>
  public int InsertOptions { get; set; }
}

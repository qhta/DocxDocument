namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a collection of BuildingBlock objects for a specific building block type and category in a template.
/// </summary>
public partial interface BuildingBlocks : InteropObject
{
  /// <summary>
  /// The count.
  /// </summary>
  public int Count { get; }
}

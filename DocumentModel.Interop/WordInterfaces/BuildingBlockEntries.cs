namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a collection of all BuildingBlock objects in a template.
/// </summary>
public partial interface BuildingBlockEntries : InteropObject
{
  /// <summary>
  /// The count.
  /// </summary>
  public int Count { get; }
}

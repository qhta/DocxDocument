namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Category.
/// </summary>
public interface Category: CollectionItem
{
  /// <summary>
  ///   Category Type
  /// </summary>
  public string? Type { get; set; }
  /// <summary>
  ///   Priority
  /// </summary>
  public UInt32? Priority { get; set; }
}
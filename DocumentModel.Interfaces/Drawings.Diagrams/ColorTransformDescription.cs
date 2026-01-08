namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Description.
/// </summary>
public interface ColorTransformDescription: CollectionItem
{
  /// <summary>
  ///   Language
  /// </summary>
  public string? Language { get; set; }
  /// <summary>
  ///   Description Value
  /// </summary>
  public string? Val { get; set; }
}
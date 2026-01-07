namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Title.
/// </summary>
public interface ColorDefinitionTitle: CollectionItem, IEquatable<ColorDefinitionTitle>
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
namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Title.
/// </summary>
public interface StyleDefinitionTitle: CollectionItem
{
  /// <summary>
  ///   Natural Language
  /// </summary>
  public string? Language { get; set; }
  /// <summary>
  ///   Description Value
  /// </summary>
  public string? Val { get; set; }
}
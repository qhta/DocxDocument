namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a style set in a Wordprocessing document.
/// This interface provides properties for the style set identifier and value, enabling management and configuration of style sets for document formatting.
/// </summary>
public interface StyleSet : CollectionItem
{
  /// <summary>
  /// Identifier for the style set.
  /// </summary>
  public UInt32? Id { get; set; }

  /// <summary>
  /// Value indicating the state or setting of the style set.
  /// </summary>
  public OnOffKind? Val { get; set; }
}
namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents a single spelling suggestion.
/// </summary>
public interface SpellingSuggestion: CollectionItem
{
  /// <summary>
  ///   Gets the suggested spelling.
  /// </summary>
  public string? Text { get; }

  /// <summary>
  ///   Gets the parent suggestions collection.
  /// </summary>
  public SpellingSuggestions? Parent { get; }

  /// <summary>
  ///   Gets the application object.
  /// </summary>
  public Application? Application { get; }
}
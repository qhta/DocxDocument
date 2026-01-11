namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents a single spelling suggestion in a WordprocessingML document.
///   This interface extends <see cref="CollectionItem"/> and provides properties for the suggested spelling text, the parent suggestions collection, and the application object, enabling advanced spelling correction and suggestion workflows.
/// </summary>
public interface SpellingSuggestion : CollectionItem
{
  /// <summary>
  ///   Suggested spelling text for the word or phrase.
  /// </summary>
  public string? Text { get; set; }

}
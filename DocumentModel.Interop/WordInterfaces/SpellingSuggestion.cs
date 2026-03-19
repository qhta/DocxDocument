namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single spelling suggestion for a misspelled word.
/// </summary>
public interface SpellingSuggestion : InteropObject
{
  /// <summary>
  /// The name.
  /// </summary>
  public string Name { get; }

}

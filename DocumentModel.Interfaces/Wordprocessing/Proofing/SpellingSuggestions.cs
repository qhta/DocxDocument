namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents a collection of spelling suggestions for a misspelled word.
/// </summary>
public interface SpellingSuggestions : IElementCollection<SpellingSuggestion>
{
  #region Collection Properties

  /// <summary>
  ///   Gets the number of suggestions.
  /// </summary>
  public int Count { get; }

  #endregion

  #region Item Access

  /// <summary>
  ///   Gets a spelling suggestion by its index.
  /// </summary>
  /// <param name="index">The one-based index of the suggestion.</param>
  /// <returns>The suggestion at the specified index.</returns>
  public SpellingSuggestion? Item(int index);

  #endregion

  #region Parent and Application

  /// <summary>
  ///   Gets the parent object.
  /// </summary>
  public object? Parent { get; }

  /// <summary>
  ///   Gets the application object.
  /// </summary>
  public Application? Application { get; }

  #endregion
}
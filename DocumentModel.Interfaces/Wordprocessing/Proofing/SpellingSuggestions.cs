namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents a collection of spelling suggestions for a misspelled word.
/// </summary>
public interface SpellingSuggestions : ElementCollection<SpellingSuggestion>
{
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
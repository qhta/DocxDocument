namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents a collection of words in a document, selection, range, or sentence.
/// </summary>
/// <remarks>
///   <para>
///   The Words interface provides access to individual words within text content.
///   A word is typically defined as a sequence of characters bounded by whitespace
///   or punctuation, though the exact definition may vary by language.
///   </para>
///   <para>
///   For Asian languages like Chinese and Japanese, word boundaries may be determined
///   by different rules and may require language-specific word-breaking algorithms.
///   </para>
/// </remarks>
public interface Words : ElementCollection<Word>
{
  #region Parent and Application

  /// <summary>
  ///   Gets the parent object that contains this words collection.
  /// </summary>
  public object? Parent { get; }

  /// <summary>
  ///   Gets the application object.
  /// </summary>
  public Application? Application { get; }

  #endregion
}
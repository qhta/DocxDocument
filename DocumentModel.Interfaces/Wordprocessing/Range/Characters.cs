namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents a collection of characters in a document, selection, range, sentence, or word.
/// </summary>
/// <remarks>
///   Each character in the collection includes not only text characters but also
///   special characters like spaces, tabs, paragraph marks, and other formatting marks.
/// </remarks>
public interface Characters : IElementCollection<Character>
{
  #region Collection Properties

  /// <summary>
  ///   Gets the number of characters in the collection.
  /// </summary>
  public int Count { get; }

  /// <summary>
  ///   Gets the first character in the collection.
  /// </summary>
  public Character? First { get; }

  /// <summary>
  ///   Gets the last character in the collection.
  /// </summary>
  public Character? Last { get; }

  #endregion

  #region Item Access

  /// <summary>
  ///   Gets a character by its index in the collection.
  /// </summary>
  /// <param name="index">The one-based index of the character to retrieve.</param>
  /// <returns>The character at the specified index.</returns>
  public Character? Item(int index);

  #endregion

  #region Parent and Application

  /// <summary>
  ///   Gets the parent object that contains this characters collection.
  /// </summary>
  public object? Parent { get; }

  /// <summary>
  ///   Gets the application object.
  /// </summary>
  public Application? Application { get; }

  #endregion
}
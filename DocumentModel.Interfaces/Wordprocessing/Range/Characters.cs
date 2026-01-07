namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents a collection of characters in a document, selection, range, sentence, or word.
/// </summary>
/// <remarks>
///   Each character in the collection includes not only text characters but also
///   special characters like spaces, tabs, paragraph marks, and other formatting marks.
/// </remarks>
public interface Characters : ElementCollection<Character>
{
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
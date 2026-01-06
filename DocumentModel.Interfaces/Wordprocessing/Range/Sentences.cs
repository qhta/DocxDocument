namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents a collection of sentences in a document, selection, or range.
/// </summary>
/// <remarks>
///   <para>
///   The Sentences interface provides access to individual sentences within text content.
///   A sentence is typically defined as text ending with a period, exclamation mark, question mark,
///   or other sentence-ending punctuation, though the exact definition may vary by language.
///   </para>
///   <para>
///   This corresponds to the Microsoft.Office.Interop.Word.Sentences interface and extends
///   the base collection interface with Word-specific functionality for sentence manipulation.
///   </para>
/// </remarks>
public interface Sentences : IElementCollection<Sentence>
{
  #region Collection Properties

  /// <summary>
  ///   Gets the number of sentences in the collection.
  /// </summary>
  /// <remarks>
  ///   Returns the total count of sentences. This may be an expensive operation
  ///   if sentences need to be parsed from the text.
  /// </remarks>
  public int Count { get; }

  /// <summary>
  ///   Gets the first sentence in the collection.
  /// </summary>
  /// <remarks>
  ///   Provides quick access to the first sentence without enumerating the collection.
  /// </remarks>
  public Sentence? First { get; }

  /// <summary>
  ///   Gets the last sentence in the collection.
  /// </summary>
  /// <remarks>
  ///   Provides quick access to the last sentence without enumerating the collection.
  /// </remarks>
  public Sentence? Last { get; }

  #endregion

  #region Item Access

  /// <summary>
  ///   Gets a sentence by its index in the collection.
  /// </summary>
  /// <param name="index">The one-based index of the sentence to retrieve.</param>
  /// <returns>The sentence at the specified index.</returns>
  /// <remarks>
  ///   Note: Word uses one-based indexing, so the first sentence is at index 1.
  /// </remarks>
  public Sentence? Item(int index);

  #endregion

  #region Parent and Application

  /// <summary>
  ///   Gets the parent object that contains this sentences collection.
  /// </summary>
  /// <remarks>
  ///   Typically a Range, Selection, or Document object.
  /// </remarks>
  public object? Parent { get; }

  /// <summary>
  ///   Gets the application object.
  /// </summary>
  public Application? Application { get; }

  #endregion
}
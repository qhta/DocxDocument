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
public interface Sentences : ElementCollection<Sentence>
{
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
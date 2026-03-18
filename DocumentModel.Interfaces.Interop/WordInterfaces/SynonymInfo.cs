namespace DocumentModel.Interop;

/// <summary>
/// Represents the information about synonyms, antonyms, related words, or related expressions for the specified range or a given string.
/// </summary>
public partial interface SynonymInfo : InteropObject
{
  /// <summary>
  /// The word.
  /// </summary>
  public string Word { get; }

  /// <summary>
  /// The found.
  /// </summary>
  public bool Found { get; }

  /// <summary>
  /// The meaning count.
  /// </summary>
  public int MeaningCount { get; }

  /// <summary>
  /// The meaning list.
  /// </summary>
  public object MeaningList { get; }

  /// <summary>
  /// The part of speech list.
  /// </summary>
  public object PartOfSpeechList { get; }

  /// <summary>
  /// The antonym list.
  /// </summary>
  public object AntonymList { get; }

  /// <summary>
  /// The related expression list.
  /// </summary>
  public object RelatedExpressionList { get; }

  /// <summary>
  /// The related word list.
  /// </summary>
  public object RelatedWordList { get; }
}

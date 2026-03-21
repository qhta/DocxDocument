namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the information about synonyms, antonyms, related words, or related expressions for the specified range or a given string.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.synonyminfo?view=word-pia"/>
public partial interface SynonymInfo : InteropObject
{
  /// <summary>
  /// The word.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.synonyminfo.word?view=word-pia"/>
  public string Word { get; }

  /// <summary>
  /// The found.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.synonyminfo.found?view=word-pia"/>
  public bool Found { get; }

  /// <summary>
  /// The meaning count.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.synonyminfo.meaningcount?view=word-pia"/>
  public int MeaningCount { get; }

  /// <summary>
  /// The meaning list.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.synonyminfo.meaninglist?view=word-pia"/>
  public object MeaningList { get; }

  /// <summary>
  /// The part of speech list.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.synonyminfo.partofspeechlist?view=word-pia"/>
  public object PartOfSpeechList { get; }

  /// <summary>
  /// The antonym list.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.synonyminfo.antonymlist?view=word-pia"/>
  public object AntonymList { get; }

  /// <summary>
  /// The related expression list.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.synonyminfo.relatedexpressionlist?view=word-pia"/>
  public object RelatedExpressionList { get; }

  /// <summary>
  /// The related word list.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.synonyminfo.relatedwordlist?view=word-pia"/>
  public object RelatedWordList { get; }
}

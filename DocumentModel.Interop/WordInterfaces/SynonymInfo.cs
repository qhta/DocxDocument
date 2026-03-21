namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the information about synonyms, antonyms, related words, or related expressions for the specified range or a given string.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.synonyminfo?view=word-pia"/>
public partial interface SynonymInfo : InteropObject
{
  /// <summary>
  /// Returns the word.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.synonyminfo.word?view=word-pia"/>
  public string Word { get; }

  /// <summary>
  /// Returns whether found.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.synonyminfo.found?view=word-pia"/>
  public bool Found { get; }

  /// <summary>
  /// Returns the meaning count.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.synonyminfo.meaningcount?view=word-pia"/>
  public int MeaningCount { get; }

  /// <summary>
  /// Returns the meaning list.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.synonyminfo.meaninglist?view=word-pia"/>
  public object MeaningList { get; }

  /// <summary>
  /// Returns the part of speech list.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.synonyminfo.partofspeechlist?view=word-pia"/>
  public object PartOfSpeechList { get; }

  /// <summary>
  /// Returns the antonym list.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.synonyminfo.antonymlist?view=word-pia"/>
  public object AntonymList { get; }

  /// <summary>
  /// Returns the related expression list.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.synonyminfo.relatedexpressionlist?view=word-pia"/>
  public object RelatedExpressionList { get; }

  /// <summary>
  /// Returns the related word list.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.synonyminfo.relatedwordlist?view=word-pia"/>
  public object RelatedWordList { get; }
}

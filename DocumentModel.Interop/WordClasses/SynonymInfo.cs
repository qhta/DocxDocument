namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the information about synonyms, antonyms, related words, or related expressions for the specified
/// range or a given string.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.synonyminfo?view=word-pia"/>
public partial class SynonymInfo : InteropObject
{
  /// <summary>
  /// Returns the word or phrase that was looked up by the thesaurus.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.synonyminfo.word?view=word-pia"/>
  public string Word { get; }

  /// <summary>
  /// True if the thesaurus finds synonyms, antonyms, related words, or related expressions for the word or phrase.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.synonyminfo.found?view=word-pia"/>
  public bool Found { get; }

  /// <summary>
  /// Returns the number of entries in the list of meanings found in the thesaurus for the word or phrase. Returns 0
  /// (zero) if no meanings were found.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.synonyminfo.meaningcount?view=word-pia"/>
  public int MeaningCount { get; }

  /// <summary>
  /// Returns the list of meanings for the word or phrase. The list is returned as an array of strings.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.synonyminfo.meaninglist?view=word-pia"/>
  public object MeaningList { get; }

  /// <summary>
  /// Returns a list of the parts of speech corresponding to the meanings found for the word or phrase looked up in
  /// the thesaurus. The list is returned as an array of integers.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.synonyminfo.partofspeechlist?view=word-pia"/>
  public object PartOfSpeechList { get; }

  /// <summary>
  /// Returns a list of antonyms for the word or phrase. The list is returned as an array of strings.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.synonyminfo.antonymlist?view=word-pia"/>
  public object AntonymList { get; }

  /// <summary>
  /// Returns a list of expressions related to the specified word or phrase. The list is returned as an array of
  /// strings.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.synonyminfo.relatedexpressionlist?view=word-pia"/>
  public object RelatedExpressionList { get; }

  /// <summary>
  /// Returns a list of words related to the specified word or phrase. The list is returned as an array of strings.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.synonyminfo.relatedwordlist?view=word-pia"/>
  public object RelatedWordList { get; }
}

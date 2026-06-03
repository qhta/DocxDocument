namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of SpellingSuggestion objects that represent all the suggestions for a specified word or for the
/// first word in the specified range.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.spellingsuggestions?view=word-pia"/>
public interface ISpellingSuggestions : IInteropObject, IInteropCollection<ISpellingSuggestion>
{
  /// <summary>
  /// Returns the spelling error type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.spellingsuggestions.spellingerrortype?view=word-pia"/>
  public SpellingErrorType SpellingErrorType { get; }
}

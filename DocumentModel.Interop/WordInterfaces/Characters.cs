namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of characters in a selection, range, or document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.characters?view=word-pia"/>
public interface Characters : InteropObject, InteropCollection<Range>
{
  /// <summary>
  /// Gets the first character in the collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.characters.first?view=word-pia"/>
  public Range First { get; }
  /// <summary>
  /// Gets the last character in the collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.characters.last?view=word-pia"/>
  public Range Last { get; }
}

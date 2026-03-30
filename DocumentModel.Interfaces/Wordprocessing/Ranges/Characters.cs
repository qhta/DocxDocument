namespace DocumentModel.Wordprocessing;

/// <summary>
/// A collection of characters in a selection, range, or document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.characters?view=word-pia"/>
public interface ICharacters : IModelCollection<IRange>
{
  /// <summary>
  /// Gets the first character in the collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.characters.first?view=word-pia"/>
  public IRange First { get; }
  /// <summary>
  /// Gets the last character in the collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.characters.last?view=word-pia"/>
  public IRange Last { get; }
}

namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of characters in a selection, range, or document.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.characters?view=word-pia"/>
public interface Characters : InteropObject, InteropCollection<Range>
{
  /// <summary>
  /// The first.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.characters.first?view=word-pia"/>
  public Range First { get; }
  /// <summary>
  /// The last.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.characters.last?view=word-pia"/>
  public Range Last { get; }
}

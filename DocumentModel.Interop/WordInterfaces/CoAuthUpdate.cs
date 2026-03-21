namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a range of text that has been updated by a co-author.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.coauthupdate?view=word-pia"/>
public interface CoAuthUpdate : InteropObject
{
  /// <summary>
  /// The range.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.coauthupdate.range?view=word-pia"/>
  public Range Range { get; }

}

namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a range of text that has been updated by a co-author.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.coauthupdate?view=word-pia"/>
public interface CoAuthUpdate : InteropObject
{
  /// <summary>
  /// The range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.coauthupdate.range?view=word-pia"/>
  public Range Range { get; }

}

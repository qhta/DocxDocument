namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single e-mail signature entry.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailsignatureentry?view=word-pia"/>
public partial interface EmailSignatureEntry : InteropObject
{
  /// <summary>
  /// The index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailsignatureentry.index?view=word-pia"/>
  public int Index { get; }

  /// <summary>
  /// The name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailsignatureentry.name?view=word-pia"/>
  public string Name { get; set; }
}

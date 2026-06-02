namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single e-mail signature entry.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailsignatureentry?view=word-pia"/>
public partial class EmailSignatureEntry : InteropObject
{
  /// <summary>
  /// Gets the index number of the email signature entry in the collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailsignatureentry.index?view=word-pia"/>
  public int Index { get; set; }

  /// <summary>
  /// Gets or sets the name of the email signature entry.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailsignatureentry.name?view=word-pia"/>
  public string? Name { get; set; }


  #region methods

/// <summary>
  /// Deletes the specified object.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailsignatureentry.delete?view=word-pia"/>
  public void Delete() { throw new NotImplementedException(); }

  #endregion methods
}

namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of EmailSignatureEntry objects that represents all the e-mail signature entries available to Microsoft Word.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailsignatureentries?view=word-pia"/>
public partial interface IEmailSignatureEntries : IInteropObject, IInteropCollection<EmailSignatureEntry>
{


  #region methods

/// <summary>
  /// Returns the value produced by the add operation.
  /// </summary>
  /// <param name="Name">Specifies the name.</param>
  /// <param name="Range">Specifies the range.</param>
  /// <returns>The resulting value.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailsignatureentries.add?view=word-pia"/>
  public EmailSignatureEntry Add(string Name, Range Range);

  #endregion methods
}

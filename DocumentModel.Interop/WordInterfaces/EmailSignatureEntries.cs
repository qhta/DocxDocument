namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of EmailSignatureEntry objects that represents all the e-mail signature entries available to Microsoft Word.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailsignatureentries?view=word-pia"/>
public partial interface IEmailSignatureEntries : IInteropObject, IInteropCollection<EmailSignatureEntry>
{
}

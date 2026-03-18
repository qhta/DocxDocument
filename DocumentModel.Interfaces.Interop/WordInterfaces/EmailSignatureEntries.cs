namespace DocumentModel.Interop;

/// <summary>
/// A collection of EmailSignatureEntry objects that represents all the e-mail signature entries available to Microsoft Word.
/// </summary>
public partial interface EmailSignatureEntries : InteropObject, InteropCollection<EmailSignatureEntry>
{
}

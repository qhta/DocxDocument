namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of MailMergeField objects that represent the mail merge related fields in a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefields?view=word-pia"/>
public partial interface MailMergeFields : InteropObject, InteropCollection<MailMergeField>
{
}

namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the mail merge field objects in a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefields?view=word-pia"/>
public partial interface IMailMergeFields : IInteropObject, IInteropCollection<MailMergeField>
{
}

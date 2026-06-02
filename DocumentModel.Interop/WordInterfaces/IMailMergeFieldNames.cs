namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the mail merge field name objects in a mail merge data source.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefieldnames?view=word-pia"/>
public interface IMailMergeFieldNames : IInteropObject, IInteropCollection<MailMergeFieldName>
{
}

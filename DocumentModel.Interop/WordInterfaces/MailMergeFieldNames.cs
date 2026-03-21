namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of MailMergeFieldName objects that represent the field names in a mail merge data source.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefieldnames?view=word-pia"/>
public interface MailMergeFieldNames : InteropObject, InteropCollection<MailMergeFieldName>
{
}

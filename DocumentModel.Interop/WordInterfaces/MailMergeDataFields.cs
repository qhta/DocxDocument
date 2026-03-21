namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of MailMergeDataField objects that represent the data fields in a mail merge data source.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatafields?view=word-pia"/>
public interface MailMergeDataFields : InteropObject, InteropCollection<MailMergeDataField>
{
}

namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the mail merge data field objects in a mail merge data source.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatafields?view=word-pia"/>
public interface IMailMergeDataFields : IInteropObject, IInteropCollection<IMailMergeDataField>
{
}

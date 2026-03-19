namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of MailMergeField objects that represent the mail merge related fields in a document.
/// </summary>
public partial interface MailMergeFields : InteropObject, InteropCollection<MailMergeField>
{
}

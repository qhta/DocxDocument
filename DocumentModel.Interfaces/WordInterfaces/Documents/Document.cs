namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.document?view=word-pia"/>
public interface Document : _Document, DocumentEvents2_Event
{
}

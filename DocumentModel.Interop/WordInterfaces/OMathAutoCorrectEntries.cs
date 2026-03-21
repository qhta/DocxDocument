namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a collection of math AutoCorrect entries. Use the OMathAutoCorrectEntry object to access individual AutoCorrect entries.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathautocorrectentries?view=word-pia"/>
public partial interface OMathAutoCorrectEntries : InteropObject, InteropCollection<OMathAutoCorrectEntry>
{
}

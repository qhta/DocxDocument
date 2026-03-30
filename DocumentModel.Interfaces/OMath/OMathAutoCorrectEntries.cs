namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the collection of math AutoCorrect entries.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathautocorrectentries?view=word-pia"/>
public partial interface OMathAutoCorrectEntries : IModelCollection<OMathAutoCorrectEntry>
{
}

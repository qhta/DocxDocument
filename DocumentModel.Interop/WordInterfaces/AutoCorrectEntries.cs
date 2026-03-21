namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of AutoCorrectEntry objects that represent all the AutoCorrect entries available to Microsoft Word. The AutoCorrectEntries collection includes all the entries in the AutoCorrect dialog box (Tools menu).
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocorrectentries?view=word-pia"/>
public partial interface AutoCorrectEntries : InteropObject, InteropCollection<AutoCorrectEntry>
{
}

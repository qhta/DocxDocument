namespace DocumentModel.Wordprocessing;

/// <summary>
/// A collection of AutoCorrectEntry objects that represent all the AutoCorrect entries available to Microsoft Word. The AutoCorrectEntries collection includes all the entries in the AutoCorrect dialog box (Tools menu).
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocorrectentries?view=word-pia"/>
public partial interface IAutoCorrectEntries : IModelCollection<IAutoCorrectEntry>
{
}

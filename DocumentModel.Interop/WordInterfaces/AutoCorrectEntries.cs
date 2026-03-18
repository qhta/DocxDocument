namespace DocumentModel.Interop;

/// <summary>
/// A collection of AutoCorrectEntry objects that represent all the AutoCorrect entries available to Microsoft Word. The AutoCorrectEntries collection includes all the entries in the AutoCorrect dialog box (Tools menu).
/// </summary>
public partial interface AutoCorrectEntries : InteropObject, InteropCollection<AutoCorrectEntry>
{
}

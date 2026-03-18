namespace DocumentModel.Interop;

/// <summary>
/// A collection of OtherCorrectionsException objects that represents the list of words that Microsoft Word won't correct automatically. This list corresponds to the list of AutoCorrect exceptions on the Other Corrections tab in the AutoCorrect Exceptions dialog box (AutoCorrect command, Tools menu).
/// </summary>
public partial interface OtherCorrectionsExceptions : InteropObject, InteropCollection<OtherCorrectionsException>
{
}

namespace DocumentModel.Wordprocessing;

/// <summary>
/// A collection of OtherCorrectionsException objects that represents the list of words that Microsoft Word won't
/// correct automatically. This list corresponds to the list of AutoCorrect exceptions on the Other Corrections
/// tab in the AutoCorrect Exceptions dialog box (AutoCorrect command, Tools menu).
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.othercorrectionsexceptions?view=word-pia"/>
public partial interface OtherCorrectionsExceptions : InteropObject, InteropCollection<OtherCorrectionsException>
{
}

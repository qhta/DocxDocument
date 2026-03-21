namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of HangulAndAlphabetException objects that represents all Hangul and alphabet AutoCorrect exceptions. This list corresponds to the list of AutoCorrect exceptions on the Korean tab in the AutoCorrect Exceptions dialog box (AutoCorrect command, Tools menu).
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hangulandalphabetexceptions?view=word-pia"/>
public partial interface HangulAndAlphabetExceptions : InteropObject, InteropCollection<HangulAndAlphabetException>
{
}

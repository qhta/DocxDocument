namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the collection of words that Word does not correct automatically.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.othercorrectionsexceptions?view=word-pia"/>
public partial interface OtherCorrectionsExceptions : InteropObject, InteropCollection<OtherCorrectionsException>
{
}

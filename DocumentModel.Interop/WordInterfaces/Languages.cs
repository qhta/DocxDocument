namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of Language objects that represent languages used for proofing or formatting in Microsoft Word.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.languages?view=word-pia"/>
public interface Languages : InteropObject, InteropCollection<Language>
{
}

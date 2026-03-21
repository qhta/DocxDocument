namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of FirstLetterException objects that represent the abbreviations excluded from automatic correction.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.firstletterexceptions?view=word-pia"/>
public partial interface FirstLetterExceptions : InteropObject, InteropCollection<FirstLetterException>
{
}

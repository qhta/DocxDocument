namespace DocumentModel.Wordprocessing;

/// <summary>
/// A collection of FirstLetterException objects that represent the abbreviations excluded from automatic correction.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.firstletterexceptions?view=word-pia"/>
public partial interface FirstLetterExceptions : IModelCollection<FirstLetterException>
{
}

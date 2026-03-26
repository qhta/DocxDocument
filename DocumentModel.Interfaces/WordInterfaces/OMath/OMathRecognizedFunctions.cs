namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the collection of recognized math functions.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathrecognizedfunctions?view=word-pia"/>
public partial interface OMathRecognizedFunctions : InteropObject, InteropCollection<OMathRecognizedFunction>
{
}

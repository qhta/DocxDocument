namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a collection of recognized functions. Use the OMathRecognizedFunction object to access individual members of the collection.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathrecognizedfunctions?view=word-pia"/>
public partial interface OMathRecognizedFunctions : InteropObject, InteropCollection<OMathRecognizedFunction>
{
}

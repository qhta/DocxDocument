namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the collection of recognized math functions.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathrecognizedfunctions?view=word-pia"/>
public partial interface IOMathRecognizedFunctions : IInteropObject, IInteropCollection<OMathRecognizedFunction>
{
}

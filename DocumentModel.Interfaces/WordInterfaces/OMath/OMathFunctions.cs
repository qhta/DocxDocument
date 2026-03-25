namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the collection of equation function objects.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfunctions?view=word-pia"/>
public partial interface OMathFunctions : InteropObject, InteropCollection<OMathFunction>
{
}

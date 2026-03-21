namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a collection of functions or structures that Microsoft Office Word supports, such as fractions, integrals, sums, and radicals.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfunctions?view=word-pia"/>
public partial interface OMathFunctions : InteropObject, InteropCollection<OMathFunction>
{
}

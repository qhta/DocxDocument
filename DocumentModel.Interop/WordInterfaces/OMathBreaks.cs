namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a collection of OMathBreak objects that represent all the line breaks in an equation.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathbreaks?view=word-pia"/>
public partial interface OMathBreaks : InteropObject, InteropCollection<OMathBreak>
{

}

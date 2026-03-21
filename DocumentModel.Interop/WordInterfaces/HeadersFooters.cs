namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of HeaderFooter objects that represent the headers or footers in the specified section of a document.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.headersfooters?view=word-pia"/>
public partial interface HeadersFooters : InteropObject, InteropCollection<HeaderFooter>
{
}

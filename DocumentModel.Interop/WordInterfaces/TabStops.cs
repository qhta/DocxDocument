namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of TabStop objects that represent the custom and default tabs for a paragraph or group of paragraphs.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tabstops?view=word-pia"/>
public partial interface TabStops : InteropObject, InteropCollection<TabStop>
{
}

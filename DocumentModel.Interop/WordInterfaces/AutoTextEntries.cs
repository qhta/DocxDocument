namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of AutoTextEntry objects that represent the AutoText entries in a template.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autotextentries?view=word-pia"/>
public partial interface AutoTextEntries : InteropObject, InteropCollection<AutoTextEntry>
{
}

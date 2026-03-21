namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of all the LegendEntry objects in the specified chart legend.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendentries?view=word-pia"/>
public interface LegendEntries : InteropObject, InteropCollection<LegendEntry>
{
}

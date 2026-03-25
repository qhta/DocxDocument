namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the full collection of all chart series, both filtered and unfiltered.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fullseriescollection?view=word-pia"/>
public interface FullSeriesCollection : InteropObject, InteropCollection<Series>
{
}

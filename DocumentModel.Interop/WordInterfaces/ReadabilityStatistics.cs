namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of ReadabilityStatistic objects for a document or range.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.readabilitystatistics?view=word-pia"/>
public interface ReadabilityStatistics : InteropObject, InteropCollection<ReadabilityStatistic>
{
}

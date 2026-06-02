namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of ReadabilityStatistic objects for a document or range.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.readabilitystatistics?view=word-pia"/>
public interface IReadabilityStatistics : IInteropObject, IInteropCollection<ReadabilityStatistic>
{
}

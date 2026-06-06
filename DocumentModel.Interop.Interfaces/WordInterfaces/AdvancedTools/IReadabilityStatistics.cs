namespace DocumentModel.Interop.Word;

/// <summary>
/// Microsoft Word’s Readability Statistics is a built-in tool that evaluates the clarity and reading level of your writing.
/// It calculates sentence length, vocabulary complexity, and passive voice to provide a detailed report on how easy your text is to understand.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.readabilitystatistics?view=word-pia"/>
public interface IReadabilityStatistics : IInteropObject, IInteropCollection<IReadabilityStatistic>
{
}

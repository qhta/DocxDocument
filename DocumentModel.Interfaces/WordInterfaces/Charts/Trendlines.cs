namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of all the Trendline objects for the specified series.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.trendlines?view=word-pia"/>
public partial interface Trendlines : InteropObject, InteropCollection<Trendline>
{
}

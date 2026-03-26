namespace DocumentModel.Wordprocessing;

/// <summary>
/// A collection of all the Series objects in the specified chart or chart group.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.seriescollection?view=word-pia"/>
public partial interface SeriesCollection : InteropObject, InteropCollection<Series>
{
}

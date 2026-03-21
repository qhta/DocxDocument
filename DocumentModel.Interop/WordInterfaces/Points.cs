namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of all the Point objects in the specified series in a chart.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.points?view=word-pia"/>
public interface Points : InteropObject, InteropCollection<Point>
{
}

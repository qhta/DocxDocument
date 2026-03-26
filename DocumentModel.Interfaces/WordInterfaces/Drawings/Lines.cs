namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the line objects in a rectangle of type wdTextRectangle.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.lines?view=word-pia"/>
public interface Lines : InteropObject, InteropCollection<Line>
{
}

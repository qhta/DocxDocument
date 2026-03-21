namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of Line objects that represents the lines in a Rectangle object that is of type wdTextRectangle.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.lines?view=word-pia"/>
public interface Lines : InteropObject, InteropCollection<Line>
{
}

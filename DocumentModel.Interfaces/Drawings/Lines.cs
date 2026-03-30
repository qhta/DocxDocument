namespace DocumentModel.Drawings;

/// <summary>
/// Represents the line objects in a rectangle of type wdTextRectangle.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.lines?view=word-pia"/>
public interface ILines : IModelCollection<ILine>
{
}

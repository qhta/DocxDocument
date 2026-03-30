namespace DocumentModel.Drawings;

/// <summary>
/// A collection of Rectangle objects in a page that represent portions of text and graphics. Use the Rectangles
/// collection and related objects and properties for programmatically defining page layout in a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rectangles?view=word-pia"/>
public interface IRectangles : IModelCollection<IRectangle>
{
}

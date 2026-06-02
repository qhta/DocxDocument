namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of Shape objects that represent all the shapes in a document or all the shapes in all the headers
/// and footers in a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shapes?view=word-pia"/>
public partial interface IShapes : IInteropObject, IInteropCollection<Shape>
{
}

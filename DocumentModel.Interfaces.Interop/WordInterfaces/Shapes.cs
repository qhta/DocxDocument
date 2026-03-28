namespace DocumentModel.Interop;

/// <summary>
/// A collection of Shape objects that represent all the shapes in a document or all the shapes in all the headers and footers in a document.
/// </summary>
public partial interface Shapes : InteropObject, InteropCollection<Shape>
{
}

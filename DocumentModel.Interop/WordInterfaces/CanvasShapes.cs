namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the shapes in a drawing canvas.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.canvasshapes?view=word-pia"/>
public partial interface ICanvasShapes : IInteropObject, IInteropCollection<Shape>
{
}

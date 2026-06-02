namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of all the ShapeNode objects in the specified freeform.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shapenodes?view=word-pia"/>
public partial interface IShapeNodes : IInteropObject, IInteropCollection<ShapeNode>
{
}

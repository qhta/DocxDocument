namespace DocumentModel.Drawings;

/// <summary>
/// A collection of all the ShapeNode objects in the specified freeform.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shapenodes?view=word-pia"/>
public partial interface ShapeNodes : IModelObject, IModelCollection<ShapeNode>
{
}

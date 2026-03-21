namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of all the ShapeNode objects in the specified freeform.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shapenodes?view=word-pia"/>
public partial interface ShapeNodes : InteropObject, InteropCollection<ShapeNode>
{
}

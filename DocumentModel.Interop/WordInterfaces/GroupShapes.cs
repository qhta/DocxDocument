namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the individual shapes within a grouped shape.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.groupshapes?view=word-pia"/>
public partial interface GroupShapes : InteropObject, InteropCollection<Shape>
{
}

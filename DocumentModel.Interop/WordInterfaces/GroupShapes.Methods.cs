namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.groupshapes?view=word-pia"/>
public partial interface GroupShapes
{
 /// <summary>
 /// Returns one or more shapes from the group.
 /// </summary>
 /// <param name="Index">The index number or name of the shape, or an array of indexes or names.</param>
 /// <returns>A <see cref="ShapeRange"/> object that represents the requested shapes.</returns>
 /// <remarks>
 /// Microsoft Learn API reference.
 /// </remarks>
 /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.groupshapes.range?view=word-pia"/>
 public ShapeRange Range(object Index);
}

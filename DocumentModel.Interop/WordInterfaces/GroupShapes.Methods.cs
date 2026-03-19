namespace DocumentModel.Interop.Word;

public partial interface GroupShapes
{
 /// <summary>
 /// Returns one or more shapes from the group.
 /// </summary>
 /// <param name="Index">The index number or name of the shape, or an array of indexes or names.</param>
 /// <returns>A <see cref="ShapeRange"/> object that represents the requested shapes.</returns>
 public ShapeRange Range(object Index);
}

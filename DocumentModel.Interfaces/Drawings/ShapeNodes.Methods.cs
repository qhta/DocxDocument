namespace DocumentModel.Drawings;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shapenodes?view=word-pia"/>
public partial interface IShapeNodes : IModelObject
{
  /// <summary>
  /// Deletes the shape node at the specified index.
  /// </summary>
  /// <param name="Index">The index of the node to delete.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shapenodes.delete?view=word-pia"/>
  public void Delete(int Index);

  /// <summary>
  /// Sets the editing type for the shape node at the specified index.
  /// </summary>
  /// <param name="Index">The index of the node to modify.</param>
  /// <param name="EditingType">The editing type to set.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shapenodes.seteditingtype?view=word-pia"/>
  public void SetEditingType(int Index, Drawings.EditingType EditingType);

  /// <summary>
  /// Sets the position of the shape node at the specified index.
  /// </summary>
  /// <param name="Index">The index of the node to move.</param>
  /// <param name="X1">The new x-coordinate for the node.</param>
  /// <param name="Y1">The new y-coordinate for the node.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shapenodes.setposition?view=word-pia"/>
  public void SetPosition(int Index, float X1, float Y1);

  /// <summary>
  /// Sets the segment type for the shape node at the specified index.
  /// </summary>
  /// <param name="Index">The index of the node to modify.</param>
  /// <param name="SegmentType">The segment type to set.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shapenodes.setsegmenttype?view=word-pia"/>
  public void SetSegmentType(int Index, Drawings.SegmentType SegmentType);

  /// <summary>
  /// Inserts a new shape node at the specified index.
  /// </summary>
  /// <param name="Index">The index at which to insert the new node.</param>
  /// <param name="SegmentType">The segment type of the new node.</param>
  /// <param name="EditingType">The editing type of the new node.</param>
  /// <param name="X1">The x-coordinate of the first point.</param>
  /// <param name="Y1">The y-coordinate of the first point.</param>
  /// <param name="X2">The x-coordinate of the second point.</param>
  /// <param name="Y2">The y-coordinate of the second point.</param>
  /// <param name="X3">The x-coordinate of the third point.</param>
  /// <param name="Y3">The y-coordinate of the third point.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shapenodes.insert?view=word-pia"/>
  public void Insert(int Index, Drawings.SegmentType SegmentType, Drawings.EditingType EditingType, float X1, float Y1, float X2, float Y2, float X3, float Y3);
}

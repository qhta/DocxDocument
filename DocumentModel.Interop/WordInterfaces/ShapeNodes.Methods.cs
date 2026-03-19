namespace DocumentModel.Interop.Word;

public partial interface ShapeNodes
{
  /// <summary>
  /// Deletes the shape node at the specified index.
  /// </summary>
  /// <param name="Index">The index of the node to delete.</param>
  public void Delete(int Index);

  /// <summary>
  /// Sets the editing type for the shape node at the specified index.
  /// </summary>
  /// <param name="Index">The index of the node to modify.</param>
  /// <param name="EditingType">The editing type to set.</param>
  public void SetEditingType(int Index, Core.MsoEditingType EditingType);

  /// <summary>
  /// Sets the position of the shape node at the specified index.
  /// </summary>
  /// <param name="Index">The index of the node to move.</param>
  /// <param name="X1">The new x-coordinate for the node.</param>
  /// <param name="Y1">The new y-coordinate for the node.</param>
  public void SetPosition(int Index, float X1, float Y1);

  /// <summary>
  /// Sets the segment type for the shape node at the specified index.
  /// </summary>
  /// <param name="Index">The index of the node to modify.</param>
  /// <param name="SegmentType">The segment type to set.</param>
  public void SetSegmentType(int Index, Core.MsoSegmentType SegmentType);

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
  public void Insert(int Index, Core.MsoSegmentType SegmentType, Core.MsoEditingType EditingType, float X1, float Y1, float X2, float Y2, float X3, float Y3);
}

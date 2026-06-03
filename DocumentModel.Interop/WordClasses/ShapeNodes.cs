namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of all the ShapeNode objects in the specified freeform.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shapenodes?view=word-pia"/>
public partial class ShapeNodes : InteropCollection<ShapeNode>
{


  #region methods

/// <summary>
  /// Deletes the shape node at the specified index.
  /// </summary>
  /// <param name="index">The index of the node to delete.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shapenodes.delete?view=word-pia"/>
  public void Delete(int index) { throw new NotImplementedException(); }

  /// <summary>
  /// Sets the editing type for the shape node at the specified index.
  /// </summary>
  /// <param name="index">The index of the node to modify.</param>
  /// <param name="editingType">The editing type to set.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shapenodes.seteditingtype?view=word-pia"/>
  public void SetEditingType(int index, Core.EditingType editingType) { throw new NotImplementedException(); }

  /// <summary>
  /// Sets the position of the shape node at the specified index.
  /// </summary>
  /// <param name="index">The index of the node to move.</param>
  /// <param name="x1">The new x-coordinate for the node.</param>
  /// <param name="y1">The new y-coordinate for the node.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shapenodes.setposition?view=word-pia"/>
  public void SetPosition(int index, float x1, float y1) { throw new NotImplementedException(); }

  /// <summary>
  /// Sets the segment type for the shape node at the specified index.
  /// </summary>
  /// <param name="index">The index of the node to modify.</param>
  /// <param name="segmentType">The segment type to set.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shapenodes.setsegmenttype?view=word-pia"/>
  public void SetSegmentType(int index, Core.SegmentType segmentType) { throw new NotImplementedException(); }

  /// <summary>
  /// Inserts a new shape node at the specified index.
  /// </summary>
  /// <param name="index">The index at which to insert the new node.</param>
  /// <param name="segmentType">The segment type of the new node.</param>
  /// <param name="editingType">The editing type of the new node.</param>
  /// <param name="x1">The x-coordinate of the first point.</param>
  /// <param name="y1">The y-coordinate of the first point.</param>
  /// <param name="x2">The x-coordinate of the second point.</param>
  /// <param name="y2">The y-coordinate of the second point.</param>
  /// <param name="x3">The x-coordinate of the third point.</param>
  /// <param name="y3">The y-coordinate of the third point.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shapenodes.insert?view=word-pia"/>
  public void Insert(int index, Core.SegmentType segmentType, Core.EditingType editingType, float x1, float y1, float x2, float y2, float x3, float y3) { throw new NotImplementedException(); }

  #endregion methods
}

namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the individual shapes within a grouped shape.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.groupshapes?view=word-pia"/>
public interface IGroupShapes : IInteropObject, IInteropCollection<IShape>
{


  #region methods

/// <summary>
 /// Returns one or more shapes from the group.
 /// </summary>
 /// <param name="index">The index number or name of the shape, or an array of indexes or names.</param>
 /// <returns>A <see cref="IShapeRange"/> object that represents the requested shapes.</returns>
 /// <remarks>
 /// Microsoft Learn API reference.
 /// </remarks>
 /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.groupshapes.range?view=word-pia"/>
 public IShapeRange Range(object index);

  #endregion methods
}

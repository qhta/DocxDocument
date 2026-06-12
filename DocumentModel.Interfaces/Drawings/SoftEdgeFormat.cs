namespace DocumentModel.Drawings;

/// <summary>
/// Represents the soft edge formatting for a shape or range of shapes.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.softedgeformat?view=word-pia"/>
public interface ISoftEdgeFormat : IModelObject
{
  /// <summary>
  /// Returns or sets an BevelType constant that represents the bevel type for the edges of images that use soft
  /// edge formatting. Read/write.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.softedgeformat.type?view=word-pia"/>
  public Drawings.SoftEdgeType Type { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets a value that represents the length of the radius for a soft edge effect.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.softedgeformat.radius?view=word-pia"/>
  public float Radius { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

}

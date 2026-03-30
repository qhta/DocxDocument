namespace DocumentModel.Drawings;

/// <summary>
/// Represents the soft edge formatting for a shape or range of shapes.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.softedgeformat?view=word-pia"/>
public interface SoftEdgeFormat : IModelObject
{
  /// <summary>
  /// Returns or sets an BevelType constant that represents the bevel type for the edges of images that use soft
  /// edge formatting. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.softedgeformat.type?view=word-pia"/>
  public Drw.SoftEdgeType Type { get; set; }
  /// <summary>
  /// Gets or sets a value that represents the length of the radius for a soft edge effect.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.softedgeformat.radius?view=word-pia"/>
  public float Radius { get; set; }

}

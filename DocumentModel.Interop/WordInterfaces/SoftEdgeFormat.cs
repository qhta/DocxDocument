namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the soft edge formatting for a shape or range of shapes.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.softedgeformat?view=word-pia"/>
public interface SoftEdgeFormat : InteropObject
{
  /// <summary>
  /// The type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.softedgeformat.type?view=word-pia"/>
  public Core.MsoSoftEdgeType Type { get; set; }
  /// <summary>
  /// The radius.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.softedgeformat.radius?view=word-pia"/>
  public float Radius { get; set; }

}

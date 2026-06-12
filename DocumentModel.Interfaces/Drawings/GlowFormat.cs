namespace DocumentModel.Drawings;

/// <summary>
/// Represents glow formatting for a shape or shape range.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.glowformat?view=word-pia"/>
public interface IGlowFormat : IModelObject
{
  /// <summary>
  /// Returns or sets the radius of the glow effect, in points.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.glowformat.radius?view=word-pia"/>
  public float Radius { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Returns the color of the glow effect.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.glowformat.color?view=word-pia"/>
  public IColorFormat Color { get; }
  /// <summary>
  /// Returns or sets the transparency of the glow effect.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.glowformat.transparency?view=word-pia"/>
  public float Transparency { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

}

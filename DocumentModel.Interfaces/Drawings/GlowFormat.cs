namespace DocumentModel.Drawings;

/// <summary>
/// Represents glow formatting for a shape or shape range.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.glowformat?view=word-pia"/>
public interface GlowFormat : InteropObject
{
  /// <summary>
  /// Returns or sets the radius of the glow effect, in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.glowformat.radius?view=word-pia"/>
  public float Radius { get; set; }
  /// <summary>
  /// Returns the color of the glow effect.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.glowformat.color?view=word-pia"/>
  public ColorFormat Color { get; }
  /// <summary>
  /// Returns or sets the transparency of the glow effect.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.glowformat.transparency?view=word-pia"/>
  public float Transparency { get; set; }

}

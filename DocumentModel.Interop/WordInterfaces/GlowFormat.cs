namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the glow formatting for a shape or range of shapes.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.glowformat?view=word-pia"/>
public interface GlowFormat : InteropObject
{
  /// <summary>
  /// The radius.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.glowformat.radius?view=word-pia"/>
  public float Radius { get; set; }
  /// <summary>
  /// The color.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.glowformat.color?view=word-pia"/>
  public ColorFormat Color { get; }
  /// <summary>
  /// The transparency.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.glowformat.transparency?view=word-pia"/>
  public float Transparency { get; set; }

}

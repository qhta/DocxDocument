using DocumentModel.Wordprocessing;

namespace DocumentModel.Wordprocessing;

/// <summary>
/// Contains shading attributes for an object.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shading?view=word-pia"/>
public interface Shading : InteropObject
{
  /// <summary>
  /// Returns or sets the color that's applied to the foreground of the Shading object. This color is applied to the
  /// dots and lines in the shading pattern.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shading.foregroundpatterncolorindex?view=word-pia"/>
  public ColorIndex ForegroundPatternColorIndex { get; set; }
  /// <summary>
  /// Returns or sets the color that's applied to the background of the Shading object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shading.backgroundpatterncolorindex?view=word-pia"/>
  public ColorIndex BackgroundPatternColorIndex { get; set; }
  /// <summary>
  /// Returns or sets the shading texture for the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shading.texture?view=word-pia"/>
  public TextureIndex Texture { get; set; }
  /// <summary>
  /// Returns or sets the 24-bit color that's applied to the foreground of the Shading object. This color is applied
  /// to the dots and lines in the shading pattern. Can be any valid Color constant or a value returned by Visual
  /// Basic's RGB function.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shading.foregroundpatterncolor?view=word-pia"/>
  public RgbColor ForegroundPatternColor { get; set; }
  /// <summary>
  /// Returns or sets the 24-bit color that's applied to the background of the Shading object. Can be any valid
  /// Color constant or a value returned by Visual Basic's RGB function.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shading.backgroundpatterncolor?view=word-pia"/>
  public RgbColor BackgroundPatternColor { get; set; }

}

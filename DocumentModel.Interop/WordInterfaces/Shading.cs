namespace DocumentModel.Interop.Word;

/// <summary>
/// Contains shading attributes for an object.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shading?view=word-pia"/>
public interface Shading : InteropObject
{
  /// <summary>
  /// The foreground pattern color index.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shading.foregroundpatterncolorindex?view=word-pia"/>
  public WdColorIndex ForegroundPatternColorIndex { get; set; }
  /// <summary>
  /// The background pattern color index.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shading.backgroundpatterncolorindex?view=word-pia"/>
  public WdColorIndex BackgroundPatternColorIndex { get; set; }
  /// <summary>
  /// The texture.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shading.texture?view=word-pia"/>
  public WdTextureIndex Texture { get; set; }
  /// <summary>
  /// The foreground pattern color.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shading.foregroundpatterncolor?view=word-pia"/>
  public WdColor ForegroundPatternColor { get; set; }
  /// <summary>
  /// The background pattern color.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shading.backgroundpatterncolor?view=word-pia"/>
  public WdColor BackgroundPatternColor { get; set; }

}

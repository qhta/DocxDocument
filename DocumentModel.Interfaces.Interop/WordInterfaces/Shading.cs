namespace DocumentModel.Interop;

/// <summary>
/// Contains shading attributes for an object.
/// </summary>
public interface Shading : InteropObject
{
  /// <summary>
  /// The foreground pattern color index.
  /// </summary>
  public WdColorIndex ForegroundPatternColorIndex { get; set; }
  /// <summary>
  /// The background pattern color index.
  /// </summary>
  public WdColorIndex BackgroundPatternColorIndex { get; set; }
  /// <summary>
  /// The texture.
  /// </summary>
  public WdTextureIndex Texture { get; set; }
  /// <summary>
  /// The foreground pattern color.
  /// </summary>
  public WdColor ForegroundPatternColor { get; set; }
  /// <summary>
  /// The background pattern color.
  /// </summary>
  public WdColor BackgroundPatternColor { get; set; }

}

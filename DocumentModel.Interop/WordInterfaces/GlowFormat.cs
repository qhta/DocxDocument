namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the glow formatting for a shape or range of shapes.
/// </summary>
public interface GlowFormat : InteropObject
{
  /// <summary>
  /// The radius.
  /// </summary>
  public float Radius { get; set; }
  /// <summary>
  /// The color.
  /// </summary>
  public ColorFormat Color { get; }
  /// <summary>
  /// The transparency.
  /// </summary>
  public float Transparency { get; set; }

}

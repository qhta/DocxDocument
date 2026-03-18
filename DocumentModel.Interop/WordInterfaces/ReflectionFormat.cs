namespace DocumentModel.Interop;

/// <summary>
/// Represents the reflection formatting for a shape or range of shapes.
/// </summary>
public interface ReflectionFormat : InteropObject
{
  /// <summary>
  /// The type.
  /// </summary>
  public Core.MsoReflectionType Type { get; set; }
  /// <summary>
  /// The transparency.
  /// </summary>
  public float Transparency { get; set; }
  /// <summary>
  /// The size.
  /// </summary>
  public float Size { get; set; }
  /// <summary>
  /// The offset.
  /// </summary>
  public float Offset { get; set; }
  /// <summary>
  /// The blur.
  /// </summary>
  public float Blur { get; set; }

}

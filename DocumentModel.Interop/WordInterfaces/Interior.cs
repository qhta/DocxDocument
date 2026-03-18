namespace DocumentModel.Interop;

/// <summary>
/// Represents the interior of an object.
/// </summary>
public interface Interior : InteropObject
{
  /// <summary>
  /// The color.
  /// </summary>
  public object Color { get; set; }
  /// <summary>
  /// The color index.
  /// </summary>
  public object ColorIndex { get; set; }
  /// <summary>
  /// The invert if negative.
  /// </summary>
  public object InvertIfNegative { get; set; }
  /// <summary>
  /// The pattern.
  /// </summary>
  public object Pattern { get; set; }
  /// <summary>
  /// The pattern color.
  /// </summary>
  public object PatternColor { get; set; }
  /// <summary>
  /// The pattern color index.
  /// </summary>
  public object PatternColorIndex { get; set; }

}

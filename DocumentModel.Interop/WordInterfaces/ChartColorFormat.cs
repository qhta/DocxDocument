namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the color of a one-color object or the foreground or background color of an object with a gradient or patterned fill.
/// </summary>
public interface ChartColorFormat : InteropObject
{
  /// <summary>
  /// The scheme color.
  /// </summary>
  public int SchemeColor { get; set; }
  /// <summary>
  /// The rgb.
  /// </summary>
  public int RGB { get; }
  /// <summary>
  /// The _default.
  /// </summary>
  public int _Default { get; }
  /// <summary>
  /// The type.
  /// </summary>
  public int Type { get; }

}

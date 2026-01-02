namespace DocumentModel;
/// <summary>
/// Type of Red, Green, Blue compacted to UInt32
/// </summary>
public interface IRGB : IHexBinary, IEquatable<IRGB>
{
  /// <summary>
  /// Red component of the color.
  /// </summary>
  public Byte R { get; set; }
  /// <summary>
  /// Green component of the color.
  /// </summary>
  public Byte G { get; set; }
  /// <summary>
  /// Blue component of the color.
  /// </summary>
  public Byte B { get; set; }

}
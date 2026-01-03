namespace DocumentModel;

/// <summary>
/// Clipboard data stored in variant.
/// </summary>
public interface IVClipboardData: IEquatable<IVClipboardData>
{
  /// <summary>
  /// Format of the clipboard data.
  /// </summary>
  public int? Format { get; set; }
  /// <summary>
  /// Size of the clipboard data.
  /// </summary>
  public UInt32? Size { get; set; }
  /// <summary>
  /// Data stored in clipboard.
  /// </summary>
  public byte[] Data { get; set; }

}
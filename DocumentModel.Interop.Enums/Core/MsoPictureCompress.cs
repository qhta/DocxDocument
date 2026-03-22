namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies whether a picture will be compressed or not when inserted into a file.
/// </summary>
public enum MsoPictureCompress
{
  /// <summary>
  /// Specifies whether a picture will be compressed or not when inserted into a file.
  /// </summary>
  msoPictureCompressDocDefault = -1,
  /// <summary>
  /// The picture is not compressed.
  /// </summary>
  msoPictureCompressFalse,
  /// <summary>
  /// The picture will be compressed.
  /// </summary>
  msoPictureCompressTrue
}

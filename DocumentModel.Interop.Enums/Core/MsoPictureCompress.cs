namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies whether a picture will be compressed or not when inserted into a file.
/// </summary>
public enum MsoPictureCompress
{
  /// <summary>
  /// Specifies whether a picture will be compressed or not when inserted into a file.
  /// </summary>
  DocDefault = -1,
  /// <summary>
  /// The picture is not compressed.
  /// </summary>
  False,
  /// <summary>
  /// The picture will be compressed.
  /// </summary>
  True
}

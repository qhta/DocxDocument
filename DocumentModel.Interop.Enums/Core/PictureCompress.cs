namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies whether a picture will be compressed or not when inserted into a file.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msopicturecompress?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoPictureCompress")]
public enum PictureCompress
{
  /// <summary>
  /// The picture is compressed or not depending on the settings for the document.
  /// </summary>
  [InteropEnumValue("msoPictureCompressDocDefault")]
  DocDefault = -1,
  /// <summary>
  /// The picture is not compressed.
  /// </summary>
  [InteropEnumValue("msoPictureCompressFalse")]
  False,
  /// <summary>
  /// The picture will be compressed.
  /// </summary>
  [InteropEnumValue("msoPictureCompressTrue")]
  True
}

namespace DocumentModel.Drawings;

/// <summary>
/// Specifies whether a picture will be compressed or not when inserted into a file.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msopicturecompress?view=office-pia` for Office interop details.
/// </remarks>
public enum PictureCompress
{
  /// <summary>
  /// The picture is compressed or not depending on the settings for the document.
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


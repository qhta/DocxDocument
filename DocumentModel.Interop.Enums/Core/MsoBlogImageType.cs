namespace DocumentModel.Interop.Core;

/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoblogimagetype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoBlogImageType")]
public enum BlogImageType
{
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoblogImageTypeJPEG")]
  JPEG = 1,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoblogImageTypeGIF")]
  GIF,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoblogImageTypePNG")]
  PNG
}

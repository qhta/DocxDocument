namespace DocumentModel.Interop.Core;

/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoblogimagetype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoBlogImageType")]
public enum BlogImageType
{
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoblogImageTypeJPEG")]
  JPEG = 1,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoblogImageTypeGIF")]
  GIF,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoblogImageTypePNG")]
  PNG
}

namespace DocumentModel.Interop.Core;

/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msotexturealignment?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoTextureAlignment))]
public enum TextureAlignment
{
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTextureAlignment.msoTextureAlignmentMixed))]
  AlignmentMixed = -2,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTextureAlignment.msoTextureTopLeft))]
  TopLeft = 0,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTextureAlignment.msoTextureTop))]
  Top = 1,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTextureAlignment.msoTextureTopRight))]
  TopRight = 2,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTextureAlignment.msoTextureLeft))]
  Left = 3,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTextureAlignment.msoTextureCenter))]
  Center = 4,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTextureAlignment.msoTextureRight))]
  Right = 5,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTextureAlignment.msoTextureBottomLeft))]
  BottomLeft = 6,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTextureAlignment.msoTextureBottom))]
  Bottom = 7,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTextureAlignment.msoTextureBottomRight))]
  BottomRight = 8
}

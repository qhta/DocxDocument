namespace DocumentModel.Interop.Core;

/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msotexturealignment?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoTextureAlignment")]
public enum TextureAlignment
{
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoTextureAlignmentMixed")]
  AlignmentMixed = -2,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoTextureTopLeft")]
  TopLeft = 0,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoTextureTop")]
  Top = 1,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoTextureTopRight")]
  TopRight = 2,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoTextureLeft")]
  Left = 3,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoTextureCenter")]
  Center = 4,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoTextureRight")]
  Right = 5,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoTextureBottomLeft")]
  BottomLeft = 6,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoTextureBottom")]
  Bottom = 7,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoTextureBottomRight")]
  BottomRight = 8
}

namespace DocumentModel.Interop.Core;

/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msotexturealignment?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoTextureAlignment")]
public enum TextureAlignment
{
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoTextureAlignmentMixed")]
  AlignmentMixed = -2,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoTextureTopLeft")]
  TopLeft = 0,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoTextureTop")]
  Top = 1,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoTextureTopRight")]
  TopRight = 2,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoTextureLeft")]
  Left = 3,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoTextureCenter")]
  Center = 4,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoTextureRight")]
  Right = 5,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoTextureBottomLeft")]
  BottomLeft = 6,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoTextureBottom")]
  Bottom = 7,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoTextureBottomRight")]
  BottomRight = 8
}

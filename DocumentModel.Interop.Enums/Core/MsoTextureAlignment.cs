namespace DocumentModel.Interop.Core;

/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msotexturealignment?view=office-pia` for Office interop details.
/// </remarks>
public enum MsoTextureAlignment
{
  AlignmentMixed = -2,
  /// <summary>
  /// msoTextureTop 1
  /// </summary>
  TopLeft = 0,
  /// <summary>
  /// msoTextureTopRight 2
  /// </summary>
  Top = 1,
  /// <summary>
  /// msoTextureLeft 3
  /// </summary>
  TopRight = 2,
  /// <summary>
  /// msoTextureCenter 4
  /// </summary>
  Left = 3,
  /// <summary>
  /// msoTextureRight 5
  /// </summary>
  Center = 4,
  /// <summary>
  /// msoTextureBottomLeft 6
  /// </summary>
  Right = 5,
  /// <summary>
  /// msoTextureBottom 7
  /// </summary>
  BottomLeft = 6,
  /// <summary>
  /// msoTextureBottomRight 8
  /// </summary>
  Bottom = 7,
  /// <summary>
  /// Applies to Product Versions Office primary interop assembly Latest public enum class MsoTextureAlignment ﾉ
  /// Expand table
  /// </summary>
  BottomRight = 8
}

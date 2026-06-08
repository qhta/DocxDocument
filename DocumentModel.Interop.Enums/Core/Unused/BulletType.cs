namespace DocumentModel.Interop.Core;

/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msobullettype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoBulletType")]
public enum BulletType
{
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoBulletMixed")]
  Mixed = -2,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoBulletNone")]
  None = 0,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoBulletUnnumbered")]
  Unnumbered = 1,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoBulletNumbered")]
  Numbered = 2,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoBulletPicture")]
  Picture = 3
}

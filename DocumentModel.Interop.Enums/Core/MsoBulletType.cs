namespace DocumentModel.Interop.Core;

/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msobullettype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoBulletType")]
public enum BulletType
{
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoBulletMixed")]
  Mixed = -2,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoBulletNone")]
  None = 0,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoBulletUnnumbered")]
  Unnumbered = 1,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoBulletNumbered")]
  Numbered = 2,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoBulletPicture")]
  Picture = 3
}

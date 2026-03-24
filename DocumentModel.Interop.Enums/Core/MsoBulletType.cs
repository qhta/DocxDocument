namespace DocumentModel.Interop.Core;

/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msobullettype?view=office-pia` for Office interop details.
/// </remarks>
public enum MsoBulletType
{
  Mixed = -2,
  /// <summary>
  /// msoBulletUnnumbered 1
  /// </summary>
  None = 0,
  /// <summary>
  /// msoBulletNumbered 2
  /// </summary>
  Unnumbered = 1,
  /// <summary>
  /// msoBulletPicture 3
  /// </summary>
  Numbered = 2,
  /// <summary>
  /// Applies to Product Versions Office primary interop assembly Latest public enum class MsoBulletType ﾉ Expand
  /// table
  /// </summary>
  Picture = 3
}


namespace DocumentModel.Interop.Core;

/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoiodgroup?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoIodGroup")]
public enum IodGroup
{
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoIodGroupPIAs")]
  PIAs,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoIodGroupVSTOR35Mgd")]
  VSTOR35Mgd,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoIodGroupVSTOR40Mgd")]
  VSTOR40Mgd
}


namespace DocumentModel.Interop.Core;

/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoiodgroup?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoIodGroup")]
public enum IodGroup
{
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoIodGroupPIAs")]
  PIAs,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoIodGroupVSTOR35Mgd")]
  VSTOR35Mgd,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoIodGroupVSTOR40Mgd")]
  VSTOR40Mgd
}

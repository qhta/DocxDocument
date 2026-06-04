namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies constants that define the styles of the groups on the File tab.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.backstagegroupstyle?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.BackstageGroupStyle))]
public enum BackstageGroupStyle
{
  /// <summary>
  /// Normal style.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.BackstageGroupStyle.BackstageGroupStyleNormal))]
  Normal,
  /// <summary>
  /// Warning style.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.BackstageGroupStyle.BackstageGroupStyleWarning))]
  Warning,
  /// <summary>
  /// Error style.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.BackstageGroupStyle.BackstageGroupStyleError))]
  Error
}

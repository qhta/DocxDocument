namespace DocumentModel.Interop.Core;

/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ribboncontrolsize?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("RibbonControlSize")]
public enum RibbonControlSize
{
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("RibbonControlSizeRegular")]
  Regular,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("RibbonControlSizeLarge")]
  Large
}

namespace DocumentModel.Interop.Core;

/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ribboncontrolsize?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.RibbonControlSize")]
public enum RibbonControlSize
{
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("RibbonControlSizeRegular")]
  Regular,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("RibbonControlSizeLarge")]
  Large
}

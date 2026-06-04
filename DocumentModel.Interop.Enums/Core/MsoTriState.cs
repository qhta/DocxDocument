namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies a tri-state Boolean value.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msotristate?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoTriState))]
public enum TriState
{
  /// <summary>
  /// Not supported.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTriState.msoTrue))]
  True = -1,
  /// <summary>
  /// False.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTriState.msoFalse))]
  False = 0,
  /// <summary>
  /// Not supported.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTriState.msoCTrue))]
  CTrue = 1,
  /// <summary>
  /// Not supported.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTriState.msoTriStateToggle))]
  TriStateToggle = -3,
  /// <summary>
  /// Not supported.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTriState.msoTriStateMixed))]
  TriStateMixed = -2
}

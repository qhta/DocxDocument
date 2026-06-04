namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the width of the arrowhead at the end of a line.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoarrowheadwidth?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoArrowheadWidth))]
public enum ArrowheadWidth
{
  /// <summary>
  /// Return value only; indicates a combination of the other states.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoArrowheadWidth.msoArrowheadWidthMixed))]
  WidthMixed = -2,
  /// <summary>
  /// Narrow.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoArrowheadWidth.msoArrowheadNarrow))]
  Narrow = 1,
  /// <summary>
  /// Medium.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoArrowheadWidth.msoArrowheadWidthMedium))]
  WidthMedium = 2,
  /// <summary>
  /// Wide.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoArrowheadWidth.msoArrowheadWide))]
  Wide = 3
}

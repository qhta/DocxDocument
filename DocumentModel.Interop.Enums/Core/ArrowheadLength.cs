namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the length of the arrowhead at the end of a line.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoarrowheadlength?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoArrowheadLength")]
public enum ArrowheadLength
{
  /// <summary>
  /// Return value only; indicates a combination of the other states in the specified shape range.
  /// </summary>
  [InteropEnumValue("msoArrowheadLengthMixed")]
  LengthMixed = -2,
  /// <summary>
  /// Short.
  /// </summary>
  [InteropEnumValue("msoArrowheadShort")]
  Short = 1,
  /// <summary>
  /// Medium.
  /// </summary>
  [InteropEnumValue("msoArrowheadLengthMedium")]
  LengthMedium = 2,
  /// <summary>
  /// Long.
  /// </summary>
  [InteropEnumValue("msoArrowheadLong")]
  Long = 3
}

namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the width of the arrowhead at the end of a line.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoarrowheadwidth?view=office-pia` for Office interop details.
/// </remarks>
public enum MsoArrowheadWidth
{
  /// <summary>
  /// Specifies the width of the arrowhead at the end of a line.
  /// </summary>
  WidthMixed = -2,
  /// <summary>
  /// Narrow. msoArrowheadWidthMedium2 Medium.
  /// </summary>
  Narrow = 1,
  /// <summary>
  /// Specifies the width of the arrowhead at the end of a line.
  /// </summary>
  WidthMedium = 2,
  /// <summary>
  /// Wide.
  /// </summary>
  Wide = 3
}

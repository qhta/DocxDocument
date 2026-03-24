namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the length of the arrowhead at the end of a line.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoarrowheadlength?view=office-pia` for Office interop details.
/// </remarks>
public enum MsoArrowheadLength
{
  /// <summary>
  /// Specifies the length of the arrowhead at the end of a line.
  /// </summary>
  LengthMixed = -2,
  /// <summary>
  /// Short. msoArrowheadLengthMedium2 Medium.
  /// </summary>
  Short = 1,
  /// <summary>
  /// Specifies the length of the arrowhead at the end of a line.
  /// </summary>
  LengthMedium = 2,
  /// <summary>
  /// Long.
  /// </summary>
  Long = 3
}

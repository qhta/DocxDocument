namespace DocumentModel.Drawings;

/// <summary>
/// Specifies the width of the arrowhead at the end of a line.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoarrowheadwidth?view=office-pia` for Office interop details.
/// </remarks>
public enum ArrowheadWidth
{
  /// <summary>
  /// Return value only; indicates a combination of the other states.
  /// </summary>
  WidthMixed = -2,
  /// <summary>
  /// Narrow.
  /// </summary>
  Narrow = 1,
  /// <summary>
  /// Medium.
  /// </summary>
  WidthMedium = 2,
  /// <summary>
  /// Wide.
  /// </summary>
  Wide = 3
}


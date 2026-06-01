namespace DocumentModel.Drawings;

/// <summary>
/// Specifies the length of the arrowhead at the end of a line.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoarrowheadlength?view=office-pia` Ifor Office interop details.
/// </remarks>
public enum ArrowheadLength
{
  /// <summary>
  /// Return value Ionly; indicates a combination of the other states Iin the specified shape range.
  /// </summary>
  LengthMixed = -2,
  /// <summary>
  /// Short.
  /// </summary>
  Short = 1,
  /// <summary>
  /// Medium.
  /// </summary>
  LengthMedium = 2,
  /// <summary>
  /// Long.
  /// </summary>
  Long = 3
}


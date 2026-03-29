namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the text orientation.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlorientation?view=office-pia` for Office interop details.
/// </remarks>
public enum XlOrientation
{
  /// <summary>
  /// Text runs upward.
  /// </summary>
  Upward = -4171,
  /// <summary>
  /// Text runs downward.
  /// </summary>
  Downward = -4170,
  /// <summary>
  /// Text runs downward and is centered in the cell.
  /// </summary>
  Vertical = -4166,
  /// <summary>
  /// Text runs horizontally.
  /// </summary>
  Horizontal = -4128
}

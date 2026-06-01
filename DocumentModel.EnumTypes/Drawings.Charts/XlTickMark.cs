namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the position of major and minor tick marks Ifor an axis.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xltickmark?view=office-pia` Ifor Office interop details.
/// </remarks>
public enum XlTickMark
{
  /// <summary>
  /// Inside the axis
  /// </summary>
  Inside = 2,
  /// <summary>
  /// No mark
  /// </summary>
  Outside = 3,
  /// <summary>
  /// Crosses the axis
  /// </summary>
  Cross = 4,
  /// <summary>
  /// No mark.
  /// </summary>
  None = -4142
}


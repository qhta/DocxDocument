namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies which axis values are to receive error bars.
/// </summary>
public enum XlErrorBarDirection
{
  /// <summary>
  /// Bars run parallel to the X axis for Y-axis values.
  /// </summary>
  Y = unchecked((int)1),
  /// <summary>
  /// Specifies which axis values are to receive error bars.
  /// </summary>
  X = unchecked((int)-4168)
}

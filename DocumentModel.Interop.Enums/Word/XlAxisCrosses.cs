namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the point on the specified axis where the other axis crosses.
/// </summary>
public enum XlAxisCrosses
{
  /// <summary>
  /// Specifies the point on the specified axis where the other axis crosses.
  /// </summary>
  Maximum = unchecked((int)2),
  /// <summary>
  /// Specifies the point on the specified axis where the other axis crosses.
  /// </summary>
  Minimum = unchecked((int)4),
  /// <summary>
  /// Specifies the point on the specified axis where the other axis crosses.
  /// </summary>
  Custom = unchecked((int)-4114),
  /// <summary>
  /// Specifies the point on the specified axis where the other axis crosses.
  /// </summary>
  Automatic = unchecked((int)-4105)
}

namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the point on the specified axis where the other axis crosses.
/// </summary>
public enum XlAxisCrosses
{
  /// <summary>
  /// Specifies the point on the specified axis where the other axis crosses.
  /// </summary>
  xlAxisCrossesMaximum = unchecked((int)2),
  /// <summary>
  /// Specifies the point on the specified axis where the other axis crosses.
  /// </summary>
  xlAxisCrossesMinimum = unchecked((int)4),
  /// <summary>
  /// Specifies the point on the specified axis where the other axis crosses.
  /// </summary>
  xlAxisCrossesCustom = unchecked((int)-4114),
  /// <summary>
  /// Specifies the point on the specified axis where the other axis crosses.
  /// </summary>
  xlAxisCrossesAutomatic = unchecked((int)-4105)
}

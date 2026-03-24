namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the background type for text in charts.
/// </summary>
public enum XlBackground
{
  /// <summary>
  /// Transparent background.
  /// </summary>
  Transparent = unchecked((int)2),
  /// <summary>
  /// Opaque background.
  /// </summary>
  Opaque = unchecked((int)3),
  /// <summary>
  /// Specifies the background type for text in charts.
  /// </summary>
  Automatic = unchecked((int)-4105)
}

namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the background type for text in charts.
/// </summary>
public enum XlBackground
{
  /// <summary>
  /// Transparent background.
  /// </summary>
  xlBackgroundTransparent = unchecked((int)2),
  /// <summary>
  /// Opaque background.
  /// </summary>
  xlBackgroundOpaque = unchecked((int)3),
  /// <summary>
  /// Specifies the background type for text in charts.
  /// </summary>
  xlBackgroundAutomatic = unchecked((int)-4105)
}

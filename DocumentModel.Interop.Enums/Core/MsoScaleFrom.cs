namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies which part of the shape retains its position when the shape is scaled.
/// </summary>
public enum MsoScaleFrom
{
  /// <summary>
  /// Shape's top left corner retains its position.
  /// </summary>
  TopLeft,
  /// <summary>
  /// Shape's midpoint retains its position. msoScaleFromBottomRight2 Shape's bottom right corner retains its
  /// position.
  /// </summary>
  Middle,
  /// <summary>
  /// Specifies which part of the shape retains its position when the shape is scaled.
  /// </summary>
  BottomRight
}

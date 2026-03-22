namespace DocumentModel.Interop.Core;

/// <summary>
/// Determines the type of automatic sizing allowed.
/// </summary>
public enum MsoAutoSize
{
  /// <summary>
  /// Determines the type of automatic sizing allowed.
  /// </summary>
  msoAutoSizeMixed = -2,
  /// <summary>
  /// No autosizing.
  /// </summary>
  msoAutoSizeNone = 0,
  /// <summary>
  /// The shape is adjusted to fit the text.
  /// </summary>
  msoAutoSizeShapeToFitText = 1,
  /// <summary>
  /// The text is adjusted to fit the shape.
  /// </summary>
  msoAutoSizeTextToFitShape = 2
}

namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies where in the z-order a shape should be moved relative to other shapes.
/// </summary>
public enum MsoZOrderCmd
{
  /// <summary>
  /// Bring shape to the front.
  /// </summary>
  msoBringToFront,
  /// <summary>
  /// Send shape to the back.
  /// </summary>
  msoSendToBack,
  /// <summary>
  /// Bring shape forward.
  /// </summary>
  msoBringForward,
  /// <summary>
  /// Send shape backward.
  /// </summary>
  msoSendBackward,
  /// <summary>
  /// Bring shape in front of text.
  /// </summary>
  msoBringInFrontOfText,
  /// <summary>
  /// Send shape behind text.
  /// </summary>
  msoSendBehindText
}

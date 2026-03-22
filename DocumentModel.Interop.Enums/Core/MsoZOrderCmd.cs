namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies where in the z-order a shape should be moved relative to other shapes.
/// </summary>
public enum MsoZOrderCmd
{
  /// <summary>
  /// Bring shape to the front.
  /// </summary>
  BringToFront,
  /// <summary>
  /// Send shape to the back.
  /// </summary>
  SendToBack,
  /// <summary>
  /// Bring shape forward.
  /// </summary>
  BringForward,
  /// <summary>
  /// Send shape backward.
  /// </summary>
  SendBackward,
  /// <summary>
  /// Bring shape in front of text.
  /// </summary>
  BringInFrontOfText,
  /// <summary>
  /// Send shape behind text.
  /// </summary>
  SendBehindText
}

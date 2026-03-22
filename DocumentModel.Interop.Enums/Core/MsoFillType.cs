namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies a shape's fill type.
/// </summary>
public enum MsoFillType
{
  /// <summary>
  /// Specifies a shape's fill type.
  /// </summary>
  Mixed = -2,
  /// <summary>
  /// Solid fill.
  /// </summary>
  Solid = 1,
  /// <summary>
  /// Patterned fill.
  /// </summary>
  Patterned = 2,
  /// <summary>
  /// Gradient fill.
  /// </summary>
  Gradient = 3,
  /// <summary>
  /// Textured fill.
  /// </summary>
  Textured = 4,
  /// <summary>
  /// Fill is the same as the background.
  /// </summary>
  Background = 5,
  /// <summary>
  /// Picture fill.
  /// </summary>
  Picture = 6
}

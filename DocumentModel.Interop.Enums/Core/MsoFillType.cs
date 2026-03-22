namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies a shape's fill type.
/// </summary>
public enum MsoFillType
{
  /// <summary>
  /// Specifies a shape's fill type.
  /// </summary>
  msoFillMixed = -2,
  /// <summary>
  /// Solid fill.
  /// </summary>
  msoFillSolid = 1,
  /// <summary>
  /// Patterned fill.
  /// </summary>
  msoFillPatterned = 2,
  /// <summary>
  /// Gradient fill.
  /// </summary>
  msoFillGradient = 3,
  /// <summary>
  /// Textured fill.
  /// </summary>
  msoFillTextured = 4,
  /// <summary>
  /// Fill is the same as the background.
  /// </summary>
  msoFillBackground = 5,
  /// <summary>
  /// Picture fill.
  /// </summary>
  msoFillPicture = 6
}

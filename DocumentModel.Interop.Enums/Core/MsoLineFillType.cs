namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the type of fill for a line.
/// </summary>
public enum MsoLineFillType
{
  /// <summary>
  /// Specifies the type of fill for a line.
  /// </summary>
  msoLineFillMixed = -2,
  /// <summary>
  /// No line fill.
  /// </summary>
  msoLineFillNone = 0,
  /// <summary>
  /// Specifies a solid color line fill.
  /// </summary>
  msoLineFillSolid = 1,
  /// <summary>
  /// Specifies a pattern line fill.
  /// </summary>
  msoLineFillPatterned = 2,
  /// <summary>
  /// Specifies a gradient line fill.
  /// </summary>
  msoLineFillGradient = 3,
  /// <summary>
  /// Specifies a textured line fill.
  /// </summary>
  msoLineFillTextured = 4,
  /// <summary>
  /// Specifies the same fill as the background.
  /// </summary>
  msoLineFillBackground = 5,
  /// <summary>
  /// Specifies a picture line fill.
  /// </summary>
  msoLineFillPicture = 6
}

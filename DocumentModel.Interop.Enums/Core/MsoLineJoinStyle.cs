namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the type of join where two lines connect.
/// </summary>
public enum MsoLineJoinStyle
{
  /// <summary>
  /// Specifies the type of join where two lines connect.
  /// </summary>
  Mixed = -2,
  /// <summary>
  /// Specifies a rounded join.
  /// </summary>
  Round = 1,
  /// <summary>
  /// Specifies a beveled join.
  /// </summary>
  Bevel = 2,
  /// <summary>
  /// Specifies a mitered join.
  /// </summary>
  Miter = 3
}

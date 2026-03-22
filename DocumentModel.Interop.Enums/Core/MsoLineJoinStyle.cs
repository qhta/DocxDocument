namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the type of join where two lines connect.
/// </summary>
public enum MsoLineJoinStyle
{
  /// <summary>
  /// Specifies the type of join where two lines connect.
  /// </summary>
  msoLineJoinMixed = -2,
  /// <summary>
  /// Specifies a rounded join.
  /// </summary>
  msoLineJoinRound = 1,
  /// <summary>
  /// Specifies a beveled join.
  /// </summary>
  msoLineJoinBevel = 2,
  /// <summary>
  /// Specifies a mitered join.
  /// </summary>
  msoLineJoinMiter = 3
}

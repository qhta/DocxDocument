namespace DocumentModel.Drawings;

/// <summary>
///   Path Fill Mode
/// </summary>
public enum PathFillMode
{
  /// <summary>
  ///   No Path Fill.
  /// </summary>
  None,

  /// <summary>
  ///   Normal Path Fill.
  /// </summary>
  Norm,

  /// <summary>
  ///   Lighten Path Fill.
  /// </summary>
  Lighten,

  /// <summary>
  ///   Lighten Path Fill Less.
  /// </summary>
  LightenLess,

  /// <summary>
  ///   Darken Path Fill.
  /// </summary>
  Darken,

  /// <summary>
  ///   Darken Path Fill Less.
  /// </summary>
  DarkenLess
}
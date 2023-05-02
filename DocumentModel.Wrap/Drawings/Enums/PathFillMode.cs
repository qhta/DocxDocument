namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Path Fill Mode
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
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
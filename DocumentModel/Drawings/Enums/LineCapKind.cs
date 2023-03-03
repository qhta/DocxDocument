namespace DocumentModel.Drawings;

/// <summary>
///   End Line Cap
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum LineCapKind
{
  /// <summary>
  ///   Round Line Cap.
  /// </summary>
  Round,

  /// <summary>
  ///   Square Line Cap.
  /// </summary>
  Square,

  /// <summary>
  ///   Flat Line Cap.
  /// </summary>
  Flat
}
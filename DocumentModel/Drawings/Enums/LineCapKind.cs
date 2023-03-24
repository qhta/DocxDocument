namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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
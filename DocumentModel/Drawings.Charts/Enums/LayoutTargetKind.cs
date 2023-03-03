namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Layout Target
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum LayoutTargetKind
{
  /// <summary>
  ///   Inner.
  /// </summary>
  Inner,

  /// <summary>
  ///   Outer.
  /// </summary>
  Outer
}
namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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
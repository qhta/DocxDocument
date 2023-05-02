namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Effect Container Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum EffectContainerKind
{
  /// <summary>
  ///   Sibling.
  /// </summary>
  Sibling,

  /// <summary>
  ///   Tree.
  /// </summary>
  Tree
}
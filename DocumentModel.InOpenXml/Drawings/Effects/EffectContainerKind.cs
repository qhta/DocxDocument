namespace DocumentModel.Drawings;

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
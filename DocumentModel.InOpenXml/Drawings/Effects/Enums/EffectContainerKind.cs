namespace DocumentModel.Drawings;
/// <summary>
///   Effect Container Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.EffectContainerValues))]
public enum EffectContainerKind
{
  /// <summary>
  ///   Sibling.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.EffectContainerValues.Sibling))]
  Sibling,
  /// <summary>
  ///   Tree.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.EffectContainerValues.Tree))]
  Tree
}
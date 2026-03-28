namespace DocumentModel.Drawings;
/// <summary>
///   Effect Container Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.EffectContainerValues))]
public enum EffectContainment
{
  /// <summary>
  ///   Sibling.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.EffectContainerValues.Sibling))]
  Sibling = 1,

  /// <summary>
  ///   Tree.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.EffectContainerValues.Tree))]
  Tree
}
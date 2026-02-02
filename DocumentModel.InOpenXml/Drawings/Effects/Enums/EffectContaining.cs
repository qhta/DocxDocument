namespace DocumentModel.Drawings;
/// <summary>
///   Effect Container Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.EffectContainerValues))]
public enum EffectContaining
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
namespace DocumentModel.Drawings;
/// <summary>
///   Effect Container Type
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.EffectContainerValues))]
public enum EffectContainment
{
  /// <summary>
  ///   Sibling.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.EffectContainerValues.Sibling))]
  Sibling = 1,

  /// <summary>
  ///   Tree.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.EffectContainerValues.Tree))]
  Tree
}
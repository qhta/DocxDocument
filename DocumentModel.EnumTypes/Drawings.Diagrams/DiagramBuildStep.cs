namespace DocumentModel.Drawings;

/// <summary>
/// Defines the DiagramBuildStep enumeration.
/// Used in types such as Diagram.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.DiagramBuildStepValues))]
public enum DiagramBuildStep
{
  /// <summary>
  ///   Shape.
  /// </summary>
  [OpenXmlEnumValue("Shape")]
  Shape,
  /// <summary>
  ///   Background.
  /// </summary>
  [OpenXmlEnumValue("Background")]
  Background
}

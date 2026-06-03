namespace DocumentModel.Drawings;

/// <summary>
/// Defines the DiagramBuildStep enumeration.
/// Used in types such as IDiagram.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.DiagramBuildStepValues))]
public enum DiagramBuildStep
{
  /// <summary>
  ///   IShape.
  /// </summary>
  [OpenXmlEnumValue("IShape")]
  IShape,
  /// <summary>
  ///   Background.
  /// </summary>
  [OpenXmlEnumValue("Background")]
  Background
}


namespace DocumentModel.Drawings;

/// <summary>
///   Diagram Animation Build Steps
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum DiagramBuildStepKind
{
  /// <summary>
  ///   Shape.
  /// </summary>
  Shape,

  /// <summary>
  ///   Background.
  /// </summary>
  Background
}
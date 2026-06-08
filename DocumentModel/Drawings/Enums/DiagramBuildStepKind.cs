namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   IDiagram Animation Build Steps
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum DiagramBuildStepKind
{
  /// <summary>
  ///   IShape.
  /// </summary>
  IShape,

  /// <summary>
  ///   Background.
  /// </summary>
  Background
}

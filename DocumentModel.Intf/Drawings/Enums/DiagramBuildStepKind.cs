namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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
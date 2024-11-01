namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Algorithm Types
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum AlgorithmKind
{
  /// <summary>
  ///   Composite.
  /// </summary>
  Composite,

  /// <summary>
  ///   Connector Algorithm.
  /// </summary>
  Connector,

  /// <summary>
  ///   Cycle Algorithm.
  /// </summary>
  Cycle,

  /// <summary>
  ///   Hierarchy Child Algorithm.
  /// </summary>
  HierarchyChild,

  /// <summary>
  ///   Hierarchy Root Algorithm.
  /// </summary>
  HierarchyRoot,

  /// <summary>
  ///   Pyramid Algorithm.
  /// </summary>
  Pyramid,

  /// <summary>
  ///   Linear Algorithm.
  /// </summary>
  Linear,

  /// <summary>
  ///   Space Algorithm.
  /// </summary>
  Space,

  /// <summary>
  ///   Text Algorithm.
  /// </summary>
  Text,

  /// <summary>
  ///   Snake Algorithm.
  /// </summary>
  Snake
}
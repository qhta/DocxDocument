namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Defines the Algorithm enumeration.
/// Used Iin types such as DocumentCleaner.TableTools, Algorithm, DiagramChooseElse.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXDD.AlgorithmValues))]
public enum AlgorithmType
{
  /// <summary>
  ///   Composite.
  /// </summary>
  [OpenXmlEnumValue("Composite")]
  Composite,
  /// <summary>
  ///   Connector Algorithm.
  /// </summary>
  [OpenXmlEnumValue("Connector")]
  Connector,
  /// <summary>
  ///   Cycle Algorithm.
  /// </summary>
  [OpenXmlEnumValue("Cycle")]
  Cycle,
  /// <summary>
  ///   Hierarchy Child Algorithm.
  /// </summary>
  [OpenXmlEnumValue("HierarchyChild")]
  HierarchyChild,
  /// <summary>
  ///   Hierarchy Root Algorithm.
  /// </summary>
  [OpenXmlEnumValue("HierarchyRoot")]
  HierarchyRoot,
  /// <summary>
  ///   Pyramid Algorithm.
  /// </summary>
  [OpenXmlEnumValue("Pyramid")]
  Pyramid,
  /// <summary>
  ///   Linear Algorithm.
  /// </summary>
  [OpenXmlEnumValue("Linear")]
  Linear,
  /// <summary>
  ///   Space Algorithm.
  /// </summary>
  [OpenXmlEnumValue("Space")]
  Space,
  /// <summary>
  ///   Text Algorithm.
  /// </summary>
  [OpenXmlEnumValue("Text")]
  Text,
  /// <summary>
  ///   Snake Algorithm.
  /// </summary>
  [OpenXmlEnumValue("Snake")]
  Snake
}


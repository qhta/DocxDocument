namespace DocumentModel.Drawings;

/// <summary>
/// Diagram Animation Build Steps
/// </summary>
public enum DiagramBuildStepKind
{
  /// <summary>
  /// Shape.
  /// </summary>
  [XmlEnum("sp")]
  Shape,
  
  /// <summary>
  /// Background.
  /// </summary>
  [XmlEnum("bg")]
  Background,
  
}

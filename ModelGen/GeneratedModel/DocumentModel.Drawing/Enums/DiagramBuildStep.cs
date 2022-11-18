namespace DocumentModel.Drawing;

/// <summary>
/// Diagram Animation Build Steps
/// </summary>
public enum DiagramBuildStep
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

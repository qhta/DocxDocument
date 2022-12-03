namespace DocumentModel.Vml;

/// <summary>
/// Shape Grouping Types
/// </summary>
public enum EditAsKind
{
  /// <summary>
  /// Shape Canvas.
  /// </summary>
  [XmlEnum("canvas")]
  Canvas,
  
  /// <summary>
  /// Organization Chart Diagram.
  /// </summary>
  [XmlEnum("orgchart")]
  OrganizationChart,
  
  /// <summary>
  /// Radial Diagram.
  /// </summary>
  [XmlEnum("radial")]
  Radial,
  
  /// <summary>
  /// Cycle Diagram.
  /// </summary>
  [XmlEnum("cycle")]
  Cycle,
  
  /// <summary>
  /// Pyramid Diagram.
  /// </summary>
  [XmlEnum("stacked")]
  Stacked,
  
  /// <summary>
  /// Venn Diagram.
  /// </summary>
  [XmlEnum("venn")]
  Venn,
  
  /// <summary>
  /// Bullseye Diagram.
  /// </summary>
  [XmlEnum("bullseye")]
  Bullseye,
  
}

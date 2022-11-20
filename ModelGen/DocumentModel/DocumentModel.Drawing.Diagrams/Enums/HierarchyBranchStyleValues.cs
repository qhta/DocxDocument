namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Hierarchy Branch Style Definition
/// </summary>
public enum HierarchyBranchStyleValues
{
  /// <summary>
  /// Left.
  /// </summary>
  [XmlEnum("l")]
  Left,
  
  /// <summary>
  /// Right.
  /// </summary>
  [XmlEnum("r")]
  Right,
  
  /// <summary>
  /// Hanging.
  /// </summary>
  [XmlEnum("hang")]
  Hanging,
  
  /// <summary>
  /// Standard.
  /// </summary>
  [XmlEnum("std")]
  Standard,
  
  /// <summary>
  /// Initial.
  /// </summary>
  [XmlEnum("init")]
  Initial,
  
}

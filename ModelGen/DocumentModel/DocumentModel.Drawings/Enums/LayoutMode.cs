namespace DocumentModel.Drawings;

/// <summary>
/// Layout Mode
/// </summary>
public enum LayoutMode
{
  /// <summary>
  /// Edge.
  /// </summary>
  [XmlEnum("edge")]
  Edge,
  
  /// <summary>
  /// Factor.
  /// </summary>
  [XmlEnum("factor")]
  Factor,
  
}

namespace DocumentModel.Drawings;

/// <summary>
/// Bar Direction
/// </summary>
public enum BarDirectionKind
{
  /// <summary>
  /// Bar.
  /// </summary>
  [XmlEnum("bar")]
  Bar,
  
  /// <summary>
  /// Column.
  /// </summary>
  [XmlEnum("col")]
  Column,
  
}

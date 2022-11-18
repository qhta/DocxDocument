namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Bar Direction
/// </summary>
public enum BarDirection
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

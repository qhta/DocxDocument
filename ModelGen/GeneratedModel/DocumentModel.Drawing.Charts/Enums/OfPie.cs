namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Pie of Pie or Bar of Pie Type
/// </summary>
public enum OfPie
{
  /// <summary>
  /// Pie.
  /// </summary>
  [XmlEnum("pie")]
  Pie,
  
  /// <summary>
  /// Bar.
  /// </summary>
  [XmlEnum("bar")]
  Bar,
  
}

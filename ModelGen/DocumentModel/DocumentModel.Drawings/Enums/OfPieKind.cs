namespace DocumentModel.Drawings;

/// <summary>
/// Pie of Pie or Bar of Pie Type
/// </summary>
public enum OfPieKind
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

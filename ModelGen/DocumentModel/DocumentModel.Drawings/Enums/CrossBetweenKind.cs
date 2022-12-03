namespace DocumentModel.Drawings;

/// <summary>
/// Cross Between
/// </summary>
public enum CrossBetweenKind
{
  /// <summary>
  /// Between.
  /// </summary>
  [XmlEnum("between")]
  Between,
  
  /// <summary>
  /// Midpoint of Category.
  /// </summary>
  [XmlEnum("midCat")]
  MidpointCategory,
  
}

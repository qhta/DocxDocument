namespace DocumentModel.InkML;

/// <summary>
/// Defines the TableApplyValues enumeration.
/// </summary>
public enum TableApply
{
  /// <summary>
  /// absolute.
  /// </summary>
  [XmlEnum("absolute")]
  Absolute,
  
  /// <summary>
  /// relative.
  /// </summary>
  [XmlEnum("relative")]
  Relative,
  
}

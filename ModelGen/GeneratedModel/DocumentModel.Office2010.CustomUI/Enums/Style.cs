namespace DocumentModel.Office2010.CustomUI;

/// <summary>
/// Defines the StyleValues enumeration.
/// </summary>
public enum Style
{
  /// <summary>
  /// normal.
  /// </summary>
  [XmlEnum("normal")]
  Normal,
  
  /// <summary>
  /// warning.
  /// </summary>
  [XmlEnum("warning")]
  Warning,
  
  /// <summary>
  /// error.
  /// </summary>
  [XmlEnum("error")]
  Error,
  
}

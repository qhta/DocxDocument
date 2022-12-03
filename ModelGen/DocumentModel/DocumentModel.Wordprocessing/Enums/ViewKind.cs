namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ViewValues enumeration.
/// </summary>
public enum ViewKind
{
  /// <summary>
  /// Default View.
  /// </summary>
  [XmlEnum("none")]
  None,
  
  /// <summary>
  /// Print Layout View.
  /// </summary>
  [XmlEnum("print")]
  Print,
  
  /// <summary>
  /// Outline View.
  /// </summary>
  [XmlEnum("outline")]
  Outline,
  
  /// <summary>
  /// Master Document View.
  /// </summary>
  [XmlEnum("masterPages")]
  MasterPages,
  
  /// <summary>
  /// Draft View.
  /// </summary>
  [XmlEnum("normal")]
  Normal,
  
  /// <summary>
  /// Web Page View.
  /// </summary>
  [XmlEnum("web")]
  Web,
  
}

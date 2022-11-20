namespace DocumentModel.Presentation;

/// <summary>
/// Splitter Bar State
/// </summary>
public enum SplitterBarStateValues
{
  /// <summary>
  /// Min.
  /// </summary>
  [XmlEnum("minimized")]
  Minimized,
  
  /// <summary>
  /// Restored.
  /// </summary>
  [XmlEnum("restored")]
  Restored,
  
  /// <summary>
  /// Max.
  /// </summary>
  [XmlEnum("maximized")]
  Maximized,
  
}

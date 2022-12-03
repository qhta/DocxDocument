namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TextWrappingValues enumeration.
/// </summary>
public enum TextWrappingKind
{
  /// <summary>
  /// Default Text Wrapping Around Frame.
  /// </summary>
  [XmlEnum("auto")]
  Auto,
  
  /// <summary>
  /// No Text Wrapping Beside Frame.
  /// </summary>
  [XmlEnum("notBeside")]
  NotBeside,
  
  /// <summary>
  /// Allow Text Wrapping Around Frame.
  /// </summary>
  [XmlEnum("around")]
  Around,
  
  /// <summary>
  /// Tight Text Wrapping Around Frame.
  /// </summary>
  [XmlEnum("tight")]
  Tight,
  
  /// <summary>
  /// Through Text Wrapping Around Frame.
  /// </summary>
  [XmlEnum("through")]
  Through,
  
  /// <summary>
  /// No Text Wrapping Around Frame.
  /// </summary>
  [XmlEnum("none")]
  None,
  
}

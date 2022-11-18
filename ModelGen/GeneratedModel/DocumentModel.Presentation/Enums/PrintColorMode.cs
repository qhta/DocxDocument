namespace DocumentModel.Presentation;

/// <summary>
/// Print Color Mode
/// </summary>
public enum PrintColorMode
{
  /// <summary>
  /// Black and White Mode.
  /// </summary>
  [XmlEnum("bw")]
  BlackWhite,
  
  /// <summary>
  /// Grayscale Mode.
  /// </summary>
  [XmlEnum("gray")]
  Gray,
  
  /// <summary>
  /// Color Mode.
  /// </summary>
  [XmlEnum("clr")]
  Color,
  
}

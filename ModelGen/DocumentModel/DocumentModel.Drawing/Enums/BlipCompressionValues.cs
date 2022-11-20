namespace DocumentModel.Drawing;

/// <summary>
/// Blip Compression Type
/// </summary>
public enum BlipCompressionValues
{
  /// <summary>
  /// Email Compression.
  /// </summary>
  [XmlEnum("email")]
  Email,
  
  /// <summary>
  /// Screen Viewing Compression.
  /// </summary>
  [XmlEnum("screen")]
  Screen,
  
  /// <summary>
  /// Printing Compression.
  /// </summary>
  [XmlEnum("print")]
  Print,
  
  /// <summary>
  /// High Quality Printing Compression.
  /// </summary>
  [XmlEnum("hqprint")]
  HighQualityPrint,
  
  /// <summary>
  /// No Compression.
  /// </summary>
  [XmlEnum("none")]
  None,
  
}

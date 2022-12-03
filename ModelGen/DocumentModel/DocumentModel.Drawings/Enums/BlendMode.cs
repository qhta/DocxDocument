namespace DocumentModel.Drawings;

/// <summary>
/// Blend Mode
/// </summary>
public enum BlendMode
{
  /// <summary>
  /// Overlay.
  /// </summary>
  [XmlEnum("over")]
  Overlay,
  
  /// <summary>
  /// Multiply.
  /// </summary>
  [XmlEnum("mult")]
  Multiply,
  
  /// <summary>
  /// Screen.
  /// </summary>
  [XmlEnum("screen")]
  Screen,
  
  /// <summary>
  /// Darken.
  /// </summary>
  [XmlEnum("darken")]
  Darken,
  
  /// <summary>
  /// Lighten.
  /// </summary>
  [XmlEnum("lighten")]
  Lighten,
  
}

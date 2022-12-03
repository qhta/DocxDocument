namespace DocumentModel.Drawings;

/// <summary>
/// Defines the PageOrientation enumeration.
/// </summary>
public enum PageOrientation
{
  /// <summary>
  /// default.
  /// </summary>
  [XmlEnum("default")]
  Default,
  
  /// <summary>
  /// portrait.
  /// </summary>
  [XmlEnum("portrait")]
  Portrait,
  
  /// <summary>
  /// landscape.
  /// </summary>
  [XmlEnum("landscape")]
  Landscape,
  
}

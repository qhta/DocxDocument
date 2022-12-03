namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GeoProjectionType enumeration.
/// </summary>
public enum GeoProjectionType
{
  /// <summary>
  /// mercator.
  /// </summary>
  [XmlEnum("mercator")]
  Mercator,
  
  /// <summary>
  /// miller.
  /// </summary>
  [XmlEnum("miller")]
  Miller,
  
  /// <summary>
  /// robinson.
  /// </summary>
  [XmlEnum("robinson")]
  Robinson,
  
  /// <summary>
  /// albers.
  /// </summary>
  [XmlEnum("albers")]
  Albers,
  
}

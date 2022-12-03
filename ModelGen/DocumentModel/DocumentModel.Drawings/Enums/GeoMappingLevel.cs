namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GeoMappingLevel enumeration.
/// </summary>
public enum GeoMappingLevel
{
  /// <summary>
  /// dataOnly.
  /// </summary>
  [XmlEnum("dataOnly")]
  DataOnly,
  
  /// <summary>
  /// postalCode.
  /// </summary>
  [XmlEnum("postalCode")]
  PostalCode,
  
  /// <summary>
  /// county.
  /// </summary>
  [XmlEnum("county")]
  County,
  
  /// <summary>
  /// state.
  /// </summary>
  [XmlEnum("state")]
  State,
  
  /// <summary>
  /// countryRegion.
  /// </summary>
  [XmlEnum("countryRegion")]
  CountryRegion,
  
  /// <summary>
  /// countryRegionList.
  /// </summary>
  [XmlEnum("countryRegionList")]
  CountryRegionList,
  
  /// <summary>
  /// world.
  /// </summary>
  [XmlEnum("world")]
  World,
  
}

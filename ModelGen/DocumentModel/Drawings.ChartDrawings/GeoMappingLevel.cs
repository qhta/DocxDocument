namespace DocumentModel.Drawings.ChartDrawings;


/// <summary>
///   Defines the GeoMappingLevel enumeration.
/// </summary>
public enum GeoMappingLevel
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;dataOnly&quot;.
  /// </summary>
  DataOnly,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;postalCode&quot;.
  /// </summary>
  PostalCode,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;county&quot;.
  /// </summary>
  County,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;state&quot;.
  /// </summary>
  State,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;countryRegion&quot;.
  /// </summary>
  CountryRegion,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;countryRegionList&quot;.
  /// </summary>
  CountryRegionList,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;world&quot;.
  /// </summary>
  World,
  
}

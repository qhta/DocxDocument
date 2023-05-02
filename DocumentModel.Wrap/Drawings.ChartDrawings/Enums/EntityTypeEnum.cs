namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the EntityTypeEnum enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum EntityTypeEnum
{
  /// <summary>
  ///   Address.
  /// </summary>
  Address,

  /// <summary>
  ///   AdminDistrict.
  /// </summary>
  AdminDistrict,

  /// <summary>
  ///   AdminDistrict2.
  /// </summary>
  AdminDistrict2,

  /// <summary>
  ///   AdminDistrict3.
  /// </summary>
  AdminDistrict3,

  /// <summary>
  ///   Continent.
  /// </summary>
  Continent,

  /// <summary>
  ///   CountryRegion.
  /// </summary>
  CountryRegion,

  /// <summary>
  ///   Locality.
  /// </summary>
  Locality,

  /// <summary>
  ///   Ocean.
  /// </summary>
  Ocean,

  /// <summary>
  ///   Planet.
  /// </summary>
  Planet,

  /// <summary>
  ///   PostalCode.
  /// </summary>
  PostalCode,

  /// <summary>
  ///   Region.
  /// </summary>
  Region,

  /// <summary>
  ///   Unsupported.
  /// </summary>
  Unsupported
}
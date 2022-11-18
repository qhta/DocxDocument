namespace DocumentModel.InkML;

/// <summary>
/// Defines the MappingTypeValues enumeration.
/// </summary>
public enum MappingType
{
  /// <summary>
  /// identity.
  /// </summary>
  [XmlEnum("identity")]
  Identity,
  
  /// <summary>
  /// lookup.
  /// </summary>
  [XmlEnum("lookup")]
  Lookup,
  
  /// <summary>
  /// affine.
  /// </summary>
  [XmlEnum("affine")]
  Affine,
  
  /// <summary>
  /// mathml.
  /// </summary>
  [XmlEnum("mathml")]
  MathML,
  
  /// <summary>
  /// product.
  /// </summary>
  [XmlEnum("product")]
  Product,
  
  /// <summary>
  /// unknown.
  /// </summary>
  [XmlEnum("unknown")]
  Unknown,
  
}
